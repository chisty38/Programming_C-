using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_02
{
    public partial class CustomerInput : Form
    {
        
        public CustomerInput()
        {
            InitializeComponent();
        }

        public Queue manager = new Queue();

        public Queue teller = new Queue();

        public Queue credit = new Queue();

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 fr = new Form1();
            if (comboBox1.SelectedIndex == 0)
            {
                teller.Enqueue(cusName.Text);
                
            }
            if (comboBox1.SelectedIndex == 1)
            {
                teller.Enqueue(cusName.Text);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                teller.Enqueue(cusName.Text);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                credit.Enqueue(cusName.Text);
            }
            if (comboBox1.SelectedIndex == 4)
            {
                credit.Enqueue(cusName.Text);
            }
            if (comboBox1.SelectedIndex == 5)
            {
                manager.Enqueue(cusName.Text);
            }
        }
    }
}
