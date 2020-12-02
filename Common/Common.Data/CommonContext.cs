using Common.Core.Enum;
using Common.Core.Exceptions;
using Common.Core.Helper;
using Common.Core.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;

namespace Common.Data
{
    public class CommonContext : DbContext
    {
        public static string STRING_CONEXION_BASE_LOCAL = ConfigurationManager.ConnectionStrings["SistemaCinderella.My.MySettings.Conexion"].ConnectionString;

        public static string STRING_CONEXION_BASE_REMOTA;

        public CommonContext(TipoBase tipoBase = TipoBase.Local)
        : base()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

            Database.Log = sql => Debug.Write(sql);
            if (tipoBase == TipoBase.Local)
                this.Database.Connection.ConnectionString = STRING_CONEXION_BASE_LOCAL;
            else
            {
                if (string.IsNullOrWhiteSpace(STRING_CONEXION_BASE_REMOTA))
                    throw new NegocioException("Error al conectarse a la base de datos, la cadena de conexión está vacío. Verifique que se encuentra configurado");
                this.Database.Connection.ConnectionString = Encriptar.DesencriptarMD5(STRING_CONEXION_BASE_REMOTA);
            }
        }

        public DbSet<Banco> Banco { get; set; }
        public DbSet<ClienteMayorista> ClienteMayorista { get; set; }
        public DbSet<Feriado> Feriado { get; set; }
        public DbSet<Domicilio> Domicilio { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Distrito> Distrito { get; set; }
        public DbSet<ListaPrecio> ListaPrecio { get; set; }
        public DbSet<Localidad> Localidad { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<SubCategoria> SubCategoria { get; set; }
        public DbSet<IVA> IVA { get; set; }

        public bool IsAttached<T>(Entity<T> entity) 
        {
           return this.Set(entity.GetType()).Local.Cast<Entity<T>>().Any(e => e.Id.Equals(entity.Id));
        }

        public Entity<T> GetAttached<T>(Entity<T> entity)
        {
            return this.Set(entity.GetType()).Local.Cast<Entity<T>>().FirstOrDefault(e => e.Id.Equals(entity.Id));
        }

        public Entity<T> Attach<T>(Entity<T> entity)
        {
            if (entity == null) return null;

            if (!this.IsAttached(entity))
                this.Entry(entity).State = EntityState.Unchanged;

            return GetAttached(entity);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Banco>().ToTable("BANCOS");
            modelBuilder.Entity<Banco>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Banco>().Property(t => t.Id).HasColumnName("BancoId");

            modelBuilder.Entity<ClienteMayorista>().ToTable("CLIENTEMAYORISTA");
            modelBuilder.Entity<ClienteMayorista>().Property(t => t.Id).HasColumnName("id_Cliente");
            modelBuilder.Entity<ClienteMayorista>().Property(t => t.PorcentajeBonificacion).HasColumnName("Bonificacion");
            modelBuilder.Entity<ClienteMayorista>().Property(t => t.PorcentajeComision).HasColumnName("Comision");
            modelBuilder.Entity<ClienteMayorista>().Property(t => t.PorcentajeLista).HasColumnName("Lista");
            modelBuilder.Entity<ClienteMayorista>().Property(t => t.CondicionIVA).HasColumnName("id_CondicionIva");
            modelBuilder.Entity<ClienteMayorista>().Property(t => t.IdListaPrecio).HasColumnName("id_ListaPrecio");
            modelBuilder.Entity<ClienteMayorista>().HasRequired(v => v.ListaPrecio).WithMany().HasForeignKey(x => x.IdListaPrecio);
            modelBuilder.Entity<ClienteMayorista>().Property(t => t.IdDomicilioFacturacion).HasColumnName("id_DireccionFacturacion");
            modelBuilder.Entity<ClienteMayorista>().HasOptional(v => v.DomicilioFacturacion).WithMany().HasForeignKey(x => x.IdDomicilioFacturacion);
            modelBuilder.Entity<ClienteMayorista>().Property(t => t.IdDomicilioEntrega).HasColumnName("id_DireccionEntrega");
            modelBuilder.Entity<ClienteMayorista>().HasOptional(v => v.DomicilioEntrega).WithMany().HasForeignKey(x => x.IdDomicilioEntrega);

            modelBuilder.Entity<Categoria>().ToTable("PRODUCTOS_CATEGORIAS");
            modelBuilder.Entity<Categoria>().Property(t => t.Id).HasColumnName("id_Categoria");
            modelBuilder.Entity<Categoria>().HasMany(v => v.SubCategorias).WithRequired(t => t.Categoria).HasForeignKey(x => x.IdCategoria);

            modelBuilder.Entity<SubCategoria>().ToTable("PRODUCTOS_SUBCATEGORIAS");
            modelBuilder.Entity<SubCategoria>().Property(t => t.Id).HasColumnName("id_Subcategoria");
            modelBuilder.Entity<SubCategoria>().Property(t => t.IdCategoria).HasColumnName("id_Categoria");
            modelBuilder.Entity<SubCategoria>().HasRequired(v => v.IVA).WithMany().HasForeignKey(x => x.IdIVA);

            modelBuilder.Entity<Feriado>().ToTable("FERIADOS");
            modelBuilder.Entity<Feriado>().Property(t => t.Id).HasColumnName("id_Feriado");
            modelBuilder.Entity<Feriado>().Property(t => t.Fecha).HasColumnName("FechaCorta");

            modelBuilder.Entity<Domicilio>().ToTable("DIRECCION");
            modelBuilder.Entity<Domicilio>().Property(t => t.Id).HasColumnName("id_Direccion");
            modelBuilder.Entity<Domicilio>().Property(t => t.IdLocalidad).HasColumnName("id_Localidad");
            modelBuilder.Entity<Domicilio>().Property(t => t.IdDistrito).HasColumnName("id_Distrito");
            modelBuilder.Entity<Domicilio>().Property(t => t.IdProvincia).HasColumnName("id_Provincia");
            modelBuilder.Entity<Domicilio>().Property(t => t.Email).HasColumnName("Mail");
            modelBuilder.Entity<Domicilio>().HasRequired(v => v.Localidad).WithMany().HasForeignKey(x => x.IdLocalidad);
            modelBuilder.Entity<Domicilio>().HasRequired(v => v.Distrito).WithMany().HasForeignKey(x => x.IdDistrito);
            modelBuilder.Entity<Domicilio>().HasRequired(v => v.Provincia).WithMany().HasForeignKey(x => x.IdProvincia);

            modelBuilder.Entity<Distrito>().ToTable("DEPARTAMENTOS");
            modelBuilder.Entity<Distrito>().Property(t => t.Id).HasColumnName("id_Departamento");
            modelBuilder.Entity<Distrito>().Property(t => t.IdProvincia).HasColumnName("id_Provincia");

            modelBuilder.Entity<ListaPrecio>().ToTable("LISTA_PRECIO");
            modelBuilder.Entity<ListaPrecio>().Property(t => t.Id).HasColumnName("id_Lista");
            modelBuilder.Entity<ListaPrecio>().Property(t => t.Nombre).HasColumnName("ListaPrecio");

            modelBuilder.Entity<Localidad>().ToTable("LOCALIDADES");
            modelBuilder.Entity<Localidad>().Property(t => t.Id).HasColumnName("id_Localidad");
            modelBuilder.Entity<Localidad>().Property(t => t.IdDepartamente).HasColumnName("id_Departamento");
            
            modelBuilder.Entity<Provincia>().ToTable("PROVINCIAS");
            modelBuilder.Entity<Provincia>().Property(t => t.Id).HasColumnName("id_Provincia");

            modelBuilder.Entity<IVA>().ToTable("NUEVA_IVA");
            modelBuilder.Entity<IVA>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            base.OnModelCreating(modelBuilder);
        }
    }
}
