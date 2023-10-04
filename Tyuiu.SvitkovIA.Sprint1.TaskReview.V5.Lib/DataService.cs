using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SvitkovIA.Sprint1.TaskReview.V5.Lib
{
    public class DataService : ISprint1Task7V5
    {
        public double Calculate(double x)
        {
            double res = Math.Round((Math.Log10(Math.Abs(Math.Cos(x)))) / (Math.Log10(1 + Math.Pow(x, 2))),3);
            return res;
        }
    }
}
