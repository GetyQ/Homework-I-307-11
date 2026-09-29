using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static Person clsperson = new Person();
        static void Main()
        {
            Console.WriteLine($"id:{clsperson.id}\n" +
                $"FullName:{clsperson.familyName} {clsperson.firstName} {clsperson.SurName}\n" +
                $"BirhDate : {clsperson.Birthday}\n" +
                $"Age : {DateTime.Now.Year - clsperson.Birthday.Year}\n" +
                $"Gender : {(clsperson.gender==true?"Мужчина":"Женщина")}");
        }
    }
}
