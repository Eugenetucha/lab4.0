using System;

namespace lab4
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            RomanNumber[] number = new RomanNumber[3];
            var a = new RomanNumber(3);
            number[0] = (RomanNumber)a.Clone();
            var b = new RomanNumber(1);
            number[1] = (RomanNumber)b.Clone();
            var c = new RomanNumber(10);
            number[2] = (RomanNumber)c.Clone();
            Array.Sort(number);
            for(int i = 0;i < number.Length;i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.WriteLine((RomanNumber)a.Clone() + (RomanNumber)c.Clone());
            Console.WriteLine((RomanNumber) a.Clone()- (RomanNumber) b.Clone());
            Console.WriteLine((RomanNumber) c.Clone()* (RomanNumber) b.Clone());
            Console.WriteLine((RomanNumber) c.Clone()/ (RomanNumber) b.Clone());
        }
    }
}