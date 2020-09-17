namespace Exercicios
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
            this.nUPPneus = new System.Windows.Forms.NumericUpDown();
            this.nUPVelas = new System.Windows.Forms.NumericUpDown();
            this.nUPCaradores = new System.Windows.Forms.NumericUpDown();
            this.nUPMacanetas = new System.Windows.Forms.NumericUpDown();
            this.LabelTotalGeral = new System.Windows.Forms.Label();
            this.LabelTotalPneus = new System.Windows.Forms.Label();
            this.LabelTotalVelas = new System.Windows.Forms.Label();
            this.LabelTotalCarburadores = new System.Windows.Forms.Label();
            this.LabelTotalMacanetas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUPPneus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPVelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPCaradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPMacanetas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pneus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Velas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carburadores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maçanetas";
            // 
            // nUPPneus
            // 
            this.nUPPneus.Location = new System.Drawing.Point(234, 82);
            this.nUPPneus.Name = "nUPPneus";
            this.nUPPneus.Size = new System.Drawing.Size(120, 20);
            this.nUPPneus.TabIndex = 4;
            // 
            // nUPVelas
            // 
            this.nUPVelas.Location = new System.Drawing.Point(234, 114);
            this.nUPVelas.Name = "nUPVelas";
            this.nUPVelas.Size = new System.Drawing.Size(120, 20);
            this.nUPVelas.TabIndex = 5;
            // 
            // nUPCaradores
            // 
            this.nUPCaradores.Location = new System.Drawing.Point(234, 149);
            this.nUPCaradores.Name = "nUPCaradores";
            this.nUPCaradores.Size = new System.Drawing.Size(120, 20);
            this.nUPCaradores.TabIndex = 6;
            // 
            // nUPMacanetas
            // 
            this.nUPMacanetas.Location = new System.Drawing.Point(234, 185);
            this.nUPMacanetas.Name = "nUPMacanetas";
            this.nUPMacanetas.Size = new System.Drawing.Size(120, 20);
            this.nUPMacanetas.TabIndex = 7;
            // 
            // LabelTotalGeral
            // 
            this.LabelTotalGeral.AutoSize = true;
            this.LabelTotalGeral.Location = new System.Drawing.Point(401, 272);
            this.LabelTotalGeral.Name = "LabelTotalGeral";
            this.LabelTotalGeral.Size = new System.Drawing.Size(0, 13);
            this.LabelTotalGeral.TabIndex = 9;
            // 
            // LabelTotalPneus
            // 
            this.LabelTotalPneus.AutoSize = true;
            this.LabelTotalPneus.Location = new System.Drawing.Point(379, 82);
            this.LabelTotalPneus.Name = "LabelTotalPneus";
            this.LabelTotalPneus.Size = new System.Drawing.Size(13, 13);
            this.LabelTotalPneus.TabIndex = 10;
            this.LabelTotalPneus.Text = "0";
            // 
            // LabelTotalVelas
            // 
            this.LabelTotalVelas.AutoSize = true;
            this.LabelTotalVelas.Location = new System.Drawing.Point(379, 116);
            this.LabelTotalVelas.Name = "LabelTotalVelas";
            this.LabelTotalVelas.Size = new System.Drawing.Size(13, 13);
            this.LabelTotalVelas.TabIndex = 11;
            this.LabelTotalVelas.Text = "0";
            // 
            // LabelTotalCarburadores
            // 
            this.LabelTotalCarburadores.AutoSize = true;
            this.LabelTotalCarburadores.Location = new System.Drawing.Point(379, 151);
            this.LabelTotalCarburadores.Name = "LabelTotalCarburadores";
            this.LabelTotalCarburadores.Size = new System.Drawing.Size(13, 13);
            this.LabelTotalCarburadores.TabIndex = 12;
            this.LabelTotalCarburadores.Text = "0";
            // 
            // LabelTotalMacanetas
            // 
            this.LabelTotalMacanetas.AutoSize = true;
            this.LabelTotalMacanetas.Location = new System.Drawing.Point(379, 192);
            this.LabelTotalMacanetas.Name = "LabelTotalMacanetas";
            this.LabelTotalMacanetas.Size = new System.Drawing.Size(13, 13);
            this.LabelTotalMacanetas.TabIndex = 13;
            this.LabelTotalMacanetas.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Vendas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total Vendas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total Geral";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelTotalMacanetas);
            this.Controls.Add(this.LabelTotalCarburadores);
            this.Controls.Add(this.LabelTotalVelas);
            this.Controls.Add(this.LabelTotalPneus);
            this.Controls.Add(this.LabelTotalGeral);
            this.Controls.Add(this.nUPMacanetas);
            this.Controls.Add(this.nUPCaradores);
            this.Controls.Add(this.nUPVelas);
            this.Controls.Add(this.nUPPneus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUPPneus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPVelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPCaradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPMacanetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUPPneus;
        private System.Windows.Forms.NumericUpDown nUPVelas;
        private System.Windows.Forms.NumericUpDown nUPCaradores;
        private System.Windows.Forms.NumericUpDown nUPMacanetas;
        private System.Windows.Forms.Label LabelTotalGeral;
        private System.Windows.Forms.Label LabelTotalPneus;
        private System.Windows.Forms.Label LabelTotalVelas;
        private System.Windows.Forms.Label LabelTotalCarburadores;
        private System.Windows.Forms.Label LabelTotalMacanetas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

