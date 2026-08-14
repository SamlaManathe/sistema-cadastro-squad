using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_cadastro_squad.classes
{
    internal class Cadastro
    {
        
        public void CadastrarAluno(string[] nome, int[] idade, int quantAlunos, double[] nota1, double[] nota2)
        {

            if (quantAlunos > 10)
            {
                Console.WriteLine("\nVocê só pode cadastrar até 10 alunos.");
            }

            else if (quantAlunos <= 0)
            {
                Console.WriteLine("\nVocê deve cadastrar pelo menos 1 aluno.");
            }

            else
            {

                for (int i = 0; i < quantAlunos; i++)
                {
                    Console.Write("\nNome do aluno: ");
                    nome[i] = Console.ReadLine();

                    Console.Write("Idade do aluno: ");
                    idade[i] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Primeira nota: ");
                    nota1[i] = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Segunda nota: ");
                    nota2[i] = Convert.ToDouble(Console.ReadLine());

                }

                Console.WriteLine("\nCadastro concluído!\n");

            }

        }
        
    }
}