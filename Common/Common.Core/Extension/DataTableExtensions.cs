using System;
using System.Data;
using System.Linq;

namespace Common.Core.Extension
{
    public static class DataTableExtensions
    {
        public static string ToCVS(this DataTable dt, string delimitador = ";")
        {
            string Res = string.Join(delimitador, dt.Columns.OfType<DataColumn>().Select(x => string.Join(delimitador, x.ColumnName)));
            Res += Environment.NewLine;
            Res += string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(x => string.Join(delimitador, x.ItemArray)));
            return Res;
        }
    }
}
