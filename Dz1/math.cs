using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz1
{
    public class math
    {
        public double sum(int[] numbers)
        {
            var result = 0;
            foreach (var elm in numbers)
            {
                result += elm;
            }
            return result;
        }
        public double count(int[] numbers)
        {
            return numbers.Length;
        }
        public double max(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
        public double min(int[] numbers)
        {
            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

    }
}
