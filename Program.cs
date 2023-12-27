
using DotNet_Metodos_Construtores_DIO.Models;

Pessoa pessoa1 = new Pessoa(nome: "Natália", sobrenome:"Resina");
Pessoa pessoa2 = new Pessoa(nome: "André", sobrenome:"de Lima");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);
cursoDeIngles.ListarAlunos();



