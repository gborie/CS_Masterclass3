﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Masterclass2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("Format exception, please enter the correct type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }

            Console.ReadKey();

        }

    }
}
