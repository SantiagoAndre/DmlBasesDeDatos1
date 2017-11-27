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
            this.txtCodeEst = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblCodeEst = new System.Windows.Forms.Label();
            this.txtCodeDip = new System.Windows.Forms.TextBox();
            this.lblCodeDip = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
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
            this.btnOkInscripcion.Click += new System.EventHandler(this.btnOkInscripcion_Click);
            // 
            // txtCodeEst
            // 
            this.txtCodeEst.Location = new System.Drawing.Point(154, 88);
            this.txtCodeEst.Name = "txtCodeEst";
            this.txtCodeEst.Size = new System.Drawing.Size(108, 20);
            this.txtCodeEst.TabIndex = 31;
            this.txtCodeEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(22, 170);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(70, 15);
            this.lblEndDate.TabIndex = 30;
            this.lblEndDate.Text = "FECHA FIN";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(22, 130);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(98, 15);
            this.lblStartDate.TabIndex = 29;
            this.lblStartDate.Text = "FECHA INICIO:";
            // 
            // lblCodeEst
            // 
            this.lblCodeEst.AutoSize = true;
            this.lblCodeEst.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeEst.Location = new System.Drawing.Point(22, 90);
            this.lblCodeEst.Name = "lblCodeEst";
            this.lblCodeEst.Size = new System.Drawing.Size(126, 15);
            this.lblCodeEst.TabIndex = 28;
            this.lblCodeEst.Text = "CODIGO ESTILISTA:";
            // 
            // txtCodeDip
            // 
            this.txtCodeDip.Location = new System.Drawing.Point(154, 50);
            this.txtCodeDip.Name = "txtCodeDip";
            this.txtCodeDip.Size = new System.Drawing.Size(108, 20);
            this.txtCodeDip.TabIndex = 27;
            this.txtCodeDip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers);
            // 
            // lblCodeDip
            // 
            this.lblCodeDip.AutoSize = true;
            this.lblCodeDip.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeDip.Location = new System.Drawing.Point(22, 50);
            this.lblCodeDip.Name = "lblCodeDip";
            this.lblCodeDip.Size = new System.Drawing.Size(126, 15);
            this.lblCodeDip.TabIndex = 26;
            this.lblCodeDip.Text = "CODIGO DIPLOMADO:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(126, 125);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(136, 20);
            this.dtpStartDate.TabIndex = 36;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(126, 165);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(136, 20);
            this.dtpEndDate.TabIndex = 37;
            // 
            // FormInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 285);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblDecription);
            this.Controls.Add(this.btnOkInscripcion);
            this.Controls.Add(this.txtCodeEst);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblCodeEst);
            this.Controls.Add(this.txtCodeDip);
            this.Controls.Add(this.lblCodeDip);
            this.Name = "FormInscripcion";
            this.Text = "Inscripcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDecription;
        private System.Windows.Forms.Button btnOkInscripcion;
        private System.Windows.Forms.TextBox txtCodeEst;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblCodeEst;
        private System.Windows.Forms.TextBox txtCodeDip;
        private System.Windows.Forms.Label lblCodeDip;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}