using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GrandCircusLab4
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)

            {
                string userInput;
                int userNumber;

                Console.WriteLine("Learn your squares and cube!!\n\n");
                Console.WriteLine("Please enter an integer: ");

                while (true)
                {
                    userInput = Console.ReadLine();

                    bool isInt = int.TryParse(userInput, out userNumber);

                    if (isInt)
                    {
                        userNumber = int.Parse(userInput);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please only enter an integer: ");
                    }
                }

                Console.WriteLine("\n\n");

                int square = 0;
                int cube = 0;

                Console.WriteLine(string.Format("{0,-10} {1,-10} {2,-10}", "Number", "Squared",  "Cubed"));
                Console.WriteLine(string.Format("{0,-10} {1,-10} {2,-10}", "======", "======", "======"));

                for (int i = 1; i <= userNumber; i++)
                {
                    square = (i * i);
                    cube = (i * (i * i));

                    Console.WriteLine(string.Format("{0,-10} {1,-10} {2,-10}", i, square, cube));

                }

                string check;

                while (true)
                {
                    Console.WriteLine("\n\n\nContinue? (y/n)");

                    check = Console.ReadLine();

                    if (Regex.IsMatch(check.ToLower(), "[y n]"))
                    {
                        break;
                    }
                }

                if(check.ToLower() == "n")
                {
                    Console.Clear();
                    Console.WriteLine("\n\nGOODBYE!!!!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
