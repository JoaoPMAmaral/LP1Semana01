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
            int i = 1;
            short s = 2;
            byte b = 3;
            long l = 4;

            Console.WriteLine("Valores das variaveis int,short,byte,long, respetivamente");
            Console.WriteLine(i);
            Console.WriteLine(s);
            Console.WriteLine(b);
            Console.WriteLine(l);
            
            char emoji = '\u2606';
            
            
            Console.WriteLine("Emoji");
            Console.WriteLine(emoji);
        }
    }
}