using EnviarCorreo.Daos;
using EnviarCorreo.Modelos_pojos_;
using System;
using System.Collections;
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
    public partial class frmAsesor : Form
    {
        Login login;
        AsesoresDAO asesorDAO;
        Alumno objAlumno;
        AlumnosDAO objAlumnosDAO;
        List<Alumno> alumnos;
        DataTable dt;
        DataView dv;

        public frmAsesor()
        {
            asesorDAO = new AsesoresDAO();
            objAlumno = new Alumno();
            InitializeComponent();
        }

        public frmAsesor(Asesor objAsesor)
        {
            InitializeComponent();
            MessageBox.Show("Bienvenido, " + objAsesor.getNombre());
            dt = new DataTable();
            dt.Columns.Add("Matricula");
            dt.Columns.Add("Usuario");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido paterno");
            dt.Columns.Add("Apellido materno");
            dt.Columns.Add("E-mail");
            dt.Columns.Add("Telefono");
            objAlumnosDAO = new AlumnosDAO();
            alumnos = objAlumnosDAO.seleccionarAlumnosPorAsesor(objAsesor.getIdAsesor());
            lblAsesorId.Text = objAsesor.getIdAsesor().ToString();
            foreach(Alumno alumno in alumnos){
                dt.Rows.Add(alumno.getMatricula(), alumno.getUsuario(), alumno.getNombre(), alumno.getApellidoPaterno(),
                    alumno.getApellidoMaterno(), alumno.getEmail(), alumno.getTelefono());
            }
            dgvAlumnos.DataSource = dt;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAsesor_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "¿Quieres salir del sistema?";
            const string caption = "Cerrar sesión";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                login = new Login();
                login.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void txtMatriculaAlumno_TextChanged(object sender, EventArgs e)
        {
            dv = dt.DefaultView;
            dv.RowFilter = $"nombre like '{txtMatriculaAlumno.Text}%'";
            dgvAlumnos.DataSource = dv;
        }

        private void dgvAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvAlumnos.Rows[e.RowIndex];
            string matricula = row.Cells[0].Value.ToString();
            VerDetallesAlumno detallesAlumno = new VerDetallesAlumno(matricula, lblAsesorId.Text);
            detallesAlumno.Show();
        }
    }
}
