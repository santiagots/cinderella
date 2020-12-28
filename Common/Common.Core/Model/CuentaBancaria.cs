namespace Common.Core.Model
{
    public class CuentaBancaria : Entity<int>
    {
        public Banco Banco { get; set; }
        public int IdBanco { get; protected set; }
        public string CBU { get; protected set; }
        public string NumeroCuenta { get; protected set; }
        public string CBUAlias { get; protected set; }
        public string Titular { get; protected set; }
        public string CUIT { get; protected set; }
        public bool EsCuentaCorriente { get; protected set; }
        public bool Habilitado { get; protected set; }

        internal CuentaBancaria()
        {
        }

        public CuentaBancaria(int idBanco, string cbu, string numeroCuenta, string cbuAlias, string titular, string cuit, bool esCuentaCorriente, bool habilitado)
        {
            IdBanco = idBanco;
            CBU = cbu;
            NumeroCuenta = numeroCuenta;
            CBUAlias = cbuAlias;
            Titular = titular;
            CUIT = cuit;
            EsCuentaCorriente = esCuentaCorriente;
            Habilitado = habilitado;
        }
    }
}
