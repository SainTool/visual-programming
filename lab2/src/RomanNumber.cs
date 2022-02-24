using System;
using System.Text;
using Except;

namespace Numb
{
    public class RomanNumber : ICloneable, IComparable
    {
        //число
        private ushort num;
        //создаём алфавит чисел 
        private static short[] Arabian = new short[]
            {1000,900,500,400,100,90,50,40,10,9,5,4,1 };
        private static string[] Roman = new string[]
            {"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I" };

        //Конструктор получает число n, которое должен представлять объект
        //класса
        public RomanNumber(ushort n)
        {
            if (n <= 0)
            {
                throw new RomanNumberException("!!! Number<=0 !!!");
            }
            num = n;
        }
        //Сложение римских чисел
        public static RomanNumber Add(RomanNumber? n1, RomanNumber? n2)
        {
            return new RomanNumber((ushort)(n1.num + n2.num));
        }
        //Вычитание римских чисел
        public static RomanNumber Sub(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1.num - n2.num <= 0)
            {
                throw new RomanNumberException("!!! Sub <=0 !!!");
            }
            return new RomanNumber((ushort)(n1.num - n2.num));
        }
        //Умножение римских чисел
        public static RomanNumber Mul(RomanNumber? n1, RomanNumber? n2)
        {
            return new RomanNumber((ushort)(n1.num * n2.num));
            throw new NotImplementedException();
        }
        //Целочисленное деление римских чисел
        public static RomanNumber Div(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1.num / n2.num <=0)
            {
                throw new RomanNumberException("!!! Div <=0 !!!");
            }
            return new RomanNumber((ushort)(n1.num / n2.num));
        }
        //Возвращает строковое представление римского числа
        public override string ToString()
        {
            StringBuilder RomanEND = new StringBuilder();
            short n = ((short)num);
            for (int i = 0; i < Roman.Length; i++)
            {
                while (n >= Arabian[i])
                {
                    n -= Arabian[i];
                    RomanEND.Append(Roman[i]);
                }
            }
            return RomanEND.ToString();
        }
        //Реализация интерфейса ICloneable
        public object Clone()
        {
            return new RomanNumber(num);
        }
        //Реализация интерфейса IComparable
        public int CompareTo(object? obj)
        {
            if (obj is RomanNumber person) {
                return ((short)num).CompareTo((short)person.num); 
            }
            else throw new RomanNumberException("Некорректное значение параметра");
        }
    }
}
