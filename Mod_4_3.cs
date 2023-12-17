using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod4
{
    public class Mod_4_3
    {
        public void Mod_4_3_test()
        {
            Mod_4_3_17();
        }
        public void Mod_4_3_Name()
        {
            Console.WriteLine("Введите своё имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам:");
            char lastChar = '\0';
            foreach (char c in name)
            {
                Console.Write($"{c} ");
                lastChar = c;
            }
            Console.WriteLine($"Последняя буква вашего имени: {lastChar}");
        }

        public void Mod_4_3_7()
        {
            Console.WriteLine("Введите своё имя: ");
            string name = Console.ReadLine();

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }
            Console.WriteLine();
        }

        public void Mod_4_3_11()
        {
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(0) + 1; j++)
                    Console.Write(array[j, i] + " ");

                Console.WriteLine();
            }
        }

        public void Mod_4_3_12()
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var tmp = arr[j]; 
                        arr[j] = arr[j + 1]; 
                        arr[j + 1] = tmp;
                    }
                }
            }
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
        }

        public void Mod_4_3_13()
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int sum = 0;

            foreach (var i in arr)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }

        public void Mod_4_3_14()
        {
            int[][] array = new int[3][];
            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var i in array)
            {
                foreach (var j in i)
                {
                    Console.Write(j + " ");
                }
            }
        }

        public void Mod_4_3_15()
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine();
            string[] strArr = input.Split(' ');
            int[] arr = new int[strArr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(strArr[i]);
            }
            int count = 0;
            foreach (var i in arr)
            {
                if (i > 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"There is {count} positive numbers in array");
        }

        public void Mod_4_3_16()
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int count = 0;

            foreach (var i in arr)
            {
                if (i > 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public void Mod_4_3_17()
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                    {
                        if (arr[i, j] > arr[i, k])
                        {
                            int tmp = arr[i, j];
                            arr[i, j] = arr[i, k];
                            arr[i, k] = tmp;
                        }
                    }
                }
            }
        }
    }
}
