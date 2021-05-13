using appventas.DAO;
using appventas.VISTAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ClsDAcceso cls = new ClsDAcceso();
            Boolean valor = cls.Acceso(txtUsuario.Text, txtPassword.Text);
            if (valor == true)
            {
                frmMenu frm = new frmMenu();
                //frm.lblNombreUsuario.Text = "Has iniciado sesión como: " + txtUsuario.Text;
                MessageBox.Show("Bienvenido/a");
                
                this.Hide();
                frm.Show();
            }
            else {
                MessageBox.Show("Error");
            }


        }
    }
}
