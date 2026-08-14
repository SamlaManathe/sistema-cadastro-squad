using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_cadastro_squad.classes
{
    internal class Listagem

    {
        public static void listarAlunos(string[] nome, int[] idade, int quantAlunos, double[] nota1, double[] nota2)
        {
            //Pegar os dados dos alunos 

            Console.WriteLine("\n--- Lista de Alunos Cadastrados ---\n");

            //Verifica se o array esta vazio e mostra um aviso
            if (quantAlunos <= 0)
            {
                Console.WriteLine("Nenhum Aluno cadastrado ainda ...");
            }
            else if (quantAlunos > 0)
            {
                for (int i = 0; i < quantAlunos; i++)
                {
                    //Calcula  media e Lista alunos
                    double media = (nota1[i] + nota2[i]) / 2;
                    Console.WriteLine($"Nome: {nome[i]}\n");
                    Console.WriteLine($"Idade: {idade[i]}\n");
                    Console.WriteLine($"Média: {media}\n");
                    Console.WriteLine("-----------------------------------\n");
                }

            }

        }
    }
}