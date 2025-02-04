using PracticeProgramOops;

internal class Program
{
    private static void Main(string[] args)
    {
        PrimeNumberExample primeNumberExample = new PrimeNumberExample();
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Prime numbers up to {n} are:");

        for (int i = 2; i <= n; i++)
        {
            if (primeNumberExample.IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }


        PlaceToVisit place = new PlaceToVisit();
         place.PlaceWantToVisit();
    }
}