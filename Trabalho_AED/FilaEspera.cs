using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_AED
{
    internal class FilaEspera
    {
        private Candidato[] array;
        int primeiro, ultimo;

        public FilaEspera()
        {
            array = new Candidato[11];
            primeiro = ultimo = 0;
        }

        public void Inserir(Candidato candidato)
        {
            if ((ultimo + 1) % array.Length == primeiro)
            {
                return;
            }

            array[ultimo] = candidato;
            ultimo = (ultimo + 1) % array.Length;
        }

        public void Remover()
        {
            if (primeiro == ultimo)
            {
                return;
            }

            primeiro = (primeiro + 1) % array.Length;
        }

        public void Mostrar()
        {
            if (primeiro == ultimo)
            {
                return;
            }

            int i = primeiro;


            while (i != ultimo)
            {
                Console.WriteLine($"{array[i].Nome} {array[i].Media} {array[i].NotaRed} {array[i].NotaMat} {array[i].NotaLing}");
                i = (i + 1) % array.Length;
            }
        }
    }
}
