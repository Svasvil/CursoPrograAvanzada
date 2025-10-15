using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using System.Threading.Tasks;
using MiPrimeraSolucion.abstraccion.DataAcces.Inventario.AgregarRepuesto;
using MiPrimeraSolucionAceesoDatos.Entidades;

namespace MiPrimeraSolucionAceesoDatos.Inventario.AgregarRepuesto
{
    public class AgregarRepuestoBaseDatos : IAgregarRepuestoAD
    {
        private ObjetoContexto _Contexto;

        public AgregarRepuestoBaseDatos()
        {
            _Contexto = new ObjetoContexto();
        }

        public async Task<int> Agregar(InventarioDTO elRepuestoParaGuardar)
        {
            int cantidadDeFilasAfectadas = 0;
            Inventario_BaseDatos_ repuestoEnEntidad = ConvertirADominio(elRepuestoParaGuardar);

            _Contexto.Inventario.Add(repuestoEnEntidad);

            cantidadDeFilasAfectadas = await _Contexto.SaveChangesAsync();

            return cantidadDeFilasAfectadas;
        }

        private Inventario_BaseDatos_ ConvertirADominio(InventarioDTO elRepuestoParaGuardar)
        {
            return new Inventario_BaseDatos_
            {
                anio = elRepuestoParaGuardar.anio,
                cantidad = elRepuestoParaGuardar.cantidad,
                codigoDelRepuesto = elRepuestoParaGuardar.codigoDelRepuesto,
                estado = elRepuestoParaGuardar.estado,
                fechaDeModificacion = elRepuestoParaGuardar.fechaDeModificacion,
                fechaDeRegistro = elRepuestoParaGuardar.fechaDeRegistro,
                marcaDelRepuesto = elRepuestoParaGuardar.marcaDelRepuesto,
                modelo = elRepuestoParaGuardar.modelo,
                nombreDelRepuesto = elRepuestoParaGuardar.nombreDelRepuesto,
                vehiculo = elRepuestoParaGuardar.vehiculo
            };
        }
    }
}