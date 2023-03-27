using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_e_funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[] { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1 };
            int valormedio = 0;
            //ordenar valores
            for (int i = 0; i < valores.Length; i++)
            {
                Array.Sort(valores);

            }
            Console.WriteLine("o maior valor é: ");
            Console.WriteLine(valores[9]);
            Console.WriteLine("o menor valor é: ");
            Console.WriteLine(valores[0]);

            for (int i = 0; i < valores.Length; i++)
            {
                valormedio += valores[i];


            }
            valormedio = valormedio / 10;

            Console.WriteLine("a media dos   valores : ");
            Console.WriteLine(valormedio);


            Console.WriteLine("os 3 maiores valores são: ");
            Console.WriteLine(valores[9]);
            Console.WriteLine(valores[8]);
            Console.WriteLine(valores[7]);

            Console.WriteLine("os valores negativos são: ");
            for (int i = 0; i < valores.Length; i++)
            {
                Array.Sort(valores);
                if (valores[i] < 0)
                {

                    Console.WriteLine(valores[i]);
                }
            }
            valores = new int[] { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1 };
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine($"o valor é : {valores[i]} e o indice é {i} ");
            }
            Console.ReadLine();

            for (int i = 0; i < valores.Length; i++)
            {
                if (i == 2)
                {
                    valores[i] = 0;
                }
            }
            Console.ReadLine();
        }
    }
}
