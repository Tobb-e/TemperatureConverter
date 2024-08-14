namespace TemperatureConverter
{
    // Implement the Celsius to Fahrenheit converter
    public class CelsiusToFahrenheitConverter : ITemperatureConverter
    {
        public double Convert(double temperature)
        {
            return temperature * 9 / 5 + 32;
        }
    }
}