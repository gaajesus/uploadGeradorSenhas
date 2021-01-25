namespace Gerador_de_senhas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblqtd = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.nudChars = new System.Windows.Forms.NumericUpDown();
            this.lstSenhas = new System.Windows.Forms.ListBox();
            this.ckbM = new System.Windows.Forms.CheckBox();
            this.ckbN = new System.Windows.Forms.CheckBox();
            this.ckbS = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudChars)).BeginInit();
            this.SuspendLayout();
            // 
            // lblqtd
            // 
            this.lblqtd.AutoSize = true;
            this.lblqtd.Location = new System.Drawing.Point(195, 24);
            this.lblqtd.Name = "lblqtd";
            this.lblqtd.Size = new System.Drawing.Size(69, 13);
            this.lblqtd.TabIndex = 0;
            this.lblqtd.Text = "QTD de char";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(189, 159);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "&Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // nudChars
            // 
            this.nudChars.Location = new System.Drawing.Point(198, 40);
            this.nudChars.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudChars.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudChars.Name = "nudChars";
            this.nudChars.Size = new System.Drawing.Size(120, 20);
            this.nudChars.TabIndex = 3;
            this.nudChars.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // lstSenhas
            // 
            this.lstSenhas.FormattingEnabled = true;
            this.lstSenhas.Location = new System.Drawing.Point(12, 24);
            this.lstSenhas.Name = "lstSenhas";
            this.lstSenhas.Size = new System.Drawing.Size(120, 147);
            this.lstSenhas.TabIndex = 4;
            // 
            // ckbM
            // 
            this.ckbM.AutoSize = true;
            this.ckbM.Location = new System.Drawing.Point(198, 80);
            this.ckbM.Name = "ckbM";
            this.ckbM.Size = new System.Drawing.Size(79, 17);
            this.ckbM.TabIndex = 5;
            this.ckbM.Text = "Maiúsculas";
            this.ckbM.UseVisualStyleBackColor = true;
            // 
            // ckbN
            // 
            this.ckbN.AutoSize = true;
            this.ckbN.Location = new System.Drawing.Point(198, 103);
            this.ckbN.Name = "ckbN";
            this.ckbN.Size = new System.Drawing.Size(68, 17);
            this.ckbN.TabIndex = 6;
            this.ckbN.Text = "Numeros";
            this.ckbN.UseVisualStyleBackColor = true;
            // 
            // ckbS
            // 
            this.ckbS.AutoSize = true;
            this.ckbS.Location = new System.Drawing.Point(198, 126);
            this.ckbS.Name = "ckbS";
            this.ckbS.Size = new System.Drawing.Size(70, 17);
            this.ckbS.TabIndex = 7;
            this.ckbS.Text = "Símbolos";
            this.ckbS.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 207);
            this.Controls.Add(this.ckbS);
            this.Controls.Add(this.ckbN);
            this.Controls.Add(this.ckbM);
            this.Controls.Add(this.lstSenhas);
            this.Controls.Add(this.nudChars);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblqtd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudChars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblqtd;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.NumericUpDown nudChars;
        private System.Windows.Forms.ListBox lstSenhas;
        private System.Windows.Forms.CheckBox ckbM;
        private System.Windows.Forms.CheckBox ckbN;
        private System.Windows.Forms.CheckBox ckbS;
    }
}

