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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        Airport Main;
        internal SearchForm(Airport m): this()
        {
            Main = m;
        }



        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.Enabled = true;
        }

        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.Enabled = true;
        }
    }
}
