using PracticeProgramOops;
using PracticeProgramOops.Shapes;

internal class Program
{
    private static void Main(string[] args)
    {
        // PrimeNumberExample primeNumberExample = new PrimeNumberExample();
        // Console.Write("Enter a number: ");
        // int n = int.Parse(Console.ReadLine());

        // Console.WriteLine($"Prime numbers up to {n} are:");

        // for (int i = 2; i <= n; i++)
        // {
        //     if (primeNumberExample.IsPrime(i))
        //     {
        //         Console.Write(i + " ");
        //     }
        // }

        // // palce to visit
        // PlaceToVisit place = new PlaceToVisit();
        //  place.PlaceWantToVisit();

        // //check anagram string
        // CheckAnagramStrings  checkAnagram= new CheckAnagramStrings();
        // Console.Write("Enter the first string: ");
        // string str1 = Console.ReadLine();

        // Console.Write("Enter the second string: ");
        // string str2 = Console.ReadLine();

        // if (checkAnagram.IsAnagram(str1, str2))
        // {
        //     Console.WriteLine("The two strings are anagrams.");
        // }
        // else
        // {
        //     Console.WriteLine("The two strings are NOT anagrams.");
        // }

        //DateDiffrenceExample date = new DateDiffrenceExample();
        // date.FindDateDiffrence();

        ////calculate age
        //Console.Write("Enter your birth year (YYYY): ");
        //int year = int.Parse(Console.ReadLine());

        //Console.Write("Enter your birth month (MM): ");
        //int month = int.Parse(Console.ReadLine());

        //Console.Write("Enter your birth day (DD): ");
        //int day = int.Parse(Console.ReadLine());


        //DateTime birthDate = new DateTime(year, month, day);

        //int age = CalculateAgeExample.CalculateAge(birthDate);
        //Console.WriteLine($"You are {age} years old.");

        //// Calculate days until next birthday
        //int daysUntilBirthday = BirthdayCalculatorExample.DaysUntilNextBirthday(birthDate);
        //Console.WriteLine($"Your next birthday is in {daysUntilBirthday} days.");


        Rectangle rect = new Rectangle();

        try
        {
            Console.Write("Enter the length of the rectangle: ");
            rect.Length = double.Parse(Console.ReadLine());

            Console.Write("Enter the breadth of the rectangle: ");
            rect.Breadth = double.Parse(Console.ReadLine());

            double area = rect.CalculateArea();
            Console.WriteLine($"The area of the rectangle is: {area}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

    }
}