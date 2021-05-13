using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class ClsDUsuario
    {
        public List<tb_usuario> CargarDatos() {

            List<tb_usuario> lista = new List<tb_usuario>();

            using (sistema_ventasEntities db = new sistema_ventasEntities()) {
                lista = db.tb_usuario.ToList();
            }
            return lista;
        }
        
        public void AgregarUsuario(tb_usuario tbParametro) {

            tb_usuario tb = new tb_usuario();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb.email = tbParametro.email;
                tb.contrasena = tbParametro.contrasena;
                db.tb_usuario.Add(tb);
                db.SaveChanges();
            }
        }

        public void ModificarUsuario(tb_usuario tbParametro) {

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                int update = tbParametro.iDUsuario;
                tb_usuario tb = db.tb_usuario.Where(x => x.iDUsuario == update).Select(x => x).FirstOrDefault();
                tb.email = tbParametro.email;
                tb.contrasena = tbParametro.contrasena;
                db.SaveChanges();
            }
        }

        public void EliminarUsuario(tb_usuario tbParametro) {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tbParametro = db.tb_usuario.Find(tbParametro.iDUsuario);
                db.tb_usuario.Remove(tbParametro);
                
                db.SaveChanges();
            }
        }
    }
}
