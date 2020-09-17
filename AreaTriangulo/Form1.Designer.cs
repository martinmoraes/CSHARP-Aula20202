namespace AreaTriangulo
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
            this.textBoxLadoA = new System.Windows.Forms.TextBox();
            this.textBoxLadoB = new System.Windows.Forms.TextBox();
            this.textBoxLadoC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelMaiorArea = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textBoxLadoA
            // 
            this.textBoxLadoA.Location = new System.Drawing.Point(156, 93);
            this.textBoxLadoA.Name = "textBoxLadoA";
            this.textBoxLadoA.Size = new System.Drawing.Size(100, 20);
            this.textBoxLadoA.TabIndex = 0;
            // 
            // textBoxLadoB
            // 
            this.textBoxLadoB.Location = new System.Drawing.Point(156, 119);
            this.textBoxLadoB.Name = "textBoxLadoB";
            this.textBoxLadoB.Size = new System.Drawing.Size(100, 20);
            this.textBoxLadoB.TabIndex = 1;
            // 
            // textBoxLadoC
            // 
            this.textBoxLadoC.Location = new System.Drawing.Point(156, 145);
            this.textBoxLadoC.Name = "textBoxLadoC";
            this.textBoxLadoC.Size = new System.Drawing.Size(100, 20);
            this.textBoxLadoC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lado A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lado B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lado C";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Triangulo X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Triangulo Y";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(345, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Área";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(156, 204);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(58, 13);
            this.labelResultado.TabIndex = 9;
            this.labelResultado.Text = "Resultado:";
            // 
            // labelMaiorArea
            // 
            this.labelMaiorArea.AutoSize = true;
            this.labelMaiorArea.Location = new System.Drawing.Point(159, 221);
            this.labelMaiorArea.Name = "labelMaiorArea";
            this.labelMaiorArea.Size = new System.Drawing.Size(0, 13);
            this.labelMaiorArea.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(285, 269);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(322, 85);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelMaiorArea);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLadoC);
            this.Controls.Add(this.textBoxLadoB);
            this.Controls.Add(this.textBoxLadoA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLadoA;
        private System.Windows.Forms.TextBox textBoxLadoB;
        private System.Windows.Forms.TextBox textBoxLadoC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelMaiorArea;
        private System.Windows.Forms.ListView listView1;
    }
}

