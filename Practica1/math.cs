using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class math
    {
        public double sum(int[] array)
        {
            var result = 0;
            foreach (var elm in array)
            {
                result += elm;
            }
            return result;
        }
        public double count(int[] array)
        {
            return array.Length;
        }
        public double max(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        public double min(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        public double factorial(int[] array)
        {
            double result = 1;
            for (int i = 2; i <= array; i++)
            {
                result *= i;
            }
            return result;
        }
        public double plus(double a, double b)
        {
            return a + b;
        }
        public double minus(double a, double b)
        { 
            return a - b; 
        }
        public double multiply(double a, double b)
        {
            return a * b; 
        }
        public double divide(double a, double b) 
        { 
            return a / b; 
        }
        public double procent(double value, double procent)
        {
            return value * procent / 100;
        }
        public double deprocent(double value, double procent)
        {
            return value * 100 / procent;
        }
    }
}
