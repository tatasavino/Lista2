public class Exercicio4 {
    public void Questao() {

        /*Faça um programa que leia um valor inteiro digitado pelo usuário e mostre todos os múltiplos desse
        valor entre 0 e 100.*/

        /*Faça um programa que leia todos os números pares entre 0 e um valor inteiro digitado pelo usuário.*/
        Console.Write("\nDigite um número natural: ");
        int natural = Convert.ToInt32(Console.ReadLine());

        if (natural<=0) {
            Console.Write("\nO número digitado não é natural.");
        } else {
            Console.WriteLine("\n");
            for (int i=1; i<=99; i++) {
                if (i%natural==0) {
                    Console.Write($"\t {i}");
                }
            }
        
        }

    }
}