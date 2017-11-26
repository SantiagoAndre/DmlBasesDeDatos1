namespace APLICACION.Interfaz
{
    partial class formInscripcion
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
            this.lblDecription = new System.Windows.Forms.Label();
            this.btnOkInscripcion = new System.Windows.Forms.Button();
            this.txtCodigoEst = new System.Windows.Forms.TextBox();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblCodigoEst = new System.Windows.Forms.Label();
            this.txtCodDip = new System.Windows.Forms.TextBox();
            this.lblCodDip = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblDecription
            // 
            this.lblDecription.AutoSize = true;
            this.lblDecription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecription.Location = new System.Drawing.Point(68, 9);
            this.lblDecription.Name = "lblDecription";
            this.lblDecription.Size = new System.Drawing.Size(140, 15);
            this.lblDecription.TabIndex = 34;
            this.lblDecription.Text = "REGISTRAR DIPLOMADO";
            // 
            // btnOkInscripcion
            // 
            this.btnOkInscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnOkInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOkInscripcion.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkInscripcion.ForeColor = System.Drawing.Color.Black;
            this.btnOkInscripcion.Location = new System.Drawing.Point(49, 220);
            this.btnOkInscripcion.Name = "btnOkInscripcion";
            this.btnOkInscripcion.Size = new System.Drawing.Size(200, 45);
            this.btnOkInscripcion.TabIndex = 33;
            this.btnOkInscripcion.Text = "OK";
            this.btnOkInscripcion.UseVisualStyleBackColor = false;
            // 
            // txtCodigoEst
            // 
            this.txtCodigoEst.Location = new System.Drawing.Point(154, 88);
            this.txtCodigoEst.Name = "txtCodigoEst";
            this.txtCodigoEst.Size = new System.Drawing.Size(108, 20);
            this.txtCodigoEst.TabIndex = 31;
            this.txtCodigoEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(22, 170);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(70, 15);
            this.lblFechaFin.TabIndex = 30;
            this.lblFechaFin.Text = "FECHA FIN";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(22, 130);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(98, 15);
            this.lblFechaInicio.TabIndex = 29;
            this.lblFechaInicio.Text = "FECHA INICIO:";
            // 
            // lblCodigoEst
            // 
            this.lblCodigoEst.AutoSize = true;
            this.lblCodigoEst.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEst.Location = new System.Drawing.Point(22, 90);
            this.lblCodigoEst.Name = "lblCodigoEst";
            this.lblCodigoEst.Size = new System.Drawing.Size(126, 15);
            this.lblCodigoEst.TabIndex = 28;
            this.lblCodigoEst.Text = "CODIGO ESTILISTA:";

            // 
            // txtCodDip
            // 
            this.txtCodDip.Location = new System.Drawing.Point(154, 50);
            this.txtCodDip.Name = "txtCodDip";
            this.txtCodDip.Size = new System.Drawing.Size(108, 20);
            this.txtCodDip.TabIndex = 27;
            this.txtCodDip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers);
            // 
            // lblCodDip
            // 
            this.lblCodDip.AutoSize = true;
            this.lblCodDip.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodDip.Location = new System.Drawing.Point(22, 50);
            this.lblCodDip.Name = "lblCodDip";
            this.lblCodDip.Size = new System.Drawing.Size(126, 15);
            this.lblCodDip.TabIndex = 26;
            this.lblCodDip.Text = "CODIGO DIPLOMADO:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(126, 125);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(136, 20);
            this.dtpFechaInicio.TabIndex = 36;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(126, 165);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(136, 20);
            this.dtpFechaFin.TabIndex = 37;
            // 
            // formInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 285);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblDecription);
            this.Controls.Add(this.btnOkInscripcion);
            this.Controls.Add(this.txtCodigoEst);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblCodigoEst);
            this.Controls.Add(this.txtCodDip);
            this.Controls.Add(this.lblCodDip);
            this.Name = "formInscripcion";
            this.Text = "Inscripcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDecription;
        private System.Windows.Forms.Button btnOkInscripcion;
        private System.Windows.Forms.TextBox txtCodigoEst;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblCodigoEst;
        private System.Windows.Forms.TextBox txtCodDip;
        private System.Windows.Forms.Label lblCodDip;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
    }
}