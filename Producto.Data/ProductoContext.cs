using System.Data.Entity;
using Model = Producto.Core.Model.ProductoAgreggate;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Configuration;
using Common.Core.Model;
using Common.Data;

namespace Producto.Data
{
    public class ProductoContext : CommonContext
    {
        public ProductoContext()
        : base()
        {
            this.Database.Connection.ConnectionString = Cripto.DesencriptarMD5(ConfigurationManager.ConnectionStrings["SistemaCinderella.My.MySettings.ConexionRemoto"].ConnectionString);
            Database.Log = sql => Debug.Write(sql);
        }

        public DbSet<Model.Producto> Producto { get; set; }
        public DbSet<Model.Proveedor> Proveedor { get; set; }
        public DbSet<Model.Precio> Precio { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Model.Producto>().ToTable("PRODUCTOS");
            modelBuilder.Entity<Model.Producto>().Property(t => t.Id).HasColumnName("id_Producto");
            modelBuilder.Entity<Model.Producto>().Property(t => t.IdCategoria).HasColumnName("id_Categoria");
            modelBuilder.Entity<Model.Producto>().Property(t => t.IdSubcategoria).HasColumnName("id_Subcategoria");
            modelBuilder.Entity<Model.Producto>().Property(t => t.IdProveedor).HasColumnName("id_Proveedor");
            modelBuilder.Entity<Model.Producto>().Property(t => t.Tamanio).HasColumnName("Tamano");
            modelBuilder.Entity<Model.Producto>().HasOptional(t => t.Categoria).WithMany().HasForeignKey(x => x.IdCategoria);
            modelBuilder.Entity<Model.Producto>().HasOptional(t => t.Subcategoria).WithMany().HasForeignKey(x => x.IdSubcategoria);
            modelBuilder.Entity<Model.Producto>().HasOptional(t => t.Proveedor).WithMany().HasForeignKey(x => x.IdProveedor);
            modelBuilder.Entity<Model.Producto>().HasMany(v => v.Precios).WithRequired().HasForeignKey(x => x.IdProducto);
           
            modelBuilder.Entity<Model.Proveedor>().ToTable("PROVEEDORES");
            modelBuilder.Entity<Model.Proveedor>().Property(t => t.Id).HasColumnName("id_Proveedor");

            modelBuilder.Entity<Model.Precio>().ToTable("PRECIOS");
            modelBuilder.Entity<Model.Precio>().Property(t => t.Id).HasColumnName("id_Precio");
            modelBuilder.Entity<Model.Precio>().Property(t => t.IdProducto).HasColumnName("id_Producto");
            modelBuilder.Entity<Model.Precio>().Property(t => t.IdLista).HasColumnName("id_Lista");
            modelBuilder.Entity<Model.Precio>().Property(t => t.Monto).HasColumnName("Precio");
        }
    }
}
