using ExemploExplorando.Models;


Pessoa p1 = new Pessoa(nome: "tah",   sobrenome: "Alves");
Pessoa p2 = new Pessoa(nome: "Léo",   sobrenome: "Cruz");
Pessoa p3 = new Pessoa(nome: "Lucas", sobrenome: "Alves");


// estanciar

Curso cursoDeIngles = new Curso();

cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();



















































// Pessoa p1 = new Pessoa();
// p1.Nome = "tah";
// p1.SobreNome = "Alves";
// p1.Idade = 20;
// p1.Apresentar();

