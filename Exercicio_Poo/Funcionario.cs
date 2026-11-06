// 4. Propriedades e controle de acesso
// Crie uma classe Funcionario para representar um funcionário de uma empresa,
// com as seguintes propriedades:
// Nome : leitura e escrita pública.
// Cargo : leitura e escrita pública.
// Salario : leitura pública e escrita privada.
// 1. Crie um método AumentarSalario() que receba um percentual de aumento e
// atualize o salário do funcionário.
// 2. Crie um método ConsultarSalario() que exiba o salário atual.
// 3. Instancie um funcionário e teste suas funcionalidades.
// 4. Tente alterar o salário atribuindo um valor diretamente pela propriedade
// Salario e explique o resultado. Escreva sua explicação em um comentário,
// no próprio código.

namespace Exercicio_Poo
{
    public class Funcionario
    {
        public string? Nome { get; set; }

        public string? Cargo { get; set; }

        public double Salario { get; set; }

        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario*(1 + (porcentagem/100));
            System.Console.WriteLine(Salario);
            
        }
        public void ConsultarSalario()
        {
            System.Console.WriteLine(Salario);
        }

        public void Funcionalidade()
        {
            System.Console.WriteLine($"Nome: {Nome} - Cargo: {Cargo} - Salario: {Salario}");
        }

    }
}