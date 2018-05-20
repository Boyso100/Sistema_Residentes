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
        AlumnosDAO alumnosDao;
        public Login()
        {
            InitializeComponent();
            asesor = new Asesor();
            asesorDAO = new AsesoresDAO();
            alumnosDao = new AlumnosDAO();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(cboTipoUser.SelectedItem == null || txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Debes especificar todos los datos.");
            }
            else
            {
                if (cboTipoUser.SelectedItem.ToString() == "Docente")
                {
                    if (asesorDAO.obtenerAsesor().getUsuario() == txtUser.Text && asesorDAO.obtenerAsesor().getPassword() == txtPassword.Text)
                    {
                        asesor = asesorDAO.obtenerAsesor();
                        frmAsesor asesorForm = new frmAsesor(asesor);
                        Hide();
                        asesorForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }

                }

                //-------------------------------------------

                if (cboTipoUser.SelectedItem.ToString() == "Alumno")
                {
                    if (alumnosDao.seleccionarAlumnoPorMatricula().getUsuario() == txtUser.Text && alumnosDao.seleccionarAlumnoPorMatricula().getPassword() == txtPassword.Text)
                    {

                        Principal_alumnos Palumnos = new Principal_alumnos();
                        Hide();
                        Palumnos.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
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
