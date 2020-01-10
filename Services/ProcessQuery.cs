using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Interfaces;

namespace Calculator.Services
{
    public class ProcessQuery : IProcessQuery
    {
        public async Task ProcessingQuery(string rawQuery)
        {
            if (rawQuery.Contains("+"))
            {
                List<string> forSum = new List<string>(rawQuery.Split('+', StringSplitOptions.RemoveEmptyEntries));
                double.TryParse(forSum.ElementAt(0), out double firstValue);
                double.TryParse(forSum.ElementAt(1), out double secondValue);
                ISum sum = new Sum();
                await sum.Summing(rawQuery, firstValue, secondValue);
            }
            else if (rawQuery.Contains("-"))
            {
                List<string> forDivision = new List<string>(rawQuery.Split('-', StringSplitOptions.RemoveEmptyEntries));
                double.TryParse(forDivision.ElementAt(0), out double firstValue);
                double.TryParse(forDivision.ElementAt(1), out double secondValue);
                IDivide division = new Divide();
                await division.Dividing(rawQuery, firstValue, secondValue);
            }
            else if (rawQuery.Contains("*"))
            {
                List<string> forMultuplying = new List<string>(rawQuery.Split('*', StringSplitOptions.RemoveEmptyEntries));
                double.TryParse(forMultuplying.ElementAt(0), out double firstValue);
                double.TryParse(forMultuplying.ElementAt(1), out double secondValue);
                IMultiply multiplication = new Multiply();
                await multiplication.Multiplying(rawQuery, firstValue, secondValue);
            }
            else if (rawQuery.Contains("/"))
            {
                List<string> forDividing = new List<string>(rawQuery.Split('/', StringSplitOptions.RemoveEmptyEntries));
                double.TryParse(forDividing.ElementAt(0), out double firstValue);
                double.TryParse(forDividing.ElementAt(1), out double secondValue);
                IDivide division = new Divide();
                await division.Dividing(rawQuery, firstValue, secondValue);
            }
            else if (rawQuery.Contains("^"))
            {
                List<string> forExponenting = new List<string>(rawQuery.Split('^', StringSplitOptions.RemoveEmptyEntries));
                double.TryParse(forExponenting.ElementAt(0), out double firstValue);
                double.TryParse(forExponenting.ElementAt(1), out double secondValue);
                IExp exponention = new Exp();
                await exponention.CalculateExp(rawQuery, firstValue, secondValue);
            }
            else
            {
                if (rawQuery.Contains("sin"))
                {
                    List<string> forSinus = new List<string>(rawQuery.Split(' ', StringSplitOptions.RemoveEmptyEntries));
                    double.TryParse(forSinus.ElementAt(0), out double firstValue);
                    ISin sinus = new Sin();
                    await sinus.CalculateSin(rawQuery, firstValue);
                }
                else if (rawQuery.Contains("cos"))
                {
                    List<string> forCosinus = new List<string>(rawQuery.Split(' ', StringSplitOptions.RemoveEmptyEntries));
                    double.TryParse(forCosinus.ElementAt(0), out double firstValue);
                    ICos cosinus = new Cos();
                    await cosinus.CalculateCos(rawQuery, firstValue);
                }
                else if (rawQuery.Contains("tan"))
                {
                    List<string> forTangens = new List<string>(rawQuery.Split(' ', StringSplitOptions.RemoveEmptyEntries));
                    double.TryParse(forTangens.ElementAt(0), out double firstValue);
                    ITan tangens = new Tan();
                    await tangens.CalculateTan(rawQuery, firstValue);
                }
                else
                {
                    string wrong = "Something went wrong. Try again.";
                }
            }



        }

    }
}

