using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helo_World2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;

            int total = int.Parse(numero1) + int.Parse(numero2);
            
            lbresultado3.Text = total.ToString();
        }

        private void txbNumero1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nume1 = txbNumero1.Text;
            string nume2 = txbNumero2.Text;

            float total = float.Parse(nume1) - float.Parse(nume2);

            lbresultado3.Text = total.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            string num1 = txbNumero1.Text;
            string num2 = txbNumero2.Text;

            float total = float.Parse(num1) / float.Parse(num2);

            lbresultado3.Text = total.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            string n1 = txbNumero1.Text;
            string n2 = txbNumero2.Text;

            float total = float.Parse(n1) * float.Parse(n2);

            lbresultado3.Text = total.ToString();
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void btnmaior_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            if (num > 0)
            {
                lbnum1.Text = "O número digitado é Maior que 0.";
            }
            else
            {
                lbnum1.Text = "O número digitado é Menor que 0.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int num = int.Parse((string)textBox2.Text);

            if (num % 2 == 0) 
            {
                label2.Text = "O número digitado é Par.";
            }else {
                label2.Text = "O número digitado é Impar.";
            }
        }
    }
}
