using System;

namespace example_PRG {
    class Program {
        static void Main(string[] args) {
            Console.Write("Input your n: ");
            int n = int.Parse(Console.ReadLine());
            int a, b=1;

            for (a=0; a<n; a++)
            {
                b=b*2;
            }

            Console.WriteLine("Sum: {0}", b);
        }
    }
}