using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleio
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name = "Nathan";
           Console.WriteLine("Hello, {0}", Name);
           // Console.Write("Hello, ");
           // Console.Write("World" );

            Console.WriteLine("Hello, " + Name);

            string input = Console.ReadLine();
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey(true);
                Console.Write("You Pressed:  ");
                if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("Alt+ ");
                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("Shift+ ");
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("Control+ ");
                Console.WriteLine("{0} (character '{1}' )", cki.Key, cki.KeyChar);

            }

            while (cki.Key != ConsoleKey.Escape);
        }
    }
}
