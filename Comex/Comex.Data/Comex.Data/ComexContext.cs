using Comex.Core.Model.ComexAggregate;
using Common.Core.Enum;
using Common.Core.Model;
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

        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<OrdenCompraItem> OrdenCompraItems { get; set; }
        public DbSet<OrdenCompra> OrdenCompra { get; set; }
        public DbSet<Sucursal> Sucursal { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Empleado>().ToTable("EMPLEADOS");
            modelBuilder.Entity<Empleado>().Property(t => t.Id).HasColumnName("id_Empleado");
            modelBuilder.Entity<Empleado>().Property(t => t.Tipo).HasColumnName("id_TipoEmpleado");

            modelBuilder.Entity<Producto>().ToTable("PRODUCTOS");
            modelBuilder.Entity<Producto>().Property(t => t.Id).HasColumnName("id_Producto");
            modelBuilder.Entity<Producto>().Property(t => t.IdSupplier).HasColumnName("id_Supplier");
            modelBuilder.Entity<Producto>().HasOptional(t => t.Supplier).WithMany().HasForeignKey(x => x.IdSupplier);
            modelBuilder.Entity<Producto>().Property(t => t.IdColor).HasColumnName("id_Color");
            modelBuilder.Entity<Producto>().HasOptional(t => t.Color).WithMany().HasForeignKey(x => x.IdColor);
            modelBuilder.Entity<Producto>().Property(t => t.IdProductType).HasColumnName("id_ProductType");
            modelBuilder.Entity<Producto>().HasOptional(t => t.ProductType).WithMany().HasForeignKey(x => x.IdProductType);
            modelBuilder.Entity<Producto>().Property(t => t.BoxSize.X).HasColumnName("BoxSize_X");
            modelBuilder.Entity<Producto>().Property(t => t.BoxSize.Y).HasColumnName("BoxSize_Y");
            modelBuilder.Entity<Producto>().Property(t => t.BoxSize.Z).HasColumnName("BoxSize_Z");
            modelBuilder.Entity<Producto>().Property(t => t.ProductSize.X).HasColumnName("ProductSize_X");
            modelBuilder.Entity<Producto>().Property(t => t.ProductSize.Y).HasColumnName("ProductSize_Y");
            modelBuilder.Entity<Producto>().Property(t => t.ProductSize.Z).HasColumnName("ProductSize_Z");

            modelBuilder.Entity<OrdenCompra>().ToTable("NUEVA_COMEX_ORDEN_COMPRA");
            modelBuilder.Entity<OrdenCompra>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<OrdenCompra>().HasMany(v => v.OrdenCompraItems).WithRequired(t => t.OrdenCompra).HasForeignKey(x => x.IdOrdenCompra);
            modelBuilder.Entity<OrdenCompra>().Property(t => t.IdSupplier).HasColumnName("id_Supplier");
            modelBuilder.Entity<OrdenCompra>().HasRequired(t => t.Supplier).WithMany().HasForeignKey(x => x.IdSupplier);
            modelBuilder.Entity<OrdenCompra>().Property(t => t.IdEncargado).HasColumnName("id_Empleado");
            modelBuilder.Entity<OrdenCompra>().HasRequired(t => t.Encargado).WithMany().HasForeignKey(x => x.IdEncargado);
            modelBuilder.Entity<OrdenCompra>().Property(t => t.IdSucursal).HasColumnName("id_Sucursal");
            modelBuilder.Entity<OrdenCompra>().HasRequired(t => t.Sucursal).WithMany().HasForeignKey(x => x.IdSucursal);

            modelBuilder.Entity<OrdenCompraItem>().ToTable("NUEVA_COMEX_ORDEN_COMPRA_ITEMS");
            modelBuilder.Entity<OrdenCompraItem>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<OrdenCompraItem>().HasRequired(v => v.Producto).WithMany().HasForeignKey(x => x.IdProducto);

            modelBuilder.Entity<Sucursal>().ToTable("SUCURSALES");
            modelBuilder.Entity<Sucursal>().Property(t => t.Id).HasColumnName("id_Sucursal");
            modelBuilder.Entity<Sucursal>().Property(t => t.CodigoVenta).HasColumnName("Codigo_Venta");
        }
    }
}
