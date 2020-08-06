using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;


namespace Datos
{
    public class clsDatRepresentanteLegal
    {
        public static List<clsEntRepresentanteLegal> mtdBuscarRepresentanteLegal()
        {
            DataSet ds = null;

            clsAcceso conexion = new clsAcceso();

            List<SqlParameter> parametros = null;
            List<clsEntRepresentanteLegal> objEntRepresentanteLegalCollection = null;
            clsEntRepresentanteLegal objEntRepresentanteLegal = null;

            try
            {

                ds = conexion.ExecutarSP("[own_BE].[PRC_slcBEADM_EstadoRCOF]", parametros);

                objEntRepresentanteLegalCollection = new List<clsEntRepresentanteLegal>();
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        objEntRepresentanteLegal = new clsEntRepresentanteLegal();

                        objEntRepresentanteLegal.iPersona = Convert.ToInt64(row["iPersona"]);
                        objEntRepresentanteLegal.cRut = Convert.ToInt32(row["cRut"].ToString());
                        objEntRepresentanteLegal.Dv= row["Dv"].ToString();
                        objEntRepresentanteLegal.RutCompleto = row["cRut"].ToString() + "-" + row["Dv"].ToString();
                        objEntRepresentanteLegal.TrackId = row["iTrackID"].ToString();

                        objEntRepresentanteLegalCollection.Add(objEntRepresentanteLegal);
                        objEntRepresentanteLegal = null;
                    }

                }
                return objEntRepresentanteLegalCollection;

            }
            catch (Exception e)
            {
                return new List<clsEntRepresentanteLegal>();
            }
            finally
            {
                parametros = null;
                ds = null;
                objEntRepresentanteLegal = null;


            }

        }
    }
}
