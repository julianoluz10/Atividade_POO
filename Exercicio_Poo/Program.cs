
using System.Runtime.InteropServices;
using Exercicio_Poo;
using EXERCICIO_POO;

Pessoa p1 = new Pessoa();
p1.Nome = "juliano";
p1.Idade = 40;
p1.Cidade = "São Caetano do Sul";

p1.apresentar();


int Somar = Calculadora.Soma(10,5);
System.Console.WriteLine("Resultado: " + Somar);


int Sub = Calculadora.Subtrair(10,5);
System.Console.WriteLine("Subtração: " + Sub);


int Mult = Calculadora.Multiplicacao(8,7);
System.Console.WriteLine("Multiplicação "+ Mult);

int Divi = Calculadora.Divisao(10,5);
System.Console.WriteLine("Divisão "+ Divi);


Veiculo c1 = new Veiculo();
System.Console.WriteLine("A velocdiade é:" +c1.AlterarVelocidade(200));


Funcionario RE1 = new Funcionario();




 RE1.Nome = "Juliano";
 RE1.Cargo = "Eletricista";
 RE1.Salario = 7500;

 RE1.Funcionalidade();

RE1.ConsultarSalario();

 RE1.AumentarSalario(10);


//  Livro L1 = new Livro();
//  L1.Titulo = "Aprenda Programação POO";
//  L1.Autor = "Samuel";
//  L1.NumeroPaginas = 320;

//  L1.Visualizar();


Livro l1 = new Livro();
Console.WriteLine($"Titulo: {l1.Titulo} - Autor: {l1.Autor} - Numero de Paginas: {l1.NumeroPaginas}");

Livro l2 = new Livro("Memorias Postumas de Brás cubas");
Console.WriteLine($"Titulo: {l2.Titulo} - Autor: {l2.Autor} - Numero de Paginas: {l2.NumeroPaginas}");

Livro l3 = new Livro("Memorias Postumas de Brás cubas", "Machado de Assis");
Console.WriteLine($"Titulo: {l3.Titulo} - Autor: {l3.Autor} - Numero de Paginas: {l3.NumeroPaginas}");

Livro l4 = new Livro("Memorias Postumas de Brás cubas", "Machado de Assis", 384);
Console.WriteLine($"Titulo: {l4.Titulo} - Autor: {l4.Autor} - Numero de Paginas: {l4.NumeroPaginas}");