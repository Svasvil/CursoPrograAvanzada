using MiPrimeraSolucion.abstraccion.LogicaDeNegocio.Inventario.ListaDeRepuestos;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaNegocio.Inventario.ListaDeRepuestos 
{
    public class ObtenerListaRepuestos_LogicaNegocio_ : IObtenerListaRepuestos_LogicaNegocio_
    {
        public List<InventarioDTO> Obtener(){
            List<InventarioDTO> lalistaDeInventario = new List<InventarioDTO>();
            lalistaDeInventario.Add(new InventarioDTO
            {
                codigoDelRepuesto = "001",
                nombreDelRepuesto = "Filtro de aire",
                marcaDelRepuesto = "Bosch",
                vehiculo = "Toyota",
                modelo = "Corolla",
                anio = 2020,
                cantidad = 15,
                estado = true
            });
                        return (lalistaDeInventario);
        }

    }
}

