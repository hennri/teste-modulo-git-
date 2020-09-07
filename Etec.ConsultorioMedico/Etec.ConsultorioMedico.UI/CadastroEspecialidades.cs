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
    public partial class CadastroEspecialidades : Form
    {
        public CadastroEspecialidades()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void CadastroEspecialidades_Load(object sender, EventArgs e)
        {
            EspecialidadesBO regra = new EspecialidadesBO();
            dtEspecialidades.DataSource = regra.buscarEspecialidades();
        }
    }
}
