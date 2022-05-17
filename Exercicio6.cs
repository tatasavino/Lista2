public class Exercicio6 {
    public void Questao() {

        /*Faça um programa que imprima a tabuada de todos os números de 1 a 10 (dica: use uma estrutura de
        repetição dentro de outra).*/

        for (int i=1; i<=10; i++) {
            Console.WriteLine($"\nTabuada de {i}:\n");
            for (int j=1; j<=10; j++) {
                Console.Write((i*j)+"\n");
            }
        }
    }
}