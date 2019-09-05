using System;

namespace ListaReversa
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();

                Console.WriteLine("Insira a quantidade de números do Array");
                l.Listinha(Convert.ToInt32(Console.ReadLine()));


            
        }
    }
}
