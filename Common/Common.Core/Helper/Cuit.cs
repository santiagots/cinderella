using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.Helper
{
    public class Cuit
    {
        public static bool Validar(string cuit)
        {
            int suma = 0;
            bool valido;
            int cuitNumero = 0;
            cuit = cuit.Replace("-", "");
            if (int.TryParse(cuit, out cuitNumero))
            {
                if (cuit.Length != 11)
                    valido = false;
                else
                {
                    suma = 0;
                    suma += System.Convert.ToInt32(cuit.Substring(0, 1)) * 5;
                    suma += System.Convert.ToInt32(cuit.Substring(1, 1)) * 4;
                    suma += System.Convert.ToInt32(cuit.Substring(2, 1)) * 3;
                    suma += System.Convert.ToInt32(cuit.Substring(3, 1)) * 2;
                    suma += System.Convert.ToInt32(cuit.Substring(4, 1)) * 7;
                    suma += System.Convert.ToInt32(cuit.Substring(5, 1)) * 6;
                    suma += System.Convert.ToInt32(cuit.Substring(6, 1)) * 5;
                    suma += System.Convert.ToInt32(cuit.Substring(7, 1)) * 4;
                    suma += System.Convert.ToInt32(cuit.Substring(8, 1)) * 3;
                    suma += System.Convert.ToInt32(cuit.Substring(9, 1)) * 2;
                    suma += System.Convert.ToInt32(cuit.Substring(10, 1));
                }

                if (Math.Round(suma / (double)11, 0) == (suma / (double)11))
                    valido = true;
                else
                    valido = false;
            }
            else
                valido = false;
            return (valido);
        }


    }
}
