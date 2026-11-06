// 2. Métodos de instância e métodos estáticos
// Crie uma classe Calculadora para realizar operações matemáticas.
// 1. Crie os métodos de instância Somar() , Subtrair() e Multiplicar() .
// 2. Crie um método estático Dividir() que receba dois números e retorne o
// resultado.
// 3. Instancie um objeto da classe Calculadora para executar os métodos de
// instância.
// 4. Execute o método Dividir() diretamente pela classe, sem criar um objeto.
namespace Exercicio_Poo
{
    public class Calculadora
    {
        public static int Soma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        
        public static int Subtrair(int numero1, int numero2 )
        {
            return numero1-numero2;
        }


        public static int Multiplicacao(int numero1, int numero2)
        {
            return numero1*numero2;
        }


        public static int Divisao(int numero1, int numero2)
        {
            return numero1/numero2;
        }


        
    }
}