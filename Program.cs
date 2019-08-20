using System;

namespace PasswordGenerator
{
    public class Program
    {   
        static string generatePassword()    //method for generating Password
        {
            var seed = (int)DateTime.Now.Ticks;
            var randomObject = new Random(seed+3);
            const int passwordLength= 10; 
            var passwordArray = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
            {
                passwordArray[i] = (char)('a'+ randomObject.Next(0, 26));
                //Console.Write($"ID{Char.ToString(randomChar)}");
            }
            var password =String.Join("",passwordArray);    //or...var password = new String(passwordArray);
            return password;
        }
        static string generateID()  //method for generating ID with different seed value
        {
            var seed = (int)DateTime.Now.Ticks;
            var randomObject = new Random(seed+5);
            const int idLength= 10; 
            var idArray = new char[idLength];
            for (var i = 0; i < idLength; i++)
            {
                idArray[i] = (char)('a' + randomObject.Next(0, 26));
            }
            var id = String.Join("", idArray);  //or...var id = new String(idArray);
            return id;
        }
        static string[] getIdAndPassword() //combines the id and password in a single array for simplicity
        {
            var idAndPassword = new string[2] { generateID(), generatePassword() };
            return idAndPassword;
        }
        static void displayIdAndPassword()  //displays ID and Password
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
