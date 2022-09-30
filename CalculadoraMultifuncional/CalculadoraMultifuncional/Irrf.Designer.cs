namespace CalculadoraMultifuncional
{
    partial class Irrf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tbAliquotaEfetiva = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbFaixa = new System.Windows.Forms.Label();
            this.tbValorFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbInss = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAliquota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.tbDependentes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPensaoAlim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbIrrf = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.tbIrrf = new System.Windows.Forms.TextBox();
            this.tbAliquotaEfetivaIRRF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbAliquotaIRRF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDependentes = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 2;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::CalculadoraMultifuncional.Properties.Resources.voltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Location = new System.Drawing.Point(770, 1);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(24, 24);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(315, 428);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 29;
            this.btnLimpar.Text = "button1";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tbAliquotaEfetiva
            // 
            this.tbAliquotaEfetiva.Location = new System.Drawing.Point(285, 242);
            this.tbAliquotaEfetiva.Name = "tbAliquotaEfetiva";
            this.tbAliquotaEfetiva.Size = new System.Drawing.Size(40, 20);
            this.tbAliquotaEfetiva.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Alíquota efetiva INSS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Alíquota INSS";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(234, 428);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 25;
            this.btnCalcular.Text = "button1";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbFaixa
            // 
            this.lbFaixa.AutoSize = true;
            this.lbFaixa.Location = new System.Drawing.Point(238, 98);
            this.lbFaixa.Name = "lbFaixa";
            this.lbFaixa.Size = new System.Drawing.Size(0, 13);
            this.lbFaixa.TabIndex = 24;
            // 
            // tbValorFinal
            // 
            this.tbValorFinal.Location = new System.Drawing.Point(241, 368);
            this.tbValorFinal.Name = "tbValorFinal";
            this.tbValorFinal.Size = new System.Drawing.Size(100, 20);
            this.tbValorFinal.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Valor final";
            // 
            // tbInss
            // 
            this.tbInss.Location = new System.Drawing.Point(241, 187);
            this.tbInss.Name = "tbInss";
            this.tbInss.Size = new System.Drawing.Size(100, 20);
            this.tbInss.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "INSS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Faixa INSS";
            // 
            // tbAliquota
            // 
            this.tbAliquota.Location = new System.Drawing.Point(241, 134);
            this.tbAliquota.Name = "tbAliquota";
            this.tbAliquota.Size = new System.Drawing.Size(40, 20);
            this.tbAliquota.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Salário bruto";
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(241, 68);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(100, 20);
            this.tbSalario.TabIndex = 16;
            // 
            // tbDependentes
            // 
            this.tbDependentes.Location = new System.Drawing.Point(421, 68);
            this.tbDependentes.Name = "tbDependentes";
            this.tbDependentes.Size = new System.Drawing.Size(38, 20);
            this.tbDependentes.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Dependentes";
            // 
            // tbPensaoAlim
            // 
            this.tbPensaoAlim.Location = new System.Drawing.Point(569, 68);
            this.tbPensaoAlim.Name = "tbPensaoAlim";
            this.tbPensaoAlim.Size = new System.Drawing.Size(100, 20);
            this.tbPensaoAlim.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Pensão Alimentícia";
            // 
            // lbIrrf
            // 
            this.lbIrrf.AutoSize = true;
            this.lbIrrf.Location = new System.Drawing.Point(238, 116);
            this.lbIrrf.Name = "lbIrrf";
            this.lbIrrf.Size = new System.Drawing.Size(0, 13);
            this.lbIrrf.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Faixa IRRF";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lbDependentes);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.tbIrrf);
            this.panel2.Controls.Add(this.tbAliquotaEfetivaIRRF);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tbAliquotaIRRF);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbSalario);
            this.panel2.Controls.Add(this.lbIrrf);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tbAliquota);
            this.panel2.Controls.Add(this.tbPensaoAlim);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbDependentes);
            this.panel2.Controls.Add(this.tbInss);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnLimpar);
            this.panel2.Controls.Add(this.tbValorFinal);
            this.panel2.Controls.Add(this.tbAliquotaEfetiva);
            this.panel2.Controls.Add(this.lbFaixa);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnCalcular);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 506);
            this.panel2.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(169, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "IRRF";
            // 
            // tbIrrf
            // 
            this.tbIrrf.Location = new System.Drawing.Point(241, 213);
            this.tbIrrf.Name = "tbIrrf";
            this.tbIrrf.Size = new System.Drawing.Size(100, 20);
            this.tbIrrf.TabIndex = 41;
            // 
            // tbAliquotaEfetivaIRRF
            // 
            this.tbAliquotaEfetivaIRRF.Location = new System.Drawing.Point(285, 265);
            this.tbAliquotaEfetivaIRRF.Name = "tbAliquotaEfetivaIRRF";
            this.tbAliquotaEfetivaIRRF.Size = new System.Drawing.Size(40, 20);
            this.tbAliquotaEfetivaIRRF.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Alíquota efetiva IRRF";
            // 
            // tbAliquotaIRRF
            // 
            this.tbAliquotaIRRF.Location = new System.Drawing.Point(241, 160);
            this.tbAliquotaIRRF.Name = "tbAliquotaIRRF";
            this.tbAliquotaIRRF.Size = new System.Drawing.Size(40, 20);
            this.tbAliquotaIRRF.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Alíquota IRRF";
            // 
            // lbDependentes
            // 
            this.lbDependentes.AutoSize = true;
            this.lbDependentes.Location = new System.Drawing.Point(271, 298);
            this.lbDependentes.Name = "lbDependentes";
            this.lbDependentes.Size = new System.Drawing.Size(0, 13);
            this.lbDependentes.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(169, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Valor dependentes";
            // 
            // Irrf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Irrf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Irrf";
            this.Load += new System.EventHandler(this.Irrf_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox tbAliquotaEfetiva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbFaixa;
        private System.Windows.Forms.TextBox tbValorFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbInss;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAliquota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.TextBox tbDependentes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPensaoAlim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbIrrf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbAliquotaEfetivaIRRF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbAliquotaIRRF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbIrrf;
        private System.Windows.Forms.Label lbDependentes;
        private System.Windows.Forms.Label label13;
    }
}