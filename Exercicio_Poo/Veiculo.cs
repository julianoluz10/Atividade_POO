// 3. Propriedades com validação
// Crie uma classe Veiculo com uma propriedade pública chamada Velocidade .
// 1. Implemente os acessores get e set da propriedade.
// 2. A propriedade deve aceitar apenas valores entre 0 e 200 km/h.
// 3. Caso seja atribuído um valor fora desse intervalo, a velocidade não deve
// ser alterada.
// 4. Crie um objeto da classe Veiculo e atribua diferentes valores à velocidade,
// incluindo valores inválidos.
// 5. Exiba a velocidade após cada tentativa de atribuição para verificar se a
// validação está funcionando corretamente.

namespace Exercicio_Poo
{
    public class Veiculo
    {
        public int  Velocidade{get;  private set;}

        public int  AlterarVelocidade(int novaVelocidade)
        {
            if (novaVelocidade <=200)
            {
                Velocidade = novaVelocidade;
            }
            else
            {
                System.Console.WriteLine("Valor acima do Permitido");
            }
            
            return Velocidade;
        }
    }


}