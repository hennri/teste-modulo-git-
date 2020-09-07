namespace Etec.ConsultorioMedico.UI
{
    partial class Paciente
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
            this.lblNomeDoPaciente = new System.Windows.Forms.Label();
            this.txtNomeDoPaciente = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblPlanoMedico = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtPlanoMedico = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dtPaciente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeDoPaciente
            // 
            this.lblNomeDoPaciente.AutoSize = true;
            this.lblNomeDoPaciente.Location = new System.Drawing.Point(13, 30);
            this.lblNomeDoPaciente.Name = "lblNomeDoPaciente";
            this.lblNomeDoPaciente.Size = new System.Drawing.Size(97, 13);
            this.lblNomeDoPaciente.TabIndex = 0;
            this.lblNomeDoPaciente.Text = "Nome do paciente:";
            // 
            // txtNomeDoPaciente
            // 
            this.txtNomeDoPaciente.Location = new System.Drawing.Point(116, 27);
            this.txtNomeDoPaciente.Name = "txtNomeDoPaciente";
            this.txtNomeDoPaciente.Size = new System.Drawing.Size(356, 20);
            this.txtNomeDoPaciente.TabIndex = 1;
            this.txtNomeDoPaciente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(13, 65);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(12, 103);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "Idade:";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(12, 144);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(24, 13);
            this.lblRg.TabIndex = 4;
            this.lblRg.Text = "Rg:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(12, 182);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 5;
            this.lblCpf.Text = "CPF:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(74, 222);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(398, 20);
            this.txtEndereco.TabIndex = 6;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(42, 141);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(274, 20);
            this.txtRg.TabIndex = 7;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(55, 100);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(417, 20);
            this.txtIdade.TabIndex = 8;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(69, 62);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(403, 20);
            this.txtTelefone.TabIndex = 9;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(48, 179);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(268, 20);
            this.txtCpf.TabIndex = 10;
            // 
            // lblPlanoMedico
            // 
            this.lblPlanoMedico.AutoSize = true;
            this.lblPlanoMedico.Location = new System.Drawing.Point(12, 266);
            this.lblPlanoMedico.Name = "lblPlanoMedico";
            this.lblPlanoMedico.Size = new System.Drawing.Size(75, 13);
            this.lblPlanoMedico.TabIndex = 11;
            this.lblPlanoMedico.Text = "Plano Medico:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(12, 225);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 12;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtPlanoMedico
            // 
            this.txtPlanoMedico.Location = new System.Drawing.Point(93, 263);
            this.txtPlanoMedico.Name = "txtPlanoMedico";
            this.txtPlanoMedico.Size = new System.Drawing.Size(379, 20);
            this.txtPlanoMedico.TabIndex = 13;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(3, 495);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(126, 42);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(325, 495);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 42);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(159, 495);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(126, 42);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // dtPaciente
            // 
            this.dtPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPaciente.Location = new System.Drawing.Point(16, 321);
            this.dtPaciente.Name = "dtPaciente";
            this.dtPaciente.Size = new System.Drawing.Size(456, 150);
            this.dtPaciente.TabIndex = 17;
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 549);
            this.Controls.Add(this.dtPaciente);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPlanoMedico);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblPlanoMedico);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtNomeDoPaciente);
            this.Controls.Add(this.lblNomeDoPaciente);
            this.Name = "Paciente";
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.Paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeDoPaciente;
        private System.Windows.Forms.TextBox txtNomeDoPaciente;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblPlanoMedico;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtPlanoMedico;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dtPaciente;
    }
}