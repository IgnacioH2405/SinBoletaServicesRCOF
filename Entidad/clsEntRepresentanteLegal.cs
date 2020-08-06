using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class clsEntRepresentanteLegal
    {

        private long lintiPersona;
        public long iPersona
        {
            get
            {
                return lintiPersona;
            }
            set
            {
                lintiPersona = value;
            }
        }

        private int lintcRut;
        public int cRut
        {
            get
            {
                return lintcRut;
            }
            set
            {
                lintcRut = value;
            }
        }

        private string strDv;
        public string Dv
        {
            get
            {
                return strDv;
            }
            set
            {
                strDv = value;
            }
        }

        private string strcRutCompleto;
        public string RutCompleto
        {
            get
            {
                return strcRutCompleto;
            }
            set
            {
                strcRutCompleto = value;
            }
        }

        private string strcTrackId;
        public string TrackId
        {
            get
            {
                return strcTrackId;
            }
            set
            {
                strcTrackId = value;
            }
        }
    }
}
