public class Exercicio5 {
    public void Questao() {

        /*Faça um programa que permita ao usuário entrar com um número entre 1 e 10 e, ao fim, mostre a
        tabuada desse número.*/

        Console.Write("\nDigite um natural menor que 11: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n  Tabuada:\n");
        
        if (numero<=0) {
            Console.Write("\nO número digitado não é natural.");
        } else if (numero>=11) {
            Console.Write
            ("\nO número digitado é maior ou igual a onze.");
        } else {
            for (int i=1;i<=10;i++) {
                Console.WriteLine("\t"+(i*numero));
            }
        }
    }
}