using Задание_1;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = InputValid.InputValidInt("Enter first number: ");
        int b = InputValid.InputValidInt("Enter second number: ");
        int c = InputValid.InputValidInt("Enter third number: ");

        ThreeOfInt mul = new ThreeOfInt();
        ThreeOfInt mul1 = new ThreeOfInt(a, b, c);
        ThreeOfInt mul2 = new ThreeOfInt(mul1);

        Console.WriteLine(mul.ToString());
        Console.WriteLine(mul1.ToString());
        Console.WriteLine(mul2.ToString());

        Console.WriteLine("\n");

        int x = RectParallelepiped.InputValidValue("Enter length: ");
        int y = RectParallelepiped.InputValidValue("Enter width");
        int z = RectParallelepiped.InputValidValue("Enter hight");

        RectParallelepiped rectParallelepiped = new RectParallelepiped(x, y, z);

        Console.WriteLine(rectParallelepiped.ShowLateral());
        Console.WriteLine(rectParallelepiped.ShowTotal());
        Console.WriteLine(rectParallelepiped.ShowVolume());
    }
}