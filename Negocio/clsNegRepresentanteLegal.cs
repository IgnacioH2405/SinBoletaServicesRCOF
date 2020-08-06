using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
    public class clsNegRepresentanteLegal
    {
        public static List<clsEntRepresentanteLegal> mtdBuscarRepresentanteLegal()
        {
            return clsDatRepresentanteLegal.mtdBuscarRepresentanteLegal();
        }
    }
}
