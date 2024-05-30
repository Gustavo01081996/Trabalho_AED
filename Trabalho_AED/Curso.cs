using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_AED
{
    internal class Curso
    {
        private int codigo;
        private string nome;
        private int quantVagas;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int QuantVagas
        {
            get { return quantVagas; }
            set { quantVagas = value; }
        }


        public Curso(int codigo, string nome, int quantVagas) 
        {
            this.codigo = codigo;
            this.nome = nome;   
            this.quantVagas = quantVagas;

        }

    }
}
    


