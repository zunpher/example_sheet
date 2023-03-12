using System;

namespace example_PRG {
    class Program {
        static void Main(string[] args) {
            Console.Write("Input a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input x: ");
            double x = double.Parse(Console.ReadLine());

            if ( a<=x && x<=b) {
                Console.WriteLine("True");
            } else {
                Console.WriteLine("False");
            }
        }
    }
}