using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SvitkovIA.Sprint1.TaskReview.V5;
using Tyuiu.SvitkovIA.Sprint1.TaskReview.V5.Lib;

namespace Tyuiu.SvitkovIA.Sprint1.TaskReview.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            double x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(dataService.Calculate(x));

            Console.ReadKey();
        }
    }
}
