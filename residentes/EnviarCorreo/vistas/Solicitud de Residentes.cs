using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnviarCorreo.Daos;
using EnviarCorreo.Modelos_pojos_;
using EnviarCorreo.vistas;

namespace EnviarCorreo.vistas
{
    public partial class Solicitud_de_Residentes : Form
    {

        Dao_empresa  dd = new Dao_empresa();
        Dao_Proyecto ddd = new Dao_Proyecto();

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest,
    int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;


        public Solicitud_de_Residentes()
        {
            InitializeComponent();
        }

       

        
        private void Solicitud_de_Residentes_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width,
                this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            cancelar.Hide();
            Guardar.Hide();
            CaptureScreen();
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string lugars=lugar.Text;
            string fechas=fecha.Text;
            string noresidente =numerodeResidentes.Text;
            string nombres_protecto = nombre_proyecto.Text;
            string periodo = periodo_delproyecto.Text;


           
            string Rfc = rfc.Text;
            string nombre_emp = nombre_empresa.Text;
            string ciudad = ciudad_empresa.Text;
            string Fax = fax.Text;
            string Mision = mision.Text;
            string Colonia = colonia.Text;
            string Cp = cp.Text;
            string Direccion = domicilio.Text;
            string tel = telefono_empresa.Text;

            Proyecto ppp =new Proyecto(lugars,fechas,noresidente, nombres_protecto,periodo);
            ddd.insertarProyecto(ppp);
            Empresa pp = new Empresa(Rfc, nombre_emp, ciudad, Fax, Mision, Colonia, Cp, Direccion, tel);
            dd.insertarEmpresa(pp);
        }
    }
}
