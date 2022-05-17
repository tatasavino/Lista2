public class Exercicio10 {
    public void Questao() {

        /*Faça um programa que leia continuamente números inteiros digitados pelo usuário até que ele digite
        -1. A cada leitura, o programa deve mostrar a soma e a média dos valores lidos até o momento.*/

        double valor = 0;
        int i = 0;
        double media = 0;
        Console.WriteLine("\nBem vindo. Digite uma ou mais valores caso queira saber\na media dos valores lidos. Caso queira parar, digite um\nvalor negativo.");
        
        do {
            Console.Write("\n\tValor: ");
            valor = Convert.ToDouble(Console.ReadLine());

            if (valor>=0) {
                i++;
                media = media + valor;
            } else {
                Console.WriteLine($"\nMédia = {media/i}");
            }

        } while  (valor>=0);
    }
}