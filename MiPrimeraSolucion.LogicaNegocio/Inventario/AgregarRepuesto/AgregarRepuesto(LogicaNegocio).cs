using MiPrimeraSolucion.abstraccion.DataAcces.Inventario.AgregarRepuesto;
using MiPrimeraSolucion.abstraccion.LogicaDeNegocio.Inventario.AgregarRepuesto;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using MiPrimeraSolucion.LogicaNegocio.General.GestionFechas;
using MiPrimeraSolucionAceesoDatos.Inventario.AgregarRepuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaNegocio.Inventario.AgregarRepuesto
{
    public class AgregarRepuesto_LogicaNegocio_ : IAgregarRepuesto_Logica_
    {

        private IAgregarRepuestoAD _AgregarRepuestoAD;
        private IFecha _fecha;

        public AgregarRepuesto_LogicaNegocio_() {
            _AgregarRepuestoAD = new AgregarRepuestoBaseDatos();
            _fecha = new IFecha();
        }


        public async Task<int> Agregar(InventarioDTO elRepuestoParaGuardar)
        {
            elRepuestoParaGuardar.fechaDeRegistro = _fecha.ObtenerFecha();
            elRepuestoParaGuardar.fechaDeModificacion = null;
            elRepuestoParaGuardar.estado = true;
            int cantidadDeFilasAfectas = await _AgregarRepuestoAD.Agregar(elRepuestoParaGuardar);
            return cantidadDeFilasAfectas;
        }


    }
}
