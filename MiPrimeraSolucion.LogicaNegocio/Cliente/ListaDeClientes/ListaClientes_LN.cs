using MiPrimeraSolucion.abstraccion.DataAcces.Clientes.ListaDeClientes;
using MiPrimeraSolucion.abstraccion.DataAcces.Inventario.ListaDeRepuestos;
using MiPrimeraSolucion.abstraccion.LogicaDeNegocio.Cliente.ListaDeClientes;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Clientes;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using MiPrimeraSolucionAceesoDatos.Clientes.ObtenerListaClienteAD;
using MiPrimeraSolucionAceesoDatos.Inventario.ListaDeRepuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaNegocio.Cliente.ListaDeClientes
{
    public class ListaClientes_LN : IListaClientes_LN
    {
        private readonly IObtenerListaClientesAD _obtenerListaDeClientesAD;

        public ListaClientes_LN()
        {
            _obtenerListaDeClientesAD = new ObtenerListaClientesAD();
        }

        public List<ClientesDTO> Obtener()
        {
            List<ClientesDTO> ListaClientes = _obtenerListaDeClientesAD.Obtener();
            return ListaClientes;
        }
    }
}
