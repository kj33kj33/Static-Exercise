using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		public static double FahrenheitToCelsius(double temperature)
		{
			return (temperature - 32) / 1.8;
		}

		public static double CelsiusToFahrenheit(double temperature)
		{
			return (1.8 * temperature) + 32;
		}
	}
}

