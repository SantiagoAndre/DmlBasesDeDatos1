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
            this.SuspendLayout();
            // 
            // lblDecription
            // 
            this.lblDecription.AutoSize = true;
            this.lblDecription.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecription.Location = new System.Drawing.Point(12, 9);
            this.lblDecription.Name = "lblDecription";
            this.lblDecription.Size = new System.Drawing.Size(264, 18);
            this.lblDecription.TabIndex = 34;
            this.lblDecription.Text = "REGISTRAR ESTILISTA EN DIPLOMADO";
            // 
            // btnOkInscripcion
            // 
            this.btnOkInscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnOkInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOkInscripcion.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtCodeDip.Location = new System.Drawing.Point(175, 50);
            this.txtCodeDip.Name = "txtCodeDip";
            this.txtCodeDip.Size = new System.Drawing.Size(108, 20);
            this.txtCodeDip.TabIndex = 27;
            this.txtCodeDip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(147, 125);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(136, 20);
            this.dtpStartDate.TabIndex = 36;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Location = new System.Drawing.Point(147, 165);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(136, 20);
            this.dtpEndDate.TabIndex = 37;
            // 
            // ckcEndDate
            // 
            this.ckcEndDate.AutoSize = true;
            this.ckcEndDate.Checked = true;
            this.ckcEndDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckcEndDate.Enabled = false;
            this.ckcEndDate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckcEndDate.Location = new System.Drawing.Point(24, 165);
            this.ckcEndDate.Name = "ckcEndDate";
            this.ckcEndDate.Size = new System.Drawing.Size(96, 19);
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
            this.ckcStarDate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckcStarDate.Location = new System.Drawing.Point(24, 125);
            this.ckcStarDate.Name = "ckcStarDate";
            this.ckcStarDate.Size = new System.Drawing.Size(117, 19);
            this.ckcStarDate.TabIndex = 39;
            this.ckcStarDate.Text = "FECHA INICIO:";
            this.ckcStarDate.UseVisualStyleBackColor = true;
            this.ckcStarDate.CheckedChanged += new System.EventHandler(this.ckcStarDate_CheckedChanged);
            // 
            // txtCodeEst
            // 
            this.txtCodeEst.Location = new System.Drawing.Point(175, 84);
            this.txtCodeEst.Name = "txtCodeEst";
            this.txtCodeEst.Size = new System.Drawing.Size(108, 20);
            this.txtCodeEst.TabIndex = 31;
            this.txtCodeEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers);
            // 
            // ckcCodeDip
            // 
            this.ckcCodeDip.AutoSize = true;
            this.ckcCodeDip.Checked = true;
            this.ckcCodeDip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckcCodeDip.Enabled = false;
            this.ckcCodeDip.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckcCodeDip.Location = new System.Drawing.Point(24, 51);
            this.ckcCodeDip.Name = "ckcCodeDip";
            this.ckcCodeDip.Size = new System.Drawing.Size(145, 19);
            this.ckcCodeDip.TabIndex = 41;
            this.ckcCodeDip.Text = "CODIGO DIPLOMADO:";
            this.ckcCodeDip.UseVisualStyleBackColor = true;
            this.ckcCodeDip.CheckedChanged += new System.EventHandler(this.ckcCodeDip_CheckedChanged);
            // 
            // ckcCodeEst
            // 
            this.ckcCodeEst.AutoSize = true;
            this.ckcCodeEst.Checked = true;
            this.ckcCodeEst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckcCodeEst.Enabled = false;
            this.ckcCodeEst.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckcCodeEst.Location = new System.Drawing.Point(24, 85);
            this.ckcCodeEst.Name = "ckcCodeEst";
            this.ckcCodeEst.Size = new System.Drawing.Size(145, 19);
            this.ckcCodeEst.TabIndex = 44;
            this.ckcCodeEst.Text = "CODIGO ESTILISTA:";
            this.ckcCodeEst.UseVisualStyleBackColor = true;
            this.ckcCodeEst.CheckedChanged += new System.EventHandler(this.ckcCodeEst_CheckedChanged);
            // 
            // FormInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(306, 285);
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
            this.Text = "Inscripcion";
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
    }
}