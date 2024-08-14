namespace TemperatureConverter
{
    // Implement the Fahrenheit to Celsius converter
    public class FahrenheitToCelsiusConverter : ITemperatureConverter
    {
        public double Convert(double temperature)
        {
            return (temperature - 32) * 5 / 9;
        }
    }
}