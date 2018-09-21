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
            int max = 0;
            int min = 0;

            List<int> lista = new List<int>();
            Console.WriteLine("Adjon meg a db számot!");
            int db;
            if (!int.TryParse(Console.ReadLine(), out db))
            {
                Console.WriteLine("Hiba. nem számot adtál meg");
                Console.ReadLine();
                return;
            }
            for (int i = 0; i < db; i++)
            {
                Console.WriteLine("Adja meg a(z)" + (i + 1) + ".-dik számot");
                int szam;
                if (!int.TryParse(Console.ReadLine(), out szam))
                {
                    Console.WriteLine("Hiba. nem számot adtál meg");
                    Console.ReadLine();
                    return;
                }
                lista.Add(szam);
            }
            for (int i = 0; i < lista.Count; i++)
            {
                if (i==0)
                {
                    min = lista[0];
                    max = lista[0];
                }
                if (lista[i]<min)
                {
                    min = lista[i];
                }
                if (lista[i] > max)
                {
                    max = lista[i];
                }
                Console.Write(lista[i] + " ");
            }
            Console.WriteLine("\nA legnagyobb szám: {0}",max);
            Console.WriteLine("A legkisebb szám: {0}",min);



        }
    }
}
