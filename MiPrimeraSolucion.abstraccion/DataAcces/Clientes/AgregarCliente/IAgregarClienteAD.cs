using MiPrimeraSolucion.abstraccion.ModelosParaUI.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.abstraccion.DataAcces.Clientes.AgregarCliente
{
    public interface IAgregarClienteAD
    {
        Task<int> Agregar(ClientesDTO elClienteParaGuardar);
    }
}
