using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_WPF_CalcUpgrd
{
    class CalcModel
    {
        private double res = 0;
        private string currOp = " ";

        public double Res { get { return res; } set {  res = value; } }
        public string CurrOp { get { return currOp; } set {  currOp = value; } }
        public void plus(double num)
        {
            res += num;
        }
        public void minus(double num)
        {
            res -= num;
        }
        public void mult(double num)
        {
            res *= num;
        }
        public void div(double num)
        {
            res /= num;
        }
    }
}
