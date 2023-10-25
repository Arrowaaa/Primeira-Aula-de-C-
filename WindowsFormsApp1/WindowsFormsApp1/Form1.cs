using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num2 = float.Parse(txb3.Text);
            
            float num = float.Parse(txb2.Text) * float.Parse(txb2.Text);
            float total2 = num2 / num *100; 
            //Lembrando que para saber o resultado desejado utilize ponto se for um numero decimal.

            label1.Text = total2.ToString();

            if (total2 >= 18 && total2 <= 24.9)
            {
                label1.Text = "Seu IMC é: " + total2 + " Peso Magro".ToString();
            }

            else if (total2 >= 18 && total2 <= 24.9)
            {
                label1.Text = "Seu IMC é: " + total2 + " Peso normal".ToString();
            }
            else if (total2 >= 25 && total2 <= 29.9)
            {
                label1.Text = "Seu IMC é: " + total2 + " Sobrepeso".ToString();
            }
            else if (total2 >= 30 && total2 <= 34.9)
            {
                label1.Text = "Seu IMC é: " + total2 + " Obesidade grau I".ToString();

            }
            else if (total2 >= 35 && total2 <= 39.9)
            {
                label1.Text = "Seu IMC é: " + total2 + " Obesidade grau II".ToString();
            }
            else if (total2 >=40)
            {
                label1.Text = "Seu IMC é: " + total2 + " Obesidade grau III".ToString();
            }

        }

        private void txb1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BntIdade_Click(object sender, EventArgs e)
        {
            float num = float.Parse(txb1.Text);

            if (num >= 18)
            {

                label2.Text = "Você tem " + num + " Anos. Então pode DIRIGIR!!".ToString();
            }else if (num <=17)
            {
                label2.Text = "Você tem " + num + " Anos. Então não pode, DIRIGIR!".ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            float valordivida = float.Parse(txb4.Text);
            float quantidadeparcela = float.Parse(txb5.Text);

            label6.Text = valordivida.ToString();
            label6.Text = quantidadeparcela.ToString();

            if (valordivida < 50000)
            {
                double juros = double.Parse(txb6.Text);
                juros = valordivida * 0.50;

                label6.Text = "Sua divida é: "+juros+" Reais".ToString();
            }
            else if (valordivida > 5000)
            {
                double juros = double.Parse(txb6.Text);
                juros = valordivida * 0.25;
                label6.Text = "Sua divida é: " + juros + " Reais".ToString();

            }
        }
    }
}
