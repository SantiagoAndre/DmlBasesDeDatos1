namespace APLICACION.Interfaz
{
    partial class FormParticipa
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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtCodigoKarateca = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoTorneo = new System.Windows.Forms.TextBox();
            this.lblCodigoKarateca = new System.Windows.Forms.Label();
            this.lblCodigoTorneo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDecription
            // 
            this.lblDecription.AutoSize = true;
            this.lblDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDecription.Location = new System.Drawing.Point(53, 9);
            this.lblDecription.Name = "lblDecription";
            this.lblDecription.Size = new System.Drawing.Size(215, 16);
            this.lblDecription.TabIndex = 34;
            this.lblDecription.Text = "REGISTRAR PARTICIPACION";
            // 
            // btnOkInscripcion
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(53, 220);
            this.btnOk.Name = "btnOkInscripcion";
            this.btnOk.Size = new System.Drawing.Size(200, 45);
            this.btnOk.TabIndex = 33;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtCodigoKarateca
            // 
            this.txtCodigoKarateca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCodigoKarateca.Location = new System.Drawing.Point(185, 49);
            this.txtCodigoKarateca.Name = "txtCodigoKarateca";
            this.txtCodigoKarateca.Size = new System.Drawing.Size(108, 22);
            this.txtCodigoKarateca.TabIndex = 27;
            this.txtCodigoKarateca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy/mm/dd";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(141, 124);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(152, 22);
            this.dtpFecha.TabIndex = 36;
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "HH:mm:ss";
            this.dtpHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(141, 164);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(152, 22);
            this.dtpHora.TabIndex = 37;
            // 
            // txtCodigoTorneo
            // 
            this.txtCodigoTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCodigoTorneo.Location = new System.Drawing.Point(185, 83);
            this.txtCodigoTorneo.Name = "txtCodigoTorneo";
            this.txtCodigoTorneo.Size = new System.Drawing.Size(108, 22);
            this.txtCodigoTorneo.TabIndex = 31;
            this.txtCodigoTorneo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers);
            // 
            // lblCodigoKarateca
            // 
            this.lblCodigoKarateca.AutoSize = true;
            this.lblCodigoKarateca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCodigoKarateca.Location = new System.Drawing.Point(25, 52);
            this.lblCodigoKarateca.Name = "lblCodigoKarateca";
            this.lblCodigoKarateca.Size = new System.Drawing.Size(154, 16);
            this.lblCodigoKarateca.TabIndex = 49;
            this.lblCodigoKarateca.Text = "CODIGO KARATECA:";
            // 
            // lblCodigoTorneo
            // 
            this.lblCodigoTorneo.AutoSize = true;
            this.lblCodigoTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCodigoTorneo.Location = new System.Drawing.Point(41, 89);
            this.lblCodigoTorneo.Name = "lblCodigoTorneo";
            this.lblCodigoTorneo.Size = new System.Drawing.Size(138, 16);
            this.lblCodigoTorneo.TabIndex = 50;
            this.lblCodigoTorneo.Text = "CODIGO TORNEO:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFecha.Location = new System.Drawing.Point(67, 130);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 16);
            this.lblFecha.TabIndex = 51;
            this.lblFecha.Text = "FECHA:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHora.Location = new System.Drawing.Point(67, 164);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(55, 16);
            this.lblHora.TabIndex = 52;
            this.lblHora.Text = "HORA:";
            // 
            // FormParticipa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(316, 285);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCodigoTorneo);
            this.Controls.Add(this.lblCodigoKarateca);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblDecription);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtCodigoTorneo);
            this.Controls.Add(this.txtCodigoKarateca);
            this.Name = "FormParticipa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Participacion";
            this.VisibleChanged += new System.EventHandler(this.FormInscripcion_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDecription;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtCodigoKarateca;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.TextBox txtCodigoTorneo;
        private System.Windows.Forms.Label lblCodigoKarateca;
        private System.Windows.Forms.Label lblCodigoTorneo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
    }
}