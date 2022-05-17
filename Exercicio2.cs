public class Exercicio2 {
    public void Questao() {

        /*Faça um programa que mostre todos os números pares entre 0 e 100.*/

        Console.WriteLine("\nLista: \n");
        for (int i=1; i<=100; i++) {
            if (i%2==0) {
                Console.Write($" {i}");
                if (i%50==0) {
                    Console.WriteLine();
                }
            }
        
        }
    }
}