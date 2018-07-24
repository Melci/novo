namespace ContaBanco
{
    partial class FrmCadastroDeConta
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
            this.txttitularConta = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lbNumeroConta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EscolhaDeTipoDeConta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txttitularConta
            // 
            this.txttitularConta.Location = new System.Drawing.Point(122, 103);
            this.txttitularConta.Name = "txttitularConta";
            this.txttitularConta.Size = new System.Drawing.Size(155, 20);
            this.txttitularConta.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(283, 128);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 20);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(60, 107);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 16);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(122, 129);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(155, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // lbNumeroConta
            // 
            this.lbNumeroConta.AutoSize = true;
            this.lbNumeroConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroConta.Location = new System.Drawing.Point(60, 133);
            this.lbNumeroConta.Name = "lbNumeroConta";
            this.lbNumeroConta.Size = new System.Drawing.Size(56, 16);
            this.lbNumeroConta.TabIndex = 4;
            this.lbNumeroConta.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadastrar Nova Conta Corrente";
            // 
            // EscolhaDeTipoDeConta
            // 
            this.EscolhaDeTipoDeConta.FormattingEnabled = true;
            this.EscolhaDeTipoDeConta.Location = new System.Drawing.Point(122, 76);
            this.EscolhaDeTipoDeConta.Name = "EscolhaDeTipoDeConta";
            this.EscolhaDeTipoDeConta.Size = new System.Drawing.Size(155, 21);
            this.EscolhaDeTipoDeConta.TabIndex = 6;
            this.EscolhaDeTipoDeConta.SelectedIndexChanged += new System.EventHandler(this.EscolhaDeTipoDeConta_SelectedIndexChanged);
            // 
            // FrmCadastroDeConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 337);
            this.Controls.Add(this.EscolhaDeTipoDeConta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNumeroConta);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txttitularConta);
            this.Name = "FrmCadastroDeConta";
            this.Text = "Cadastro De Conta";
            this.Load += new System.EventHandler(this.FrmCadastroDeConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttitularConta;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lbNumeroConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EscolhaDeTipoDeConta;
    }
}