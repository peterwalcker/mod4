using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod4
{
    public class Mod_4_5
    {
        public void Test()
        {
            (string FirstName, string LastName, string Login, int LoginLenght, bool HavePet, double Age, string[] FavColors) User;

            Console.Write("Enter your first name: ");
            User.FirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            User.LastName = Console.ReadLine();
            Console.Write("Enter your login: ");
            User.Login = Console.ReadLine();
            User.LoginLenght = User.Login.Length;
            Console.Write("Do you have a pet? (yes/no): ");
            User.HavePet = Console.ReadLine() == "yes" ? true : false;
            Console.Write("Enter your age in numbers: ");
            User.Age = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            User.FavColors = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter your favorite color number {i + 1}: ");
                User.FavColors[i] = Console.ReadLine();
            }
        }
    }
}
