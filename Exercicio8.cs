public class Exercicio8 {
    public void Questao() {

        /*Faça um programa que leia um número inteiro digitado pelo usuário e informe se o número é ou não
        um número primo (divisível apenas por 1 e por ele mesmo).*/

        Console.Write("\nDigite um número natural: ");
        int natural = Convert.ToInt32(Console.ReadLine());

        if (natural<=0) {
            Console.Write("\nO número digitado não é natural.");
        } else {
            int divisores = 0;
            for (int i = 1; i<=natural; i++) {
                if (natural%i == 0) {
                    divisores++;
                }
            }
            
            if (divisores==2) {
                Console.WriteLine("\nÉ primo.");
            } else {
                Console.WriteLine("\nNão é primo;");
            }
        }
    }
}