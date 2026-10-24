using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dynamic_Array dynamic_Array = new Dynamic_Array();
            math math = new math();
            var array = new List<double>();
            Dynamic_Array.GetDynamicArray(array);
            while (true)
            {
               Console.WriteLine("Номер операции?\n1 - plus\n2 - minus\n3 - multiply\n4 - divide\n5 - procent\n6 - deprocent\n7 - factorial\n8 - max\n9 - min\n10 - count");
                int check_why_operation = Convert.ToInt32(Console.ReadLine());
                double result = 0;
                double x = 0, y = 0;
                switch (check_why_operation)
                {
                    case 0:
                        return;
                    case 1:
                        result = math.plus(array.ToArray());
                        Console.WriteLine(result);
                        break;
                    case 2:
                        result = math.minus(array.ToArray());
                        Console.WriteLine(result);
                        break;
                    case 3:
                        result = math.mult(array.ToArray());
                        Console.WriteLine(result);
                        break;
                    case 4:
                        result = math.divide(array.ToArray());
                        Console.WriteLine(result);
                        break;
                    case 5:
                        result = math.max(array.ToArray());
                        Console.WriteLine(result);
                        break;
                    case 6:
                        result = math.min(array.ToArray());
                        Console.WriteLine(result);
                        break;
                    case 7:
                        Console.WriteLine("Число ");
                        x = Convert.ToDouble(Console.ReadLine());
                        result = math.factorial((int)x);
                        Console.WriteLine(result);
                        break;
                    case 8:
                        Console.WriteLine("Первое число ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Второе число ");
                        y = Convert.ToDouble(Console.ReadLine());
                        result = math.precent(x, y);
                        Console.WriteLine(result + "%");
                        break;
                    case 9:
                        Console.WriteLine("Сколько % ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("От какого числа");
                        y = Convert.ToDouble(Console.ReadLine());
                        result = math.deprecent(x, y);
                        Console.WriteLine(result);
                        break;
                }
               }
        }
    }
}
