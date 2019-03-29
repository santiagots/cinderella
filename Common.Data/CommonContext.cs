using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data
{
    public class CommonContext : DbContext
    {
        public CommonContext()
        : base("SistemaCinderella.My.MySettings.Conexion")
        {
            Database.Log = sql => Debug.Write(sql);
        }

        public DbSet<Feriado> Feriado { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Feriado>().ToTable("FERIADOS");
            modelBuilder.Entity<Feriado>().Property(t => t.Id).HasColumnName("id_Feriado");
            modelBuilder.Entity<Feriado>().Property(t => t.Fecha).HasColumnName("FechaCorta");

            base.OnModelCreating(modelBuilder);
        }
    }
}
