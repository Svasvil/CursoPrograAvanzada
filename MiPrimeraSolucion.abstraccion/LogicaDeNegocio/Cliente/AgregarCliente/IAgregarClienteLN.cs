using MiPrimeraSolucion.abstraccion.ModelosParaUI.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.abstraccion.LogicaDeNegocio.Cliente.AgregarCliente
{
    public  interface IAgregarClienteLN
    {
    Task<int> Agregar(ClientesDTO elClienteParaGuardar);
    }
}
