namespace EnviarCorreo.vistas
{
    partial class frmRevisionDocumentos
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
            this.gbxDocumentacion = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlChecks = new System.Windows.Forms.Panel();
            this.checkCronograma = new System.Windows.Forms.CheckBox();
            this.checkKardex = new System.Windows.Forms.CheckBox();
            this.checkSolicitud = new System.Windows.Forms.CheckBox();
            this.gbxDocumentacion.SuspendLayout();
            this.pnlChecks.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDocumentacion
            // 
            this.gbxDocumentacion.Controls.Add(this.pnlChecks);
            this.gbxDocumentacion.Controls.Add(this.btnAceptar);
            this.gbxDocumentacion.Controls.Add(this.btnCancelar);
            this.gbxDocumentacion.Font = new System.Drawing.Font("Calibri", 14F);
            this.gbxDocumentacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.gbxDocumentacion.Location = new System.Drawing.Point(13, 13);
            this.gbxDocumentacion.Name = "gbxDocumentacion";
            this.gbxDocumentacion.Size = new System.Drawing.Size(434, 185);
            this.gbxDocumentacion.TabIndex = 0;
            this.gbxDocumentacion.TabStop = false;
            this.gbxDocumentacion.Text = "Documentación del alumno";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnCancelar.Location = new System.Drawing.Point(338, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 34);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(243, 145);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 34);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // pnlChecks
            // 
            this.pnlChecks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pnlChecks.Controls.Add(this.checkSolicitud);
            this.pnlChecks.Controls.Add(this.checkKardex);
            this.pnlChecks.Controls.Add(this.checkCronograma);
            this.pnlChecks.Location = new System.Drawing.Point(6, 29);
            this.pnlChecks.Name = "pnlChecks";
            this.pnlChecks.Size = new System.Drawing.Size(421, 110);
            this.pnlChecks.TabIndex = 3;
            // 
            // checkCronograma
            // 
            this.checkCronograma.AutoSize = true;
            this.checkCronograma.Location = new System.Drawing.Point(4, 3);
            this.checkCronograma.Name = "checkCronograma";
            this.checkCronograma.Size = new System.Drawing.Size(239, 27);
            this.checkCronograma.TabIndex = 0;
            this.checkCronograma.Text = "Cronograma de actividades";
            this.checkCronograma.UseVisualStyleBackColor = true;
            // 
            // checkKardex
            // 
            this.checkKardex.AutoSize = true;
            this.checkKardex.Location = new System.Drawing.Point(3, 36);
            this.checkKardex.Name = "checkKardex";
            this.checkKardex.Size = new System.Drawing.Size(82, 27);
            this.checkKardex.TabIndex = 1;
            this.checkKardex.Text = "Kárdex";
            this.checkKardex.UseVisualStyleBackColor = true;
            // 
            // checkSolicitud
            // 
            this.checkSolicitud.AutoSize = true;
            this.checkSolicitud.Location = new System.Drawing.Point(4, 69);
            this.checkSolicitud.Name = "checkSolicitud";
            this.checkSolicitud.Size = new System.Drawing.Size(207, 27);
            this.checkSolicitud.TabIndex = 2;
            this.checkSolicitud.Text = "Solicitud de residencias";
            this.checkSolicitud.UseVisualStyleBackColor = true;
            // 
            // frmRevisionDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(459, 210);
            this.Controls.Add(this.gbxDocumentacion);
            this.Name = "frmRevisionDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RevisionDocumentos";
            this.gbxDocumentacion.ResumeLayout(false);
            this.pnlChecks.ResumeLayout(false);
            this.pnlChecks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDocumentacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlChecks;
        private System.Windows.Forms.CheckBox checkSolicitud;
        private System.Windows.Forms.CheckBox checkKardex;
        private System.Windows.Forms.CheckBox checkCronograma;
    }
}