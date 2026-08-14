using sistema_cadastro_squad.classes;

string[]? nome = new string[10];
int[] idade = new int[10];
double[] nota1 = new double[10];
double[] nota2 = new double[10];

Console.Write("\nQuantos alunos você deseja cadastrar? ");
int quantAlunos = Convert.ToInt32(Console.ReadLine());

Cadastro cadastro = new Cadastro();
cadastro.CadastrarAluno(nome, idade, quantAlunos, nota1, nota2);

if (quantAlunos <= 0)
{
    Console.WriteLine("\nQuantidade de alunos inválida.");
}
else
{
    int opcao;

    do
    {
        Console.WriteLine("1 - Listar alunos\n2 - Buscar aluno\n3 - Exibir aprovados\n4 - Exibir média da turma\n0 - Encerrar");

        Console.Write("\nOpção: ");

        if (int.TryParse(Console.ReadLine(), out opcao))
        {
            switch (opcao)
            {

                case 1:

                    Listagem.listarAlunos(nome, idade, quantAlunos, nota1, nota2);
                    break;

                case 2:

                    Busca.BuscaPorNome(nome, idade, nota1, nota2, quantAlunos);
                    break;

                case 3:

                    Aprovacao.verificarAprovacao(nome, quantAlunos, nota1, nota2);
                    break;

                case 4:
                    Console.WriteLine($"\nMédia da turma: {MediaTurma.mediaTurma(nota1, nota2, quantAlunos)}\n");
                    break;

                case 0:

                    Console.WriteLine("\nEncerrando...\n");
                    break;

                default:

                    Console.WriteLine("\nOpção inválida, insira novamente!\n");
                    break;
            }
        }
        else
        {
            Console.WriteLine("\nEntrada inválida, insira novamente!\n");
        }

    } while (opcao != 0);
}