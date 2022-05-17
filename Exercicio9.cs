public class Exercicio9 {
    public void Questao() {

        /*Faça um programa que leia um valor monetário a ser investido, a taxa de juros mensal sobre o
        investimento e a quantidade de meses que o valor ficará investido. O programa deve calcular e
        mostrar quanto foi o rendimento do valor investido.
        */
        
        Console.Write("\n\t--- Investing ---\n\nValor monetário: ");
        double valor = Convert.ToDouble(Console.ReadLine());
        Console.Write("Taxa de juros (mensal): ");
        double taxa = Convert.ToDouble(Console.ReadLine());
        Console.Write("Quantidade de meses: ");
        double meses = Convert.ToDouble(Console.ReadLine());

        double x = 1;
        for (int i = 1; i<=meses; i++) {
            x = (x*(1+taxa));
        }

        double rendimento = (valor*x);

        Console.WriteLine($"\n\tRendimento: {rendimento:F2}");
    }
}