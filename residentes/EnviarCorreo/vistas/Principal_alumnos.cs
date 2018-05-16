using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnviarCorreo.vistas;

namespace EnviarCorreo
{
    public partial class Principal_alumnos : Form
    {
        public Principal_alumnos()
        {
            InitializeComponent();
        }

        

        private void Principal_alumnos_Load(object sender, EventArgs e)
        {

        }

       

      

        private void button1_Click(object sender, EventArgs e)
        {
            Solicitud_de_Residentes Form = new Solicitud_de_Residentes();
            Form.ShowDialog();
        }
    }
}
