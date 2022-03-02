// See https://aka.ms/new-console-template for more information
using System;

namespace OlaMundo
///
{
    class Program
    ///
    {
        static void Main(string[] args)
        {
            int pi = (Convert.ToInt32(3.1415926f)); //
            int raio; 
            int altura; 

            int S = 2 * pi * raio * (raio + altura); //
            int V = pi * (raio * raio) * altura; 

            Console.WriteLine("insira o raio");
            string str1 = Console.ReadLine();

            Console.WriteLine("insira a altura");
            string str2 = Console.ReadLine();

            Console.WriteLine(raio + "\n" + altura + "\n");
        }
    }
}
