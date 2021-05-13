using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class ClsDDocumento
    {
        public List<tb_documento> CargarDatos()
        {

            List<tb_documento> lista = new List<tb_documento>();

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                lista = db.tb_documento.ToList();
            }
            return lista;
        }

        public void AgregarDocumento(tb_documento tbParametro)
        {

            tb_documento tb = new tb_documento();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb.nombreDocumento = tbParametro.nombreDocumento;
                db.tb_documento.Add(tb);
                db.SaveChanges();
            }
        }

        public void ModificarDocumento(tb_documento tbParametro)
        {

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                int update = tbParametro.iDDocumento;
                tb_documento tb = db.tb_documento.Where(x => x.iDDocumento == update).Select(x => x).FirstOrDefault();

                tb.nombreDocumento = tbParametro.nombreDocumento;
                db.SaveChanges();
            }
        }

        public void EliminarDocumento(tb_documento tbParametro)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tbParametro = db.tb_documento.Find(tbParametro.iDDocumento);
                db.tb_documento.Remove(tbParametro);

                db.SaveChanges();
            }
        }
    }
}
