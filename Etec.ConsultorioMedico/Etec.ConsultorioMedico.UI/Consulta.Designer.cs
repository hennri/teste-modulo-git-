namespace Etec.ConsultorioMedico.UI
{
    partial class Consulta
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
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblDataDaConsulta = new System.Windows.Forms.Label();
            this.lblTipoConsulta = new System.Windows.Forms.Label();
            this.lblAgendado = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtDataDaConsulta = new System.Windows.Forms.TextBox();
            this.txtTipoConsulta = new System.Windows.Forms.TextBox();
            this.txtAgendado = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dtConsulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(23, 44);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(52, 13);
            this.lblPaciente.TabIndex = 0;
            this.lblPaciente.Text = "Paciente:";
            this.lblPaciente.Click += new System.EventHandler(this.lblPaciente_Click);
            // 
            // lblDataDaConsulta
            // 
            this.lblDataDaConsulta.AutoSize = true;
            this.lblDataDaConsulta.Location = new System.Drawing.Point(23, 81);
            this.lblDataDaConsulta.Name = "lblDataDaConsulta";
            this.lblDataDaConsulta.Size = new System.Drawing.Size(92, 13);
            this.lblDataDaConsulta.TabIndex = 1;
            this.lblDataDaConsulta.Text = "Data da Consulta:";
            // 
            // lblTipoConsulta
            // 
            this.lblTipoConsulta.AutoSize = true;
            this.lblTipoConsulta.Location = new System.Drawing.Point(23, 115);
            this.lblTipoConsulta.Name = "lblTipoConsulta";
            this.lblTipoConsulta.Size = new System.Drawing.Size(74, 13);
            this.lblTipoConsulta.TabIndex = 2;
            this.lblTipoConsulta.Text = "Tipo consulta:";
            // 
            // lblAgendado
            // 
            this.lblAgendado.AutoSize = true;
            this.lblAgendado.Location = new System.Drawing.Point(23, 156);
            this.lblAgendado.Name = "lblAgendado";
            this.lblAgendado.Size = new System.Drawing.Size(59, 13);
            this.lblAgendado.TabIndex = 4;
            this.lblAgendado.Text = "Agendado:";
            this.lblAgendado.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(81, 41);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(379, 20);
            this.txtPaciente.TabIndex = 5;
            // 
            // txtDataDaConsulta
            // 
            this.txtDataDaConsulta.Location = new System.Drawing.Point(121, 78);
            this.txtDataDaConsulta.Name = "txtDataDaConsulta";
            this.txtDataDaConsulta.Size = new System.Drawing.Size(339, 20);
            this.txtDataDaConsulta.TabIndex = 6;
            // 
            // txtTipoConsulta
            // 
            this.txtTipoConsulta.Location = new System.Drawing.Point(103, 112);
            this.txtTipoConsulta.Name = "txtTipoConsulta";
            this.txtTipoConsulta.Size = new System.Drawing.Size(357, 20);
            this.txtTipoConsulta.TabIndex = 7;
            this.txtTipoConsulta.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtAgendado
            // 
            this.txtAgendado.Location = new System.Drawing.Point(88, 149);
            this.txtAgendado.Name = "txtAgendado";
            this.txtAgendado.Size = new System.Drawing.Size(372, 20);
            this.txtAgendado.TabIndex = 9;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 395);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(126, 42);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(345, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 42);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(189, 395);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(126, 42);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // dtConsulta
            // 
            this.dtConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtConsulta.Location = new System.Drawing.Point(26, 204);
            this.dtConsulta.Name = "dtConsulta";
            this.dtConsulta.Size = new System.Drawing.Size(434, 150);
            this.dtConsulta.TabIndex = 13;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 476);
            this.Controls.Add(this.dtConsulta);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtAgendado);
            this.Controls.Add(this.txtTipoConsulta);
            this.Controls.Add(this.txtDataDaConsulta);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.lblAgendado);
            this.Controls.Add(this.lblTipoConsulta);
            this.Controls.Add(this.lblDataDaConsulta);
            this.Controls.Add(this.lblPaciente);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblDataDaConsulta;
        private System.Windows.Forms.Label lblTipoConsulta;
        private System.Windows.Forms.Label lblAgendado;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox txtDataDaConsulta;
        private System.Windows.Forms.TextBox txtTipoConsulta;
        private System.Windows.Forms.TextBox txtAgendado;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dtConsulta;
    }
}