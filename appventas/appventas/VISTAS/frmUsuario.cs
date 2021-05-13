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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        void Cargar() {
            dataGridView1.Rows.Clear();
            ClsDUsuario cls = new ClsDUsuario();

            List<tb_usuario> lista = cls.CargarDatos();

            foreach (var iteracion in lista){
                dataGridView1.Rows.Add(iteracion.iDUsuario, iteracion.email, iteracion.contrasena);
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            Cargar();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                ClsDUsuario cls = new ClsDUsuario();
                tb_usuario tb = new tb_usuario();
                tb.email = txtEmail.Text;
                tb.contrasena = txtPassword.Text;
                cls.AgregarUsuario(tb);

            }
            else {
                ClsDUsuario cls = new ClsDUsuario();
                tb_usuario tb = new tb_usuario();
                tb.iDUsuario = Convert.ToInt32(txtId.Text);
                tb.email = txtEmail.Text;
                tb.contrasena = txtPassword.Text;
                cls.ModificarUsuario(tb);
            }

            Cargar();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsDUsuario cls = new ClsDUsuario();
            tb_usuario tb = new tb_usuario();

            tb.iDUsuario = Convert.ToInt32(txtId.Text);
           
            cls.EliminarUsuario(tb);

            Cargar();
            Limpiar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        void Limpiar() {
            txtId.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }
    }
}
