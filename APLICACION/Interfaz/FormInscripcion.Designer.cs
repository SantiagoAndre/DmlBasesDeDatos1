namespace APLICACION.Interfaz
{
    partial class FormInscripcion
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
            this.txtCodeDip = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.ckcEndDate = new System.Windows.Forms.CheckBox();
            this.ckcStarDate = new System.Windows.Forms.CheckBox();
            this.txtCodeEst = new System.Windows.Forms.TextBox();
            this.ckcCodeDip = new System.Windows.Forms.CheckBox();
            this.ckcCodeEst = new System.Windows.Forms.CheckBox();
            this.pcb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDecription
            // 
            this.lblDecription.AutoSize = true;
            this.lblDecription.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDecription.Location = new System.Drawing.Point(53, 9);
            this.lblDecription.Name = "lblDecription";
            this.lblDecription.Size = new System.Drawing.Size(152, 16);
            this.lblDecription.TabIndex = 34;
            this.lblDecription.Text = "REALIZAR INSCRIPCION";
            // 
            // btnOkInscripcion
            // 
            this.btnOkInscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnOkInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOkInscripcion.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOkInscripcion.ForeColor = System.Drawing.Color.Black;
            this.btnOkInscripcion.Location = new System.Drawing.Point(53, 220);
            this.btnOkInscripcion.Name = "btnOkInscripcion";
            this.btnOkInscripcion.Size = new System.Drawing.Size(200, 45);
            this.btnOkInscripcion.TabIndex = 33;
            this.btnOkInscripcion.Text = "OK";
            this.btnOkInscripcion.UseVisualStyleBackColor = false;
            this.btnOkInscripcion.Click += new System.EventHandler(this.btnOkInscripcion_Click);
            // 
            // txtCodeDip
            // 
            this.txtCodeDip.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCodeDip.Location = new System.Drawing.Point(185, 49);
            this.txtCodeDip.Name = "txtCodeDip";
            this.txtCodeDip.Size = new System.Drawing.Size(108, 22);
            this.txtCodeDip.TabIndex = 27;
            this.txtCodeDip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpStartDate.Location = new System.Drawing.Point(141, 124);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(152, 22);
            this.dtpStartDate.TabIndex = 36;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpEndDate.Location = new System.Drawing.Point(141, 164);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(152, 22);
            this.dtpEndDate.TabIndex = 37;
            // 
            // ckcEndDate
            // 
            this.ckcEndDate.AutoSize = true;
            this.ckcEndDate.Checked = true;
            this.ckcEndDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckcEndDate.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ckcEndDate.Location = new System.Drawing.Point(24, 171);
            this.ckcEndDate.Name = "ckcEndDate";
            this.ckcEndDate.Size = new System.Drawing.Size(93, 20);
            this.ckcEndDate.TabIndex = 38;
            this.ckcEndDate.Text = "FECHA FIN:";
            this.ckcEndDate.UseVisualStyleBackColor = true;
            this.ckcEndDate.CheckedChanged += new System.EventHandler(this.ckcEndDate_CheckedChanged);
            // 
            // ckcStarDate
            // 
            this.ckcStarDate.AutoSize = true;
            this.ckcStarDate.Checked = true;
            this.ckcStarDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckcStarDate.Enabled = false;
            this.ckcStarDate.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ckcStarDate.Location = new System.Drawing.Point(24, 131);
            this.ckcStarDate.Name = "ckcStarDate";
            this.ckcStarDate.Size = new System.Drawing.Size(111, 20);
            this.ckcStarDate.TabIndex = 39;
            this.ckcStarDate.Text = "FECHA INICIO:";
            this.ckcStarDate.UseVisualStyleBackColor = true;
            this.ckcStarDate.CheckedChanged += new System.EventHandler(this.ckcStarDate_CheckedChanged);
            // 
            // txtCodeEst
            // 
            this.txtCodeEst.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCodeEst.Location = new System.Drawing.Point(185, 83);
            this.txtCodeEst.Name = "txtCodeEst";
            this.txtCodeEst.Size = new System.Drawing.Size(108, 22);
            this.txtCodeEst.TabIndex = 31;
            this.txtCodeEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers);
            // 
            // ckcCodeDip
            // 
            this.ckcCodeDip.AutoSize = true;
            this.ckcCodeDip.Checked = true;
            this.ckcCodeDip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckcCodeDip.Enabled = false;
            this.ckcCodeDip.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ckcCodeDip.Location = new System.Drawing.Point(24, 51);
            this.ckcCodeDip.Name = "ckcCodeDip";
            this.ckcCodeDip.Size = new System.Drawing.Size(153, 20);
            this.ckcCodeDip.TabIndex = 41;
            this.ckcCodeDip.Text = "CODIGO DIPLOMADO";
            this.ckcCodeDip.UseVisualStyleBackColor = true;
            this.ckcCodeDip.CheckedChanged += new System.EventHandler(this.ckcCodeDip_CheckedChanged);
            // 
            // ckcCodeEst
            // 
            this.ckcCodeEst.AutoSize = true;
            this.ckcCodeEst.Checked = true;
            this.ckcCodeEst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckcCodeEst.Enabled = false;
            this.ckcCodeEst.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ckcCodeEst.Location = new System.Drawing.Point(24, 88);
            this.ckcCodeEst.Name = "ckcCodeEst";
            this.ckcCodeEst.Size = new System.Drawing.Size(139, 20);
            this.ckcCodeEst.TabIndex = 44;
            this.ckcCodeEst.Text = "CODIGO ESTILISTA:";
            this.ckcCodeEst.UseVisualStyleBackColor = true;
            this.ckcCodeEst.CheckedChanged += new System.EventHandler(this.ckcCodeEst_CheckedChanged);
            // 
            // pcb
            // 
            this.pcb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb.Image = global::APLICACION.Properties.Resources.pregunta;
            this.pcb.InitialImage = global::APLICACION.Properties.Resources.pregunta;
            this.pcb.Location = new System.Drawing.Point(226, 9);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(27, 20);
            this.pcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb.TabIndex = 45;
            this.pcb.TabStop = false;
            this.pcb.Click += new System.EventHandler(this.pcb_Click);
            // 
            // FormInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(316, 285);
            this.Controls.Add(this.pcb);
            this.Controls.Add(this.ckcCodeEst);
            this.Controls.Add(this.ckcCodeDip);
            this.Controls.Add(this.ckcStarDate);
            this.Controls.Add(this.ckcEndDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblDecription);
            this.Controls.Add(this.btnOkInscripcion);
            this.Controls.Add(this.txtCodeEst);
            this.Controls.Add(this.txtCodeDip);
            this.Name = "FormInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inscripcion";
            this.VisibleChanged += new System.EventHandler(this.FormInscripcion_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDecription;
        private System.Windows.Forms.Button btnOkInscripcion;
        private System.Windows.Forms.TextBox txtCodeDip;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.CheckBox ckcEndDate;
        private System.Windows.Forms.CheckBox ckcStarDate;
        private System.Windows.Forms.TextBox txtCodeEst;
        private System.Windows.Forms.CheckBox ckcCodeDip;
        private System.Windows.Forms.CheckBox ckcCodeEst;
        private System.Windows.Forms.PictureBox pcb;
    }
}