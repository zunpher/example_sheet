using System;

namespace example_PRG {
    class Program {
        static void Main(string[] args) {
            Console.Write("Input your number: ");
            int x = int.Parse(Console.ReadLine());

            if (x>=0) {
                Console.WriteLine(x);
            } else {
                x=x*-1;
                Console.WriteLine(x);
            }
        }
    }
}