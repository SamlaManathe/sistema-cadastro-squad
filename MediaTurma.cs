using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_cadastro_squad.classes
{
    internal class MediaTurma
    {
        public static double mediaTurma(double[] nota1, double[] nota2, int quantAlunos)
        {
            double somaMedias = 0;

            for(int i = 0; i < quantAlunos; i++)
            {
                double media = (nota1[i] + nota2[i]) / 2;

                somaMedias += media;
            }

            return somaMedias / quantAlunos;
        }

    }
}
