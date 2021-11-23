using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaCalculator
{
    public partial class Form1 : Form
    {

        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btn_Click(object sender, EventArgs e)
        {
            if( (txtShowResult.Text == "0")||(isOperationPerformed))
                txtShowResult.Clear();
            isOperationPerformed = false;

            Button button = (Button)sender;

            if (button.Text==".")
            {
                if (!txtShowResult.Text.Contains("."))

                    txtShowResult.Text = txtShowResult.Text + button.Text;

            }
            else

            txtShowResult.Text = txtShowResult.Text + button.Text;

        }

        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = double.Parse(txtShowResult.Text);
            lblShowDetials.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;

        }

        private void btnClearEnd_Click(object sender, EventArgs e)
        {
            txtShowResult.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtShowResult.Text = "0";
            resultValue = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                            txtShowResult.Text =( resultValue + double.Parse(txtShowResult.Text)).ToString();
                    break;
                case "-":
                    txtShowResult.Text = (resultValue - double.Parse(txtShowResult.Text)).ToString();
                    break;

                case "*":
                    txtShowResult.Text = (resultValue * double.Parse(txtShowResult.Text)).ToString();
                    break;
                case "/":
                    txtShowResult.Text = (resultValue / double.Parse(txtShowResult.Text)).ToString();
                    break;
                default:
                    break;


            }
    }
    }
}
