using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegats
{
    internal class Program
    {
        public static int[] massive = { 5, 21, -43, 25, -4, 3 };
        public delegate void delegat(int[] massive);
        static void Main(string[] args)
        {
            delegat Main = Modul;
            Main += Square;
            Main += Sinus;

            Transform(massive, Main);
            Third zadanie = new Third(massive);
            Console.ReadKey();
        }
        public static void Transform(int[] massive,delegat deleg)
        {
            deleg?.Invoke(massive);
        }
        public static void Square(int[] massiv)
        {
            string finalstr = "";
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = massiv[i] * massiv[i];
                finalstr = $"{finalstr} {massiv[i]}";
            }
            Console.WriteLine(finalstr);
        }
        public static void Sinus(int[] massiv)
        {

        }
        public static void Modul(int[] massiv)
        {
            string finalstr = "";
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = Math.Abs(massiv[i]);
                finalstr = $"{finalstr} {massiv[i]}";
            }
            Console.WriteLine(finalstr);
        }
    }
}
