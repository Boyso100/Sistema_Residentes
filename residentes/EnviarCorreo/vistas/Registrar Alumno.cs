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
    public partial class frmAgregarAlumno : Form
    {
        public frmAgregarAlumno()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();

            alumno.setMatricula(txtMatricula.Text);
            alumno.setNombre(txtNombre.Text);
            alumno.setApellidoPaterno(txtApellidoP.Text);
            alumno.setApellidoMaterno(txtApellidoM.Text);
            alumno.setEmail(textEmail.Text);
            alumno.setTelefono(textTelefono.Text);
            alumno.setCiudad(ciudad.Text);



            AlumnosDAO daoAlumno = new AlumnosDAO();

            daoAlumno.insertarAlumno(alumno);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
