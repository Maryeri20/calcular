using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular
{
    class Operaciones
    {
        public bool IsNumeric(string num)
        {
            try
            {
                double x = Convert.ToInt32(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int Suma(int a, int b)
        {
            return a + b;
        }

        public int Resta(int a, int b)
        {
            return a - b;
        }

        public int Multiplicación(int a, int b)
        {
            return a * b;
        }

        public int División(int a, int b)
        {
            return a / b;
        }
    }
}
