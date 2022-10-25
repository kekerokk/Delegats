using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegats
{
    public class Third
    {
        public static Func<int[], string> onDelegat;
        //int[] massiv = { 4, 6, 8, 2, 34 };
        public Third(int[] massiv)
        {
            //int[] result1 = DoOperation(massiv, Diapazon);
            //int[] result2 = DoOperation(massiv, PosNegNumbers);
            Console.WriteLine(DoOperation(massiv, Diapazon));
            Console.WriteLine(DoOperation(massiv, PosNegNumbers));
        }
        string DoOperation(int[] massive, Func<int[], string> operation) => operation(massive);
        public string Diapazon(int[] massiv)
        {
            Console.WriteLine($"Фильтр по диапазону:\nОт:");
            int diapazonOt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"До:");
            int diapazonDo = Convert.ToInt32(Console.ReadLine());
            List<int> pol_result = new List<int>();
            foreach(int i in massiv)
            {
                if (i > diapazonOt && i < diapazonDo)
                    pol_result.Add(i);
            }
            string final = "";
            foreach (int i in pol_result)
            {
                final = $"{final} {i}";
            }
            /*int[] result = new int[pol_result.Count];
            for(int i = 0; i < pol_result.Count; i++)
            {
                result[i] = pol_result[i];
            }*/
            return final;
        }
        public string PosNegNumbers(int[] massiv)
        {
            string PosNumbs = "";
            string NegNumbs = "";
            foreach (int i in massiv)
            {
                if (i >= 0)
                    PosNumbs = $"{PosNumbs} {i}";
                else
                    NegNumbs = $"{NegNumbs} {i}";
            }
            string final = $"Положительные числа: \n{PosNumbs}\nОтрицательные числа: \n{NegNumbs}";
            return final;
        }
    }
}
