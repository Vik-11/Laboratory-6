using Задание_2;
internal class Program
{
    private static void Main(string[] args)
    {
        Time time1 = TimeInput.InputValidTime("Enter first time");
        Time time2 = TimeInput.InputValidTime("Enter second time");

        Time result = time1.Subtract(time2);

        Console.WriteLine(result.ToString());

        time1++;
        time2--;
        Console.WriteLine($"Result for ++ operator { time1 }");
        Console.WriteLine($"Result for -- operator { time2 }");
        Console.WriteLine($"Quantity of minutes in time1 =  { (int)time1 }");
        Console.WriteLine($"time1 isn't midnight  = { (bool)time1 }");
        Console.WriteLine($"Is time1 greater than time2: { time1 > time2 }");
        Console.WriteLine($"Is time1 lesser than time2: { time1 < time2 }");
    }
}