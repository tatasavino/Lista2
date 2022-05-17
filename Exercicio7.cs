public class Exercicio7 {
    public void Questao() {

        /*Faça um programa que leia continuamente notas entre 0 e 100, até que o usuário informe o valor -1
        para a nota. Ao fim, o programa deve mostrar a média das notas digitadas pelo usuário.*/
         
        double nota = 0;
        int i = 0;
        double media = 0;
        Console.WriteLine("\nBem vindo. Digite uma ou mais notas caso queira saber\na media de suas notas. Caso queira parar, digite um\nvalor negativo. Detalhe: as notas devem ser menores que 100.");
        
        do {
            Console.Write("\n\tNota: ");
            nota = Convert.ToDouble(Console.ReadLine());

            if (nota>100) {
                Console.WriteLine("\nAs notas devem ser menores que 100.\n");
            }
            else if (nota>=0) {
                i++;
                media = media + nota;
            } else {
                Console.WriteLine($"\nMédia = {media/i}");
            }

        } while  (nota>=0);
    }
}