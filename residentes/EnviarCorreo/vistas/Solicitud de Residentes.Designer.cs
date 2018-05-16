namespace EnviarCorreo.vistas
{
    partial class Solicitud_de_Residentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solicitud_de_Residentes));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Imprimir = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.telefono_residente = new System.Windows.Forms.TextBox();
            this.ciudad_residente = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.domicilio_residente = new System.Windows.Forms.TextBox();
            this.no_control = new System.Windows.Forms.TextBox();
            this.carrera = new System.Windows.Forms.TextBox();
            this.nombreResidente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.mision = new System.Windows.Forms.TextBox();
            this.telefono_empresa = new System.Windows.Forms.TextBox();
            this.ciudad_empresa = new System.Windows.Forms.TextBox();
            this.fax = new System.Windows.Forms.TextBox();
            this.cp = new System.Windows.Forms.TextBox();
            this.colonia = new System.Windows.Forms.TextBox();
            this.domicilio = new System.Windows.Forms.TextBox();
            this.rfc = new System.Windows.Forms.TextBox();
            this.nombre_empresa = new System.Windows.Forms.TextBox();
            this.numerodeResidentes = new System.Windows.Forms.TextBox();
            this.periodo_delproyecto = new System.Windows.Forms.TextBox();
            this.nombre_proyecto = new System.Windows.Forms.TextBox();
            this.lugar = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.Imprimir);
            this.panel2.Controls.Add(this.cancelar);
            this.panel2.Controls.Add(this.Guardar);
            this.panel2.Controls.Add(this.telefono_residente);
            this.panel2.Controls.Add(this.ciudad_residente);
            this.panel2.Controls.Add(this.email);
            this.panel2.Controls.Add(this.domicilio_residente);
            this.panel2.Controls.Add(this.no_control);
            this.panel2.Controls.Add(this.carrera);
            this.panel2.Controls.Add(this.nombreResidente);
            this.panel2.Location = new System.Drawing.Point(1, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 205);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Imprimir
            // 
            this.Imprimir.BackColor = System.Drawing.Color.Teal;
            this.Imprimir.Location = new System.Drawing.Point(411, 165);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(75, 23);
            this.Imprimir.TabIndex = 23;
            this.Imprimir.Text = "Imprimir";
            this.Imprimir.UseVisualStyleBackColor = false;
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.Red;
            this.cancelar.Location = new System.Drawing.Point(12, 152);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 22;
            this.cancelar.Text = "cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Guardar.Location = new System.Drawing.Point(12, 178);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 21;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // telefono_residente
            // 
            this.telefono_residente.Location = new System.Drawing.Point(336, 127);
            this.telefono_residente.Name = "telefono_residente";
            this.telefono_residente.Size = new System.Drawing.Size(168, 20);
            this.telefono_residente.TabIndex = 20;
            // 
            // ciudad_residente
            // 
            this.ciudad_residente.Location = new System.Drawing.Point(58, 126);
            this.ciudad_residente.Name = "ciudad_residente";
            this.ciudad_residente.Size = new System.Drawing.Size(168, 20);
            this.ciudad_residente.TabIndex = 19;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(57, 101);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(446, 20);
            this.email.TabIndex = 18;
            // 
            // domicilio_residente
            // 
            this.domicilio_residente.Location = new System.Drawing.Point(57, 77);
            this.domicilio_residente.Name = "domicilio_residente";
            this.domicilio_residente.Size = new System.Drawing.Size(446, 20);
            this.domicilio_residente.TabIndex = 17;
            // 
            // no_control
            // 
            this.no_control.Location = new System.Drawing.Point(378, 49);
            this.no_control.Name = "no_control";
            this.no_control.Size = new System.Drawing.Size(125, 20);
            this.no_control.TabIndex = 16;
            // 
            // carrera
            // 
            this.carrera.Location = new System.Drawing.Point(55, 49);
            this.carrera.Name = "carrera";
            this.carrera.Size = new System.Drawing.Size(252, 20);
            this.carrera.TabIndex = 15;
            // 
            // nombreResidente
            // 
            this.nombreResidente.Location = new System.Drawing.Point(55, 25);
            this.nombreResidente.Name = "nombreResidente";
            this.nombreResidente.Size = new System.Drawing.Size(446, 20);
            this.nombreResidente.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.textBox15);
            this.panel1.Controls.Add(this.mision);
            this.panel1.Controls.Add(this.telefono_empresa);
            this.panel1.Controls.Add(this.ciudad_empresa);
            this.panel1.Controls.Add(this.fax);
            this.panel1.Controls.Add(this.cp);
            this.panel1.Controls.Add(this.colonia);
            this.panel1.Controls.Add(this.domicilio);
            this.panel1.Controls.Add(this.rfc);
            this.panel1.Controls.Add(this.nombre_empresa);
            this.panel1.Controls.Add(this.numerodeResidentes);
            this.panel1.Controls.Add(this.periodo_delproyecto);
            this.panel1.Controls.Add(this.nombre_proyecto);
            this.panel1.Controls.Add(this.lugar);
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Location = new System.Drawing.Point(-2, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 488);
            this.panel1.TabIndex = 0;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(58, 512);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(437, 20);
            this.textBox15.TabIndex = 14;
            // 
            // mision
            // 
            this.mision.Location = new System.Drawing.Point(70, 459);
            this.mision.Name = "mision";
            this.mision.Size = new System.Drawing.Size(437, 20);
            this.mision.TabIndex = 13;
            // 
            // telefono_empresa
            // 
            this.telefono_empresa.Location = new System.Drawing.Point(363, 434);
            this.telefono_empresa.Name = "telefono_empresa";
            this.telefono_empresa.Size = new System.Drawing.Size(145, 20);
            this.telefono_empresa.TabIndex = 12;
            // 
            // ciudad_empresa
            // 
            this.ciudad_empresa.Location = new System.Drawing.Point(70, 434);
            this.ciudad_empresa.Name = "ciudad_empresa";
            this.ciudad_empresa.Size = new System.Drawing.Size(218, 20);
            this.ciudad_empresa.TabIndex = 11;
            // 
            // fax
            // 
            this.fax.Location = new System.Drawing.Point(408, 407);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(96, 20);
            this.fax.TabIndex = 10;
            // 
            // cp
            // 
            this.cp.Location = new System.Drawing.Point(328, 409);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(44, 20);
            this.cp.TabIndex = 9;
            // 
            // colonia
            // 
            this.colonia.Location = new System.Drawing.Point(70, 408);
            this.colonia.Name = "colonia";
            this.colonia.Size = new System.Drawing.Size(218, 20);
            this.colonia.TabIndex = 8;
            // 
            // domicilio
            // 
            this.domicilio.Location = new System.Drawing.Point(70, 380);
            this.domicilio.Name = "domicilio";
            this.domicilio.Size = new System.Drawing.Size(438, 20);
            this.domicilio.TabIndex = 7;
            // 
            // rfc
            // 
            this.rfc.Location = new System.Drawing.Point(69, 354);
            this.rfc.Name = "rfc";
            this.rfc.Size = new System.Drawing.Size(438, 20);
            this.rfc.TabIndex = 6;
            // 
            // nombre_empresa
            // 
            this.nombre_empresa.Location = new System.Drawing.Point(69, 325);
            this.nombre_empresa.Name = "nombre_empresa";
            this.nombre_empresa.Size = new System.Drawing.Size(438, 20);
            this.nombre_empresa.TabIndex = 5;
            // 
            // numerodeResidentes
            // 
            this.numerodeResidentes.Location = new System.Drawing.Point(484, 278);
            this.numerodeResidentes.Name = "numerodeResidentes";
            this.numerodeResidentes.Size = new System.Drawing.Size(23, 20);
            this.numerodeResidentes.TabIndex = 4;
            // 
            // periodo_delproyecto
            // 
            this.periodo_delproyecto.Location = new System.Drawing.Point(182, 276);
            this.periodo_delproyecto.Name = "periodo_delproyecto";
            this.periodo_delproyecto.Size = new System.Drawing.Size(218, 20);
            this.periodo_delproyecto.TabIndex = 3;
            // 
            // nombre_proyecto
            // 
            this.nombre_proyecto.Location = new System.Drawing.Point(283, 223);
            this.nombre_proyecto.Name = "nombre_proyecto";
            this.nombre_proyecto.Size = new System.Drawing.Size(218, 20);
            this.nombre_proyecto.TabIndex = 2;
            // 
            // lugar
            // 
            this.lugar.Location = new System.Drawing.Point(41, 150);
            this.lugar.Name = "lugar";
            this.lugar.Size = new System.Drawing.Size(199, 20);
            this.lugar.TabIndex = 1;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(286, 150);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(218, 20);
            this.fecha.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Solicitud_de_Residentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(504, 684);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Solicitud_de_Residentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud_de_Residentes";
            this.Load += new System.EventHandler(this.Solicitud_de_Residentes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox carrera;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox mision;
        private System.Windows.Forms.TextBox telefono_empresa;
        private System.Windows.Forms.TextBox ciudad_empresa;
        private System.Windows.Forms.TextBox fax;
        private System.Windows.Forms.TextBox cp;
        private System.Windows.Forms.TextBox colonia;
        private System.Windows.Forms.TextBox domicilio;
        private System.Windows.Forms.TextBox rfc;
        private System.Windows.Forms.TextBox nombre_empresa;
        private System.Windows.Forms.TextBox numerodeResidentes;
        private System.Windows.Forms.TextBox periodo_delproyecto;
        private System.Windows.Forms.TextBox nombre_proyecto;
        private System.Windows.Forms.TextBox lugar;
        private System.Windows.Forms.TextBox fecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nombreResidente;
        private System.Windows.Forms.TextBox telefono_residente;
        private System.Windows.Forms.TextBox ciudad_residente;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox domicilio_residente;
        private System.Windows.Forms.TextBox no_control;
        private System.Windows.Forms.Button Imprimir;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button Guardar;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}