using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dz1
{

    internal class Test
    {
        static math clsmath = new math();
        static int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static void Main()
        {
            Console.WriteLine($"summa:{clsmath.sum(numbers)}\n" +
                $"counting:{clsmath.count(numbers)}\n" +
                $"maximum:{clsmath.max(numbers)}\n" +
                $"minimum:{clsmath.min(numbers)}\n");
        }
    }
}