namespace Etec.ConsultorioMedico.UI
{
    partial class Menu
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
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnPlanoMedico = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnCadEspecialidades = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(2, 12);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnPaciente.TabIndex = 0;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.Location = new System.Drawing.Point(2, 41);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(75, 23);
            this.btnMedico.TabIndex = 1;
            this.btnMedico.Text = "Medico";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnPlanoMedico
            // 
            this.btnPlanoMedico.Location = new System.Drawing.Point(2, 99);
            this.btnPlanoMedico.Name = "btnPlanoMedico";
            this.btnPlanoMedico.Size = new System.Drawing.Size(75, 23);
            this.btnPlanoMedico.TabIndex = 2;
            this.btnPlanoMedico.Text = "PlanoMedico";
            this.btnPlanoMedico.UseVisualStyleBackColor = true;
            this.btnPlanoMedico.Click += new System.EventHandler(this.btnPlanoMedico_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(2, 70);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnFuncionario.TabIndex = 3;
            this.btnFuncionario.Text = "Funcionario";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnCadEspecialidades
            // 
            this.btnCadEspecialidades.Location = new System.Drawing.Point(2, 128);
            this.btnCadEspecialidades.Name = "btnCadEspecialidades";
            this.btnCadEspecialidades.Size = new System.Drawing.Size(75, 23);
            this.btnCadEspecialidades.TabIndex = 4;
            this.btnCadEspecialidades.Text = "CadastroEspecialidades";
            this.btnCadEspecialidades.UseVisualStyleBackColor = true;
            this.btnCadEspecialidades.Click += new System.EventHandler(this.btnCadEspecialidades_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(2, 157);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 261);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnCadEspecialidades);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnPlanoMedico);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.btnPaciente);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnPlanoMedico;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnCadEspecialidades;
        private System.Windows.Forms.Button btnConsulta;
    }
}