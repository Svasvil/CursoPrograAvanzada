using MiPrimeraSolucion.abstraccion.DataAcces.Clientes.AgregarCliente;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Clientes;
using MiPrimeraSolucionAceesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucionAceesoDatos.Clientes.AgregarCliente
{
    public class AgregarClienteBaseDatos : IAgregarClienteAD
    {
        private ObjetoContexto _Contexto;
        public AgregarClienteBaseDatos()
        {
            _Contexto = new ObjetoContexto();
        }


        public async Task<int> Agregar(ClientesDTO elClienteParaGuardar)
        {
            int cantidadDeFilasAfectadas = 0;
            ClientesAD clienteEnEntidad = ConvertirADominio(elClienteParaGuardar);

            _Contexto.Clientes.Add(clienteEnEntidad);
            cantidadDeFilasAfectadas = await _Contexto.SaveChangesAsync();
            return cantidadDeFilasAfectadas;
        }

        public ClientesAD ConvertirADominio(ClientesDTO elClienteParaGuardar)
        {
            return new ClientesAD
            {
                Nombre = elClienteParaGuardar.Nombre,
                PrimerApellido = elClienteParaGuardar.PrimerApellido,
                SegundoApellido = elClienteParaGuardar.SegundoApellido,
                Telefono = elClienteParaGuardar.Telefono,
                Correo = elClienteParaGuardar.Correo,
                fechaDeRegistro = elClienteParaGuardar.fechaDeRegistro,
                fechaDeModificacion = elClienteParaGuardar.fechaDeRegistro,
                estado = elClienteParaGuardar.estado
            };
        }
    }
}
