using MiPrimeraSolucion.abstraccion.ModelosParaUI.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.abstraccion.DataAcces.Clientes.ListaDeClientes
{
    public  interface IObtenerListaClientesAD
    {
            List<ClientesDTO> Obtener();
    }
}
