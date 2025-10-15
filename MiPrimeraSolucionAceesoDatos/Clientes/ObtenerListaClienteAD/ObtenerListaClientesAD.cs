using MiPrimeraSolucion.abstraccion.DataAcces.Clientes.ListaDeClientes;
using MiPrimeraSolucion.abstraccion.DataAcces.Inventario.ListaDeRepuestos;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucionAceesoDatos.Clientes.ObtenerListaClienteAD
{
    public class ObtenerListaClientesAD : IObtenerListaClientesAD
    {
        private ObjetoContexto _objetoContexto; // Aquí se declara

 
        public ObtenerListaClientesAD()
        {
       
            _objetoContexto = new ObjetoContexto();
        }

        public List<ClientesDTO> Obtener()
        {
           
            List<ClientesDTO> ListaClientes = (from Clientes in _objetoContexto.Clientes
                                               select new ClientesDTO
                                               {
                                                   IDCliente = Clientes.IDCliente,
                                                   Nombre = Clientes.Nombre,
                                                   PrimerApellido = Clientes.PrimerApellido,
                                                   SegundoApellido = Clientes.SegundoApellido,
                                                   Telefono = Clientes.Telefono,
                                                   Correo = Clientes.Correo,
                                                   estado = Clientes.estado
                                               }).ToList();

            return ListaClientes;

        }
    }
}