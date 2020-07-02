using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double Fahrenheit)
        {
           var result = (Fahrenheit - 32) / 1.8;
           
            return result;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            var result = (celsius * 9) / 5 + 32;
            return result;
            

        }
    }
}   
