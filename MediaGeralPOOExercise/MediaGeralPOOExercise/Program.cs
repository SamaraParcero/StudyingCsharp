using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOOExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "### Média Geral dos Alunos ###";
            Console.Write("Quantos alunos?");
            int nAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] alunos = new Aluno[nAlunos];

            for(int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write("Aluno #" + (i + 1) + " Nome..: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Aluno #" + (i + 1) + " Provas..: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);
                Console.WriteLine("Insira as notas do aluno " + nome);
                alunos[i].InserirNotas();
            }

            Console.Clear();

            double mediaGeral = 0;
            foreach(Aluno aluno in alunos)
            {
                Console.Write("Aluno: " + aluno.Nome);
                Console.WriteLine("Media: " + aluno.Media);

                mediaGeral += aluno.Media;   
            }

            double resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine("Média geral: " + resultadoFinal);
            Console.ReadKey();

        }
    }
}
