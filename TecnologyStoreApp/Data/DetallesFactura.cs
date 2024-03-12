using System.ComponentModel.DataAnnotations;

namespace TecnologyStoreApp.Data
{
    public class DetallesFactura
    {
        [Key]
        public int FacturaId { get; set; }
        public string nombreCliente { get; set; }
        public string direccionEntrega { get; set; }
        public string nombreProductoSeleccionado { get; set; }

        public string colorSeleccionado { get; set; }
        public int cantidadSeleccionada { get; set; }
        public decimal precioProductoSeleccionado { get; set; }
        public decimal totalApagar { get; set; }

        public string metodoPago { get; set; }

    }
}
