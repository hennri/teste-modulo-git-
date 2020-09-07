using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etec.ConsultorioMedico.BO;

namespace Etec.ConsultorioMedico.UI
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void lblCargo_Click(object sender, EventArgs e)
        {

        }

        private void lblEspecialidade_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CLASS.Funcionario classeFuncionario = new CLASS.Funcionario();
            classeFuncionario.Cargo = txtCargo.Text;
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            FuncionarioBO regra = new FuncionarioBO();
            dtFuncionario.DataSource = regra.buscarFuncionario();
        }
    }
}
