using System;

namespace example_PRG {
    class Program {
        static void Main(string[] args) {
            Console.Write("Input your seat: ");
            int n = int.Parse(Console.ReadLine());
            int a;

            for (a=0; a<4; a++)
            {
                n=n%8;
                n=n+1;
                Console.WriteLine(n);
            }
        }
    }
}