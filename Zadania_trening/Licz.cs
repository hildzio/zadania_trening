using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_trening
{
    internal class Count
    {
        public int Value { get; private set; }
        public void Add(int input)
        {
            Value += input;
        }
        public void Subtract(int input)
        {
            Value -= input;
        }
        public void WriteNumber()
        {
            Console.WriteLine("Podaj liczbę do działania: ");
            Value = int.Parse(Console.ReadLine()!);
        }
        public void ReadNumber()
        { 
             Console.WriteLine($"Wartość Value: {Value} ");
        }
    }
}