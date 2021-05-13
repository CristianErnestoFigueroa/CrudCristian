using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class ClsDCliente
    {
        public List<tb_cliente> CargarDatos()
        {

            List<tb_cliente> lista = new List<tb_cliente>();

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                lista = db.tb_cliente.ToList();
            }
            return lista;
        }

        public void AgregarCliente(tb_cliente tbParametro)
        {

            tb_cliente tb = new tb_cliente();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb.nombreCliente = tbParametro.nombreCliente;
                tb.direccionCliente = tbParametro.direccionCliente;
                tb.duiCliente = tbParametro.duiCliente;
                db.tb_cliente.Add(tb);
                db.SaveChanges();
            }
        }

        public void ModificarCliente(tb_cliente tbParametro)
        {

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                int update = tbParametro.iDCliente;
                tb_cliente tb = db.tb_cliente.Where(x => x.iDCliente == update).Select(x => x).FirstOrDefault();

                tb.nombreCliente = tbParametro.nombreCliente;
                tb.direccionCliente = tbParametro.direccionCliente;
                tb.duiCliente = tbParametro.duiCliente;
                db.SaveChanges();
            }
        }

        public void EliminarCliente(tb_cliente tbParametro)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tbParametro = db.tb_cliente.Find(tbParametro.iDCliente);
                db.tb_cliente.Remove(tbParametro);

                db.SaveChanges();
            }
        }
    }
}
