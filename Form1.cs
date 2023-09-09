using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcee
{
    public partial class Form1 : Form
    {
        Double resultvalue = 0;
        string opperformed = "";
        bool isopperformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isopperformed))
                textBoxResult.Clear();
            isopperformed = false;
            Button n1 = (Button) sender;
            if (n1.Text == ".")
            {
                if(!textBoxResult.Text.Contains("."))
                    textBoxResult.Text = textBoxResult.Text + n1.Text;
            }else
            textBoxResult.Text = textBoxResult.Text + n1.Text;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void op_click(object sender, EventArgs e)
        {
            Button n1 = (Button)sender;
            if(resultvalue!=0)
            {
                neqal.PerformClick();
                opperformed = n1.Text;
                lcurrentOP.Text = resultvalue + " " + opperformed;
                isopperformed = true;
            }
            else
            {
                opperformed = n1.Text;
                resultvalue = Double.Parse(textBoxResult.Text);
                lcurrentOP.Text = resultvalue + " " + opperformed;
                isopperformed = true;

            }

        }

        private void nCE_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void nC_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            resultvalue = 0;
        }

        private void neqal_Click(object sender, EventArgs e)
        {
            switch(opperformed)
                {
                case "+":
                    textBoxResult.Text = (resultvalue + Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (resultvalue - Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (resultvalue * Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (resultvalue / Double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
               
            }
            resultvalue = Double.Parse(textBoxResult.Text);
            lcurrentOP.Text = "";
        }

        private void ndot_Click(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isopperformed))
                textBoxResult.Clear();
            isopperformed = false;
            Button n1 = (Button)sender;
            if (n1.Text == ".")
            {
                if (!textBoxResult.Text.Contains("."))
                    textBoxResult.Text = textBoxResult.Text + n1.Text;
            }
            else
                textBoxResult.Text = textBoxResult.Text + n1.Text;
        }
    }
}
