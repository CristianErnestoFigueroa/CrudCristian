using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class ClsDProducto
    {
        public List<tb_producto> CargarDatos()
        {

            List<tb_producto> lista = new List<tb_producto>();

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                lista = db.tb_producto.ToList();
            }
            return lista;
        }

        public void AgregarProducto(tb_producto tbParametro)
        {

            tb_producto tb = new tb_producto();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb.nombreProducto = tbParametro.nombreProducto;
                tb.precioProducto = tbParametro.precioProducto;
                tb.estadoProducto = tbParametro.estadoProducto;
                db.tb_producto.Add(tb);
                db.SaveChanges();
            }
        }

        public void ModificarProducto(tb_producto tbParametro)
        {

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                int update = tbParametro.idProducto;
                tb_producto tb = db.tb_producto.Where(x => x.idProducto == update).Select(x => x).FirstOrDefault();
                tb.nombreProducto = tbParametro.nombreProducto;
                tb.precioProducto = tbParametro.precioProducto;
                tb.estadoProducto = tbParametro.estadoProducto;
                db.SaveChanges();
            }
        }

        public void EliminarProducto(tb_producto tbParametro)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tbParametro = db.tb_producto.Find(tbParametro.idProducto);
                db.tb_producto.Remove(tbParametro);

                db.SaveChanges();
            }
        }
    }
}
