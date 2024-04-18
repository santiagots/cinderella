using Comex.Core.Model.ValueObjects;
using Common.Core.Model;

namespace Comex.Core.Model.ComexAggregate
{
    public class Producto : Entity<int>
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        //Volumen del producto
        public int UCBM { get; protected set; }
        //Claisficación Aduanera
        public string DoG { get; protected set; }
        //Precio de origen en USD
        public decimal FOBUSD { get; protected set; }
        //Precio de origen en RMB(yuanes chinos)
        public decimal FOBRMB { get; protected set; }
        //Cantidad de unidades que vienen en una caja
        public int Packing { get; protected set; }
        //Cantidad de unidades que vienen en una caja chica
        public int InPacking { get; protected set; }
        //Peso bruto del producto
        public decimal UGW { get; protected set; }
        //Peso neto del producto
        public decimal UNW { get; protected set; }
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
        public int QtyOfLights { get; protected set; }
    }
}
