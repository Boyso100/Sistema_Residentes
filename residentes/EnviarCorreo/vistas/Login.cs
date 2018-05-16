using EnviarCorreo.Daos;
using EnviarCorreo.Modelos_pojos_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnviarCorreo.vistas
{
    public partial class Login : Form
    {

        Asesor asesor;
        AsesoresDAO asesorDAO;

        public Login()
        {
            InitializeComponent();
            asesor = new Asesor();
            asesorDAO = new AsesoresDAO();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(cboTipoUser.SelectedItem == null || txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Debes especificar todos los datos.");
            }
            else
            {
                if(asesorDAO.obtenerAsesor(txtUser.Text).getUsuario() == txtUser.Text)
                {
                    asesor = asesorDAO.obtenerAsesor(txtUser.Text);
                    frmAsesor asesorForm = new frmAsesor(asesor);
                    Hide();
                    asesorForm.Show();
                }
                else
                {
                    MessageBox.Show("No existe ningún docente con ese nombre de usuario.");
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblRegistroAlumno_Click(object sender, EventArgs e)
        {
            frmAgregarAlumno registrarAlumno = new frmAgregarAlumno();
            Hide();
            registrarAlumno.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
