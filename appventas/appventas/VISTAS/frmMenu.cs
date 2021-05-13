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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void formCRUDClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void formCRUDUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void formCRUDDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocumento frm = new frmDocumento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void formCRUDProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto frm = new frmProducto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void formularioDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenta frm = new frmVenta();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
