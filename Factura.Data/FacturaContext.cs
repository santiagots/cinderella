using Common.Core.Helper;
using Common.Data;
using Factura.Core.Model.AfipAgreggate;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;

namespace Factura.Data
{
    public class FacturaContext : CommonContext
    {
        public FacturaContext()
        : base()
        {
            this.Database.Connection.ConnectionString = Encriptar.DesencriptarMD5(ConfigurationManager.ConnectionStrings["SistemaCinderella.My.MySettings.ConexionRemoto"].ConnectionString);
            Database.Log = sql => Debug.Write(sql);
        }

        public DbSet<AfipTokenAcces> AfipTokenAcces { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<AfipTokenAcces>().ToTable("NUEVA_AFIP_TOKEN_ACCES");
            modelBuilder.Entity<AfipTokenAcces>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            base.OnModelCreating(modelBuilder);
        }
    }
}
