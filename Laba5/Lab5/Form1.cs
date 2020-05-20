using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Airport : Form
    {
        LinkedList<Plane> Planes = new LinkedList<Plane>();
        Plane CurrForm = new Plane();
        public Airport()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ScrollBarLable.Text = "Количество мест: " + trackBar1.Value;
            CurrForm.NofSeats = trackBar1.Value;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

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
            Planes.AddLast(new Plane());
            dataGridView1.Rows.Add(CurrForm.Id.ToString(), CurrForm.creator, CurrForm.type.ToString(), CurrForm.NofSeats.ToString(),CurrForm.DateOfIssue.Date.ToString(), CurrForm.carrying.ToString());
            CurrForm.Id++;
            IdBox.Text = (int.Parse(IdBox.Text)+1).ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            CurrForm.DateOfIssue = Calendar.SelectionStart;
        }

        private void AddCrew_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CurrForm.Id = (int)IdBox.Value;
        }
    }
}
