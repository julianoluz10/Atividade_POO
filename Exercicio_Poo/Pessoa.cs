// Exercícios
// 1. Apresentação de pessoas
// Crie uma classe Pessoa com as propriedades Nome , Idade e Cidade .
// 1. Crie um método Apresentar() que exiba os dados da pessoa.
// 2. Instancie dois objetos da classe Pessoa .
// 3. Atribua valores diferentes para cada objeto.
// 4. Execute o método Apresentar() para ambos.

using System.Security.Cryptography.X509Certificates;

namespace EXERCICIO_POO
{
    public class Pessoa
    {
        public string? Nome{ get; set;}
        public int Idade{ get; set;}
        public string? Cidade{ get; set;}

        public void apresentar()
        {
            System.Console.WriteLine($"Nome: {Nome}-Idade {Idade}-Cidade{Cidade}");
        }
        
    }
}
