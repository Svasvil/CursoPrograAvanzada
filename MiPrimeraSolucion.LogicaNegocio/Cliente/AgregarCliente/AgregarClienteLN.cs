using MiPrimeraSolucion.abstraccion.DataAcces.Clientes.AgregarCliente;
using MiPrimeraSolucion.abstraccion.LogicaDeNegocio.Cliente.AgregarCliente;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Clientes;
using MiPrimeraSolucion.LogicaNegocio.General.GestionFechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaNegocio.Cliente.AgregarCliente
{
    public  class AgregarClienteLN : IAgregarClienteLN
    {
        private IAgregarClienteAD _agregarClienteAD;
        private IFecha _fecha;
    }

    public AgregarClienteLN() { 
        _agregarClienteAD = new AgregarClienteAD();
            _fecha = new IFecha();
        }

        public async Task<int> Agregar(ClientesDTO elClienteParaGuardar)
        {
            elClienteParaGuardar.fechaDeRegistro = _fecha.ObtenerFecha();
            elClienteParaGuardar.fechaDeModificacion = null;
            elClienteParaGuardar.estado = true;
            int cantidadDeFilasAfectas = await _agregarClienteAD.Agregar(elClienteParaGuardar);
            return cantidadDeFilasAfectas;
        }
    }
