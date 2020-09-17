namespace L2E3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb10 = new System.Windows.Forms.TextBox();
            this.tb20 = new System.Windows.Forms.TextBox();
            this.tb50 = new System.Windows.Forms.TextBox();
            this.tb100 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelFechamento = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notas R$ 2,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Notas R$ 5,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Notas R$ 10,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Notas R$ 50,00";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Notas R$ 100,00";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Notas R$ 20,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantidades";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(252, 66);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(64, 20);
            this.tb2.TabIndex = 7;
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(252, 89);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(64, 20);
            this.tb5.TabIndex = 8;
            // 
            // tb10
            // 
            this.tb10.Location = new System.Drawing.Point(252, 113);
            this.tb10.Name = "tb10";
            this.tb10.Size = new System.Drawing.Size(64, 20);
            this.tb10.TabIndex = 9;
            this.tb10.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tb20
            // 
            this.tb20.Location = new System.Drawing.Point(252, 139);
            this.tb20.Name = "tb20";
            this.tb20.Size = new System.Drawing.Size(64, 20);
            this.tb20.TabIndex = 10;
            // 
            // tb50
            // 
            this.tb50.Location = new System.Drawing.Point(252, 165);
            this.tb50.Name = "tb50";
            this.tb50.Size = new System.Drawing.Size(64, 20);
            this.tb50.TabIndex = 11;
            // 
            // tb100
            // 
            this.tb100.Location = new System.Drawing.Point(252, 188);
            this.tb100.Name = "tb100";
            this.tb100.Size = new System.Drawing.Size(64, 20);
            this.tb100.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fechamento do Dia";
            // 
            // labelFechamento
            // 
            this.labelFechamento.AutoSize = true;
            this.labelFechamento.Location = new System.Drawing.Point(359, 232);
            this.labelFechamento.Name = "labelFechamento";
            this.labelFechamento.Size = new System.Drawing.Size(0, 13);
            this.labelFechamento.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calcula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelFechamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb100);
            this.Controls.Add(this.tb50);
            this.Controls.Add(this.tb20);
            this.Controls.Add(this.tb10);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb10;
        private System.Windows.Forms.TextBox tb20;
        private System.Windows.Forms.TextBox tb50;
        private System.Windows.Forms.TextBox tb100;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelFechamento;
        private System.Windows.Forms.Button button1;
    }
}

