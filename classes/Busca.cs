using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_cadastro_squad.classes
{
    internal class Busca
    {
        // 1. idade mudou para int[]
        // 2. totalCadastrados mudou para int
        public static void BuscaPorNome(string[] nome, int[] idade, double[] nota1, double[] nota2, int totalCadastrados)
        {
            Console.WriteLine("\n---Buscar aluno pelo nome---");
            Console.Write("Digite o nome do aluno que deseja buscar: ");
            string? nomeBusca = Console.ReadLine();

            bool alunoEncontrado = false;

            // Percorre até o número total de alunos cadastrados
            for (int i = 0; i < totalCadastrados; i++)
            {
                if (nome[i] != null && nome[i].Equals(nomeBusca, StringComparison.OrdinalIgnoreCase))
                {
                    double media = (notas1[i] + notas2[i]) / 2.0;

                    Console.WriteLine($"\nAluno encontrado: {nome[i]}");
                    Console.WriteLine($"Idade: {idade[i]}"); // Agora busca a idade do aluno no índice i
                    Console.WriteLine($"Nota 1: {nota1[i]}");
                    Console.WriteLine($"Nota 2: {nota2[i]}");
                    Console.WriteLine($"Média: {media:F1}");

                    alunoEncontrado = true;
                    break;
                }
            }

            if (!alunoEncontrado)
            {
                Console.WriteLine("Aluno não encontrado.");
            }
        }
    }
}
