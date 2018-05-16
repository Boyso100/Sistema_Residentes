namespace EnviarCorreo.vistas
{
    partial class Principal_docente
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
            this.components = new System.ComponentModel.Container();
            this.mstripAcciones = new System.Windows.Forms.MenuStrip();
            this.documentosRecibidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarALUMNOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mstripAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstripAcciones
            // 
            this.mstripAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(237)))), ((int)(((byte)(219)))));
            this.mstripAcciones.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstripAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentosRecibidoToolStripMenuItem,
            this.buscarALUMNOToolStripMenuItem});
            this.mstripAcciones.Location = new System.Drawing.Point(0, 0);
            this.mstripAcciones.Name = "mstripAcciones";
            this.mstripAcciones.Size = new System.Drawing.Size(884, 34);
            this.mstripAcciones.TabIndex = 0;
            this.mstripAcciones.Text = "menuAcciones";
            // 
            // documentosRecibidoToolStripMenuItem
            // 
            this.documentosRecibidoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.documentosRecibidoToolStripMenuItem.Name = "documentosRecibidoToolStripMenuItem";
            this.documentosRecibidoToolStripMenuItem.Size = new System.Drawing.Size(132, 30);
            this.documentosRecibidoToolStripMenuItem.Text = "Documentos";
            this.documentosRecibidoToolStripMenuItem.Click += new System.EventHandler(this.documentosRecibidoToolStripMenuItem_Click);
            // 
            // buscarALUMNOToolStripMenuItem
            // 
            this.buscarALUMNOToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.buscarALUMNOToolStripMenuItem.Name = "buscarALUMNOToolStripMenuItem";
            this.buscarALUMNOToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.buscarALUMNOToolStripMenuItem.Text = "Buscar alumno";
            this.buscarALUMNOToolStripMenuItem.Click += new System.EventHandler(this.buscarALUMNOToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Principal_docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(118)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.mstripAcciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mstripAcciones;
            this.MaximizeBox = false;
            this.Name = "Principal_docente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asesores | Monitoreo de alumnos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mstripAcciones.ResumeLayout(false);
            this.mstripAcciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstripAcciones;
        private System.Windows.Forms.ToolStripMenuItem documentosRecibidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarALUMNOToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}