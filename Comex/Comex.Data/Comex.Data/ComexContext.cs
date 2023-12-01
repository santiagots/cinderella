using Comex.Core.Model.ComexAggregate;
using Common.Core.Enum;
using Common.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Comex.Data
{
    public class ComexContext : CommonContext
    {
        public ComexContext(TipoBase local = TipoBase.Local) : base(local)
        {
        }

        public DbSet<Supplier> Suppier { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
