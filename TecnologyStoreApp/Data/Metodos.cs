using Microsoft.EntityFrameworkCore;

namespace TecnologyStoreApp.Data
{
    public class Metodos
    {
        //Leer Detalles de Factura
        public async Task<List<DetallesFactura>> GetDetallesFacturaAsync()
        {
            try
            {
                using (var db = new Context())
                {
                    return await db.DetallesFacturas.ToListAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Insertar Detalles de Factura
        public async Task InsertarDetallesFacturaAsync(DetallesFactura detallesFactura)
        {
            try
            {
                using (var db = new Context())
                {
                    db.DetallesFacturas.Add(detallesFactura);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Eliminar Detalles de Factura por ID
        public async Task EliminarDetallesFacturaAsync(int id)
        {
            try
            {
                using (var db = new Context())
                {
                    var detallesFactura = await db.DetallesFacturas.FindAsync(id);
                    if (detallesFactura != null)
                    {
                        db.DetallesFacturas.Remove(detallesFactura);
                        await db.SaveChangesAsync();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Actualizar Detalles de Factura
        public async Task ActualizarDetallesFacturaAsync(int id, DetallesFactura detallesFacturaActualizado)
        {
            try
            {
                using (var db = new Context())
                {
                    var detallesFactura = await db.DetallesFacturas.FindAsync(id);
                    if (detallesFactura != null)
                    {
                        detallesFactura.nombreCliente = detallesFacturaActualizado.nombreCliente;
                        detallesFactura.direccionEntrega = detallesFacturaActualizado.direccionEntrega;
                        detallesFactura.nombreProductoSeleccionado = detallesFacturaActualizado.nombreProductoSeleccionado;
                        detallesFactura.colorSeleccionado = detallesFacturaActualizado.colorSeleccionado;
                        detallesFactura.cantidadSeleccionada = detallesFacturaActualizado.cantidadSeleccionada;
                        detallesFactura.precioProductoSeleccionado = detallesFacturaActualizado.precioProductoSeleccionado;
                        detallesFactura.totalApagar = detallesFacturaActualizado.totalApagar;
                        detallesFactura.metodoPago = detallesFacturaActualizado.metodoPago;
                        await db.SaveChangesAsync();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

