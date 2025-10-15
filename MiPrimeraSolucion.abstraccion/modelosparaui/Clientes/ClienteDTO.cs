using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.abstraccion.ModelosParaUI.Clientes
{
    public class ClientesDTO
    {
   
        public int IDCliente { get; set; }
       

        public string Nombre { get; set; }

        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }

     
        public string Telefono { get; set; }
  

        public string Correo { get; set; }

        public DateTime fechaDeRegistro { get; set; }

        public DateTime? fechaDeModificacion { get; set; }

        public bool estado { get; set; }

        public string IDClienteString => IDCliente.ToString();
        public string EstadoString => estado.ToString();
    }
}