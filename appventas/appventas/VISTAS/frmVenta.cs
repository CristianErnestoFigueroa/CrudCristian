using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas.VISTAS
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities()){
                var consultaCliente = db.tb_cliente.ToList();
                cbxCliente.DataSource = consultaCliente;
                //Mostrar miembros de la db, mostramos los nombres de los clientes.
                cbxCliente.DisplayMember = "nombreCliente";
                cbxCliente.ValueMember = "iDCliente";

                var consultaDocumento = db.tb_documento.ToList();
                cbxCliente.DataSource = consultaDocumento;
                cbxCliente.DisplayMember = "nombreDocumento";
                cbxCliente.ValueMember = "iDDocumento";
            }
        }
    }
}
