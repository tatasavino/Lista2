public class Exercicio15 {
    public void Questao() {

        /*Faça um programa que leia um valor inteiro maior do que zero e mostre todos os números primos
        menores do que o valor lido.*/

        Console.Write("\nInforme um número natural: ");
        int natural = Convert.ToInt32(Console.ReadLine());


        if (natural<=0) {
            Console.Write("\nO número digitado não é natural.");
        } else {
            Console.WriteLine("\n");
            for (int i=2; i<natural; i++) {
                int divisores = 0;
                for (int j=1; j<=i; j++) {
                    if (i%j==0) {
                        divisores++;
                    }
                }
                if (divisores==2) {
                    Console.Write($"\t {i}");
                }
            }
        
        }

    }
}