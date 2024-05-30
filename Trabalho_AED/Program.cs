using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Collections.Specialized;

namespace Trabalho_AED
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string read, nome, nomeCurso;
            double notaRed, notaMat, notaLang, media;
            int quantCursos, quantCandidatos, opcao1, opcao2, count = 0, index = 0, indexCurso = 0, codigo, quantVagas;
            string[] configPage = new string[1];

            StreamReader arq = new StreamReader("C:\\Users\\conta\\Downloads\\entrada.txt", Encoding.UTF8);
            read = arq.ReadLine();
            configPage = read.Split(';');
            quantCursos = int.Parse(configPage[0]);
            quantCandidatos = int.Parse(configPage[1]);

       



            Candidato[] listaCandidatos = new Candidato[quantCandidatos];
            Curso[] listaCursos = new Curso[quantCursos];

            string[] candidatos = new string[quantCandidatos];
            string[] cursos = new string[quantCursos];

            while ((read = arq.ReadLine()) != null)
            {
                if (count < quantCursos)
                {
                    cursos = read.Split(';');
                    codigo = int.Parse(cursos[0]);
                    nome = cursos[1];
                    quantVagas = int.Parse(cursos[2]);
                    listaCursos[indexCurso] = new Curso(codigo, nome, quantVagas);
                    indexCurso++;

                }

                else
                {
                 
                    candidatos = read.Split(';');
                    nome = candidatos[0];
                    notaRed = double.Parse(candidatos[1]);
                    notaMat = double.Parse(candidatos[2]);
                    notaLang = double.Parse(candidatos[3]);
                    media = (notaRed + notaMat + notaLang) / quantCursos;
                    opcao1 = int.Parse(candidatos[4]);
                    opcao2 = int.Parse(candidatos[5]);

                    listaCandidatos[index] = new Candidato(nome, notaRed, notaMat, notaLang, media, opcao1, opcao2);
                    index++;


                }
                count++;



            }
      


        }
    }






}
