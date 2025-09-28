using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario
{
    public class InventarioDTO
    {
        public string codigoDelRepuesto { get; set; }
        public string nombreDelRepuesto { get; set; }
        public string marcaDelRepuesto { get; set; }
        public string vehiculo { get; set; }
        public string modelo { get; set; }
        public int anio { get; set; }
        public int cantidad { get; set; }
        public DateTime fechaDeRegistro { get; set; }
        public DateTime fechaDeModificacion { get; set; }
        public bool estado { get; set; }
        


    }
}
