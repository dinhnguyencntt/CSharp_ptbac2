using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_ptbac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtA.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            txtB.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            txtC.Text = trackBar3.Value.ToString();
        }

        private void btngpt_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
            c = Convert.ToInt32(txtC.Text);
            Double delta, x1, x2;
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c != 0)
                    {
                        lblkq.Text = " pt vo nghiệm";
                    }
                    else
                    {
                        lblkq.Text = "pt vô số nghiệm";

                    }
                } else {
                    lblkq.Text = "pt có nghiệm"+((-c) / b).ToString();
                      }
            }else{
                delta = b * b - 4 * a * c;
                if (delta < 0) {
                    lblkq.Text = " pt vo nghiệm";
                }
                else if (delta == 0) { 
                    lblkq.Text = "pt có nghiệm kep "+ ((-b) / (2 * a)).ToString();
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta) / (2 * a));
                    x2 = (-b - Math.Sqrt(delta) / (2 * a));
                    lblkq.Text = "pt có 2 nghiệm phân biệt \n"+  "x1=" + x1 + "\nx2=" + x2;       
                         }
            }

            }

                        }
                    }
                
            
       
    

