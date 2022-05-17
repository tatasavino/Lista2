public class Exercicio14 {
    public void Questao() {

        /*. Faça um programa semelhante ao da questão anterior, porém, para duas pessoas (A e B) tentarem
        adivinhar de forma alternada. Ao fim, o programa deve informar o usuário vencedor (A ou B).
        */

        int sorteio = (new Random()).Next(1, 11);
        int chute1 = 0;
        int chute2 = 0;
        
        do {

            Console.Write("\n\tApostador 1: Chute um número de um a dez: ");
            chute1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\tApostador 2: Chute um número de um a dez: ");
            chute2 = Convert.ToInt32(Console.ReadLine());

        } while ((chute1 != sorteio)&(chute2 != sorteio));

        if (chute1 == sorteio) {
            if (chute2 == sorteio) {
                Console.WriteLine("\nEmpate! Mas... Apostador 1 colocou o número sorteado primeiro.");
            } else {
                Console.WriteLine("\nApostador 1 ganhou!");
            }
        } else if (chute2 == sorteio) {
            Console.WriteLine("\nApostador 2 ganhou!");
        }
    }
}