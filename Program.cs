using System;

namespace PasswordGenerator
{
    public class Program
    {
        static string generatePassword()
        {
            var seed = (int)DateTime.Now.Ticks;
            var randomObject = new Random(seed+3);
            var passwordArray = new char[10];
            for (var i = 0; i < 10; i++)
            {
                passwordArray[i] = (char)('a'+ randomObject.Next(0, 26));
                //Console.Write($"ID{Char.ToString(randomChar)}");
            }
            var password =String.Join("",passwordArray);
            return password;
        }
        static string generateID()
        {
            var seed = (int)DateTime.Now.Ticks;
            var randomObject = new Random(seed+5);
            var idArray = new char[4];
            for (var i = 0; i < 4; i++)
            {
                idArray[i] = (char)('a' + randomObject.Next(0, 26));
            }
            var id = String.Join("", idArray);
            return id;
        }
        static string[] getIdAndPassword()
        {
            var idAndPassword = new string[2] { generateID(), generatePassword() };
            return idAndPassword;
        }
        static void displayIdAndPassword()
        {
            var newIdAndPassword = getIdAndPassword();
            Console.WriteLine($"New ID:{newIdAndPassword[0]}   New Password:{newIdAndPassword[1]}");
            var empty = String.IsNullOrWhiteSpace(Console.ReadLine());
            if (empty)
            {
                displayIdAndPassword();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to generate new password and ID, and any other key to quit");
            var check = String.IsNullOrWhiteSpace(Console.ReadLine());
            if (check)
            {
                displayIdAndPassword();
            }
        }
    }
}
