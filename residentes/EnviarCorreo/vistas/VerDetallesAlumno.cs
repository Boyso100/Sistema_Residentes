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
    public partial class VerDetallesAlumno : Form
    {

        Alumno alumno;
        AlumnosDAO obtenerAlumno;

        public VerDetallesAlumno()
        {
            InitializeComponent();
        }

        public VerDetallesAlumno(string matricula, string id_asesor)
        {
            InitializeComponent();
            obtenerAlumno = new AlumnosDAO();
            alumno = obtenerAlumno.seleccionarAlumnoPorMatricula(matricula);
            lblMatricula.Text = matricula;
            lblAsesorId.Text = id_asesor;
            txtNombre.Text = alumno.getNombre();
            txtApellidoP.Text = alumno.getApellidoPaterno();
            txtApellidoM.Text = alumno.getApellidoMaterno();
            txtEmail.Text = alumno.getEmail();
            txtTelefono.Text = alumno.getTelefono();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            AlumnosDAO alumno_dao = new AlumnosDAO();
            alumno = alumno_dao.seleccionarAlumnoPorMatricula(lblMatricula.Text);
            Observacion objObservacion = new Observacion();
            ObservacionesDAO observaciones = new ObservacionesDAO();
            string timestamp;
            timestamp = DateTime.Now.ToString("MM-dd-yyyy");
            objObservacion.setFecha(timestamp);
            objObservacion.setDescripcion(txtObservaciones.Text);
            objObservacion.setMatricula(alumno.getMatricula());
            objObservacion.setIdAsesor(Convert.ToInt32(lblAsesorId.Text));
            observaciones.agregarObservacion(objObservacion);
            MessageBox.Show("Se ha registrado la observación.");
            txtObservaciones.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblVerDocumentos_Click(object sender, EventArgs e)
        {
            frmRevisionDocumentos verDocumentos = new frmRevisionDocumentos();
            verDocumentos.Show();
        }
    }
}
