using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario
{
    public class InventarioDTO
    {
        [Display(Name ="Codigo Repuesto.")] //Este display es para mostrar un texto en vez de la variable como tal , si vemos la variable no tiene espacions minetras que este texto si                       
        [Required] // Esto es para que el campo sea obligatorio 
        [MinLength(4)] // Esto es para que el campo tenga un minimo de caracteres, en este caso de cuatro caracteres.
        public string codigoDelRepuesto { get; set; }


        [Display(Name = "Nombre del  Repuesto.")] //Este display es para mostrar un texto en vez de la variable como tal , si vemos la variable no tiene espacions minetras que este texto si                       
        [Required] // Esto es para que el campo sea obligatorio 
       
        public string nombreDelRepuesto { get; set; }


        [Display(Name = "Marca del  Repuesto.")] //Este display es para mostrar un texto en vez de la variable como tal , si vemos la variable no tiene espacions minetras que este texto si                       
        [Required] // Esto es para que el campo sea obligatorio 
      
        public string marcaDelRepuesto { get; set; }


        [Display(Name = "Vehichulo ")] //Este display es para mostrar un texto en vez de la variable como tal , si vemos la variable no tiene espacions minetras que este texto si                       
        [Required] // Esto es para que el campo sea obligatorio 
        public string vehiculo { get; set; }

        [Display(Name = "modelo  Repuesto.")] //Este display es para mostrar un texto en vez de la variable como tal , si vemos la variable no tiene espacions minetras que este texto si                       
        [Required] // Esto es para que el campo sea obligatorio 
        
        public string modelo { get; set; }

        [Display(Name = "anio del  Repuesto.")] //Este display es para mostrar un texto en vez de la variable como tal , si vemos la variable no tiene espacions minetras que este texto si                       
        [Required] // Esto es para que el campo sea obligatorio 
        public int anio { get; set; }


        [Display(Name = "Cantidad.")] //Este display es para mostrar un texto en vez de la variable como tal , si vemos la variable no tiene espacions minetras que este texto si                       
        [Required] // Esto es para que el campo sea obligatorio 
        [MinLength(1)] // Esto es para que el campo tenga un minimo de caracteres, en este caso de cuatro caracteres.
        public int cantidad { get; set; }

        [Display(Name = "Fecha del Registro.")] //Este display es para mostrar un texto en vez de la variable como tal , si vemos la variable no tiene espacions minetras que este texto si                       
        [Required] // Esto es para que el campo sea obligatorio 
      
        public DateTime fechaDeRegistro { get; set; }

        [Display(Name = "Fecha de la modificacion.")] //Este display es para mostrar un texto en vez de la variable como tal , si vemos la variable no tiene espacions minetras que este texto si                       
        [Required] // Esto es para que el campo sea obligatorio 
        [MinLength(4)] // Esto es para que el campo tenga un minimo de caracteres, en este caso de cuatro caracteres.
        public DateTime fechaDeModificacion { get; set; }

        [Display(Name = "Estado")] //Este display es para mostrar un texto en vez de la variable como tal , si vemos la variable no tiene espacions minetras que este texto si                       
        [Required] // Esto es para que el campo sea obligatorio 
        public bool estado { get; set; }



    }
}
