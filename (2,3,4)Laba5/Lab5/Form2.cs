using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace Lab5
{
    public partial class Form2 : Form
    {
        CrewMember member=new CrewMember();
        Plane plane;
        Form Main;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2( Plane a,Form parent)
        {
            InitializeComponent();
            plane = a;
            Main = parent;
        }
        public void CrewAdd(CrewMember i)
        { 
            TreeNode node = new TreeNode(i.Name);
            node.Nodes.Add("Возраст: " + i.Age.ToString());
            node.Nodes.Add("Опыт работы: " + i.Experience.ToString());
            node.Nodes.Add("Должность: " + i.position.ToString());
            CrewTree.Nodes.Add(node);

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            TypeBox.Text = plane.type.ToString();
            IdBox.Text = plane.Id.ToString();
            DateBox.Text = plane.DateOfIssue.ToShortDateString();
            CreatorBox.Text = plane.creator.ToString();
            CarryBox.Text = plane.carrying;
            NoSeats.Text = plane.NofSeats.ToString();

            foreach(CrewMember i in plane.Crew)
            {
                CrewAdd(i);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            member.Name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            member.position = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            member.Experience = (int)ExpBox.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            member.Age = (int)AgeBox.Value;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CrewMember i = new CrewMember
            {
                Name = member.Name,
                Age = member.Age,
                Experience = member.Experience,
                position = member.position
            };
            var results = new List<ValidationResult>();
            var context = new ValidationContext(i);
            if (Validator.TryValidateObject(i, context, results, true))
            {
                CrewAdd(i);
                plane.Crew.AddLast(i);
            }
        }

        private void CrewTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (plane.Crew.Count!=0)
            {
                if (CrewTree.SelectedNode.Level == 0)
                {
                    foreach(CrewMember i in plane.Crew)
                    {
                        if (i.Name==CrewTree.SelectedNode.Text)
                        {
                            plane.Crew.Remove(i);
                            CrewTree.SelectedNode.Remove();
                            break;
                        }
                    }
                    return;
                }

                if(CrewTree.SelectedNode.Level == 1)
                {
                    foreach (CrewMember i in plane.Crew)
                    {
                        if (i.Name == CrewTree.SelectedNode.Parent.Text)
                        {
                            plane.Crew.Remove(i);
                            CrewTree.SelectedNode.Parent.Remove();
                            break;
                        }
                    }
                    return;
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.Enabled = true;
        }
    }
}
