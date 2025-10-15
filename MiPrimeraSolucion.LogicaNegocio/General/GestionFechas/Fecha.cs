using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaNegocio.General.GestionFechas
{
    public class IFecha
    {


        public DateTime ObtenerFecha()
        {
            int zonaHoraria = int.Parse(ConfigurationManager.AppSettings["zonaHoraria"]);
            return DateTime.UtcNow.AddHours(zonaHoraria);
        }

    }
}
