class Program {
    static void Main(string[] args) {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());

        if ( (N > 1 && N <= 10000) && (1<K && K<=1000)) {
            for (int i = 0; i < N; i++) {
                int gender = int.Parse(Console.ReadLine());
                int score1 = int.Parse(Console.ReadLine());
                int score2 = int.Parse(Console.ReadLine());

                if (gender == 1 && score1 > 8) {
                    Console.WriteLine("{0} 1", i+1);
                } else {
                    if (score2>score1) {
                        Console.WriteLine("{0} 2", i+1);
                    }
                }
                if (gender == 2 && score2 > 8) {
                    Console.WriteLine("{0} 2", i+1);
                } else {
                    if (score1>score2) {
                        Console.WriteLine("{0} 1", i+1);
                    }
                }
            }
        }
    }
}