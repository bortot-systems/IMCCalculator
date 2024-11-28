public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the IMC Calculator!");

        Console.Write("Enter your weight (kg): ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter your height (m): ");
        double height = double.Parse(Console.ReadLine());

        double imc = CalculateIMC(weight, height);
        Console.WriteLine($"Your IMC is: {imc:F2}");

        string category = GetIMCCategory(imc);
        Console.WriteLine($"You are classified as: {category}");
    }

    public static double CalculateIMC(double weight, double height)
    {
        return weight / (height * height);
    }

    public static string GetIMCCategory(double imc)
    {
        return imc switch
        {
            < 18.5 => "Underweight",
            >= 18.5 and < 24.9 => "Normal weight",
            >= 25 and < 29.9 => "Overweight",
            >= 30 => "Obesity",
            _ => "Invalid"
        };
    }
}