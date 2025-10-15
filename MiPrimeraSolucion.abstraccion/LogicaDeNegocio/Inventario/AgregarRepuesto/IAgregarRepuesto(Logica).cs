using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.abstraccion.LogicaDeNegocio.Inventario.AgregarRepuesto
{
    public interface IAgregarRepuesto_Logica_
    {
        Task<int> Agregar(InventarioDTO elRepuestoParaGuardar);
    }
}

