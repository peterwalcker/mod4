using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod4
{
    public class Mod_4_4
    {
        public void Test()
        {
            Mod_4_4_5();
        }

        public void Mod_4_4_2()
        {
            (string name, int age) anketa;
            Console.WriteLine("Insert your name: ");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Insert your age in numbers: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your name is {anketa.name} and your age is {anketa.Item2}");
        }

        public void Mod_4_4_3()
        {
            (string name, int age)  = ("Vlad", 33);
            Console.WriteLine($"My name is {name} and my age is {age}");

            Console.WriteLine("Insert your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Insert your age in numbers: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your name is {name} and your age is {age}");
        }

        public void Mod_4_4_5()
        {
            (string Name, string Type, double Age, int NameCount) Pet;
            Console.Write("Insert pet name: ");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;
            Console.Write("Insert pet type: ");
            Pet.Type = Console.ReadLine();
            Console.Write("Insert pet age in numbers: ");
            Pet.Age = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
        }
    }
}
