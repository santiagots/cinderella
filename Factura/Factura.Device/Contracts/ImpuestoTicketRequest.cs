using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Factura.Device.Contracts
{
    public class ImpuestoTicketRequest
    {
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }

        public ImpuestoTicketRequest(string descripcion, decimal monto)
        {
            Descripcion = descripcion;
            Monto = monto;
        }

        public override string ToString()
        {
            if(Monto == 0)
                return Descripcion;
            else
                return $"{Descripcion} {Monto.ToString()}";
        }

        public List<string> FormatearLinea(int largoTotal)
        {
            List<string> resultado = new List<string>();
            string montoStr = string.Empty;

            if (Monto != 0)
                // Formateamos el monto con dos decimales
                montoStr = Monto.ToString("F2", CultureInfo.InvariantCulture);

            // Calculamos el espacio disponible para el texto (lo que sobra después del monto)
            int espacioTexto = largoTotal - montoStr.Length;
            if (espacioTexto < 1)
            {
                throw new ArgumentException("La longitud total es insuficiente para mostrar el monto.");
            }

            resultado = DividirString(Descripcion, largoTotal);

            if(largoTotal > resultado.Last().Length + montoStr.Length)
                resultado[resultado.Count-1] = resultado[resultado.Count - 1].PadRight(espacioTexto) + montoStr;
            else
                resultado.Add(string.Empty.PadRight(espacioTexto) + montoStr);

            return resultado;
        }

        public List<string> DividirString(string input, int longitud)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("El string de entrada no puede estar vacío.", nameof(input));

            if (longitud <= 0)
                throw new ArgumentException("La longitud debe ser mayor a 0.", nameof(longitud));

            List<string> resultado = new List<string>();

            for (int i = 0; i < input.Length; i += longitud)
            {
                resultado.Add(input.Substring(i, Math.Min(longitud, input.Length - i)));
            }

            return resultado;
        }
    }
}
