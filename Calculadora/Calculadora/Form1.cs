using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        String Signos = "";
        Operaciones calcular = new Operaciones();  //instancioar clase
        public Form1()
        {
            InitializeComponent();
        }

        private void btfactor_Click(object sender, EventArgs e)
        {
            Signos = "-";
            txtoperac.Text = txtoperac.Text + Signos;
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            

            if (Signos=="")
            {
                num2 = Convert.ToDouble(Convert.ToString(num2 + "1"));
            }
            else
            {
                num1 = Convert.ToDouble(Convert.ToString(num1 + "1"));
                
            }

            txtoperac.Text = txtoperac.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Signos == "")
            {
                num2 = Convert.ToDouble(Convert.ToString(num2 + "2"));
            }
            else
            {
                num1 = Convert.ToDouble(Convert.ToString(num1 + "2"));

            }

            txtoperac.Text = txtoperac.Text + "2";

        }

        private void btresta_Click(object sender, EventArgs e)
        {
            Signos = "-";
            txtoperac.Text = txtoperac.Text + Signos;    
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (Signos == "")
            {
                num2 = Convert.ToDouble(Convert.ToString(num2 + "3"));
            }
            else
            {
                num1 = Convert.ToDouble(Convert.ToString(num1 + "3"));

            }

            txtoperac.Text = txtoperac.Text + "3";


        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (Signos == "")
            {
                num2 = Convert.ToDouble(Convert.ToString(num2 + "4"));
            }
            else
            {
                num1 = Convert.ToDouble(Convert.ToString(num1 + "4"));

            }

            txtoperac.Text = txtoperac.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (Signos == "")
            {
                num2 = Convert.ToDouble(Convert.ToString(num2 + "5"));
            }
            else
            {
                num1 = Convert.ToDouble(Convert.ToString(num1 + "5"));

            }

            txtoperac.Text = txtoperac.Text + "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (Signos == "")
            {
                num2 = Convert.ToDouble(Convert.ToString(num2 + "6"));
            }
            else
            {
                num1 = Convert.ToDouble(Convert.ToString(num1 + "6"));

            }

            txtoperac.Text = txtoperac.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (Signos == "")
            {
                num2 = Convert.ToDouble(Convert.ToString(num2 + "7"));
            }
            else
            {
                num1 = Convert.ToDouble(Convert.ToString(num1 + "7"));

            }

            txtoperac.Text = txtoperac.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (Signos == "")
            {
                num2 = Convert.ToDouble(Convert.ToString(num2 + "8"));
            }
            else
            {
                num1 = Convert.ToDouble(Convert.ToString(num1 + "8"));

            }

            txtoperac.Text = txtoperac.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (Signos == "")
            {
                num2 = Convert.ToDouble(Convert.ToString(num2 + "9"));
            }
            else
            {
                num1 = Convert.ToDouble(Convert.ToString(num1 + "9"));

            }

            txtoperac.Text = txtoperac.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (Signos == "0")
            {
                num2 = Convert.ToDouble(Convert.ToString(num2 + "0"));
            }
            else
            {
                num1 = Convert.ToDouble(Convert.ToString(num1 + "0"));

            }

            txtoperac.Text = txtoperac.Text + "0";
        }

        private void btsuma_Click(object sender, EventArgs e)
        {
            if (txtoperac.Text != "")
            {
                Signos = "+";
                txtoperac.Text = txtoperac.Text + Signos;
                                            
            }
        }

        private void btdivision_Click(object sender, EventArgs e)
        {
            if (txtoperac.Text != "")
            {
                Signos = "/";
                txtoperac.Text = txtoperac.Text + Signos;
               
            }
        }

        private void btmultip_Click(object sender, EventArgs e)
        {
            Signos = "*";
            txtoperac.Text = txtoperac.Text + Signos;
           
        }

        private void btigual_Click(object sender, EventArgs e)
        {
            
            txtresultado.Text = Convert.ToString(calcular.Operacion(Convert.ToDouble(num2), Convert.ToDouble(num1), Signos));
            num1 = 0;
            num2 = 0;
            Signos = "";
            txtoperac.Text = "";

        }

        private void btporcent_Click(object sender, EventArgs e)
        {
            Signos = "%";
            txtoperac.Text = txtoperac.Text + Signos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            Signos = "";
            txtoperac.Text = "";
        }
    }
}
