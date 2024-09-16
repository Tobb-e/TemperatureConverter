namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitRequested = false;

            // Create a dictionary to map options to converter instances
            var converters = new Dictionary<string, ITemperatureConverter>
            {
                { "1", new CelsiusToFahrenheitConverter() },
                { "2", new FahrenheitToCelsiusConverter() }
            };

            while (!exitRequested)
            {
                Console.WriteLine("|-----------------------------|");
                Console.WriteLine("|    Temperature Converter    |");
                Console.WriteLine("|-----------------------------|");
                Console.WriteLine("|  (1) Celsius to Fahrenheit  |");
                Console.WriteLine("|  (2) Fahrenheit to Celsius  |");
                Console.WriteLine("|  (3) Exit                   |");
                Console.WriteLine("|-----------------------------|");
                Console.Write("Choose an option (1, 2 or 3): ");
                
                // Ensure that the choice is not null
                string? choice = Console.ReadLine();

                if (string.IsNullOrEmpty(choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    continue;
                }

                if (choice == "3")
                {
                    exitRequested = true;
                    Console.WriteLine("Exiting the Temperature Converter. Thank you!");
                    continue;
                }

                // Try to find the corresponding converter in the dictionary
                if (converters.TryGetValue(choice, out var converter))
                {
                    string targetUnit = choice == "1" ? "Fahrenheit" : "Celsius";
                    Console.Write($"Enter temperature in {(choice == "1" ? "Celsius" : "Fahrenheit")}: ");
                    if (double.TryParse(Console.ReadLine(), out double inputTemperature))
                    {
                        double convertedTemperature = converter.Convert(inputTemperature);
                        Console.WriteLine($"Converted temperature is {convertedTemperature:F1} degrees {targetUnit}\n");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid numeric value.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 1, 2 or 3.");
                }
            }
        }
    }
}
