# 🎓 Sistema de Cadastro de Alunos

Projeto desenvolvido em **Squad** durante o Bootcamp de .NET da WoMakersCode, com o objetivo de aplicar na prática os conceitos fundamentais da linguagem e, simultaneamente, desenvolver habilidades de colaboração, versionamento e integração de código utilizando Git e GitHub.

## 📌 Sobre o projeto

O sistema permite cadastrar até 10 alunos e consultar suas informações por meio de um menu interativo.

Para cada aluno são armazenados:

* Nome
* Idade
* Nota 1
* Nota 2

Os dados são organizados em arrays e utilizados nas seguintes funcionalidades:

* Cadastro de alunos
* Listagem dos alunos cadastrados
* Busca de aluno por nome
* Exibição dos alunos aprovados
* Cálculo da média da turma
* Validação da quantidade de alunos
* Validação das opções do menu

### Critério de aprovação

Um aluno é considerado aprovado quando sua média é maior ou igual a `7.0`.

---

## 🗂️ Estrutura do projeto

```text
sistema-cadastro-squad/
│
├── classes/
│   ├── Aprovacao.cs
│   ├── Busca.cs
│   ├── Cadastro.cs
│   ├── Listagem.cs
│   └── MediaTurma.cs
│
│── .gitignore
├── Program.cs
└── README.md
```

### Classes

| Classe       | Responsabilidade                                                  |
| ------------ | ----------------------------------------------------------------- |
| `Cadastro`   | Recebe e armazena os dados dos alunos                             |
| `Listagem`   | Exibe os alunos cadastrados e suas médias                         |
| `Busca`      | Pesquisa alunos pelo nome                                         |
| `Aprovacao`  | Identifica os alunos aprovados                                    |
| `MediaTurma` | Calcula a média geral da turma                                    |
| `Program`    | Inicializa os dados, controla o menu e integra as funcionalidades |

---

## 🛠️ Tecnologias e ferramentas

* C#
* .NET
* Visual Studio
* Git
* GitHub

---

## ▶️ Execução

### Pré-requisitos

Para executar o projeto, é necessário ter instalado:

* .NET SDK
* Visual Studio

### Como executar

Clone o repositório:

```bash
git clone https://github.com/SamlaManathe/sistema-cadastro-squad.git
```

Abra o projeto no Visual Studio e execute a aplicação.

---

## 👥 Equipe

Projeto desenvolvido pela Squad Ada Lovelace durante o Bootcamp de .NET da WoMakersCode.

| Integrante | Responsabilidade | GitHub           |
| ---------- | ---------------- | ---------------- |
| Maria Vitória | Cadastro | [@espinola2007](https://github.com/espinola2007) |
| Ana Carla | Listagem | [@anacarlags](https://github.com/Anacarlags) |
| Renata | Busca | [@renataaires](https://github.com/RenataAires) |
| Thaislaine | Aprovação | [@httpthaes](https://github.com/httpthaes) |
| Samla | Menu | [@samlamanathe](https://github.com/SamlaManathe) |
