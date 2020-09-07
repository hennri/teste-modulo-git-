namespace Etec.ConsultorioMedico.UI
{
    partial class PlanoMedico
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
            this.lblTitularDoPlano = new System.Windows.Forms.Label();
            this.lblEmpresaFornecedora = new System.Windows.Forms.Label();
            this.txtTitularDoPlano = new System.Windows.Forms.TextBox();
            this.txtEmpresaFornecedora = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtPlanoMedico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlanoMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitularDoPlano
            // 
            this.lblTitularDoPlano.AutoSize = true;
            this.lblTitularDoPlano.Location = new System.Drawing.Point(42, 33);
            this.lblTitularDoPlano.Name = "lblTitularDoPlano";
            this.lblTitularDoPlano.Size = new System.Drawing.Size(83, 13);
            this.lblTitularDoPlano.TabIndex = 0;
            this.lblTitularDoPlano.Text = "Titular do plano:";
            // 
            // lblEmpresaFornecedora
            // 
            this.lblEmpresaFornecedora.AutoSize = true;
            this.lblEmpresaFornecedora.Location = new System.Drawing.Point(42, 77);
            this.lblEmpresaFornecedora.Name = "lblEmpresaFornecedora";
            this.lblEmpresaFornecedora.Size = new System.Drawing.Size(114, 13);
            this.lblEmpresaFornecedora.TabIndex = 1;
            this.lblEmpresaFornecedora.Text = "Empresa Fornecedora:";
            // 
            // txtTitularDoPlano
            // 
            this.txtTitularDoPlano.Location = new System.Drawing.Point(131, 30);
            this.txtTitularDoPlano.Name = "txtTitularDoPlano";
            this.txtTitularDoPlano.Size = new System.Drawing.Size(391, 20);
            this.txtTitularDoPlano.TabIndex = 4;
            // 
            // txtEmpresaFornecedora
            // 
            this.txtEmpresaFornecedora.Location = new System.Drawing.Point(156, 74);
            this.txtEmpresaFornecedora.Name = "txtEmpresaFornecedora";
            this.txtEmpresaFornecedora.Size = new System.Drawing.Size(366, 20);
            this.txtEmpresaFornecedora.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(30, 262);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(126, 42);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(217, 262);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(126, 42);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(396, 262);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 42);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtPlanoMedico
            // 
            this.dtPlanoMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPlanoMedico.Location = new System.Drawing.Point(30, 100);
            this.dtPlanoMedico.Name = "dtPlanoMedico";
            this.dtPlanoMedico.Size = new System.Drawing.Size(492, 150);
            this.dtPlanoMedico.TabIndex = 11;
            // 
            // PlanoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 415);
            this.Controls.Add(this.dtPlanoMedico);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtEmpresaFornecedora);
            this.Controls.Add(this.txtTitularDoPlano);
            this.Controls.Add(this.lblEmpresaFornecedora);
            this.Controls.Add(this.lblTitularDoPlano);
            this.Name = "PlanoMedico";
            this.Text = "PlanoMedico";
            this.Load += new System.EventHandler(this.PlanoMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPlanoMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitularDoPlano;
        private System.Windows.Forms.Label lblEmpresaFornecedora;
        private System.Windows.Forms.TextBox txtTitularDoPlano;
        private System.Windows.Forms.TextBox txtEmpresaFornecedora;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dtPlanoMedico;
    }
}