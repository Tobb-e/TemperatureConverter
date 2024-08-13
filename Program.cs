class Program
{
    // Converts Celsius temperature to Fahrenheit
    static double ConvertToFahrenheit(double celTemp) => celTemp * 9 / 5 + 32;

    static void Main(string[] args)
    {
        // Create two variables to store respective temperature
        double celTemp, ferTemp;
        bool validChoice = false;

        // Create a menu to chose which temperature scale to convert to
        while (!validChoice)
        {
            // Print out an interactive menu to the user
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
                    if (double.TryParse(Console.ReadLine(), out celTemp))
                    {
                        // Call the variable function to convert Celsius to Fahrenheit
                        ferTemp = ConvertToFahrenheit(celTemp);
                        Console.WriteLine($"{celTemp} degrees Celcius is {ferTemp:F1} degrees Fahrenheit");
                        validChoice = true;
                    }
                    else
                    {
                        // Print a message if the user enters an invalid character
                        Console.WriteLine("Invalid input. Please enter a valid numeric value for Celsius");
                    }
                    break;

                case "2":
                    // Take the input from the user and store it in a variable
                    Console.Write("Enter Fahrenheit temperature: ");
                    if (double.TryParse(Console.ReadLine(), out ferTemp))
                    {
                        // Write the logic to handle the conversion from Fahrenheit to Celsius
                        celTemp = (ferTemp - 32) * 5 / 9;
                        Console.WriteLine($"{ferTemp} degrees Fahrenheit is {celTemp:F1} degrees Celsius");
                        validChoice = true;
                    }
                    else
                    {
                        // Print a message if the user enters an invalid character
                        Console.WriteLine("Invalid input. Please enter a valid numeric value for Fahrenheit");
                    }
                    break;
                
                case "3":
                    // Exit the program
                    Console.WriteLine("Exiting the Temperature Converter. Thank you!");
                    validChoice = true;
                    break;

                default:
                    // Print a message if the user enters an invalid character 
                    Console.WriteLine("Invalid choice. Please enter 1, 2 or 3");
                    break;
            }
        }
    }
}