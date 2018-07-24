namespace ContaBanco
{
    partial class Form1
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoNumeroConta = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeposita = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.destinoDaTransferencia = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdicionarCliente = new System.Windows.Forms.Button();
            this.txtTipoDaConta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExcluiCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(80, 21);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(95, 20);
            this.textoTitular.TabIndex = 1;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(80, 73);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(95, 20);
            this.textoSaldo.TabIndex = 2;
            // 
            // textoNumeroConta
            // 
            this.textoNumeroConta.Location = new System.Drawing.Point(80, 47);
            this.textoNumeroConta.Name = "textoNumeroConta";
            this.textoNumeroConta.Size = new System.Drawing.Size(95, 20);
            this.textoNumeroConta.TabIndex = 3;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(80, 107);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(95, 20);
            this.txtValor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor";
            // 
            // btnDeposita
            // 
            this.btnDeposita.Location = new System.Drawing.Point(27, 175);
            this.btnDeposita.Name = "btnDeposita";
            this.btnDeposita.Size = new System.Drawing.Size(64, 20);
            this.btnDeposita.TabIndex = 9;
            this.btnDeposita.Text = "Depositar";
            this.btnDeposita.UseVisualStyleBackColor = true;
            this.btnDeposita.Click += new System.EventHandler(this.btnDeposita_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(111, 175);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(64, 20);
            this.btnSacar.TabIndex = 10;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(27, 148);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(148, 21);
            this.comboContas.TabIndex = 12;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // destinoDaTransferencia
            // 
            this.destinoDaTransferencia.FormattingEnabled = true;
            this.destinoDaTransferencia.Location = new System.Drawing.Point(27, 201);
            this.destinoDaTransferencia.Name = "destinoDaTransferencia";
            this.destinoDaTransferencia.Size = new System.Drawing.Size(148, 21);
            this.destinoDaTransferencia.TabIndex = 13;
            this.destinoDaTransferencia.SelectedIndexChanged += new System.EventHandler(this.destinoDaTransferencia_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 20);
            this.button1.TabIndex = 14;
            this.button1.Text = "Trasferir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdicionarCliente
            // 
            this.btnAdicionarCliente.Location = new System.Drawing.Point(227, 59);
            this.btnAdicionarCliente.Name = "btnAdicionarCliente";
            this.btnAdicionarCliente.Size = new System.Drawing.Size(75, 49);
            this.btnAdicionarCliente.TabIndex = 15;
            this.btnAdicionarCliente.Text = "Adicionar Cliente";
            this.btnAdicionarCliente.UseVisualStyleBackColor = true;
            this.btnAdicionarCliente.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // txtTipoDaConta
            // 
            this.txtTipoDaConta.Location = new System.Drawing.Point(227, 21);
            this.txtTipoDaConta.Name = "txtTipoDaConta";
            this.txtTipoDaConta.Size = new System.Drawing.Size(148, 20);
            this.txtTipoDaConta.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tipo da conta";
            // 
            // btnExcluiCliente
            // 
            this.btnExcluiCliente.Location = new System.Drawing.Point(308, 59);
            this.btnExcluiCliente.Name = "btnExcluiCliente";
            this.btnExcluiCliente.Size = new System.Drawing.Size(67, 49);
            this.btnExcluiCliente.TabIndex = 18;
            this.btnExcluiCliente.Text = "Excluir Cliente";
            this.btnExcluiCliente.UseVisualStyleBackColor = true;
            this.btnExcluiCliente.Click += new System.EventHandler(this.btnExcluiCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 430);
            this.Controls.Add(this.btnExcluiCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTipoDaConta);
            this.Controls.Add(this.btnAdicionarCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.destinoDaTransferencia);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDeposita);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.textoNumeroConta);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoTitular);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoNumeroConta;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeposita;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.ComboBox destinoDaTransferencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdicionarCliente;
        private System.Windows.Forms.TextBox txtTipoDaConta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcluiCliente;
    }
}

