namespace APLICACION.Interfaz
{
    partial class FromCiudad
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
            this.txtNameDip = new System.Windows.Forms.TextBox();
            this.lblNameDip = new System.Windows.Forms.Label();
            this.txtCodeDip = new System.Windows.Forms.TextBox();
            this.lblCodeDip = new System.Windows.Forms.Label();
            this.btnOkCiudad = new System.Windows.Forms.Button();
            this.lblDecripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNameDip
            // 
            this.txtNameDip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNameDip.Location = new System.Drawing.Point(116, 90);
            this.txtNameDip.Name = "txtNameDip";
            this.txtNameDip.Size = new System.Drawing.Size(162, 22);
            this.txtNameDip.TabIndex = 20;
            // 
            // lblNameDip
            // 
            this.lblNameDip.AutoSize = true;
            this.lblNameDip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNameDip.Location = new System.Drawing.Point(25, 92);
            this.lblNameDip.Name = "lblNameDip";
            this.lblNameDip.Size = new System.Drawing.Size(77, 16);
            this.lblNameDip.TabIndex = 17;
            this.lblNameDip.Text = "NOMBRE:";
            // 
            // txtCodeDip
            // 
            this.txtCodeDip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCodeDip.Location = new System.Drawing.Point(116, 50);
            this.txtCodeDip.Name = "txtCodeDip";
            this.txtCodeDip.Size = new System.Drawing.Size(162, 22);
            this.txtCodeDip.TabIndex = 16;
            this.txtCodeDip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_onlyNumbers_KeyPerss);
            // 
            // lblCodeDip
            // 
            this.lblCodeDip.AutoSize = true;
            this.lblCodeDip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCodeDip.Location = new System.Drawing.Point(25, 53);
            this.lblCodeDip.Name = "lblCodeDip";
            this.lblCodeDip.Size = new System.Drawing.Size(70, 16);
            this.lblCodeDip.TabIndex = 15;
            this.lblCodeDip.Text = "CODIGO:";
            // 
            // btnOkCiudad
            // 
            this.btnOkCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnOkCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOkCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOkCiudad.ForeColor = System.Drawing.Color.Black;
            this.btnOkCiudad.Location = new System.Drawing.Point(75, 127);
            this.btnOkCiudad.Name = "btnOkCiudad";
            this.btnOkCiudad.Size = new System.Drawing.Size(120, 30);
            this.btnOkCiudad.TabIndex = 23;
            this.btnOkCiudad.Text = "OK";
            this.btnOkCiudad.UseVisualStyleBackColor = false;
            this.btnOkCiudad.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblDecripcion
            // 
            this.lblDecripcion.AutoSize = true;
            this.lblDecripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDecripcion.Location = new System.Drawing.Point(72, 9);
            this.lblDecripcion.Name = "lblDecripcion";
            this.lblDecripcion.Size = new System.Drawing.Size(157, 16);
            this.lblDecripcion.TabIndex = 24;
            this.lblDecripcion.Text = "REGISTRAR CIUDAD";
            // 
            // FromCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(300, 161);
            this.Controls.Add(this.lblDecripcion);
            this.Controls.Add(this.btnOkCiudad);
            this.Controls.Add(this.txtNameDip);
            this.Controls.Add(this.lblNameDip);
            this.Controls.Add(this.txtCodeDip);
            this.Controls.Add(this.lblCodeDip);
            this.Name = "FromCiudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ciudad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNameDip;
        private System.Windows.Forms.Label lblNameDip;
        private System.Windows.Forms.TextBox txtCodeDip;
        private System.Windows.Forms.Label lblCodeDip;
        private System.Windows.Forms.Button btnOkCiudad;
        private System.Windows.Forms.Label lblDecripcion;
    }
}