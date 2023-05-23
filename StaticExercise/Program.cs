namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double tempFahrenheit = 98.5;
            Console.WriteLine("Please enter a temperature to convert to Celsius:");

            while (!double.TryParse(Console.ReadLine(), out tempFahrenheit))
            {
                Console.WriteLine("Invalid input\nPlease input a temperature to convert to Celsius:");
            }

            double tempCelsius = TempConverter.FahrenheitToCelsius(tempFahrenheit);
            Console.WriteLine($"\n{tempFahrenheit} degrees Fahrenheit equals {tempCelsius} degrees Celsius.\n");

            tempFahrenheit = TempConverter.CelsiusToFahrenheit(tempCelsius);
            Console.WriteLine($"{tempCelsius} degrees Celsius equals {tempFahrenheit} degrees Fahrenheit.");
        }
    }
}
