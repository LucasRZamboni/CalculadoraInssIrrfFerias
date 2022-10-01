namespace CalculadoraMultifuncional
{
    partial class Inss
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbFaixa = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbValorFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.tbAliquotaEfetiva = new System.Windows.Forms.TextBox();
            this.tbAliquota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInss = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pInss = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackgroundImage = global::CalculadoraMultifuncional.Properties.Resources.fundo1;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnLimpar);
            this.panel2.Controls.Add(this.btnCalcular);
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 505);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pInss);
            this.panel3.Controls.Add(this.lbFaixa);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbSalario);
            this.panel3.Controls.Add(this.tbAliquotaEfetiva);
            this.panel3.Controls.Add(this.tbAliquota);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbInss);
            this.panel3.Location = new System.Drawing.Point(63, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(641, 331);
            this.panel3.TabIndex = 16;
            // 
            // lbFaixa
            // 
            this.lbFaixa.BackColor = System.Drawing.Color.White;
            this.lbFaixa.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFaixa.Location = new System.Drawing.Point(187, 152);
            this.lbFaixa.Name = "lbFaixa";
            this.lbFaixa.ReadOnly = true;
            this.lbFaixa.Size = new System.Drawing.Size(113, 35);
            this.lbFaixa.TabIndex = 16;
            this.lbFaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.tbValorFinal);
            this.panel4.Location = new System.Drawing.Point(311, 271);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(323, 53);
            this.panel4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor final";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbValorFinal
            // 
            this.tbValorFinal.BackColor = System.Drawing.Color.White;
            this.tbValorFinal.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorFinal.Location = new System.Drawing.Point(148, 7);
            this.tbValorFinal.Name = "tbValorFinal";
            this.tbValorFinal.ReadOnly = true;
            this.tbValorFinal.Size = new System.Drawing.Size(168, 35);
            this.tbValorFinal.TabIndex = 9;
            this.tbValorFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salário bruto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSalario
            // 
            this.tbSalario.BackColor = System.Drawing.Color.White;
            this.tbSalario.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalario.Location = new System.Drawing.Point(207, 88);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(160, 35);
            this.tbSalario.TabIndex = 0;
            this.tbSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAliquotaEfetiva
            // 
            this.tbAliquotaEfetiva.BackColor = System.Drawing.Color.White;
            this.tbAliquotaEfetiva.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAliquotaEfetiva.Location = new System.Drawing.Point(541, 152);
            this.tbAliquotaEfetiva.Name = "tbAliquotaEfetiva";
            this.tbAliquotaEfetiva.ReadOnly = true;
            this.tbAliquotaEfetiva.Size = new System.Drawing.Size(87, 35);
            this.tbAliquotaEfetiva.TabIndex = 14;
            this.tbAliquotaEfetiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAliquota
            // 
            this.tbAliquota.BackColor = System.Drawing.Color.White;
            this.tbAliquota.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAliquota.Location = new System.Drawing.Point(541, 88);
            this.tbAliquota.Name = "tbAliquota";
            this.tbAliquota.ReadOnly = true;
            this.tbAliquota.Size = new System.Drawing.Size(70, 35);
            this.tbAliquota.TabIndex = 2;
            this.tbAliquota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Alíquota efetiva";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Faixa INSS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(416, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Alíquota";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "INSS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbInss
            // 
            this.tbInss.BackColor = System.Drawing.Color.White;
            this.tbInss.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInss.Location = new System.Drawing.Point(113, 219);
            this.tbInss.Name = "tbInss";
            this.tbInss.ReadOnly = true;
            this.tbInss.Size = new System.Drawing.Size(150, 35);
            this.tbInss.TabIndex = 5;
            this.tbInss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.BackgroundImage = global::CalculadoraMultifuncional.Properties.Resources.apagador1;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 3;
            this.btnLimpar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(396, 407);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 85);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.BackgroundImage = global::CalculadoraMultifuncional.Properties.Resources.calculadora1;
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCalcular.FlatAppearance.BorderSize = 3;
            this.btnCalcular.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(284, 406);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 85);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pInss
            // 
            this.pInss.BackgroundImage = global::CalculadoraMultifuncional.Properties.Resources.inss_institute;
            this.pInss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pInss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pInss.Location = new System.Drawing.Point(274, 16);
            this.pInss.Name = "pInss";
            this.pInss.Size = new System.Drawing.Size(126, 65);
            this.pInss.TabIndex = 17;
            // 
            // Inss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inss";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbValorFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbInss;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAliquota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.TextBox tbAliquotaEfetiva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox lbFaixa;
        private System.Windows.Forms.Panel pInss;
    }
}