namespace reversenumber1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Eded daxil edin:");
        int n = int.Parse(Console.ReadLine());
        int s = 0;
        int reverse = 0;
        while (n > 0)
        {
            int c = n % 10;
            reverse = reverse * 10 + c;
            n /= 10;
        }
        Console.WriteLine(reverse);

    }
}

