// 5. Construtores e sobrecarga
// Crie uma classe Livro com as propriedades Titulo , Autor e NumeroPaginas .

// Lista de Exercicios POO — criando objetos, definindo propriedades, metodos e aplicando diferentes formas de inicializacao 2

// 1. Crie um construtor sem parâmetros que inicialize as propriedades com
// valores padrão.
// 2. Crie um construtor que receba apenas o título do livro.
// 3. Crie um construtor que receba título e autor.
// 4. Crie um construtor que receba título, autor e número de páginas.
// 5. Instancie quatro objetos utilizando os diferentes construtores.
// 6. Exiba os dados dos livros.

namespace Exercicio_Poo
{
    public class Livro
    {
        public string? Titulo { get; set; }
        public string? Autor{ get; set; }
        public int NumeroPaginas { get; set; }



          public Livro()//metodo construtor
        {
            Titulo = "Nao Informado";
            Autor = " Não Informado";
            NumeroPaginas = 0;
          
        }

        public Livro(string titulo)//metodo construtor com sobrecarga
        {
            Titulo = titulo;
        }
        public Livro (string titulo, string autor)//metodo construtor com sobrecarga
        {   
            Titulo = titulo;
            Autor= autor;
        }

        public Livro(string titulo, string autor, int paginas)//metodo construtor com sobrecarga
        {
            Titulo = titulo;
            Autor= autor;
            NumeroPaginas= paginas;
        }


    }
  
}