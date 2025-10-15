using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.abstraccion.DataAcces.Inventario.AgregarRepuesto
{
    public interface IAgregarRepuestoAD
    {
         Task<int> Agregar(InventarioDTO elRepuestoParaGuardar);
    }
}
