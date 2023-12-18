using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_WPF_CalcUpgrd
{
    class CalcVievMod
    {
        private CalcModel model = new CalcModel();

        public string GetRes { get { return $"{model.Res}"; } }
        public string GetOp { get { return model.CurrOp;  } }

        public string Operation(string op, string numb)
        {
            if (model.CurrOp != " " && op != "=")
            {
                if (model.CurrOp == "+")
                {
                    model.plus(double.Parse(numb));
                    model.CurrOp = op;
                    return $"{model.Res}\n{model.CurrOp}\n";
                }
                else if (model.CurrOp == "-")
                {
                    model.minus(double.Parse(numb));
                    model.CurrOp = op;
                    return $"{model.Res}\n{model.CurrOp}\n";
                }
                else if (model.CurrOp == "*")
                {
                    model.mult(double.Parse(numb));
                    model.CurrOp = op;
                    return $"{model.Res}\n{model.CurrOp}\n";
                }
                else
                {
                    model.div(double.Parse(numb));
                    model.CurrOp = op;
                    return $"{model.Res}\n{model.CurrOp}\n";
                }
            }
            else if (op == "=")
            {
                if (model.CurrOp == "+")
                {
                    model.plus(double.Parse(numb));
                    model.CurrOp = " ";
                    return $"{model.Res}\n{model.CurrOp}\n";
                }
                else if (model.CurrOp == "-")
                {
                    model.minus(double.Parse(numb));
                    model.CurrOp = " ";
                    return $"{model.Res}\n{model.CurrOp}\n";
                }
                else if (model.CurrOp == "*")
                {
                    model.mult(double.Parse(numb));
                    model.CurrOp = " ";
                    return $"{model.Res}\n{model.CurrOp}\n";
                }
                else
                {
                    model.div(double.Parse(numb));
                    model.CurrOp = " ";
                    return $"{model.Res}\n{model.CurrOp}\n";
                }
            }
            else
            {
                model.Res = double.Parse(numb);
                model.CurrOp = op;
                return $"{model.Res}\n{model.CurrOp}\n";
            }
        }
        public void Clear()
        {
            model.Res = 0;
            model.CurrOp = " ";
        }
    }
}
