namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitRequested = false;

            // Declare the temperature variables once at the start of the method
            double celsiusTemp = 0;
            double fahrenheitTemp = 0;

            // Print out an interactive menu to the user
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
                string? choice = Console.ReadLine();

                // Create three cases (Celsius - Fahrenheit - Exit) and one default
                switch (choice)
                {
                    case "1":
                        // Take the input from the user and store it in a variable
                        Console.Write("Enter Celsius temperature: ");
                        if (double.TryParse(Console.ReadLine(), out celsiusTemp))
                        {
                            // Call the function to convert Celsius to Fahrenheit 
                            var fahrenheitConverter = new CelsiusToFahrenheitConverter();
                            fahrenheitTemp = fahrenheitConverter.Convert(celsiusTemp);
                            Console.WriteLine($"{celsiusTemp} degrees Celsius is {fahrenheitTemp:F1} degrees Fahrenheit\n");
                        }
                        else
                        {
                            // Print a message if the user enters an invalid character
                            Console.WriteLine("Invalid input. Please enter a valid numeric value for Celsius.");
                        }
                        break;

                    case "2":
                        // Take the input from the user and store it in a variable
                        Console.Write("Enter Fahrenheit temperature: ");
                        if (double.TryParse(Console.ReadLine(), out fahrenheitTemp))
                        {
                            // Call the function to convert Fahrenheit to Celsius
                            var celsiusConverter = new FahrenheitToCelsiusConverter();
                            celsiusTemp = celsiusConverter.Convert(fahrenheitTemp);
                            Console.WriteLine($"{fahrenheitTemp} degrees Fahrenheit is {celsiusTemp:F1} degrees Celsius\n");
                        }
                        else
                        {
                            // Print a message if the user enters an invalid character
                            Console.WriteLine("Invalid input. Please enter a valid numeric value for Fahrenheit");
                        }
                        break;

                    case "3":
                        // Exit the program
                        exitRequested = true;
                        Console.WriteLine("Exiting the Temperature Converter. Thank you!");
                        break;

                    default:
                        // Print a message if the user enters an invalid character
                        Console.WriteLine("Invalid choice. Please enter 1, 2 or 3");
                        break;
                }
            }
        }
    }
}