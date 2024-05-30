using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_AED
{
    internal class Candidato
    {
        private string nome;
        private double notaRed;
        private double notaMat;
        private double notaLing;
        private double media;
        private int opcao1;
        private int opcao2;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double NotaRed
        {
            get { return notaRed; }
            set { notaRed = value; }
        }

        public double NotaMat
        {
            get { return notaMat; }
            set { notaMat = value; }
        }

        public double NotaLing
        {
            get { return notaLing; }
            set { notaLing = value; }
        }


        public double Media
        {
            get { return media; }
            set { media = value; }
        }

        public int Opcao1
        {
            get { return opcao1; }
            set { opcao1 = value; }
        }

        public int Opcao2
        {
            get { return opcao2; }
            set { opcao2 = value; }
        }


        public Candidato(string nome, double notaRed, double notaMat, double notaLing, double media,  int opcao1, int opcao2) 
        {

            this.nome = nome;
            this.notaRed = notaRed; 
            this.notaMat = notaMat; 
            this.notaLing = notaLing;   
            this.media = media;
            this.opcao1 = opcao1;
            this.opcao2 = opcao2;   

        }


        public static void MostrarCandidato(Candidato[] listaCandidatos)
        {

            Console.WriteLine("");
            Console.WriteLine("");

            for (int i = 0; i < listaCandidatos.Length; i++)
            {
                Console.WriteLine($" Nome: {listaCandidatos[i].nome}, Nota Redação: {listaCandidatos[i].notaRed};  Nota Matemática: {listaCandidatos[i].notaMat}; Nota Lang: {listaCandidatos[i].notaLing}; Média: {listaCandidatos[i].media}; Opcao 1: {listaCandidatos[i].opcao1}; Opção 2: {listaCandidatos[i].opcao2}");
            }

        }




    }
}
