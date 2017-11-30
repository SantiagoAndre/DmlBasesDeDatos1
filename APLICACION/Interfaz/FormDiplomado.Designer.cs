namespace APLICACION.Interfaz
{
    partial class FromDiplomado
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
            this.txtDurationH = new System.Windows.Forms.TextBox();
            this.txtNameDip = new System.Windows.Forms.TextBox();
            this.lblModalityDip = new System.Windows.Forms.Label();
            this.lblDurationH = new System.Windows.Forms.Label();
            this.lblNameDip = new System.Windows.Forms.Label();
            this.txtCodeDip = new System.Windows.Forms.TextBox();
            this.lblCodeDip = new System.Windows.Forms.Label();
            this.btnOkDiplomado = new System.Windows.Forms.Button();
            this.lblDecripcion = new System.Windows.Forms.Label();
            this.cbxModalityDip = new System.Windows.Forms.ComboBox();
            this.ckcModeDrop = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtDurationH
            // 
            this.txtDurationH.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtDurationH.Location = new System.Drawing.Point(116, 130);
            this.txtDurationH.Name = "txtDurationH";
            this.txtDurationH.Size = new System.Drawing.Size(162, 22);
            this.txtDurationH.TabIndex = 21;
            this.txtDurationH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_onlyNumbers_KeyPerss);
            // 
            // txtNameDip
            // 
            this.txtNameDip.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNameDip.Location = new System.Drawing.Point(116, 90);
            this.txtNameDip.Name = "txtNameDip";
            this.txtNameDip.Size = new System.Drawing.Size(162, 22);
            this.txtNameDip.TabIndex = 20;
            // 
            // lblModalityDip
            // 
            this.lblModalityDip.AutoSize = true;
            this.lblModalityDip.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblModalityDip.Location = new System.Drawing.Point(25, 171);
            this.lblModalityDip.Name = "lblModalityDip";
            this.lblModalityDip.Size = new System.Drawing.Size(87, 16);
            this.lblModalityDip.TabIndex = 19;
            this.lblModalityDip.Text = "MODALIDAD:";
            // 
            // lblDurationH
            // 
            this.lblDurationH.AutoSize = true;
            this.lblDurationH.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDurationH.Location = new System.Drawing.Point(25, 124);
            this.lblDurationH.Name = "lblDurationH";
            this.lblDurationH.Size = new System.Drawing.Size(78, 32);
            this.lblDurationH.TabIndex = 18;
            this.lblDurationH.Text = "HORAS  DE  \r\nDURACION";
            // 
            // lblNameDip
            // 
            this.lblNameDip.AutoSize = true;
            this.lblNameDip.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNameDip.Location = new System.Drawing.Point(25, 92);
            this.lblNameDip.Name = "lblNameDip";
            this.lblNameDip.Size = new System.Drawing.Size(64, 16);
            this.lblNameDip.TabIndex = 17;
            this.lblNameDip.Text = "NOMBRE:";
            // 
            // txtCodeDip
            // 
            this.txtCodeDip.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCodeDip.Location = new System.Drawing.Point(116, 50);
            this.txtCodeDip.Name = "txtCodeDip";
            this.txtCodeDip.Size = new System.Drawing.Size(162, 22);
            this.txtCodeDip.TabIndex = 16;
            this.txtCodeDip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_onlyNumbers_KeyPerss);
            // 
            // lblCodeDip
            // 
            this.lblCodeDip.AutoSize = true;
            this.lblCodeDip.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCodeDip.Location = new System.Drawing.Point(25, 53);
            this.lblCodeDip.Name = "lblCodeDip";
            this.lblCodeDip.Size = new System.Drawing.Size(58, 16);
            this.lblCodeDip.TabIndex = 15;
            this.lblCodeDip.Text = "CODIGO:";
            // 
            // btnOkDiplomado
            // 
            this.btnOkDiplomado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnOkDiplomado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOkDiplomado.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOkDiplomado.ForeColor = System.Drawing.Color.Black;
            this.btnOkDiplomado.Location = new System.Drawing.Point(90, 222);
            this.btnOkDiplomado.Name = "btnOkDiplomado";
            this.btnOkDiplomado.Size = new System.Drawing.Size(120, 30);
            this.btnOkDiplomado.TabIndex = 23;
            this.btnOkDiplomado.Text = "OK";
            this.btnOkDiplomado.UseVisualStyleBackColor = false;
            this.btnOkDiplomado.Click += new System.EventHandler(this.btnOkDiplomado_Click);
            // 
            // lblDecripcion
            // 
            this.lblDecripcion.AutoSize = true;
            this.lblDecripcion.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDecripcion.Location = new System.Drawing.Point(72, 9);
            this.lblDecripcion.Name = "lblDecripcion";
            this.lblDecripcion.Size = new System.Drawing.Size(156, 16);
            this.lblDecripcion.TabIndex = 24;
            this.lblDecripcion.Text = "REGISTRAR DIPLOMADO";
            // 
            // cbxModalityDip
            // 
            this.cbxModalityDip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModalityDip.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbxModalityDip.FormattingEnabled = true;
            this.cbxModalityDip.Items.AddRange(new object[] {
            "presencial",
            "semipresencial",
            "virtual"});
            this.cbxModalityDip.Location = new System.Drawing.Point(116, 168);
            this.cbxModalityDip.Name = "cbxModalityDip";
            this.cbxModalityDip.Size = new System.Drawing.Size(162, 24);
            this.cbxModalityDip.TabIndex = 25;
            // 
            // ckcModeDrop
            // 
            this.ckcModeDrop.AutoSize = true;
            this.ckcModeDrop.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ckcModeDrop.Location = new System.Drawing.Point(28, 92);
            this.ckcModeDrop.Name = "ckcModeDrop";
            this.ckcModeDrop.Size = new System.Drawing.Size(246, 20);
            this.ckcModeDrop.TabIndex = 27;
            this.ckcModeDrop.Text = "BORRAR INSCRIPCIONES ASOCIADAS";
            this.ckcModeDrop.UseVisualStyleBackColor = true;
            this.ckcModeDrop.Visible = false;
            // 
            // FromDiplomado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(300, 265);
            this.Controls.Add(this.ckcModeDrop);
            this.Controls.Add(this.cbxModalityDip);
            this.Controls.Add(this.lblDecripcion);
            this.Controls.Add(this.btnOkDiplomado);
            this.Controls.Add(this.txtDurationH);
            this.Controls.Add(this.txtNameDip);
            this.Controls.Add(this.lblModalityDip);
            this.Controls.Add(this.lblDurationH);
            this.Controls.Add(this.lblNameDip);
            this.Controls.Add(this.txtCodeDip);
            this.Controls.Add(this.lblCodeDip);
            this.Name = "FromDiplomado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Diplomado";
            this.VisibleChanged += new System.EventHandler(this.FromDiplomado_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDurationH;
        private System.Windows.Forms.TextBox txtNameDip;
        private System.Windows.Forms.Label lblModalityDip;
        private System.Windows.Forms.Label lblDurationH;
        private System.Windows.Forms.Label lblNameDip;
        private System.Windows.Forms.TextBox txtCodeDip;
        private System.Windows.Forms.Label lblCodeDip;
        private System.Windows.Forms.Button btnOkDiplomado;
        private System.Windows.Forms.Label lblDecripcion;
        private System.Windows.Forms.ComboBox cbxModalityDip;
        private System.Windows.Forms.CheckBox ckcModeDrop;
    }
}