using System;

namespace Cilindro2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pi = (Convert.ToInt32(3.1415926f)); //

            Console.WriteLine("insira o raio");
            int raio = int.Parse(Console.ReadLine());

            Console.WriteLine("insira a altura");
            int altura = int.Parse(Console.ReadLine());

            int S = 2 * pi * raio * (raio + altura); //
            int V = pi * (raio * raio) * altura; 

            Console.WriteLine(S + "\n" + V + "\n");
        }
    }
}
