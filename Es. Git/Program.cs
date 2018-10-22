using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es.Git
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] vettore = { 2, 5, 3, 23, 12, 8, 6, 7, 1, 29 };
            int num_min = vettore[0];
            int num_max = vettore[0];

            num_max = vettore.Max();
            num_min = vettore.Min();

            Console.WriteLine("Numero massimo : " + num_max);
            Console.WriteLine("Numero minimo : " + num_min);
            Console.ReadKey();

            }
        }
    }

