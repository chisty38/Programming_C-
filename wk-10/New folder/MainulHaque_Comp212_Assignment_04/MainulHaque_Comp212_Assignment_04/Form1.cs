using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackInheritanceLibrary;
using LinkedListLibrary;
using System.Collections;

namespace MainulHaque_Comp212_Assignment_04
{
    public partial class Form1 : Form
    {
        string current;
        string previous;
        string next;

        Stack st = new Stack();
        Stack st1 = new Stack();
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
        }
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                current = textBox1.Text;
                st.Push(current);
                label2.Text = current;
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (st.Count <= 0)
            {
                MessageBox.Show("There is no active URL is stored. Please input URL in text box.");
                button1.Enabled = false;
            }
            if (st.Count > 0)
            {
                next = st.Peek().ToString();
                st.Pop();
                st1.Push(next);
                label2.Text = next;
                button2.Enabled = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (st1.Count <= 0)
            {
                MessageBox.Show("There is no active URL is stored. Please input URL in text box.");
                button2.Enabled = false;
            }
            if (st1.Count > 0)
            {               
                previous = st1.Peek().ToString();
                st1.Pop();
                st.Push(previous);
                label2.Text = previous;
                button1.Enabled = true;
            }
        
        }
    }
}
