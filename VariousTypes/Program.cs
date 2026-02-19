using System;
using System.Diagnostics;
using System.Text;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //1-4
            int i = 1;
            short s = 2;
            byte b = 3;
            long l = 4;

            Console.WriteLine("Valores das variaveis int,short,byte,long, respetivamente");
            Console.WriteLine(i);
            Console.WriteLine(s);
            Console.WriteLine(b);
            Console.WriteLine(l);
            
            //5-7
            char emoji = '\u2606';

            Console.WriteLine("Emoji");
            Console.WriteLine(emoji);

            //8-10
            float f = 3.1416f;
            double d = 3.1416;

            Console.WriteLine("Float e double");
            Console.WriteLine(f);
            Console.WriteLine(d);

            //11-14
            bool t = true;
            bool fal = false;

            Console.WriteLine("Bools");
            Console.WriteLine(t);
            Console.WriteLine(fal);
        }
    }
}