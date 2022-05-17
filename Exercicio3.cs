public class Exercicio3 {
    public void Questao() {

        /*Faça um programa que leia todos os números pares entre 0 e um valor inteiro digitado pelo usuário.*/
        Console.Write("\nDigite um número natural: ");
        int natural = Convert.ToInt32(Console.ReadLine());

        if (natural<=0) {
            Console.Write("\nO número digitado não é natural.");
        } else {
            Console.WriteLine("\n");
            for (int i=2; i<natural; i++) {
                if (i%2==0) {
                    Console.Write($"\t {i}");
                }
            }
        
        }
    }
}