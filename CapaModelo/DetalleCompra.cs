using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public int IdCompra { get; set; }
        public Producto oProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitarioCompra { get; set; }
        public float TextoPrecioUnitarioCompra { get; set; }
        public float PrecioUnitarioVenta { get; set; }
        public float TextoPrecioUnitarioVenta { get; set; }
        public decimal TotalCosto { get; set; }
        public decimal TextoTotalCosto { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
