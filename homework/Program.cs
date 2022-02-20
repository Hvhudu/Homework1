using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 30, 0, 9, 3, 0, 4, 2, 0, 7 };
            int[] arrtemp = new int[10];
            for (int i = 0; i<10;i++)
            {
                if(arr[i]==0)
                    arr[i] = -1;
                Console.Write($"{ arr[i]} " );
            }
            Array.Sort(arr);
            Console.WriteLine();
            foreach(int elem in arr)
            {
                Console.Write($"{elem} ");
            }
            Console.WriteLine("\nВведите число для поиска: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int key = Array.IndexOf(arr, num);
            Console.WriteLine($"Ваше число: {arr[key]}");
        }
    }
}
