using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.abstraccion.DataAcces.Inventario.ListaDeRepuestos
{
    public  interface IObtenerListaDeRepuestos_Db_{
        //Creamos una intefaz con un metodo vacio , el cual vamos a implementar en la clase ObtenerListaDeRepuestos_Db_ que esta en la carpeta de Acceso a datos.
        List<InventarioDTO> Obtener(); 

    }
}
