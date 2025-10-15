using MiPrimeraSolucionAceesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucionAceesoDatos.Inventario.EliminarRepuesto
{
    public class EliminarRespuesto {
        private ObjetoContexto objetoContexto;
    


        public int Eliminar(int idDelRepuestoAEliminar)
        {
            int cantidadDeFilasAfectadas = 0;
            Inventario_BaseDatos_ elRepuestoEnBaseDeDatos = objetoContexto.Inventario
                .Where(inventarioABuscar => inventarioABuscar.id == idDelRepuestoAEliminar).FirstOrDefault();
            if (elRepuestoEnBaseDeDatos != null)
            {
                objetoContexto.Inventario.Remove(elRepuestoEnBaseDeDatos);
                cantidadDeFilasAfectadas = objetoContexto.SaveChanges();
            }
            return cantidadDeFilasAfectadas;
        }

    }
}