﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec.ConsultorioMedico.CLASS
{
   public class Paciente
    {
        public int idPaciente { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public int Idade { get; set; }
        public int Rg { get; set; }
        public int Cpf { get; set; }
        public string Endereco { get; set; }
        public string PlanoMedico { get; set; }

    }
}
