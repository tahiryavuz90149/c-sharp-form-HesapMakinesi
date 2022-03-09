using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HesapMakinası
{
    public partial class Form1 : Form
    {
        double sayı1;
        double sayı2;
        char op ;
        double sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            label1.Text += btn.Text;

        }

        private void buttonOp_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            op = Convert.ToChar(btn.Text);

            sayı1 = Convert.ToDouble(label1.Text);
            label1.Text = "";
            

        }

        private void buttonEşit_Click(object sender, EventArgs e)
        {

            sayı2 = Convert.ToDouble(label1.Text);
            switch (op)
            {
                case '+': sonuc = (float)(sayı1 + sayı2);
                    break;
                case '-':
                    sonuc = (float)(sayı1 - sayı2);
                    break;
                case '*':
                    sonuc = (float)(sayı1 * sayı2);
                    break;
                case '/':
                    sonuc = (float)(sayı1 / sayı2);
                    break;

                default: 
                    break;
            }

            label1.Text = sonuc.ToString();
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
