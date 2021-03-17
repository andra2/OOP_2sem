using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Lab5
{
    public partial class Airport : Form
    {
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        ToolStripLabel lastChangeLabel;
        Timer timer;
        protected internal LinkedList<Plane> Planes = new LinkedList<Plane>();
        Plane CurrForm = new Plane();
        public Airport()
        {
            InitializeComponent();

            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Текущие дата и время:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
            lastChangeLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);
            statusStrip1.Items.Add(lastChangeLabel);
            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
        protected internal Plane FindPlane(DataGridViewCellEventArgs e)
        {
            foreach (Plane i in Planes)
            {
                if (i.Id == int.Parse(dataGridView1[0, e.RowIndex].Value.ToString()))
                {
                    return i;
                }
            }
            return null;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 6 && dataGridView1[0, 0].Value != null)
            {
                Form2 newForm = new Form2(FindPlane(e), this);
                newForm.Show();
                this.Enabled = false;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ScrollBarLable.Text = "Количество мест: " + trackBar1.Value;
            CurrForm.NofSeats = trackBar1.Value;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CurrForm.type = Plane.Type.passenger;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CurrForm.type = Plane.Type.cargo;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            CurrForm.type = Plane.Type.military;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrForm.creator = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lastChangeLabel.Text = "Добавление самолета";
            Plane i = new Plane
            {
                Id = CurrForm.Id,
                creator = CurrForm.creator,
                type = CurrForm.type,
                NofSeats = CurrForm.NofSeats,
                DateOfIssue = CurrForm.DateOfIssue,
                carrying = CurrForm.carrying
            };
            var results = new List<ValidationResult>();
            var context = new ValidationContext(i);
            if (Validator.TryValidateObject(i, context, results, false))
            {
                Planes.AddLast(i);
                i.DrawToGrid(dataGridView1);
                CurrForm.Id++;
                IdBox.Text = (int.Parse(IdBox.Text) + 1).ToString();
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            CurrForm.DateOfIssue = Calendar.SelectionStart;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CurrForm.Id = (int)IdBox.Value;
        }

        private void JsonSave_Click(object sender, EventArgs e)
        {
            lastChangeLabel.Text = "Сохранение в память";
            File.WriteAllText("Planes.json", JsonConvert.SerializeObject(Planes,Formatting.Indented));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void JsonRead_Click(object sender, EventArgs e)
        {
            lastChangeLabel.Text = "Загрузка из памяти";
            LinkedList<Plane> plane = JsonConvert.DeserializeObject<LinkedList<Plane>>(File.ReadAllText("Planes.json"));
            foreach (Plane i in plane)
            {
                bool check = true;
                foreach (Plane a in Planes)
                {
                    if (i.Id == a.Id)
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    Planes.AddLast(i);

                    i.DrawToGrid(dataGridView1);
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info newForm = new Info(this);
            newForm.Show();
            this.Enabled = false;
        }

        private void CarryingBox_TextChanged(object sender, EventArgs e)
        {
            double result;
            double.TryParse(CarryingBox.Text,out result);
            CurrForm.carrying = result.ToString() + " т.";
        }

        private void CarryingBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
               if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                    e.Handled = true;
            }

            
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Planes.Count != 0)
            {
                SearchForm search = new SearchForm(this);
                search.Show();
                this.Enabled = false;
            }
            else
            {
                MessageBox.Show("Не из чего искать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            lastChangeLabel.Text = "Удаление  самолета";

            int index = dataGridView1.CurrentRow.Index;
            if (index != dataGridView1.RowCount - 1 && index!=-1)
            {
                int id = int.Parse(dataGridView1[0, index].Value.ToString());
                foreach(Plane i in Planes)
                {
                    if (i.Id == id)
                    {
                        Planes.Remove(i);
                        dataGridView1.Rows.RemoveAt(index);
                        return;
                    }

                }
                
            }
        }

        private void idToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ascToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastChangeLabel.Text = "сортировка во ID";
            dataGridView1.Rows.Clear();
            IEnumerable<Plane> result = from t in Planes
                                        orderby t.Id ascending
                                        select t;
            foreach(Plane pl in result)
            {
                pl.DrawToGrid(dataGridView1);
            }
        }

        private void descToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastChangeLabel.Text = "сортировка во ID";
            dataGridView1.Rows.Clear();
            IEnumerable<Plane> result = from t in Planes
                                        orderby t.Id descending
                                        select t;
            foreach (Plane pl in result)
            {
                pl.DrawToGrid(dataGridView1);
            }
        }

        private void ascToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lastChangeLabel.Text = "сортировка во типу";
            dataGridView1.Rows.Clear();
            IEnumerable<Plane> result = from t in Planes
                                        orderby t.type ascending
                                        select t;
            foreach (Plane pl in result)
            {
                pl.DrawToGrid(dataGridView1);
            }
        }

        private void descToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lastChangeLabel.Text = "сортировка во типу";
            dataGridView1.Rows.Clear();
            IEnumerable<Plane> result = from t in Planes
                                        orderby t.type descending
                                        select t;
            foreach (Plane pl in result)
            {
                pl.DrawToGrid(dataGridView1);
            }
        }

        private void ascToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lastChangeLabel.Text = "сортировка во производителю";
            dataGridView1.Rows.Clear();
            IEnumerable<Plane> result = from t in Planes
                                        orderby t.creator ascending
                                        select t;
            foreach (Plane pl in result)
            {
                pl.DrawToGrid(dataGridView1);
            }
        }

        private void descToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lastChangeLabel.Text = "сортировка во производителю";
            dataGridView1.Rows.Clear();
            IEnumerable<Plane> result = from t in Planes
                                        orderby t.creator descending
                                        select t;
            foreach (Plane pl in result)
            {
                pl.DrawToGrid(dataGridView1);
            }
        }

        private void ascToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            lastChangeLabel.Text = "сортировка во дате производства";
            dataGridView1.Rows.Clear();
            IEnumerable<Plane> result = from t in Planes
                                        orderby t.DateOfIssue ascending
                                        select t;
            foreach (Plane pl in result)
            {
                pl.DrawToGrid(dataGridView1);
            }
        }

        private void descToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            lastChangeLabel.Text = "сортировка во дате производства";
            dataGridView1.Rows.Clear();
            IEnumerable<Plane> result = from t in Planes
                                        orderby t.DateOfIssue descending
                                        select t;
            foreach (Plane pl in result)
            {
                pl.DrawToGrid(dataGridView1);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            File.WriteAllText("Planes.json", JsonConvert.SerializeObject(Planes, Formatting.Indented));
            Planes = new LinkedList<Plane>();
            dataGridView1.Rows.Clear();
        }
    }
}
