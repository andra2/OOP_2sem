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
    public partial class Info : Form
    {
        Form Main;
        public Info(Form e)
        {
            InitializeComponent();
            Main = e;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.Enabled = true;
            this.Close();
        }

        private void Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.Enabled = true;
        }
    }
}
