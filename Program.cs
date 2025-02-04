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

        // palce to visit
        PlaceToVisit place = new PlaceToVisit();
         place.PlaceWantToVisit();

        //check anagram string
        CheckAnagramStringscs  checkAnagram= new CheckAnagramStringscs();
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();

        if (checkAnagram.IsAnagram(str1, str2))
        {
            Console.WriteLine("The two strings are anagrams.");
        }
        else
        {
            Console.WriteLine("The two strings are NOT anagrams.");
        }
    }
}