#nullable enable
using System;

namespace lab4;

public class RomanNumber : ICloneable, IComparable
    {
        private ushort n;
        private static ushort _number;
        
        //Конструктор получает число n, которое должен представлять объект
        //класса
        public RomanNumber(ushort n)
        {
            this.n = n;
            _number = this.n;
            if (n == 0) throw new RomanNumberException();
        }
        

        //Сложение римских чисел
        public static  RomanNumber operator +(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 != null)
                if (n2 != null)
                    _number = (ushort) (n1.n + n2.n);
            RomanNumber now = new RomanNumber(_number);
            return now;
        }
        //Вычитание римских чисел
        public static  RomanNumber operator -(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 != null)
                if (n2 != null)
                    _number = (ushort) (n1.n - n2.n);
            RomanNumber now = new RomanNumber(_number);
            return now;
        }
        //Умножение римских чисел
        public static RomanNumber operator *(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 != null)
                if (n2 != null)
                    _number = (ushort) (n1.n * n2.n);
            RomanNumber now = new RomanNumber(_number);
            return now;
        }
        //Целочисленное деление римских чисел
        public static  RomanNumber operator /(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 != null)
                if (n2 != null)
                    _number = (ushort) (n1.n / n2.n);
            RomanNumber now = new RomanNumber(_number);
            return now;
        }
        //Возвращает строковое представление римского числа
        public override string ToString()
        {
            ushort[] mas1 = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
                string[] mas2 = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
                ushort i;
                i = 0;
                string s = "";
                while (n > 0)
                {
                    if (mas1[i] <=n)
                    {
                        n -= mas1[i];
                        s += mas2[i];
                    }
                    else i++;

                }
                return s;
            }
        //Реализация интерфейса IClonable
        public object Clone()
        {
            return new RomanNumber(n);
        }
        //Реализация интерфейса IComparable
        public int CompareTo(object? obj)
        {
            if(obj is RomanNumber next) return (n).CompareTo(next.n);
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
