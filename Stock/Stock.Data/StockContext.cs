using Common.Core.Enum;
using Common.Core.Model;
using Common.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Model = Stock.Core.Model.BaseAgreggate;

namespace Stock.Data
{
    public class StockContext : CommonContext
    {
        public StockContext(TipoBase local = TipoBase.Local) : base(local)
        {
        }

        public DbSet<Model.Bitacora> Bitacora { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Model.Stock> Stock { get; set; }
        public DbSet<Model.Producto> Producto { get; set; }
        public DbSet<Model.NotaPedidoItem> NotaPedidoItem { get; set; }
        public DbSet<Model.NotaPedido> NotaPedido { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Model.Bitacora>().ToTable("STOCK_BITACORA");
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.Id).HasColumnName("id_Bitacora").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.Accion).HasColumnName("Accion");
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.Fecha).HasColumnName("Fecha");
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.FechaEdicion).HasColumnName("Fecha_Edicion");
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.Habilitado).HasColumnName("Habilitado");
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.IdProducto).HasColumnName("id_Producto");
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.IdStock).HasColumnName("id_Stock");
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.IdSucursal).HasColumnName("id_Sucursal");
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.IdUsuario).HasColumnName("id_Usuario");
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.Motivo).HasColumnName("Motivo");
            modelBuilder.Entity<Model.Bitacora>().HasRequired(t => t.Producto).WithMany().HasForeignKey(x => x.IdProducto);
            modelBuilder.Entity<Model.Bitacora>().HasRequired(t => t.Stock).WithMany().HasForeignKey(x => x.IdStock);
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.StockActual).HasColumnName("Stock_Actual");
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.StockActualAnterior).HasColumnName("Stock_Actual_Ant");
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.StockMinimo).HasColumnName("Stock_Minimo");
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.StockMinimoAnterior).HasColumnName("Stock_Minimo_Ant");
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.StockOptimo).HasColumnName("Stock_Optimo");
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.StockOptimoAnterior).HasColumnName("Stock_Optimo_Ant");
            modelBuilder.Entity<Model.Bitacora>().HasRequired(t => t.Usuario).WithMany().HasForeignKey(x => x.IdUsuario);
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.VentaMensual).HasColumnName("Venta_Mensual");
            modelBuilder.Entity<Model.Bitacora>().Property(t => t.VentaMensualAnterior).HasColumnName("Venta_Mensual_Ant");
            modelBuilder.Entity<Model.Bitacora>().Ignore(t => t.Total);

            modelBuilder.Entity<Categoria>().ToTable("PRODUCTOS_CATEGORIAS");
            modelBuilder.Entity<Categoria>().Property(t => t.Id).HasColumnName("id_Categoria");

            modelBuilder.Entity<Model.Producto>().ToTable("PRODUCTOS");
            modelBuilder.Entity<Model.Producto>().Property(t => t.Id).HasColumnName("id_Producto");
            modelBuilder.Entity<Model.Producto>().Property(t => t.IdCategoria).HasColumnName("id_Categoria");
            modelBuilder.Entity<Model.Producto>().HasOptional(t => t.Categoria).WithMany().HasForeignKey(x => x.IdCategoria);
            modelBuilder.Entity<Model.Producto>().HasMany(t => t.NotaPedidoItems).WithOptional(t => t.Producto).HasForeignKey(x => x.IdProducto);

            modelBuilder.Entity<Model.Stock>().ToTable("STOCK");
            modelBuilder.Entity<Model.Stock>().Property(t => t.Id).HasColumnName("id_Stock").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Model.Stock>().Property(t => t.IdSucursal).HasColumnName("id_Sucursal");
            modelBuilder.Entity<Model.Stock>().Property(t => t.IdProducto).HasColumnName("id_Producto");
            modelBuilder.Entity<Model.Stock>().Property(t => t.IdUsuario).HasColumnName("id_Usuario");
            modelBuilder.Entity<Model.Stock>().HasRequired(t => t.Producto).WithMany().HasForeignKey(x => x.IdProducto);
            modelBuilder.Entity<Model.Stock>().HasOptional(t => t.Usuario).WithMany().HasForeignKey(x => x.IdUsuario);
            modelBuilder.Entity<Model.Stock>().Property(t => t.IdUsuario).HasColumnName("id_Usuario");
            modelBuilder.Entity<Model.Stock>().Property(t => t.Cantidad).HasColumnName("Stock_Actual");
            modelBuilder.Entity<Model.Stock>().Property(t => t.Minimo).HasColumnName("Stock_Minimo");
            modelBuilder.Entity<Model.Stock>().Property(t => t.Optimo).HasColumnName("Stock_Optimo");
            modelBuilder.Entity<Model.Stock>().Property(t => t.Borrado).HasColumnName("Borrado");
            modelBuilder.Entity<Model.Stock>().Property(t => t.Fecha).HasColumnName("Fecha");
            modelBuilder.Entity<Model.Stock>().Property(t => t.FechaEdicion).HasColumnName("Fecha_Edicion");
            modelBuilder.Entity<Model.Stock>().Property(t => t.FechaModificacion).HasColumnName("Fecha_Mod");
            modelBuilder.Entity<Model.Stock>().Property(t => t.Habilitado).HasColumnName("Habilitado");
            modelBuilder.Entity<Model.Stock>().Property(t => t.Modificado).HasColumnName("Modificado");
            modelBuilder.Entity<Model.Stock>().Property(t => t.MotivoModificacion).HasColumnName("Motivo_Mod");
            modelBuilder.Entity<Model.Stock>().Property(t => t.VentaMensual).HasColumnName("Venta_Mensual");
            modelBuilder.Entity<Model.Stock>().Ignore(t => t.Reservado);

            modelBuilder.Entity<Model.NotaPedidoItem>().ToTable("NUEVA_NOTA_PEDIDO_ITEMS");
            modelBuilder.Entity<Model.NotaPedidoItem>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Model.NotaPedidoItem>().HasRequired(t => t.NotaPedido).WithMany().HasForeignKey(x => x.IdNotaPedido);

            modelBuilder.Entity<Model.NotaPedido>().ToTable("NUEVA_NOTA_PEDIDO");
            modelBuilder.Entity<Model.NotaPedido>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
