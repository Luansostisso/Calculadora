using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_2 {
    public partial class Form1 : Form {
        decimal calculo;
        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        //bool porcentagem = false;
        bool resultado = false;
        private TextBox txtresultado;
        public Form1() {
            InitializeComponent();

        }
        //private void ConfigureFlatButtons() {
        //foreach (Control control in Controls) {
        //if (control is Button button) {
        //button.FlatStyle = FlatStyle.Flat;
        //button.FlatAppearance.BorderSize = 0;
        //button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        //button.BackColor = Color.White;
        //button.ForeColor = Color.Black;
        //button.Font = new Font("Arial", 12, FontStyle.Regular);
        //button.Padding = new Padding(0); // Adiciona algum espaçamento interno para um visual mais "infinito"
        //button.Margin = new Padding(0); // Adiciona algum espaçamento externo entre os botões
        //button.Size = new Size(0, 0); // Ajusta o tamanho dos botões conforme necessário
        //}
        //}
        //}
        private void Button1_Click(object sender, EventArgs e) {
            if (textBox1 != null) {
                textBox1.Text += "1";
                txtOperacao.Text += "1";
            }
        }
        private void button2_Click(object sender, EventArgs e) {
            if (textBox1 != null) {
                textBox1.Text += "2";
                txtOperacao.Text += "2";
            }
        }
        private void button3_Click(object sender, EventArgs e) {
            if (textBox1 != null) {
                textBox1.Text += "3";
                txtOperacao.Text += "3";
            }
        }
        private void button4_Click(object sender, EventArgs e) {
            if (textBox1 != null) {
                textBox1.Text += "4";
                txtOperacao.Text += "4";
            }
        }
        private void button5_Click(object sender, EventArgs e) {
            if (textBox1 != null) {
                textBox1.Text += "5";
                txtOperacao.Text += "5";
            }
        }
        private void button6_Click(object sender, EventArgs e) {
            if (textBox1 != null) {
                textBox1.Text += "6";
                txtOperacao.Text += "6";
            }
        }
        private void button7_Click(object sender, EventArgs e) {
            if (textBox1 != null) {
                textBox1.Text += "7";
                txtOperacao.Text += "7";
            }
        }
        private void button8_Click(object sender, EventArgs e) {
            if (textBox1 != null) {
                textBox1.Text += "8";
                txtOperacao.Text += "8";
            }
        }
        private void button9_Click(object sender, EventArgs e) {
            if (textBox1 != null) {
                textBox1.Text += "9";
                txtOperacao.Text += "9";
            }
        }
        private void Adição_Click(object sender, EventArgs e) {
                calculo = decimal.Parse(textBox1.Text);
                txtOperacao.Text += "+";
                textBox1.Text = "";
                adicao = true;
                multiplicacao = false;
                divisao = false;
                subtracao = false;
        }
        private void button14_Click(object sender, EventArgs e) {
            resultado = true;
            txtOperacao.Text += "=";
            if (adicao) {
                textBox1.Text = Convert.ToString(calculo + decimal.Parse(textBox1.Text));
                txtOperacao.Text += textBox1.Text;
                // Operação de cálculo para Adição
            }
            if (subtracao) {
                textBox1.Text = Convert.ToString(calculo - decimal.Parse(textBox1.Text));
                txtOperacao.Text += textBox1.Text;
                // Operação de cálculo para Subtração
            }
            if (multiplicacao) {
                textBox1.Text = Convert.ToString(calculo * decimal.Parse(textBox1.Text));
                txtOperacao.Text += textBox1.Text;
                // Operação de cálculo para Multiplicação
            }
            if (divisao) {
                textBox1.Text = Convert.ToString(calculo / decimal.Parse(textBox1.Text));
                txtOperacao.Text += textBox1.Text;
                // Operação de cálculo para Divisão
            }
        }
        private void Subtração_Click(object sender, EventArgs e) {
            calculo = decimal.Parse(textBox1.Text);

            txtOperacao.Text += "-";
            textBox1.Text = "";
            adicao = false;
            multiplicacao = false;
            divisao = false;
            subtracao = true;
        }
        private void Multiplicação_Click(object sender, EventArgs e) {
            calculo = decimal.Parse(textBox1.Text);

            txtOperacao.Text += "x";
            textBox1.Text = "";
            adicao = false;
            multiplicacao = true;
            divisao = false;
            subtracao = false;
        }
        private void Divisão_Click(object sender, EventArgs e) {
            calculo = decimal.Parse(textBox1.Text);

            txtOperacao.Text += "÷";
            textBox1.Text = "";
            adicao = false;
            multiplicacao = false;
            divisao = true;
            subtracao = false;
        }
        private void C_Click(object sender, EventArgs e) {
            textBox1.Text = "";
            txtOperacao.Text = "";
        }
        private void button0_Click(object sender, EventArgs e) {
            if (textBox1 != null) {
                textBox1.Text += "0";
                txtOperacao.Text += "0";
            }
        }
        private void button18_Click(object sender, EventArgs e) {
            if (textBox1 != null) {
                textBox1.Text += ",";
                txtOperacao.Text += ",";
            }
        }
        private void CE_Click(object sender, EventArgs e) {
            try {
                string Apagar = textBox1.Text;
                Apagar = Apagar.Remove(Apagar.Length - 1);
                textBox1.Text = Apagar;
                txtOperacao.Text = Apagar;
            }
            catch (Exception) {

            }
        }
        private void Porcento_Click(object sender, EventArgs e) {
            if (subtracao == true) {
                double valor1 = Convert.ToDouble(calculo);
                double percentual = Convert.ToDouble(textBox1.Text) / 100;
                textBox1.Text = Convert.ToString(valor1 - (percentual * valor1));
                txtOperacao.Text += "% =";
                txtOperacao.Text += textBox1.Text;
            }
            if (adicao == true) {
                double valor1 = Convert.ToDouble(calculo);
                double percentual = Convert.ToDouble(textBox1.Text) / 100;
                textBox1.Text = Convert.ToString(valor1 + (percentual * valor1));
                txtOperacao.Text += "% =";
                txtOperacao.Text += textBox1.Text;

            }
        }
    }
}