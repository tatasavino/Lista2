public class Exercicio12 {
    public void Questao() {

        /*Faça um programa que sorteie um número inteiro entre 1 e 10 e permita ao usuário tentar adivinhar
        esse número continuamente até conseguir. Ao fim, o programa deve mostrar quantas tentativas
        foram realizadas até o número ser adivinhado pelo usuário. Use o código abaixo para obter um valor
        sorteado entre 1 e 10:
        int sorteio = (new Random()).Next(1, 11);*/

        int sorteio = (new Random()).Next(1, 11);
        int chute = 0;
        
        do {

            Console.Write("\n\tChute um número de um a dez: ");
            chute = Convert.ToInt32(Console.ReadLine());

            if (chute == sorteio) {
                Console.WriteLine("\nParabéns! Você ACERTOU!");
            } else {
                Console.WriteLine("\nResposta EEEEEEEEE...ERRADA!");
            }

        } while (chute != sorteio);

        
    }
}