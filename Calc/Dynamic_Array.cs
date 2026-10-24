using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calc;
    public class Dynamic_Array
{
    public static void GetDynamicArray(List<double> array)
    {
        Console.WriteLine("Введите числа");
            while (true)
        {
            string check_result = Console.ReadLine();
            if (check_result == "stop")
            {
                break;
            }
            array.Add(Convert.ToDouble(check_result));
        }
    }
}