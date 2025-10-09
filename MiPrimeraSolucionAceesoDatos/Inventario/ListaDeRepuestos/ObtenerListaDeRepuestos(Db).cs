using MiPrimeraSolucion.abstraccion.DataAcces.Inventario.ListaDeRepuestos;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucionAceesoDatos.Inventario.ListaDeRepuestos{
    public class ObtenerListaDeRepuestos_Db_ : IObtenerListaDeRepuestos_Db_
    {
        private ObjetoContexto contexto; //Creamos una variable de tipo ObjetoContexto , el cual es el que nos va a ayudar a comunicarnos con la base de datos.

        public ObtenerListaDeRepuestos_Db_()
        {
            contexto = new ObjetoContexto(); //Instanciamos el objeto contexto , para poder utilizarlo.
        }
        public List<InventarioDTO> Obtener()
        {
            List<InventarioDTO> laListaDeInventario = (from inventario in contexto.Inventario //Aqui le decimos que de la variable contexto , de la propiedad inventarios (la cual es el DbSet que creamos en el ObjetoContexto)
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
                                                       }).ToList();
            return laListaDeInventario;
        }
    }


}
