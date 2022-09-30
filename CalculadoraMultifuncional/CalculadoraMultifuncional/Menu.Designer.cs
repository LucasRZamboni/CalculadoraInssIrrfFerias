namespace CalculadoraMultifuncional
{
    partial class Menu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFerias = new System.Windows.Forms.Button();
            this.btnIrrf = new System.Windows.Forms.Button();
            this.btnInss = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 30);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.BackgroundImage = global::CalculadoraMultifuncional.Properties.Resources.fundo1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 465);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnFerias);
            this.panel3.Controls.Add(this.btnIrrf);
            this.panel3.Controls.Add(this.btnInss);
            this.panel3.Location = new System.Drawing.Point(57, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 333);
            this.panel3.TabIndex = 0;
            // 
            // btnFerias
            // 
            this.btnFerias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFerias.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFerias.BackgroundImage = global::CalculadoraMultifuncional.Properties.Resources.ferias_removebg_preview;
            this.btnFerias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFerias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFerias.Location = new System.Drawing.Point(380, 92);
            this.btnFerias.Name = "btnFerias";
            this.btnFerias.Size = new System.Drawing.Size(175, 135);
            this.btnFerias.TabIndex = 2;
            this.btnFerias.UseVisualStyleBackColor = false;
            this.btnFerias.Click += new System.EventHandler(this.btnFerias_Click);
            this.btnFerias.MouseEnter += new System.EventHandler(this.btnFerias_MouseEnter);
            this.btnFerias.MouseLeave += new System.EventHandler(this.btnFerias_MouseLeave);
            // 
            // btnIrrf
            // 
            this.btnIrrf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIrrf.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIrrf.BackgroundImage = global::CalculadoraMultifuncional.Properties.Resources._1194px_Logo_Receita_Federal_do_Brasil_svg;
            this.btnIrrf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIrrf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrrf.Location = new System.Drawing.Point(200, 92);
            this.btnIrrf.Name = "btnIrrf";
            this.btnIrrf.Size = new System.Drawing.Size(175, 135);
            this.btnIrrf.TabIndex = 1;
            this.btnIrrf.UseVisualStyleBackColor = false;
            this.btnIrrf.Click += new System.EventHandler(this.btnIrrf_Click);
            this.btnIrrf.MouseEnter += new System.EventHandler(this.btnIrrf_MouseEnter);
            this.btnIrrf.MouseLeave += new System.EventHandler(this.btnIrrf_MouseLeave);
            // 
            // btnInss
            // 
            this.btnInss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInss.BackColor = System.Drawing.Color.Gainsboro;
            this.btnInss.BackgroundImage = global::CalculadoraMultifuncional.Properties.Resources._1200x600wa;
            this.btnInss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInss.Location = new System.Drawing.Point(20, 92);
            this.btnInss.Name = "btnInss";
            this.btnInss.Size = new System.Drawing.Size(175, 135);
            this.btnInss.TabIndex = 0;
            this.btnInss.UseVisualStyleBackColor = false;
            this.btnInss.Click += new System.EventHandler(this.btnInss_Click);
            this.btnInss.MouseEnter += new System.EventHandler(this.btnInss_MouseEnter);
            this.btnInss.MouseLeave += new System.EventHandler(this.btnInss_MouseLeave);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::CalculadoraMultifuncional.Properties.Resources.btnfechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.Transparent;
            this.btnFechar.Location = new System.Drawing.Point(665, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(695, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFerias;
        private System.Windows.Forms.Button btnIrrf;
        private System.Windows.Forms.Button btnInss;
    }
}