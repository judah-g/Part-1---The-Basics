using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1___The_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // judah

            string firstName = "Judah", favMovie = "The Matrix";

            Console.WriteLine($"Hello, my name is {firstName} and my favourite movie is {favMovie.ToLower()}.");
            Console.WriteLine();

            favMovie = favMovie.ToUpper();
            Console.WriteLine(favMovie);
            Console.WriteLine();

            Console.WriteLine(favMovie.Contains("THE"));
            Console.WriteLine();

            favMovie = favMovie.Replace("A", "@");  favMovie = favMovie.Replace("E", "3");
            Console.WriteLine(favMovie);
            Console.WriteLine();


        }
    }
}
