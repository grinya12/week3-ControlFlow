﻿using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Personality test
            //приложение просит пользователя ввести его любимый цвет
            //на основе введенного значения, консоль показывает пользователю некоторую обратную связь
            //red - you are so romantic
            //blue - you are a workaholic
            //green - you care about environment
            //любое другое значение, то консоль выведет предложение "you are a {userInput} unicorn"

            Console.WriteLine("Please enter your favorite calor:");
            string userInput = Console.ReadLine().ToLower(); //RED/Red/rED/rEd/rdE --> red

            if(userInput == "red")
            {
                Console.WriteLine("You are so romantic.");
            }
            else if(userInput == "blue")
            {
                Console.WriteLine("You are a workaholic.");
            }
            else if(userInput == "green")
            {
                Console.WriteLine("You care about environment.");
            }
            else
            {
                Console.WriteLine($"You are {userInput} unicorn.");
            }

            Console.WriteLine("Have a nice day.");

        }
    }
}
