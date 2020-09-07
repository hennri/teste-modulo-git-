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
using Etec.ConsultorioMedico.CLASS;


namespace Etec.ConsultorioMedico.UI
{
    public partial class PlanoMedico : Form
    {
        public PlanoMedico()
        {
            InitializeComponent();
        }

        private void lblDataTermino_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CLASS.PlanoMedico classePlanoMedico = new CLASS.PlanoMedico();
            classePlanoMedico.Titular = txtTitularDoPlano.Text;

        }

        private void PlanoMedico_Load(object sender, EventArgs e)
        {
            PlanoMedicoBO regra = new PlanoMedicoBO();
            dtPlanoMedico.DataSource = regra.buscarPlanoMedico();
        }
    }
}
