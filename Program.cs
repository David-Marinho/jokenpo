using System;

namespace jokenpo
{
    
    class Program
    {
        static bool conferir(int player, int cpu)
        {   
            if (player == 1 && cpu == 3)
            {
                return true;
            }

            else if (player == 2 && cpu == 1){
                return true;
            }

            else if (player == 3 && cpu == 2){
                return true;
            }

            else{
                return false;
            }
        }

        static int[] contagem(bool ganhou, int[] contador)
        {
            if (ganhou)
            {
                contador[0] ++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Você ganhou");
                Console.ResetColor();
            }

            else{
                contador[1] ++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("A cpu ganhou");
                Console.ResetColor();
            }

            return contador;
        }
        static void Main(string[] args)
        {
            int[] contador = new int[2];
            contador[0] = 0;
            contador[1] = 0;

            bool resultado;
            int player = 0, cpu = 0, continuar = 0;
            Random rand = new Random();

            do
            {
                Console.Clear();
                
                continuar = 0;

                Console.WriteLine("+-------------------+");
                Console.WriteLine("| [1] pedra         |");
                Console.WriteLine("| [2] papel         |");
                Console.WriteLine("| [3] tesoura       |");
                Console.WriteLine("+-------------------+");

                Console.Write("digite o numero: ");
                player = Convert.ToInt32(Console.ReadLine());

                cpu = rand.Next(1, 3);

                resultado = conferir(player, cpu);

                contador = contagem(resultado, contador);

                Console.WriteLine("---------------------");
                Console.WriteLine($"jogador = {contador[0]}");
                Console.WriteLine($"inimigo = {contador[1]}");
                Console.WriteLine("---------------------");

                Console.Write("digite [1] para continuar ou [2] para finalizar o jogo: ");
                continuar = Convert.ToInt32(Console.ReadLine());

            } while(continuar == 1);
        }
    }
}
