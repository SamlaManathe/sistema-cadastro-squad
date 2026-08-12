using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_cadastro_squad.classes
{
    internal class Cadastro
    {
        public void CadastrarAluno() 
        { 

            string[] nome = new string[10];
            int[] idade = new int[10];
            double[] nota1 = new double[10];
            double[] nota2 = new double[10];

            Console.WriteLine("Você deseja cadastrar algum aluno? (s/n)");
            string resposta = Console.ReadLine();

            bool desejaCadastrar = resposta.ToLower() == "s";
            if(desejaCadastrar != true)

            {
                Console.WriteLine(" ");
                return;
            }

            Console.WriteLine("Quantos alunos você deseja cadastrar? ");
            int quantAlunos = Convert.ToInt32(Console.ReadLine());

            if (quantAlunos > 10)
            {
                Console.WriteLine("Você só pode cadastrar até 10 alunos.");
            }

            else if (quantAlunos <= 0)
            {
                Console.WriteLine("Você deve cadastrar pelo menos 1 aluno.");
            }

            else
            {

                for (int i = 0; i < quantAlunos; i++)
                {
                    Console.Write("Digite o nome do aluno: ");
                    nome[i] = Console.ReadLine();

                    Console.Write("Digite a idade do aluno: ");
                    idade[i] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite a primeira nota: ");
                    nota1[i] = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite a segunda nota: ");
                    nota2[i] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(" ");

                }

                Console.WriteLine(" ");
                Console.WriteLine("~~Cadastro Concluído!~~");
                Console.WriteLine(" ");

            }
        }
    }

}
