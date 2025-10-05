using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiPrimeraSolucionAceesoDatos.Entidades
{

    [Table("INVENTARIO")] //Con esta anotacion lo que estamos haciendo es decirle que vamos a utilizar la tabla de Inventario que creamos 
    public  class Inventario_BaseDatos_
    {

        //todo este codigo es un copy paste de la parte de InventarioDTO.cs que esta en la carpeta de modelos para UI. el cual nos ayuda a "setear" las variables que vamos a utilizar en la base de datos
        
        
        [Column("ID")] //Esta anotacion lo que hace es decirle aa cual va asociedad cada parte con la columna de la base de datos, ya que tienen nombres diferentes.
        public int id { get; set; }
        [Column("CODIGO_DEL_REPUESTO")]
        public string codigoDelRepuesto { get; set; }
        [Column("NOMBRE_DEL_REPUESTO")]
        public string nombreDelRepuesto { get; set; }
        [Column("MARCA_DEL_REPUESTO")]
        public string marcaDelRepuesto { get; set; }
        [Column("VEHICULO")]
        public string vehiculo { get; set; }
        [Column("MODELO")]
        public string modelo { get; set; }
        [Column("ANIO")]
        public int anio { get; set; }
        [Column("CANTIDAD")]
        public int cantidad { get; set; }
        [Column("FECHA_DE_REGISTRO")]
        public DateTime fechaDeRegistro { get; set; }
        [Column("FECHA_DE_MODIFICION")]
        public DateTime? fechaDeModificacion { get; set; } // Este "? " nos ayuda a que pueda aceptar nulos.
        [Column("ESTADO")]
        public bool estado { get; set; }


        //En caso de que se llamen iguales no es necesario poner la anotacion [Column("NOMBRE_DE_LA_COLUMNA")] , puesto que automaticamente lo mapea a la columna que tiene el mismo nombre.
    }
}
