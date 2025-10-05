using MiPrimeraSolucion.abstraccion.DataAcces.Inventario.ListaDeRepuestos;
using MiPrimeraSolucion.abstraccion.LogicaDeNegocio.Inventario.ListaDeRepuestos;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using MiPrimeraSolucionAceesoDatos.Inventario.ListaDeRepuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaNegocio.Inventario.ListaDeRepuestos
{
    // Esta clase se encarga de la lógica de negocio para obtener la lista de repuestos del inventario.
    // Implementa la interfaz IObtenerListaRepuestos_LogicaNegocio_ para cumplir con el contrato definido en la abstracción.
    public class ObtenerListaRepuestos_LogicaNegocio_ : IObtenerListaRepuestos_LogicaNegocio_
    {
        // Creamos una variable privada para acceder a la capa de datos, que nos permite obtener la lista de repuestos desde la base de datos.
        private readonly IObtenerListaDeRepuestos_Db_ obtenerListaDeRepuestos_Db_;

        // Constructor de la clase, donde inicializamos la variable que accede a la base de datos.
        public ObtenerListaRepuestos_LogicaNegocio_()
        {
            obtenerListaDeRepuestos_Db_ = new ObtenerListaDeRepuestos_Db_();
        }

        // Este método retorna una lista de objetos InventarioDTO, que representa la lista de repuestos del inventario.
        // Ahora, en vez de llenar la lista manualmente, se obtiene la lista directamente desde la capa de datos usando el método Obtener de obtenerListaDeRepuestos_Db_.
        // Así, los datos provienen de la fuente real (por ejemplo, una base de datos) y no están quemados en el código.
        public List<InventarioDTO> Obtener()
        {
            List<InventarioDTO> lalistaDeInventario = obtenerListaDeRepuestos_Db_.Obtener();
            return lalistaDeInventario;
        }
    }
}