using System;

namespace Trójkąt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj bok a");

            string a = Console.ReadLine();
            int ax = int.Parse(a);

            Console.WriteLine("Podaj bok b");

            string b = Console.ReadLine();
            int bx = int.Parse(b);

            Console.WriteLine("Podaj bok c");

            string c = Console.ReadLine();
            int cx = int.Parse(c);

            if (ax+bx > cx && ax+cx > bx && bx+cx > ax) 
            {
                Console.WriteLine("Można zbudować trójkąt");

            }
            else 
            {
                Console.WriteLine("Nie można zbudować trójkąta");

            }



        }
    }
}
