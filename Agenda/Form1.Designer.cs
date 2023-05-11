namespace Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.bntAddContato = new System.Windows.Forms.Button();
            this.istContatos = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("News706 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(71, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(71, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(182, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(182, 87);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(100, 20);
            this.txtSobrenome.TabIndex = 4;
            this.txtSobrenome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(182, 128);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 5;
            // 
            // bntAddContato
            // 
            this.bntAddContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bntAddContato.Font = new System.Drawing.Font("News706 BT", 9F, System.Drawing.FontStyle.Bold);
            this.bntAddContato.ForeColor = System.Drawing.Color.Black;
            this.bntAddContato.Location = new System.Drawing.Point(70, 203);
            this.bntAddContato.Name = "bntAddContato";
            this.bntAddContato.Size = new System.Drawing.Size(212, 23);
            this.bntAddContato.TabIndex = 6;
            this.bntAddContato.Text = "Adicionar Contato";
            this.bntAddContato.UseVisualStyleBackColor = false;
            this.bntAddContato.Click += new System.EventHandler(this.bntAddContato_Click);
            // 
            // istContatos
            // 
            this.istContatos.FormattingEnabled = true;
            this.istContatos.Location = new System.Drawing.Point(334, 36);
            this.istContatos.Name = "istContatos";
            this.istContatos.Size = new System.Drawing.Size(120, 147);
            this.istContatos.TabIndex = 7;
            this.istContatos.SelectedIndexChanged += new System.EventHandler(this.istContatos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News706 BT", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(71, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(182, 168);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.istContatos);
            this.Controls.Add(this.bntAddContato);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button bntAddContato;
        private System.Windows.Forms.ListBox istContatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
    }
}

