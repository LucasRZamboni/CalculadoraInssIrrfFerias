using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMultifuncional
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInss_MouseEnter(object sender, EventArgs e)
        {
            btnInss.BackColor = Color.DarkOrange;
            pInss.BackColor = Color.DarkOrange;
        }

        private void btnInss_MouseLeave(object sender, EventArgs e)
        {
            btnInss.BackColor = Color.Gainsboro;
            pInss.BackColor = Color.Transparent;
        }
        private void btnIrrf_MouseEnter(object sender, EventArgs e)
        {
            btnIrrf.BackColor = Color.DarkOrange;
            pIrrf.BackColor = Color.DarkOrange;
        }

        private void btnIrrf_MouseLeave(object sender, EventArgs e)
        {
            btnIrrf.BackColor = Color.Gainsboro;
            pIrrf.BackColor = Color.Transparent;
        }
        private void btnFerias_MouseEnter(object sender, EventArgs e)
        {
            btnFerias.BackColor = Color.DarkOrange;
            pFerias.BackColor = Color.DarkOrange;
        }

        private void btnFerias_MouseLeave(object sender, EventArgs e)
        {
            btnFerias.BackColor = Color.Gainsboro;
            pFerias.BackColor = Color.Transparent;
        }

        private void btnInss_Click(object sender, EventArgs e)
        {
            var inss = new Inss();
            this.Hide();
            inss.ShowDialog();
        }

        private void btnIrrf_Click(object sender, EventArgs e)
        {
            var irrf = new Irrf();
            this.Hide();
            irrf.ShowDialog();
        }

        private void btnFerias_Click(object sender, EventArgs e)
        {
            var ferias = new Ferias();
            this.Hide();
            ferias.ShowDialog();
        }
    }
}
