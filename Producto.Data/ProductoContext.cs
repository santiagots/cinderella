using System.Data.Entity;
using Model = Producto.Core.Model.ProductoAgreggate;
using System.Data.Entity.ModelConfiguration.Conventions;
using Common.Data;
using Common.Core.Enum;
using Common.Core.Model;
using Producto.Core.Model.ProductoAgreggate;
using System.ComponentModel.DataAnnotations.Schema;

namespace Producto.Data
{
    public class ProductoContext : CommonContext
    {
        public ProductoContext()
        : base(TipoBase.Remota)
        {
        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<SubCategoria> SubCategoria { get; set; }
        public DbSet<Model.Producto> Producto { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Precio> Precio { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<TipoProducto> TipoProducto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Color>().ToTable("COLORES");
            modelBuilder.Entity<Color>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Categoria>().ToTable("PRODUCTOS_CATEGORIAS");
            modelBuilder.Entity<Categoria>().Property(t => t.Id).HasColumnName("id_Categoria");
            modelBuilder.Entity<Categoria>().HasMany(v => v.SubCategorias).WithRequired(t => t.Categoria).HasForeignKey(x => x.IdCategoria);

            modelBuilder.Entity<SubCategoria>().ToTable("PRODUCTOS_SUBCATEGORIAS");
            modelBuilder.Entity<SubCategoria>().Property(t => t.Id).HasColumnName("id_Subcategoria");
            modelBuilder.Entity<SubCategoria>().Property(t => t.IdCategoria).HasColumnName("id_Categoria");
            modelBuilder.Entity<SubCategoria>().HasRequired(v => v.IVA).WithMany().HasForeignKey(x => x.IdIVA);

            modelBuilder.Entity<Model.Producto>().ToTable("PRODUCTOS");
            modelBuilder.Entity<Model.Producto>().Property(t => t.Id).HasColumnName("id_Producto");
            modelBuilder.Entity<Model.Producto>().HasMany(v => v.Precios).WithRequired().HasForeignKey(x => x.IdProducto);
            modelBuilder.Entity<Model.Producto>().Property(t => t.IdCategoria).HasColumnName("id_Categoria");
            modelBuilder.Entity<Model.Producto>().HasOptional(t => t.Categoria).WithMany().HasForeignKey(x => x.IdCategoria);
            modelBuilder.Entity<Model.Producto>().Property(t => t.IdSubcategoria).HasColumnName("id_Subcategoria");
            modelBuilder.Entity<Model.Producto>().HasOptional(t => t.Subcategoria).WithMany().HasForeignKey(x => x.IdSubcategoria);
            modelBuilder.Entity<Model.Producto>().Property(t => t.IdProveedor).HasColumnName("id_Proveedor");
            modelBuilder.Entity<Model.Producto>().HasOptional(t => t.Proveedor).WithMany().HasForeignKey(x => x.IdProveedor);
            modelBuilder.Entity<Model.Producto>().Property(t => t.IdSupplier).HasColumnName("id_Supplier");
            modelBuilder.Entity<Model.Producto>().HasOptional(t => t.Supplier).WithMany().HasForeignKey(x => x.IdSupplier);
            modelBuilder.Entity<Model.Producto>().Property(t => t.IdColor).HasColumnName("id_Color");
            modelBuilder.Entity<Model.Producto>().HasOptional(t => t.Color).WithMany().HasForeignKey(x => x.IdColor);
            modelBuilder.Entity<Model.Producto>().Property(t => t.IdProductType).HasColumnName("id_ProductType");
            modelBuilder.Entity<Model.Producto>().HasOptional(t => t.ProductType).WithMany().HasForeignKey(x => x.IdProductType);
            modelBuilder.Entity<Model.Producto>().Property(t => t.Tamanio).HasColumnName("Tamano");
            modelBuilder.Entity<Model.Producto>().Property(t => t.BoxSize.X).HasColumnName("BoxSize_X");
            modelBuilder.Entity<Model.Producto>().Property(t => t.BoxSize.Y).HasColumnName("BoxSize_Y");
            modelBuilder.Entity<Model.Producto>().Property(t => t.BoxSize.Z).HasColumnName("BoxSize_Z");
            modelBuilder.Entity<Model.Producto>().Property(t => t.ProductSize.X).HasColumnName("ProductSize_X");
            modelBuilder.Entity<Model.Producto>().Property(t => t.ProductSize.Y).HasColumnName("ProductSize_Y");
            modelBuilder.Entity<Model.Producto>().Property(t => t.ProductSize.Z).HasColumnName("ProductSize_Z");

            modelBuilder.Entity<Proveedor>().ToTable("PROVEEDORES");
            modelBuilder.Entity<Proveedor>().Property(t => t.Id).HasColumnName("id_Proveedor");

            modelBuilder.Entity<Precio>().ToTable("PRECIOS");
            modelBuilder.Entity<Precio>().Property(t => t.Id).HasColumnName("id_Precio");
            modelBuilder.Entity<Precio>().Property(t => t.IdProducto).HasColumnName("id_Producto");
            modelBuilder.Entity<Precio>().Property(t => t.IdLista).HasColumnName("id_Lista");
            modelBuilder.Entity<Precio>().Property(t => t.Monto).HasColumnName("Precio");

            modelBuilder.Entity<Supplier>().ToTable("NUEVA_SUPPLIER");
            modelBuilder.Entity<Supplier>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TipoProducto>().ToTable("TIPO_PRODUCTO");
            modelBuilder.Entity<TipoProducto>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
