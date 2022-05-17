public class Exercicio11 {
    public void Questao() {

        /*Considere uma eleição presidencial com os candidatos A, B, C e D. Faça um programa que solicite ao
        usuário em quem ele vai votar, até que se digite a letra “S” para encerrar a votação. Ao fim, o programa
        deve mostrar qual foi o candidato vencedor.*/

        char resposta= 'n';
        int a=0 , b=0, c=0, d=0;

        do {
            Console.Write("\nVoto (A, B, C ou D): ");
            char voto = Convert.ToChar(Console.ReadLine().Substring(0,1).ToUpper());

        if ("ABCD".Contains(voto)) {

            if (voto == 'A') {
                a = a + 1;
            } else if (voto == 'B') {
                b = b + 1;
            } else if (voto == 'C') {
                c = c + 1;
            } else {
                d = d + 1;
            }

            Console.Write("Deseja continuar? ");
            resposta = Convert.ToChar(Console.ReadLine().Substring(0,1).ToUpper());

        } else {
            Console.WriteLine("\n\tVoto inválido. Deseja continuar? ");
            resposta = Convert.ToChar(Console.ReadLine().Substring(0,1).ToUpper());
        }

        } while (resposta!='N');

        if (a>b) {
            if (c>d) {
                if (a>c) {
                    Console.WriteLine("/n/nO vencedor é: A");
                } else {
                    Console.WriteLine("/n/nO vencedor é: C");
                }
            } else {
                if (a>d) {
                    Console.WriteLine("/n/nO vencedor é: A");
                } else {
                    Console.WriteLine("/n/nO vencedor é: D");
                }
            } 
        } else {
            if (c>d) {
                if (b>c) {
                    Console.WriteLine("/n/nO vencedor é: B");
                } else {
                    Console.WriteLine("/n/nO vencedor é: C");
                }
            } else {
                if (b>d) {
                    Console.WriteLine("/n/nO vencedor é: B");
                } else {
                    Console.WriteLine("/n/nO vencedor é: D");
                }
            } 
        }
        
        
    }
}