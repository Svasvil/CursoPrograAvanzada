using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucionAceesoDatos.Entidades
{
    [Table("[Clientes]")]
    public class ClientesAD
    {
        [Key] 
        [Column("IDCliente")]
        public int IDCliente { get; set; } 

        [Column("Nombre")]
        public string Nombre { get; set; }

        [Column("PrimerApellido")]
        public string PrimerApellido { get; set; }

        [Column("SegundoApellido")]
        public string SegundoApellido { get; set; }

        [Column("Telefono")]
        public string Telefono { get; set; } 

        [Column("Correo")]
        public string Correo { get; set; }

        [Column("fechaDeRegistro")]
        public DateTime fechaDeRegistro { get; set; }

        [Column("fechaDeModificacion")]
        public DateTime? fechaDeModificacion { get; set; }

        [Column("Estado")]
        public bool estado { get; set; }
    }
}