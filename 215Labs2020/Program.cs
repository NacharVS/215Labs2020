using _215Labs2020.Ibragimov.BankKlas;
using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of strings by using a
            // collection initializer.
            var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

            // Remove an element from the list by specifying
            // the object.
            salmons.Remove("pink");

            // Iterate through the list.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
            // Output: chinook pink sockeye
            yser.method();




        }
    }
}
