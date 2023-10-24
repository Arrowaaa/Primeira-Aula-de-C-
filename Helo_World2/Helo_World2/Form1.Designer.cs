namespace Helo_World2
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
            this.txbNumero2 = new System.Windows.Forms.TextBox();
            this.txbNumero1 = new System.Windows.Forms.TextBox();
            this.lbNumero1 = new System.Windows.Forms.Label();
            this.lbNumero2 = new System.Windows.Forms.Label();
            this.lbresultado3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnmaior = new System.Windows.Forms.Button();
            this.lbNumero3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbnum1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnimpa1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbNumero2
            // 
            this.txbNumero2.Location = new System.Drawing.Point(54, 64);
            this.txbNumero2.Name = "txbNumero2";
            this.txbNumero2.Size = new System.Drawing.Size(100, 20);
            this.txbNumero2.TabIndex = 0;
            // 
            // txbNumero1
            // 
            this.txbNumero1.Location = new System.Drawing.Point(54, 25);
            this.txbNumero1.Name = "txbNumero1";
            this.txbNumero1.Size = new System.Drawing.Size(100, 20);
            this.txbNumero1.TabIndex = 1;
            this.txbNumero1.TextChanged += new System.EventHandler(this.txbNumero1_TextChanged);
            // 
            // lbNumero1
            // 
            this.lbNumero1.AutoSize = true;
            this.lbNumero1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbNumero1.Location = new System.Drawing.Point(12, 9);
            this.lbNumero1.Name = "lbNumero1";
            this.lbNumero1.Size = new System.Drawing.Size(53, 13);
            this.lbNumero1.TabIndex = 2;
            this.lbNumero1.Text = "Numero 1";
            this.lbNumero1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lbNumero2
            // 
            this.lbNumero2.AutoSize = true;
            this.lbNumero2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbNumero2.Location = new System.Drawing.Point(12, 48);
            this.lbNumero2.Name = "lbNumero2";
            this.lbNumero2.Size = new System.Drawing.Size(53, 13);
            this.lbNumero2.TabIndex = 3;
            this.lbNumero2.Text = "Numero 2";
            // 
            // lbresultado3
            // 
            this.lbresultado3.AutoSize = true;
            this.lbresultado3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbresultado3.Location = new System.Drawing.Point(89, 104);
            this.lbresultado3.Name = "lbresultado3";
            this.lbresultado3.Size = new System.Drawing.Size(55, 13);
            this.lbresultado3.TabIndex = 4;
            this.lbresultado3.Text = "Resultado";
            this.lbresultado3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalcular.Location = new System.Drawing.Point(43, 131);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(36, 21);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSubtrair.Location = new System.Drawing.Point(133, 131);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(38, 21);
            this.btnSubtrair.TabIndex = 6;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDividir.Location = new System.Drawing.Point(43, 171);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(36, 20);
            this.btnDividir.TabIndex = 7;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMultiplicar.Location = new System.Drawing.Point(133, 171);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(38, 20);
            this.btnMultiplicar.TabIndex = 8;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnmaior
            // 
            this.btnmaior.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnmaior.Location = new System.Drawing.Point(258, 144);
            this.btnmaior.Name = "btnmaior";
            this.btnmaior.Size = new System.Drawing.Size(75, 23);
            this.btnmaior.TabIndex = 9;
            this.btnmaior.Text = "Descubra";
            this.btnmaior.UseVisualStyleBackColor = false;
            this.btnmaior.Click += new System.EventHandler(this.btnmaior_Click);
            // 
            // lbNumero3
            // 
            this.lbNumero3.AutoSize = true;
            this.lbNumero3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbNumero3.Location = new System.Drawing.Point(234, 32);
            this.lbNumero3.Name = "lbNumero3";
            this.lbNumero3.Size = new System.Drawing.Size(121, 13);
            this.lbNumero3.TabIndex = 10;
            this.lbNumero3.Text = "Numero Maior ou Menor";
            this.lbNumero3.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbnum1
            // 
            this.lbnum1.AutoSize = true;
            this.lbnum1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbnum1.Location = new System.Drawing.Point(255, 104);
            this.lbnum1.Name = "lbnum1";
            this.lbnum1.Size = new System.Drawing.Size(55, 13);
            this.lbnum1.TabIndex = 12;
            this.lbnum1.Text = "Resultado";
            this.lbnum1.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(412, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Impar ou Par";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(400, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // btnimpa1
            // 
            this.btnimpa1.Location = new System.Drawing.Point(404, 144);
            this.btnimpa1.Name = "btnimpa1";
            this.btnimpa1.Size = new System.Drawing.Size(75, 23);
            this.btnimpa1.TabIndex = 15;
            this.btnimpa1.Text = "Impar/Par";
            this.btnimpa1.UseVisualStyleBackColor = true;
            this.btnimpa1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(397, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(578, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnimpa1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbnum1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbNumero3);
            this.Controls.Add(this.btnmaior);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbresultado3);
            this.Controls.Add(this.lbNumero2);
            this.Controls.Add(this.lbNumero1);
            this.Controls.Add(this.txbNumero1);
            this.Controls.Add(this.txbNumero2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNumero2;
        private System.Windows.Forms.TextBox txbNumero1;
        private System.Windows.Forms.Label lbNumero1;
        private System.Windows.Forms.Label lbNumero2;
        private System.Windows.Forms.Label lbresultado3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnmaior;
        private System.Windows.Forms.Label lbNumero3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbnum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnimpa1;
        private System.Windows.Forms.Label label2;
    }
}

