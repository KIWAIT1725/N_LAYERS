using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Materiales
{
    public static class General
    {
        public static bool ValidateEmail(string? email)
        {
            string patron = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            if (email != null)
            {
                return Regex.Match(email, patron).Success;
            }
            return false;
        }
        public static short ValidateShort(object? PosibleNum)
        {
            short numero = 0;
            if (PosibleNum != null)
            {
                string? auxiliar = Convert.ToString(PosibleNum);
                if (short.TryParse(auxiliar, out numero))
                {
                    return numero;
                }
            }
            return numero;
        }
        public static int ValidateInt(object? PosibleNum)
        {
            int numero = 0;
            if (PosibleNum != null)
            {
                string? auxiliar = Convert.ToString(PosibleNum);
                if (int.TryParse(auxiliar, out numero))
                {
                    return numero;
                }
            }
            return numero;
        }
        public static Int64 ValidateInt64(object? PosibleNum)
        {
            Int64 numero = 0;
            if(PosibleNum != null)
            {
                string? auxiliar = Convert.ToString(PosibleNum);
                if(Int64.TryParse(auxiliar, out numero))
                {
                    return numero;
                }
            }
            return numero;
        }
        public static decimal ValidateDecimal(object? PosibleNum)
        {
            decimal numero = 0;
            if(PosibleNum!= null)
            {
                string? auxiliar = Convert.ToString(PosibleNum);
                if (decimal.TryParse(auxiliar,out numero))
                {
                    return numero;
                }
            }
            return numero;
        }
        public static float ValidateFloat(object? PosibleNum)
        {
            float numero = 0;
            if(PosibleNum != null)
            {
                string? auxiliar = Convert.ToString(PosibleNum);
                if(float.TryParse(auxiliar,out numero))
                {
                    return numero;
                }
            }
            return numero;
        }
    }
}
