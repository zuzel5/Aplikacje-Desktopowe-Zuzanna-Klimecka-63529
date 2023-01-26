using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja3._0
{
    public partial class Calculator : Form
    {
        double result = 0;
        string operation = "";
        bool enter_value = false;
        string firstnum, secondnum;
        public Calculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DelateHistory_Click(object sender, EventArgs e)
        {
            
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void numbers_Only(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;

            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + b.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }
        }

        private void operations_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (result != 0)
            {
                btnEquals.PerformClick();
                enter_value = true;
                operation = b.Text;
                lblShowOps.Text = System.Convert.ToString(result) + "  " + operation;

            }
            else
            {
                operation = b.Text;
                result = Double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                lblShowOps.Text = System.Convert.ToString(result) + "  " + operation;
            }

            firstnum = lblShowOps.Text;

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            secondnum = txtDisplay.Text;
            lblShowOps.Text = "";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "x":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "%":
                    txtDisplay.Text = (result % Double.Parse(txtDisplay.Text)).ToString();
                    break;

                default:
                    break;
            }
            result = Double.Parse(txtDisplay.Text);
            operation = "";
            //________________________________________
          
            
           
            
        }

        private void procent_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100);
            txtDisplay.Text = Convert.ToString(a);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x;
           x=  Convert.ToDouble(txtDisplay.Text)* Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(x);
        }

        private void pierwiastek_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtDisplay.Text);
            sq = Math.Sqrt(sq);
            txtDisplay.Text = Convert.ToString(sq);
        }

        private void btx1x_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0/ Convert.ToDouble (txtDisplay.Text));
            txtDisplay.Text = Convert.ToString(a);

        }

        private void btnBackspace_Click_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length >0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text =="")
            {
                txtDisplay.Text = "0";
            }
        }
    }
}
