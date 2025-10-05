using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.abstraccion.LogicaDeNegocio.Inventario.ListaDeRepuestos
{
    public  interface IObtenerListaRepuestos_LogicaNegocio_{
        List<InventarioDTO> Obtener();


  }
}
