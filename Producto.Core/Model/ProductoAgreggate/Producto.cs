using Common.Core.Exceptions;
using Common.Core.Model;
using Common.Core.Model.ValueObjects;
using System;
using System.Collections.Generic;

namespace Producto.Core.Model.ProductoAgreggate
{
    public class Producto : Entity<int>
    {
        public int? IdCategoria { get; protected set; }
        public virtual Categoria Categoria { get; protected set; }
        public int? IdSubcategoria { get; protected set; }
        public virtual SubCategoria Subcategoria { get; protected set; }
        public int? IdProveedor { get; protected set; }
        public virtual Proveedor Proveedor { get; protected set; }
        public virtual IList<Precio> Precios { get; protected set; }
        public string Nombre { get; protected set; }
        public string Descripcion { get; protected set; }
        public decimal Costo { get; protected set; }
        public string Origen { get; protected set; }
        public string Tamanio { get; protected set; }
        public string Codigo { get; protected set; }
        public string CodigoBarra { get; protected set; }
        public string Foto { get; protected set; }
        public DateTime Fecha { get; protected set; }
        public bool Habilitado { get; protected set; }
        public bool Novedad { get; protected set; }
        public bool SubirWeb { get; protected set; }

        //Volumen del producto
        public int? UCBM { get; protected set; }

        //Claisficación Aduanera
        public string DoG { get; protected set; }

        //Precio de origen en USD
        public decimal? FOBUSD { get; protected set; }

        //Precio de origen en RMB(yuanes chinos)
        public decimal? FOBRMB { get; protected set; }

        //Cantidad de unidades que vienen en una caja
        public int? Packing { get; protected set; }

        //Cantidad de unidades que vienen en una caja chica
        public int? InPacking { get; protected set; }

        //Peso bruto del producto
        public decimal? UGW { get; protected set; }

        //Peso neto del producto
        public decimal? UNW { get; protected set; }

        //Tamaño de la caja
        public Tamanio BoxSize { get; protected set; }

        //Medida del producto
        public Tamanio ProductSize { get; protected set; }

        //Posición Arancelaria aduanera
        public string NCM { get; protected set; }

        //Código de Seguridad Eléctrica
        public string Modelo { get; protected set; }

        //Código del artículo del proveedor
        public string SupplierProductCode { get; protected set; }

        public int? IdSupplier { get; protected set; }

        //Proveedor del exterior
        public virtual Supplier Supplier { get; protected set; }

        public int? IdColor { get; protected set; }

        //Color del producto
        public virtual Color Color { get; protected set; }

        public int? IdProductType { get; protected set; }

        //Tipo de Producto
        public virtual TipoProducto ProductType { get; protected set; }

        //Cantidad de luces de una lámpara
        public int? QtyOfLights { get; protected set; }


        public Producto()
        {
        }

        public Producto(Categoria categoria, SubCategoria subcategoria, Proveedor proveedor, string nombre, string descripcion, decimal costo, string origen, string tamanio, string codigo, string foto, bool habilitado, bool novedad, bool subirWeb, IList<Precio> precios)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new NegocioException("En nombre del producto no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(codigo))
                throw new NegocioException("En código del producto no puede estar vacío.");
            if (precios.Count < 6)
                throw new NegocioException("Debe completar el listado de precios.");

            Categoria = categoria ?? throw new NegocioException("La categoría del producto no puede estar vacío.");
            IdCategoria = categoria.Id;
            Subcategoria = subcategoria ?? throw new NegocioException("En subcategoría del producto no puede estar vacío.");
            IdSubcategoria = subcategoria.Id;
            Proveedor = proveedor ?? throw new NegocioException("El proveedor del producto no puede estar vacío.");
            IdProveedor = proveedor.Id;
            Nombre = nombre;
            Descripcion = descripcion;
            Costo = costo;
            Origen = origen;
            Tamanio = tamanio;
            Codigo = codigo;
            Foto = foto;
            Fecha = DateTime.Now;
            Habilitado = habilitado;
            Novedad = Novedad;
            SubirWeb = SubirWeb;
            Precios = precios;
        }

        public void ActualizarDatos(Categoria categoria, SubCategoria subcategoria, Proveedor proveedor, string nombre, string descripcion, decimal costo, string origen, string tamanio, string codigo, string foto, bool habilitado, bool novedad, bool subirWeb)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new NegocioException("En nombre del producto no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(codigo))
                throw new NegocioException("En código del producto no puede estar vacío.");

            Categoria = categoria ?? throw new NegocioException("La categoría del producto no puede estar vacío.");
            IdCategoria = categoria.Id;
            Subcategoria = subcategoria ?? throw new NegocioException("En subcategoría del producto no puede estar vacío.");
            IdSubcategoria = subcategoria.Id;
            Proveedor = proveedor ?? throw new NegocioException("El proveedor del producto no puede estar vacío.");
            IdProveedor = proveedor.Id;
            Nombre = nombre;
            Descripcion = descripcion;
            Costo = costo;
            Origen = origen;
            Tamanio = tamanio;
            Codigo = codigo;
            Foto = foto;
            Fecha = DateTime.Now;
            Habilitado = habilitado;
            Novedad = Novedad;
            SubirWeb = SubirWeb;
        }

        public void CargarCodigoBarras(int idProducto)
        {
            CodigoBarra = ObtenerCodigoBarras(idProducto);
        }


        private string ObtenerCodigoBarras(int idProducto)
        {
            string codigo = "7791234" + idProducto.ToString().PadLeft(5, '0');
            return codigo + ObtenerCodigoVerificador(codigo);
        }

        private string ObtenerCodigoVerificador(string codigo)
        {
            int num;
            if (codigo == null || codigo.Length != 12)
            {
                throw new ArgumentException("Code length should be 12, i.e. excluding the checksum digit");
            }
            int num1 = 0;
            for (int i = 0; i < 12; i++)
            {
                if (!int.TryParse(codigo[i].ToString(), out num))
                {
                    throw new ArgumentException("Invalid character encountered in specified code.");
                }
                num1 = num1 + (i % 2 == 0 ? num : num * 3);
            }
            return ((10 - num1 % 10) % 10).ToString();
        }
    }
}
