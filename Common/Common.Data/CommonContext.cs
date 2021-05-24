using Common.Core.Enum;
using Common.Core.Exceptions;
using Common.Core.Helper;
using Common.Core.Interfaces;
using Common.Core.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

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
        public DbSet<CuentaBancaria> CuentaBancaria { get; set; }
        public DbSet<ClienteMayorista> ClienteMayorista { get; set; }
        public DbSet<Feriado> Feriado { get; set; }
        public DbSet<Domicilio> Domicilio { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Distrito> Distrito { get; set; }
        public DbSet<ListaPrecio> ListaPrecio { get; set; }
        public DbSet<Localidad> Localidad { get; set; }
        public DbSet<IVA> IVA { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

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
                this.Entry(entity).State = EntityState.Modified;

            return GetAttached(entity);
        }

        public void AttachRecursive<T>(Entity<T> entity)
        {
            List<object> entitys = GetAllEntitys(entity, new List<object>());

            object uniqueEntity = SetEntitys(entity, entitys, new List<object>());

            this.Entry(uniqueEntity).State = GetState(((IEntity)entity).EstadoEntidad);

            foreach (var item in ChangeTracker.Entries())
            {
                item.State = GetState(((IEntity)item.Entity).EstadoEntidad);
            }
        }

        public List<object> GetAllEntitys(object entity, List<object> entitys)
        {
            //Si la entidad es null o si ya esta agregada en el listado retrno la lista.
            if (entity == null || entitys.Any(x =>  Equals(x, entity))) return entitys;

            //Si la entidad es una clase y tiene la propiedad ID la agrego a la lista.
            if (entity.GetType().IsClass && entity.GetType().GetProperty("Id") != null)
                entitys.Add(entity);

            //Reviso las propiedades de la entidad para agregar las entidades hijas
            PropertyInfo[] properties = entity.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                //Si la propiedad es del tipo Enumerado
                if (property.PropertyType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(property.PropertyType))
                {
                    IList list = property.GetValue(entity, null) as IList;

                    if (list == null) return entitys;

                    //Recorro el enumerado obteniendo todas las entiedades hijas
                    foreach (object item in list)
                        GetAllEntitys(item, entitys);
                }
                //Si la propiedad es una clase y tiene la propiedad ID
                if (property.PropertyType.IsClass && property.PropertyType.GetProperty("Id") != null)
                {
                    object value = property.GetValue(entity, null);
                    //Obteniendo todas las entiedades hijas
                    GetAllEntitys(value, entitys);
                }
            }

            return entitys;
        }

        public object SetEntitys(object entity, List<object> entitys, List<object> entitysProcessed)
        {
            //Si la entidad es null o si ya esta agregada en el listado retrno la lista.
            if ((entity == null || entitysProcessed.Any(x => ReferenceEquals(x, entity)))) 
                return entity;

            entitysProcessed.Add(entity);

            //Reviso las propiedades de la entidad para agregar las entidades hijas
            PropertyInfo[] properties = entity.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(entity, null);

                //Si la propiedad es del tipo Enumerado
                if (property.PropertyType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(property.PropertyType))
                {
                    IList list = property.GetValue(entity, null) as IList;

                    if (list == null) return null;

                    //Recorro el enumerado obteniendo todas las entiedades hijas
                    foreach (object item in list)
                        SetEntitys(item, entitys, entitysProcessed);
                }
                //Si la propiedad es una clase y tiene la propiedad ID
                if (property.PropertyType.IsClass && property.PropertyType.GetProperty("Id") != null)
                {
                    //Obteniendo todas las entiedades hijas
                    SetEntitys(value, entitys, entitysProcessed);

                    //Actualizo la referencia de la propiedad a una misma entidad
                    object referenceIqualsEntity = entitys.FirstOrDefault(x => x.Equals(value));
                    property.SetValue(entity, referenceIqualsEntity);
                }
            }

            return entity;
        }

        private EntityState GetState(EstadoEntidad estado)
        {
            switch (estado) 
            {
                case EstadoEntidad.SinCambios: return EntityState.Unchanged;
                case EstadoEntidad.Nuevo: return EntityState.Added;
                case EstadoEntidad.Borrado: return EntityState.Deleted;
                case EstadoEntidad.Modificado: return EntityState.Modified;
                default:
                    throw new InvalidOperationException($"El tipo de datos {estado} no pudo ser convertido.");
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Banco>().ToTable("BANCOS");
            modelBuilder.Entity<Banco>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Banco>().Property(t => t.Id).HasColumnName("BancoId");

            modelBuilder.Entity<CuentaBancaria>().ToTable("NUEVA_CUENTABANCARIA");
            modelBuilder.Entity<CuentaBancaria>().HasRequired(v => v.Banco).WithMany().HasForeignKey(x => x.IdBanco);

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

            modelBuilder.Entity<Usuario>().ToTable("USUARIOS");
            modelBuilder.Entity<Usuario>().Property(t => t.Id).HasColumnName("id_Usuario");
            modelBuilder.Entity<Usuario>().Property(t => t.UsuarioNombre).HasColumnName("Usuario");
            modelBuilder.Entity<Usuario>().Property(t => t.Password).HasColumnName("PWD");
            modelBuilder.Entity<Usuario>().Property(t => t.Nombre).HasColumnName("Nombre");
            modelBuilder.Entity<Usuario>().Property(t => t.Apellido).HasColumnName("Apellido");
            modelBuilder.Entity<Usuario>().Property(t => t.Mail).HasColumnName("Mail");
            modelBuilder.Entity<Usuario>().Property(t => t.Fecha).HasColumnName("Fecha");
            modelBuilder.Entity<Usuario>().Property(t => t.Habilitado).HasColumnName("Habilitado");
            modelBuilder.Entity<Usuario>().Property(t => t.IdPerfil).HasColumnName("id_Perfil");

            base.OnModelCreating(modelBuilder);
        }
    }
}
