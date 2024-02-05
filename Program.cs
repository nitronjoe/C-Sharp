using System;

namespace Workshop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureConverter tc = new TemperatureConverter();

            // Celsius to Fahrenheit calculation.
            double temperatureInCelsius = tc.C;
            double temperatureInFahrenheit = (temperatureInCelsius * 9 / 5) + 32;

            // Fahrenheit to Celsius calculation.
            double f_temp = tc.F;
            double celsiusFromFahrenheit = (f_temp - 32) * 5 / 9;

            // Result for absolute difference.
            double result = CalculateAbsoluteDifference(10, 2);
            Console.WriteLine($"The result is: {result}");

            // Print of what the temperature is in Celsius and Fahrenheit.
            Console.WriteLine($"Celsius = {temperatureInCelsius} and Fahrenheit = {temperatureInFahrenheit}");
            Console.ReadKey();
        }

        // Method for calculating the Absolute difference.
        public static double CalculateAbsoluteDifference(double num1, double num2)
        {
            // Calculate the absolute difference regardless of which number is greater.
            return 2 * Math.Abs(num1 - num2);
        }

        // Initiates the TemperatureConverter Class.
        public class TemperatureConverter
        {
            private double _C = 32.0;
            private double _F = 20.0;

            // Allow access to Celsius private field.
            public double C
            {
                get { return _C; }
                set
                {
                    _C = value;
                    // Update Fahrenheit when Celsius is set.
                    _F = value * 9 / 5 + 32;
                }
            }

            // Allow access to Fahrenheit private field.
            public double F
            {
                get { return _F; }
                set
                {
                    _F = value;
                    // Update Celsius when Fahrenheit is set.
                    _C = (value - 32) * 5 / 9;
                }
            }
        }
    }
}
