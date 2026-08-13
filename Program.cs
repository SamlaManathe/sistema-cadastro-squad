using sistema_cadastro_squad.classes;
string[] nome = new string[10];
int[] idade = new int[10];
double[] nota1 = new double[10];
double[] nota2 = new double[10];
Console.WriteLine("Quantos alunos você deseja cadastrar? ");
int quantAlunos = Convert.ToInt32(Console.ReadLine());


Cadastro cadastro = new Cadastro();


cadastro.CadastrarAluno(nome, idade, quantAlunos, nota1, nota2);
Listagem.listarAlunos(nome, idade, quantAlunos, nota1, nota2);
Aprovacao aprovacao = new Aprovacao();
aprovacao.verificarAprovacao(nome, quantAlunos, nota1, nota2);
