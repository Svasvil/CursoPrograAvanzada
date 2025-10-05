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
        public ObjetoContexto() : base("ObjetoContexto(BaseDatos)")
        {
            Database.SetInitializer<ObjetoContexto>(null);
        }

        public DbSet<Inventario_BaseDatos_> Inventario { get; set; }
    }