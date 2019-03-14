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
    
    public partial class Form1 : Form
    {
        
        CustomerInput input = new CustomerInput();
        public Form1()
        {
            InitializeComponent();
        }

        int managerCusId = 101;
        int tellerCusId = 201;
        int creditOfficerCusId = 301;

        string cusWithManager;
        string cusWithTeller;
        string cusWithcreditOfficer;

        

        private void newCus_Click(object sender, EventArgs e)
        {
            if (input == null || input.IsDisposed)
                input = new CustomerInput();

            input.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (input.manager.Count <= 0)
            {
                MessageBox.Show("No more customer in waiting");
            }
            if (input.manager.Count > 0)
            { 

            cusWithManager = input.manager.Peek().ToString();
            managerDisplay.Text = cusWithManager;
            managerLabel.Text = managerCusId.ToString();
            managerCusId += 1;
            input.manager.Dequeue();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (input.manager.Count <= 0 && input.teller.Count <= 0)
            {
                MessageBox.Show("No more customer in waiting");
                
            }

            
            if (input.teller.Count <= 0 && input.manager.Count > 0)
            {
                
                    cusWithTeller = input.manager.Peek().ToString();
                    tellerDisplay.Text = cusWithTeller;
                    tellerLabel.Text = tellerCusId.ToString();
                    tellerCusId += 1;
                    input.manager.Dequeue();
                
            }
            if (input.teller.Count > 0)
            {
                cusWithTeller = input.teller.Peek().ToString();
                tellerDisplay.Text = cusWithTeller;
                tellerLabel.Text = tellerCusId.ToString();
                tellerCusId += 1;
                input.teller.Dequeue();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (input.manager.Count <= 0 && input.credit.Count <= 0)
            {
                MessageBox.Show("No more customer in waiting");

            }
            if (input.credit.Count <= 0 && input.manager.Count > 0)
            {
                cusWithcreditOfficer = input.manager.Peek().ToString();
                creditDisplay.Text = cusWithcreditOfficer;
                creditLabel.Text = creditOfficerCusId.ToString();
                creditOfficerCusId += 1;
                input.manager.Dequeue();
            }
            if (input.credit.Count > 0)
            {
                cusWithcreditOfficer = input.credit.Peek().ToString();
                creditDisplay.Text = cusWithcreditOfficer;
                creditLabel.Text = creditOfficerCusId.ToString();
                creditOfficerCusId += 1;
                input.credit.Dequeue();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
