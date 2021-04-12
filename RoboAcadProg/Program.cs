using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] direcao = new string[4] {"Norte", "Sul", "Leste", "Oeste" };
            string[] posicaox = new string[4] {"0", "1", "2", "3" };
            string[] posicaoy = new string[4] {"0", "1", "2", "3" };    
            string opcao = "";

            {
                while (true)
                {
                    //Menu com opções
                    Console.WriteLine("=============== Robô Tupiniquim I ===============");
                    Console.WriteLine("==                                             ==");
                    Console.WriteLine("==   (M)-Para mover para frente                ==");                  
                    Console.WriteLine("==   (D)-Para mover 90° graus para direita     ==");
                    Console.WriteLine("==   (E)-Para mover 90° graus para esquerda    ==");
                    Console.WriteLine("==   (S)-Para Sair                             ==");
                    Console.WriteLine("==                                             ==");
                    Console.WriteLine("=================================================");

                    opcao = Console.ReadLine();


                    if (opcao == "M" || opcao == "m")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Posição x é: " + posicaox[0]);
                        Console.WriteLine("Posição y é: " + posicaoy[1]);
                        Console.WriteLine();
                        Console.WriteLine(direcao[0]);
                        Console.ReadLine();
                        Console.Clear();
                        
                    }
                    else if(opcao == "D" || opcao == "d")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Posição x é: " + posicaox[1]);
                        Console.WriteLine("Posição y é: " + posicaoy[0]);
                        Console.WriteLine();
                        Console.WriteLine(direcao[3]);
                        Console.ReadLine();
                        Console.Clear();

                    }
                    else if (opcao == "S" || opcao == "s")
                    {
                        break;
                    }

                    //Caso digite opção que não esteja no menu, aparecera a mensagem Invalida
                    else if (opcao != "M" && opcao != "D" && opcao != "S")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opcao Invalida! Digite Apenas M, D e S");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                }
            }
        }
    }
}
