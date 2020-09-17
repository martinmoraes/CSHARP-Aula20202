namespace CadastroPessoas
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.richTextBoxPessoas = new System.Windows.Forms.RichTextBox();
            this.buttonSalvaJson = new System.Windows.Forms.Button();
            this.buttonAbrirJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Idade";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(165, 66);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 4;
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Location = new System.Drawing.Point(165, 92);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEMail.TabIndex = 5;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(165, 117);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(100, 20);
            this.textBoxPeso.TabIndex = 6;
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(165, 143);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdade.TabIndex = 7;
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(393, 62);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 8;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(497, 62);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "Salvar CSV";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Location = new System.Drawing.Point(578, 62);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(75, 23);
            this.buttonAbrir.TabIndex = 10;
            this.buttonAbrir.Text = "Abrir";
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // richTextBoxPessoas
            // 
            this.richTextBoxPessoas.Location = new System.Drawing.Point(359, 132);
            this.richTextBoxPessoas.Name = "richTextBoxPessoas";
            this.richTextBoxPessoas.Size = new System.Drawing.Size(395, 199);
            this.richTextBoxPessoas.TabIndex = 12;
            this.richTextBoxPessoas.Text = "";
            // 
            // buttonSalvaJson
            // 
            this.buttonSalvaJson.Location = new System.Drawing.Point(497, 33);
            this.buttonSalvaJson.Name = "buttonSalvaJson";
            this.buttonSalvaJson.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvaJson.TabIndex = 13;
            this.buttonSalvaJson.Text = "Salva Json";
            this.buttonSalvaJson.UseVisualStyleBackColor = true;
            this.buttonSalvaJson.Click += new System.EventHandler(this.buttonSalvaJson_Click);
            // 
            // buttonAbrirJson
            // 
            this.buttonAbrirJson.Location = new System.Drawing.Point(579, 33);
            this.buttonAbrirJson.Name = "buttonAbrirJson";
            this.buttonAbrirJson.Size = new System.Drawing.Size(75, 23);
            this.buttonAbrirJson.TabIndex = 14;
            this.buttonAbrirJson.Text = "Abrir";
            this.buttonAbrirJson.UseVisualStyleBackColor = true;
            this.buttonAbrirJson.Click += new System.EventHandler(this.buttonAbrirJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAbrirJson);
            this.Controls.Add(this.buttonSalvaJson);
            this.Controls.Add(this.richTextBoxPessoas);
            this.Controls.Add(this.buttonAbrir);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textBoxEMail);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEMail;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.RichTextBox richTextBoxPessoas;
        private System.Windows.Forms.Button buttonSalvaJson;
        private System.Windows.Forms.Button buttonAbrirJson;
    }
}

