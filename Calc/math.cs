using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class math
    {
        public double count(double[] array)
        {
            return array.Length;
        }
        public double max(double[] numbers)
        {
            double max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
        public double min(double[] array)
        {
            double min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        public double plus(double[] array)
        {
            double result = 0;
            foreach (var number in array)
            {
                result += number;
            }
            return result;
        }
        public double minus(double[] array)
        {
            double result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                result -= array[i];
            }
            return result;
        }
        public double mult(double[] array)
        {
            double result = 1;
            foreach (var number in array)
            {  
                result *= number; 
            }
            return result;
        }
        public double divide(double[] array)
        {
            double result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                result /= array[i];
            }
            return result;
        }
        public double precent(double a, double b)
        {
            double precent = a * 100 / b;
            return precent;
        }
        public double deprecent(double precent, double b)
        {
            double number = b * precent / 100;
            return number;
        }
        public double factorial(int number)
        {
            if (number < 0) return -1;
            double result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
