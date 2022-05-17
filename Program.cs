using System;

namespace Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool comecar = true;
            do {
                Console.Write("\nBem vindo, usuário! Escolha um exercício para ver (1-15): ");
                int resposta = Convert.ToInt32(Console.ReadLine());
               
                    switch (resposta) {
                        case 1:
                            Exercicio1 ex1 = new Exercicio1();
                            ex1.Questao();
                            break;
                        case 2:
                            Exercicio2 ex2 = new Exercicio2();
                            ex2.Questao();
                            break;
                        case 3:
                            Exercicio3 ex3 = new Exercicio3();
                            ex3.Questao();
                            break;
                        case 4:
                            Exercicio4 ex4 = new Exercicio4();
                            ex4.Questao();
                            break;
                        case 5:
                            Exercicio5 ex5 = new Exercicio5();
                            ex5.Questao();
                            break;
                        case 6:
                            Exercicio6 ex6 = new Exercicio6();
                            ex6.Questao();
                            break;
                        case 7:
                            Exercicio7 ex7 = new Exercicio7();
                            ex7.Questao();
                            break;
                        case 8:
                            Exercicio8 ex8 = new Exercicio8();
                            ex8.Questao();
                            break;
                        case 9:
                            Exercicio9 ex9 = new Exercicio9();
                            ex9.Questao();
                            break;
                        case 10:
                            Exercicio10 ex10 = new Exercicio10();
                            ex10.Questao();
                            break;
                        case 11:
                            Exercicio11 ex11 = new Exercicio11();
                            ex11.Questao();
                            break;
                        case 12: 
                            Exercicio12 ex12 = new Exercicio12();
                            ex12.Questao();
                            break;
                        case 13:
                            Exercicio13 ex13 = new Exercicio13();
                            ex13.Questao();
                            break;
                        case 14:
                            Exercicio14 ex14 = new Exercicio14();
                            ex14.Questao();
                            break;
                        case 15:
                            Exercicio15 ex15 = new Exercicio15();
                            ex15.Questao();
                            break;
                        default:
                            Console.WriteLine("\nSó há questões do número 1 ao 15.");
                            break;
                    }
                    
                    Console.Write("\n\n--------------------------------------------------------------------------\n\nDeseja escolher novamente? \n\n");
                    string resposta2 = Console.ReadLine();
                    resposta2 = resposta2.ToLower();
                    char res2 = Convert.ToChar(resposta2.Substring(0,1));
                    Console.Write("\n\n--------------------------------------------------------------------------");

                    if (res2=='n') {
                        comecar = false;
                    }
            } while (comecar == true);
            Console.WriteLine("\n");
        }
    }
}
