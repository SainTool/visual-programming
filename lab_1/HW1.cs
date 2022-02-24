using System;

namespace visual_programming
{
    class Program{
        static void Main(string[] args) {
            int[] mass = new int [4]{ 10,2,3,3 };
            int n = 2;
            Console.WriteLine(HW1.QueueTime(mass, n));
        }
    }
    public class HW1 {
        public static long QueueTime(int[] customers, int n) {
            int[] cass = new int[n];
            for (int i = 0; i < n; cass[i++] = 0) { }
            foreach(int znach in customers) {
                cass[0] += znach;
                if(n!=1)
                    Array.Sort(cass);
            }
            return cass[n-1];
        }
    }
}
