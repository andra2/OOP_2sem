using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        Airport Main;
        private void DrawAll(IEnumerable<Plane> list)
        {
            foreach(Plane i in list)
            {
                i.DrawToGrid(searchDataGrid);
            }
        }
        private void DrawAll(LinkedList<Plane> list)
        {
            foreach (Plane i in list)
            {
                i.DrawToGrid(searchDataGrid);
            }
        }
        protected internal SearchForm(Airport m): this()
        {
            Main = m;
            DrawAll(Main.Planes);
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.Enabled = true;
        }
        private void searchDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 6)
            {
                Form2 newForm = new Form2(Main.FindPlane(e), this);
                newForm.Show();
                this.Enabled = false;
            }
        }
        private IEnumerable<Plane> SearchText(string text)
        {
            string pattern = @"\w*" + text + @"\w*";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            IEnumerable<Plane> result = from t in Main.Planes
                         where regex.Match(t.creator).Success
                         orderby t.Id
                         select t;
            return result;
        }
        private IEnumerable<Plane> SearchType(string text)
        {
            string pattern = @"\w*" + text + @"\w*";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            IEnumerable<Plane> result = from t in Main.Planes
                                        where regex.Match(t.type.ToString()).Success
                                        orderby t.Id
                                        select t;
            return result;
        }
        private void Sort()
        {

            var result = from t in Main.Planes

                         orderby t
                         select t;
        }

        private void Search(object sender, EventArgs e)
        {
            searchDataGrid.Rows.Clear();
            IEnumerable<Plane> result = SearchText(creatorBox.Text);
            result = result.Intersect(SearchType(typeBox.Text));
            if (CapacTo.Value==0)
            {
                CapacTo.Value = decimal.MaxValue;
            }
            result = from t in result
                     where t.NofSeats >= CapacFrom.Value && t.NofSeats <= CapacTo.Value
                     where int.Parse(t.carrying.Replace(" т.","")) >= CarryFrom.Value && int.Parse(t.carrying.Replace(" т.", "")) <= CarryTo.Value
                     select t;
            DrawAll(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchDataGrid.Rows.Clear();
            DrawAll(Main.Planes);
        }
    }
}
