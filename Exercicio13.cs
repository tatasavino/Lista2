public class Exercicio13 {
    public void Questao() {

        /*Usando o código de geração de números aleatórios mostrado na questão anterior, faça um programa
        que sorteie os 6 números da Mega-Sena, lembrando que os números variam de 1 a 50 e são diferentes
        entre eles*/

        Console.WriteLine("\n");

        for (int i = 0; i!=6; i++) {
            int sorteio = (new Random()).Next(1, 51);
            Console.Write($"\t{sorteio}");
        }
    }
}