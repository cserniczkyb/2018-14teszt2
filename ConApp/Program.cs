using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            int max = 0;
            List<int> lista = new List<int>();
            Console.WriteLine("Adjon meg a db számot!");
            int db = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < db; i++)
            {
                Console.WriteLine("Adja meg a(z)" + (i+1) +  ".-edik számot");
                lista.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for (int i = 0; i < lista.Count; i++)
            {
               
                if (lista[i] > max)
                {
                    max = lista[i];
                }
                Console.Write(lista[i] + " ");
            }
            Console.WriteLine("\nA legnagyobb szám: {0}",max);




        }
    }
}
