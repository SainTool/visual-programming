using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Numb;

namespace RomanCalc.Models
{
    class RomanNumberExtend : RomanNumber
    {

        public RomanNumberExtend(string value) : base(ToUshort(value)) { }
        private static ushort ToUshort(string value)
        {
            ushort[] Arabian = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] Roman = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            string temp = value;
            ushort ArabianForm = 0;
            for (int i = 1; i < 13; i += 2)
            {
                while (temp.Contains(Roman[i]))
                {
                    ArabianForm += Arabian[i];
                    int startIndex = temp.IndexOf(Roman[i][0]);
                    temp = temp.Remove(startIndex, Roman[i].Length);
                }
            }
            for (int i = 0; i < 13; i += 2)
            {
                while (temp.Contains(Roman[i]))
                {
                    ArabianForm += Arabian[i];
                    int startIndex = temp.IndexOf(Roman[i][0]);
                    temp = temp.Remove(startIndex, Roman[i].Length);
                }
            }

            return ArabianForm;
        }
    }
}