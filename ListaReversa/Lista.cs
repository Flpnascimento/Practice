using System;
using System.Collections.Generic;

namespace ListaReversa
{
    class Lista
    {
        public void Listinha(int x)
        {

            var numbers = new double[x];

            for (int i = 0; i < x;)
            {
                Console.WriteLine("Insira um numero no Array");

                numbers.SetValue(Convert.ToDouble(Console.ReadLine()), i);

                i++;
            }

            Console.WriteLine("O Array inicialmente te os seguintes valores:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Precione Enter para ver o Array invertido");
            Console.ReadLine();

            Array.Reverse(numbers);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
