using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using MiPrimeraSolucionAceesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucionAceesoDatos.Inventario.EditarRepuestos
{
    public class EditarRespuesto{

   
     private ObjetoContexto contexto; //Creamos una variable de tipo ObjetoContexto , el cual es el que nos va a ayudar a comunicarnos con la base de datos.
        
       public EditarRespuesto() {
            contexto = new ObjetoContexto();
        }

        public int Editar(InventarioDTO elRepuestoParaGuardar) {

            int CantidadAfectada = 0; //Esta variable nos va a ayudar a saber si se realizo la operacion o no.
            Inventario_BaseDatos_  elInventarioBD = contexto.Inventario
                .Where(InventarioABuscar => 
                InventarioABuscar.id == elRepuestoParaGuardar.id).FirstOrDefault(); //Con este codigo lo que hacemos es buscar en la base de datos el id que nos estan pasando desde la capa de UI , y lo guardamos en la variable elInventarioBD.
           
            
            if (elInventarioBD != null) //Si el inventario no es nulo , quiere decir que encontro el id en la base de datos.
            {
                //Si encontro el id en la base de datos , entonces lo que hacemos es actualizar los campos con los valores que nos estan pasando desde la capa de UI.
                elInventarioBD.codigoDelRepuesto = elRepuestoParaGuardar.codigoDelRepuesto;
                elInventarioBD.nombreDelRepuesto = elRepuestoParaGuardar.nombreDelRepuesto;
                elInventarioBD.marcaDelRepuesto = elRepuestoParaGuardar.marcaDelRepuesto;
                elInventarioBD.vehiculo = elRepuestoParaGuardar.vehiculo;
                elInventarioBD.modelo = elRepuestoParaGuardar.modelo;
                elInventarioBD.anio = elRepuestoParaGuardar.anio;
                elInventarioBD.cantidad = elRepuestoParaGuardar.cantidad;
                elInventarioBD.fechaDeModificacion = elRepuestoParaGuardar.fechaDeModificacion; //Aqui lo que hacemos es actualizar la fecha de modificacion con la fecha actual.
                CantidadAfectada=contexto.SaveChanges(); //Con este codigo lo que hacemos es guardar los cambios en la base de datos.
                
            }
            return CantidadAfectada; //Retornamos la cantidad de filas afectadas, si es 0 quiere decir que no se realizo la operacion, si es 1 quiere decir que si se realizo la operacion.
        }
    }
}
