using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_trening
{
    internal class Sumator
    {
        private List<int> Numbers { get; set; } = new();
        private List<int> NumberDevide3 { get; set; } = new();
        public int sumDevide3;
        public int amount;
        public Sumator() 
        {   
        }

        public void Sum()
        {
            for (int i = 0; i <= Numbers.Count; i++)
            {
                 amount += Numbers[i];
            
            }
        }
        public void SumDevide3()
        {
            foreach (int i in Numbers)
            {
                if (i % 3 == 0)
                {
                    sumDevide3 += i;
                    NumberDevide3.Add(i);
                }
            }
        }
        public void HowManyElementsInNumbers()
        {
            Console.WriteLine($"Lista ma {Numbers.Count} elemntów ");
        }

        public void PrintAllElementsFromNumbers() 
        {
            foreach (var i in Numbers)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine("\n");
        }

    }
}
