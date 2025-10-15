using MiPrimeraSolucion.abstraccion.DataAcces.Inventario.AgregarRepuesto;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucionAceesoDatos.Inventario.ObtenerRepuestoID
{
    public class BuscarRepuestoID : IAgregarRepuestoAD
    {

        private ObjetoContexto contexto; //Creamos una variable de tipo ObjetoContexto , el cual es el que nos va a ayudar a comunicarnos con la base de datos.
        public BuscarRepuestoID() { contexto = new ObjetoContexto(); }

        public Task<int> Agregar(InventarioDTO elRepuestoParaGuardar)
        {
            throw new NotImplementedException();
        }

        public InventarioDTO Obtener(int IdRepuesto)
        {
            InventarioDTO ElRepuestoEnBaseDatos = (from inventario in contexto.Inventario //Aqui le decimos que de la variable contexto , de la propiedad inventarios (la cual es el DbSet que creamos en el ObjetoContexto)
                                                   where inventario.id == IdRepuesto //Aqui le decimos que solo queremos el inventario que tenga el id que nos estan pasando por parametro
                                                   select new InventarioDTO //Creamos un nuevo objeto de tipo InventarioDTO (el cual es el que vamos a retornal luego) ademas , esto es como un slect de db 
                                                   {
                                                       id = inventario.id, //Basicamente estamos diciendo que cada parte del InventarioDTO va a ser igual a la parte del inventario que estamos obteniendo de la base de datos., Lo igualamos por decirlo asi 
                                                       nombreDelRepuesto = inventario.nombreDelRepuesto,
                                                       marcaDelRepuesto = inventario.marcaDelRepuesto,
                                                       vehiculo = inventario.vehiculo,
                                                       modelo = inventario.modelo,
                                                       anio = inventario.anio,
                                                       cantidad = inventario.cantidad,
                                                       fechaDeRegistro = inventario.fechaDeRegistro,
                                                       fechaDeModificacion = inventario.fechaDeModificacion,
                                                       estado = inventario.estado

                                                   }).FirstOrDefault();

            return ElRepuestoEnBaseDatos;
        }
    }
}