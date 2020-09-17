namespace L2E2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxReais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEuro = new System.Windows.Forms.Label();
            this.labelDolar = new System.Windows.Forms.Label();
            this.labelFranco = new System.Windows.Forms.Label();
            this.labelLibras = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor em Reais: ";
            // 
            // tboxReais
            // 
            this.tboxReais.Location = new System.Drawing.Point(204, 55);
            this.tboxReais.Name = "tboxReais";
            this.tboxReais.Size = new System.Drawing.Size(100, 20);
            this.tboxReais.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Euro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dólar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Franco Suíço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Libras Esterlinas";
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.Location = new System.Drawing.Point(201, 102);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(0, 13);
            this.labelEuro.TabIndex = 6;
            // 
            // labelDolar
            // 
            this.labelDolar.AutoSize = true;
            this.labelDolar.Location = new System.Drawing.Point(201, 127);
            this.labelDolar.Name = "labelDolar";
            this.labelDolar.Size = new System.Drawing.Size(0, 13);
            this.labelDolar.TabIndex = 7;
            // 
            // labelFranco
            // 
            this.labelFranco.AutoSize = true;
            this.labelFranco.Location = new System.Drawing.Point(201, 152);
            this.labelFranco.Name = "labelFranco";
            this.labelFranco.Size = new System.Drawing.Size(0, 13);
            this.labelFranco.TabIndex = 8;
            // 
            // labelLibras
            // 
            this.labelLibras.AutoSize = true;
            this.labelLibras.Location = new System.Drawing.Point(201, 175);
            this.labelLibras.Name = "labelLibras";
            this.labelLibras.Size = new System.Drawing.Size(0, 13);
            this.labelLibras.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelLibras);
            this.Controls.Add(this.labelFranco);
            this.Controls.Add(this.labelDolar);
            this.Controls.Add(this.labelEuro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxReais);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxReais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.Label labelDolar;
        private System.Windows.Forms.Label labelFranco;
        private System.Windows.Forms.Label labelLibras;
        private System.Windows.Forms.Button button1;
    }
}

