using System;

namespace Gradingif
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение просит пользователя ввести результат его экзамена
            //результат экзамена это одна буква от A до F
            //A - Outstanding
            //B - Superior
            //C - Good
            //D - Satisfactory
            //E - Low Pass
            //F - Failure
            //в работе используется if-statements

            Console.WriteLine("Enter your exam result:");
            char userInput = Convert.ToChar(Console.ReadLine().ToUpper());

            if(userInput == 'A')
            {
                Console.WriteLine("Outstanding!");
            }
            else if(userInput == 'B')
            {
                Console.WriteLine("Superior!");
            }
            else if(userInput == 'C')
            {
                Console.WriteLine("Good!");
            }
            else if(userInput == 'D')
            {
                Console.WriteLine("Satisfactory!");
            }
            else if(userInput == 'E')
            {
                Console.WriteLine("Low Pass!");
            }
            else if(userInput == 'F')
            {
                Console.WriteLine("Failure!");
            }

            Console.WriteLine("Have a nice day.");

        }
    }
}
