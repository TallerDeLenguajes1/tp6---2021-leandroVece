using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp6
{
    public partial class Form1 : Form
    {
        float numero1 = 0, numero2 = 0;
        char operacion;
        float temp;
        operaciones calculadora = new operaciones();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '9';
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '0';
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            textBox1.Text += '.';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            char[] aux = textBox1.Text.ToCharArray();
            for(int i=0; i<textBox1.Text.Length; i++)
            {
                if(aux[i] == '+' || aux[i] == '-' || aux[i] == '*' || aux[i] == '/')
                {
                    operacion = aux[i];
                    numero1 = float.Parse(textBox1.Text.Remove(aux.Length-1));
                    textBox1.Clear();
                }
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            numero1 = float.Parse(textBox1.Text);
            operacion = '+';
            textBox1.Clear();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            numero1 = float.Parse(textBox1.Text);
            operacion = '-';
            textBox1.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            numero1 = float.Parse(textBox1.Text);
            operacion = '*';
            textBox1.Clear();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            numero2 = float.Parse(textBox1.Text);

            switch (operacion)
            {
                case '+':
                    textBox1.Text = Convert.ToString(calculadora.suma(numero1, numero2));
                    break;
                case '-':
                    textBox1.Text = Convert.ToString(calculadora.resta(numero1, numero2));
                    break;
                case '*':
                    textBox1.Text = Convert.ToString(calculadora.multi(numero1, numero2));
                    break;
                case '/':
                    textBox1.Text = Convert.ToString(calculadora.div(numero1, numero2));
                    break;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numero1 = 0;
            numero2 = 0;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            numero1 = float.Parse(textBox1.Text);
            operacion = '/';
            textBox1.Clear();
        }

    }
}
