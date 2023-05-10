using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, cont1 = 1, cont2 = 1;

            while (cont2 <= 20)
            {
                Console.SetCursorPosition(0, 0);
                for (b = cont2; cont1 <= 10; cont1++)
                {
                    a = b * cont1;
                    Console.WriteLine("{0} * {1} = {2}", b, cont1, a);
                }
                cont2++;
                cont1 = 1;
                Console.WriteLine("aperte uma tecla para continuar");
                Console.ReadKey();
                


            }
        }
    } 
}
