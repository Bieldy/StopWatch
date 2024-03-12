using System;
using System.Threading;

namespace STOPWATCH
{

    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }
        static void Menu()
        {

            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower(); // o ToLower converte todos os caracteres para minusculo
            char type = char.Parse(data.Substring(data.Length - 1, 1)); // o Length pega o ultimo caracter que o usuario digitou
            // aqui foi feita conversão do da string para char 
            // o SUBSTRING ele possibilita pegar 1 ou mais caracteres na mesma posição do que se é digitado.
            // Por exemplo: (1,2)= O 1 é a posição o 2 é a quantidade de caracter que ele vai pegar. 
            Console.WriteLine(data);
            Console.WriteLine(type);





        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);

            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
        }

    }
}