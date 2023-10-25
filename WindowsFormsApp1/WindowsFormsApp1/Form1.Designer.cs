namespace WindowsFormsApp1
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
            this.LBIdade = new System.Windows.Forms.Label();
            this.LBAltura = new System.Windows.Forms.Label();
            this.LBPeso = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.txb3 = new System.Windows.Forms.TextBox();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.BntIdade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txb4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb5 = new System.Windows.Forms.TextBox();
            this.txb6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBIdade
            // 
            this.LBIdade.AutoSize = true;
            this.LBIdade.Location = new System.Drawing.Point(84, 37);
            this.LBIdade.Name = "LBIdade";
            this.LBIdade.Size = new System.Drawing.Size(33, 13);
            this.LBIdade.TabIndex = 0;
            this.LBIdade.Text = "idade";
            // 
            // LBAltura
            // 
            this.LBAltura.AutoSize = true;
            this.LBAltura.Location = new System.Drawing.Point(122, 171);
            this.LBAltura.Name = "LBAltura";
            this.LBAltura.Size = new System.Drawing.Size(34, 13);
            this.LBAltura.TabIndex = 1;
            this.LBAltura.Text = "Altura";
            // 
            // LBPeso
            // 
            this.LBPeso.AutoSize = true;
            this.LBPeso.Location = new System.Drawing.Point(266, 171);
            this.LBPeso.Name = "LBPeso";
            this.LBPeso.Size = new System.Drawing.Size(31, 13);
            this.LBPeso.TabIndex = 2;
            this.LBPeso.Text = "Peso";
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(84, 53);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(100, 20);
            this.txb1.TabIndex = 3;
            this.txb1.TextChanged += new System.EventHandler(this.txb1_TextChanged);
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(87, 216);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(100, 20);
            this.txb2.TabIndex = 4;
            // 
            // txb3
            // 
            this.txb3.Location = new System.Drawing.Point(227, 216);
            this.txb3.Name = "txb3";
            this.txb3.Size = new System.Drawing.Size(100, 20);
            this.txb3.TabIndex = 5;
            // 
            // bntCalcular
            // 
            this.bntCalcular.Location = new System.Drawing.Point(84, 256);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(86, 35);
            this.bntCalcular.TabIndex = 6;
            this.bntCalcular.Text = "Calcular IMC";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // BntIdade
            // 
            this.BntIdade.Location = new System.Drawing.Point(87, 90);
            this.BntIdade.Name = "BntIdade";
            this.BntIdade.Size = new System.Drawing.Size(90, 35);
            this.BntIdade.TabIndex = 7;
            this.BntIdade.Text = "Posso dirigir?";
            this.BntIdade.UseVisualStyleBackColor = true;
            this.BntIdade.Click += new System.EventHandler(this.BntIdade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "resultado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Simular parcelamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Valor da divida";
            // 
            // txb4
            // 
            this.txb4.Location = new System.Drawing.Point(87, 352);
            this.txb4.Name = "txb4";
            this.txb4.Size = new System.Drawing.Size(100, 20);
            this.txb4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quantidde de parcelas";
            // 
            // txb5
            // 
            this.txb5.Location = new System.Drawing.Point(231, 352);
            this.txb5.Name = "txb5";
            this.txb5.Size = new System.Drawing.Size(96, 20);
            this.txb5.TabIndex = 14;
            // 
            // txb6
            // 
            this.txb6.Location = new System.Drawing.Point(389, 352);
            this.txb6.Name = "txb6";
            this.txb6.Size = new System.Drawing.Size(100, 20);
            this.txb6.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Juros do parcelamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 595);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb6);
            this.Controls.Add(this.txb5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BntIdade);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.txb3);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.LBPeso);
            this.Controls.Add(this.LBAltura);
            this.Controls.Add(this.LBIdade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBIdade;
        private System.Windows.Forms.Label LBAltura;
        private System.Windows.Forms.Label LBPeso;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.TextBox txb3;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.Button BntIdade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb5;
        private System.Windows.Forms.TextBox txb6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

