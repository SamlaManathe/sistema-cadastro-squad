using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_cadastro_squad.classes
{
    internal class Aprovacao
    {
        public static void verificarAprovacao(string[] nome, int quantAlunos, double[] nota1, double[] nota2)
        {
            int aprovados = 0;

            Console.WriteLine("\n------- Alunos Aprovados -------\n");

            for (int i = 0; i < quantAlunos; i++)
            {
                double media = (nota1[i] + nota2[i]) / 2;

                if (media >= 7)
                {
                    Console.WriteLine($"{nome[i]} - Média {media}\n");
                    aprovados++;
                }
            }

            var alunosAprovados = aprovados != 1 ? $"{aprovados} alunos" : "1 aluno";
            Console.WriteLine($"Total: {alunosAprovados}");
            Console.WriteLine("---------------------------------\n");
        }

    }
};