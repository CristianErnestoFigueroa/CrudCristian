using appventas.DAO;
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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        void Cargar()
        {
            dataGridView1.Rows.Clear();
            ClsDCliente cls = new ClsDCliente();

            List<tb_cliente> lista = cls.CargarDatos();

            foreach (var iteracion in lista)
            {
                dataGridView1.Rows.Add(iteracion.iDCliente, iteracion.nombreCliente, iteracion.direccionCliente, iteracion.duiCliente);
            }
        }

        void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtDui.Clear();

        }
        private void frmCliente_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                ClsDCliente cls = new ClsDCliente();
                tb_cliente tb = new tb_cliente();
                tb.nombreCliente = txtNombre.Text;
                tb.direccionCliente = txtDireccion.Text;
                tb.duiCliente = txtDui.Text;
                cls.AgregarCliente(tb);

            }
            else
            {
                ClsDCliente cls = new ClsDCliente();
                tb_cliente tb = new tb_cliente();
                tb.iDCliente = Convert.ToInt32(txtId.Text);
                tb.nombreCliente = txtNombre.Text;
                tb.direccionCliente = txtDireccion.Text;
                tb.duiCliente = txtDui.Text;
                cls.ModificarCliente(tb);
            }

            Cargar();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsDCliente cls = new ClsDCliente();
            tb_cliente tb = new tb_cliente();

            tb.iDCliente = Convert.ToInt32(txtId.Text);

            cls.EliminarCliente(tb);

            Cargar();
            Limpiar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDireccion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDui.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
    
}
