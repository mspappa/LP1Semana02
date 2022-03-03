using System;

namespace Cilindro2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pi = (Convert.ToInt32(Math.PI)); //

            Console.WriteLine("insira o raio");
            int raio = int.Parse(Console.ReadLine());

            Console.WriteLine("insira a altura");
            int altura = int.Parse(Console.ReadLine());

            int raio2 = Convert.ToInt32(Math.Pow(raio, 2));

            int S = 2 * pi * raio * (raio + altura); //
            int V = pi * raio2 * altura; 

            //mostra no ecra os valores
            Console.WriteLine($"A Superficie do Cilindro e: {S}\n" + $"O Volume do Cilindro e: {V}");

        }
    }
}
