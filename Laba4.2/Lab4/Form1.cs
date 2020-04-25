using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            try
            {
                UnitCollection.AddUnits(Convert.ToInt32(textBox1.Text));
            }
            catch (Exception)
            {
                UnitCollection.AddUnits(8);
            }
            listBox1.DataSource = UnitCollection.units;
            listBox1.Refresh();
        }

        private void linq1_Click(object sender, EventArgs e)
        {
            SortedlistBox2.DataSource = (List<Unit>)UnitCollection.GetAboveAvg();
            SortedlistBox2.Refresh();
        }

        private void linq2_Click(object sender, EventArgs e)
        {
            SortedlistBox2.DataSource = (List<Unit>)UnitCollection.GetBelowAvg();
            SortedlistBox2.Refresh();
        }

        private void linq3_Click(object sender, EventArgs e)
        {
            SortedlistBox2.DataSource = (List<Unit>)UnitCollection.GetSomething();
            SortedlistBox2.Refresh();
        }

        private void AscSort_Click(object sender, EventArgs e)
        {
            SortedlistBox2.DataSource = null;
            SortedlistBox2.Refresh();
            UnitCollection.Sort(UnitCollection.AscSort);
            SortedlistBox2.DataSource = UnitCollection.units;
            SortedlistBox2.Refresh();
        }

        private void DescSort_Click(object sender, EventArgs e)
        {
            SortedlistBox2.DataSource = null;
            SortedlistBox2.Refresh();
            UnitCollection.Sort(UnitCollection.DescSort);
            SortedlistBox2.DataSource = UnitCollection.units;
            SortedlistBox2.Refresh();
        }
    }
}
