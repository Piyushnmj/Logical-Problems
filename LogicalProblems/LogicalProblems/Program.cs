class FinonacciSeries
{
    public static int Fibonacci(int num)
    {
        int a = 0;
        int b = 1;

        for (int i = 0; i < num; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter N terms for Fibonacci Series: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The Fibonacci Series of {0} terms are:", N);

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("{0}" , Fibonacci(i));
        }
        Console.ReadLine();
    }
}
