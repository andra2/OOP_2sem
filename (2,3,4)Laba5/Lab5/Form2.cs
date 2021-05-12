using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form2 : Form
    {
        CrewMember member = new Client(new StewardFactory()).GetMember();
        Plane plane;
        Form Main;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Plane a, Form parent)
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
            node.Nodes.Add("Должность: " + i.Position.ToString());
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

            foreach (CrewMember i in plane.Crew)
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
            member.Position = textBox2.Text;
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
            member.Age = (int)AgeBox.Value;
            member.Experience = (int)ExpBox.Value;
            member.Position = textBox2.Text;
            member.Name = textBox1.Text;
            var results = new List<ValidationResult>();
            var context = new ValidationContext(member);
            if (Validator.TryValidateObject(member, context, results, true))
            {
                CrewAdd(member);
                plane.Crew.Add(member);
                member = new Client(new StewardFactory()).GetMember();
            }
        }

        private void CrewTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (plane.Crew.Count != 0)
            {
                if (CrewTree.SelectedNode.Level == 0)
                {
                    foreach (CrewMember i in plane.Crew)
                    {
                        if (i.Name == CrewTree.SelectedNode.Text)
                        {
                            plane.Crew.Remove(i);
                            CrewTree.SelectedNode.Remove();
                            break;
                        }
                    }
                    return;
                }

                if (CrewTree.SelectedNode.Level == 1)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Adapter adapter = new Adapter();

            CrewAdd(adapter);
            plane.Crew.Add(adapter);
        }
    }
}
