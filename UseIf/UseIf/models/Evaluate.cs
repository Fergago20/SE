using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseIf.models
{
    internal class Evaluate
    {
        public Evaluate() { }
        public string EvalAge(int age)
        {
            try
            {


                if (age >= 0 && age <= 12) { return "Eres ninno"; }
                else if (age >= 13 && age <= 25) { return "Eres Joven"; }
                else if (age >= 26 && age<=120) { return "Eres Adulto"; }
            }
            catch (Exception ex)
            {
                return $"Error {ex.ToString}";
            }
            return "Edad no admitida";

        }
    }
}
