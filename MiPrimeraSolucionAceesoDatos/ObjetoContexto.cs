using MiPrimeraSolucionAceesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucionAceesoDatos
{
    public class ObjetoContexto : DbContext
    {
        public ObjetoContexto() 
        {
            Database.SetInitializer<ObjetoContexto>(null);
        }

        public DbSet<Inventario_BaseDatos_> Inventario { get; set; }
        public DbSet<ClientesAD> Clientes { get; set; }
    }
}