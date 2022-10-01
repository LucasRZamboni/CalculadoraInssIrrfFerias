using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraMultifuncional
{
    public partial class Inss : Form
    {
        public Inss()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {


            if (tbSalario.Text == "")
            {
                MessageBox.Show("Valor não digitado", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Calculos.salario = Convert.ToDouble(tbSalario.Text);
                //faixa = Convert.ToDouble(tbFaixa.Text);
                //inss = Convert.ToDouble(tbInss.Text); 
                //valorFinal = Convert.ToDouble(tbValorFinal.Text);



                //---------------------------------------------------------------------------


                if (Calculos.salario >= 0 && Calculos.salario <= 1212)
                {
                    Calculos.CalculoFaixa1();

                    tbAliquota.Text = Calculos.f1 + "%";
                    lbFaixa.Text = "Faixa 1";
                    tbInss.Text = Calculos.inss.ToString("C2");
                    tbAliquotaEfetiva.Text = Calculos.aliquotaEfetiva.ToString("N2") + "%";

                    tbValorFinal.Text = Calculos.valorFinal.ToString("C2");
                }
                //=SE(E(G3>0;G3<=1212);G3*K5;SE(E(G3>=1212,01;G3<=2427,35);M5+((G3-1212)*K6);
                //SE(E(G3>=2427,36;G3<=3641,03);M5+M6+((G3-2427,36)*K7);
                //SE(E(G3>=3641,04;G3<7087,22);M5+M6+M7+((G3-3641,03)*K8);
                //SE(G3=7087,22;M5+M6+M7+((G3-7087,22)*K8);
                //SE(G3>7087,22;M5+M6+M7+M8;"Valor zerado"))))))

                else if (Calculos.salario >= 1212.01 && Calculos.salario <= 2427)
                {

                    Calculos.CalculoFaixa2();

                    tbAliquota.Text = Calculos.f2 + "%";
                    lbFaixa.Text = "Faixa 2";
                    tbInss.Text = Calculos.inss.ToString("C2");
                    tbAliquotaEfetiva.Text = Calculos.aliquotaEfetiva.ToString("N2") + "%";
                    tbValorFinal.Text = Calculos.valorFinal.ToString("C2");
                }
                else if (Calculos.salario >= 2427.01 && Calculos.salario <= 3641)
                {
                    Calculos.CalculoFaixa3();

                    tbAliquota.Text = Calculos.f3 + "%";
                    lbFaixa.Text = "Faixa 3";
                    tbInss.Text = Calculos.inss.ToString("C2");
                    tbAliquotaEfetiva.Text = Calculos.aliquotaEfetiva.ToString("N2") + "%";
                    tbValorFinal.Text = Calculos.valorFinal.ToString("C2");
                }
                else if (Calculos.salario >= 3641.01 && Calculos.salario <= 7087)
                {
                    Calculos.CalculoFaixa4();

                    tbAliquota.Text = Calculos.f4 + "%";
                    lbFaixa.Text = "Faixa 4";
                    tbInss.Text = Calculos.inss.ToString("C2");
                    tbAliquotaEfetiva.Text = Calculos.aliquotaEfetiva.ToString("N2") + "%";
                    tbValorFinal.Text = Calculos.valorFinal.ToString("C2");
                }
                else if (Calculos.salario >= 7087.01)
                {
                    Calculos.CalculoTeto();

                    tbAliquota.Text = Calculos.f4 + "%";
                    lbFaixa.Text = "Teto INSS";
                    tbInss.Text = Calculos.inss.ToString("C2");
                    tbAliquotaEfetiva.Text = Calculos.aliquotaEfetiva.ToString("N2") + "%";
                    tbValorFinal.Text = Calculos.valorFinal.ToString("C2");
                }
                tbValorFinal.BackColor = Color.LightGreen;

            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbAliquota.Text = "";
            tbAliquotaEfetiva.Text = "";
            tbInss.Text = "";
            tbSalario.Text = "";
            lbFaixa.Text = "";
            tbValorFinal.Text = "";
            tbValorFinal.BackColor = Color.White;
        }
    }
}
