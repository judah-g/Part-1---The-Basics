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

            favMovie = favMovie.Replace("A", "@"); favMovie = favMovie.Replace("E", "3");
            Console.WriteLine(favMovie);
            Console.WriteLine();

            string quote = "Why buy a mattress anywhere else?";
            quote = quote.Replace("a", ""); quote = quote.Replace("e", "");
            quote = quote.Replace("i", ""); quote = quote.Replace("o", "");
            quote = quote.Replace("u", ""); quote = quote.Replace("y", "");
            Console.WriteLine(quote);
            Console.WriteLine();

            Console.Write("  _ 0                                             ");    Console.WriteLine("\t                ,-'\"\"\"\"`-._");
            Console.Write("o'-/-\\--------------------------------------------");   Console.WriteLine("\t              ,' // <->    \"-.");
            Console.Write("  |\\                                           . o");   Console.WriteLine("\t              | '` ,;;;....__|");
            Console.Write("  / |       '.                             . o . o");    Console.WriteLine("\t              |   /._''''''''                       ,");
            Console.Write("             .'                              o . o");    Console.WriteLine("\t               | `--._\"-._                         /|");
            Console.Write("            '                                    o");    Console.WriteLine("\t                | ===|\"-__'                    _.-'/");
            Console.Write("__________________________________________________");    Console.WriteLine("\t              .-: ==||-\"'\"-'--.          _..--' ,-'");
            Console.WriteLine("\t\t\t\t\t\t\t  ,,--\"\"\"--._ ( |\\__||         |____----\"   _.-\"");
            Console.WriteLine("\t\t\t\t\t\t\t  VV--\"\\ ,_  \"',\\  .-,`---.-,  `-_   __..--\"");
            Console.WriteLine("\t\t\t\t\t\t\t,'_/_-\"`V' \"-./_ `\\.` `     |    _'\"\"");
            Console.WriteLine("\t\t\t\t\t\t\t|__|__.-|     | \"-. `------' `,-\"");
            Console.WriteLine("\t\t\t\t\t\t\t`.-\\-_ ,'      |  |\"\"\"---._,-\"'`]\"\"-.");
            Console.WriteLine("\t\t\t\t\t\t\t  `-`-'        ;--;,        `._ /  ||");
            Console.WriteLine("\t\t\t\t\t\t\t            ,\"\"`   |           ,\"  ||");
            Console.WriteLine("\t\t\t\t\t\t\t            VV_.==='           VV--'");
        }
    }
}
