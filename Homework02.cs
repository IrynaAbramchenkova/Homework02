//Create a program that uses string type, number type, boolean, and collection of any of those types.
//Transform your collection in any way and output the result to the screen


//Console.WriteLine("How warm is there?");
//var temperature = Convert.ToInt32(Console.ReadLine());
//var temperature = Console.ReadLine();
//Console.WriteLine($"Wow! {temperature}°C is sure hot!");


//int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
using System.Windows.Markup;

//var values = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
//double[] values = new double[] { 1, 2, 3, 4.1, 5.02, -6, -7.99, 0.8, 9.006, 10, 11 };
//Console.WriteLine("Numbers greater than 5: " + string.Join(',', numbers.Where(number => number > 5)));
//Console.WriteLine("Numbers between 3 and 7: " + string.Join(',', numbers.Where(number => number > 3 && number < 7)));
//Console.WriteLine("Odd numbers: " + string.Join(',', numbers.Where(number => number % 2 == 1)));
//numbers.AddRange(new int[] { 11, 12 });
//Console.WriteLine(string.Join(',', numbers));
//Console.WriteLine(numbers);
//Console.WriteLine("Is the number odd?: ");
//Console.WriteLine(string.Join(',', numbers.Select(number => number % 2 == 1)));
//string join = "";



//MY COLLECTIONS 


//var filters = new Dictionary<string, string>
//{   "a", 
    //"b", 
    //"c"
//}

//Console.WriteLine(string.Join(", ", Dictionary));


using System;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> strings = new List<string> { "yes", "no" };
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //IceCreamList = new List<(string, decimal)>();
        List<bool> bools = new List<bool> { true, false };

        numbers.AddRange(new int[] { 11, 12 });
        strings.Add("maybe");
        numbers.Insert(0, 0);
        bools.RemoveAt(1);

        //MY PROGRAM

        Console.WriteLine(" Value With Maybe: " + string.Join(", ", strings));
        Console.WriteLine(" All Numbers: " + string.Join(", ", numbers));
        Console.WriteLine(" Only True: " + string.Join(", ", bools));
        Console.WriteLine("Numbers less than 1: " + string.Join(',', numbers.Where(number => number < 1)));
        Console.WriteLine("Numbers between 1 and 5: " + string.Join(',', numbers.Where(number => number > 1 && number < 5)));
        Console.WriteLine("Odd numbers: " + string.Join(',', numbers.Where(number => number % 2 == 1)));
        Console.WriteLine(string.Join(',', numbers.Select(number => number % 2 == 1)));
        Console.WriteLine("Even numbers: " + string.Join(',', numbers.Where(number => number % 2 == 0)));
        Console.ReadLine();
    }
}