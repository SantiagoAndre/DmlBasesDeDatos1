namespace APLICACION.Interfaz
{
    partial class FormTorneo2
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
            this.btnOkKarateka = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEstorbo = new System.Windows.Forms.Label();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.lblFrecuencia = new System.Windows.Forms.Label();
            this.cbxFrecuencia = new System.Windows.Forms.ComboBox();
            this.cbxModalidad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDecription
            // 
            this.lblDecription.AutoSize = true;
            this.lblDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDecription.Location = new System.Drawing.Point(90, 5);
            this.lblDecription.Name = "lblDecription";
            this.lblDecription.Size = new System.Drawing.Size(185, 16);
            this.lblDecription.TabIndex = 34;
            this.lblDecription.Text = "ACTUALIZAR KARATECA";
            // 
            // btnOkKarateka
            // 
            this.btnOkKarateka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnOkKarateka.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOkKarateka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOkKarateka.ForeColor = System.Drawing.Color.Black;
            this.btnOkKarateka.Location = new System.Drawing.Point(124, 205);
            this.btnOkKarateka.Name = "btnOkKarateka";
            this.btnOkKarateka.Size = new System.Drawing.Size(120, 30);
            this.btnOkKarateka.TabIndex = 33;
            this.btnOkKarateka.Text = "OK";
            this.btnOkKarateka.UseVisualStyleBackColor = false;
            this.btnOkKarateka.Click += new System.EventHandler(this.btnOk_Click);
            
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNombre.Location = new System.Drawing.Point(149, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 22);
            this.txtNombre.TabIndex = 30;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCodigo.Location = new System.Drawing.Point(149, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(169, 22);
            this.txtCodigo.TabIndex = 26;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarCodigo);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_onlyNumbers_KeyPerss);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.Location = new System.Drawing.Point(37, 51);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 16);
            this.lblCodigo.TabIndex = 43;
            this.lblCodigo.Text = "CODIGO:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(38, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 16);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "NOMBRE:";
            this.lblNombre.Visible = false;
            // 
            // lblEstorbo
            // 
            this.lblEstorbo.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.lblEstorbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEstorbo.Location = new System.Drawing.Point(14, 45);
            this.lblEstorbo.Name = "lblEstorbo";
            this.lblEstorbo.Size = new System.Drawing.Size(20, 161);
            this.lblEstorbo.TabIndex = 47;
            this.lblEstorbo.Visible = false;
            // 
            // lblModalidad
            // 
            this.lblModalidad.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblModalidad.Location = new System.Drawing.Point(35, 125);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(100, 16);
            this.lblModalidad.TabIndex = 49;
            this.lblModalidad.Text = "MODALIDAD:";
            this.lblModalidad.Visible = false;
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.AutoSize = true;
            this.lblFrecuencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFrecuencia.Location = new System.Drawing.Point(37, 168);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(108, 16);
            this.lblFrecuencia.TabIndex = 51;
            this.lblFrecuencia.Text = "FRECUENCIA:";
            // 
            // cbxFrecuencia
            // 
            this.cbxFrecuencia.FormattingEnabled = true;
            this.cbxFrecuencia.Location = new System.Drawing.Point(149, 163);
            this.cbxFrecuencia.Name = "cbxFrecuencia";
            this.cbxFrecuencia.Size = new System.Drawing.Size(169, 21);
            this.cbxFrecuencia.TabIndex = 55;
            // 
            // cbxModalidad
            // 
            this.cbxModalidad.FormattingEnabled = true;
            this.cbxModalidad.Location = new System.Drawing.Point(149, 125);
            this.cbxModalidad.Name = "cbxModalidad";
            this.cbxModalidad.Size = new System.Drawing.Size(169, 21);
            this.cbxModalidad.TabIndex = 56;
            // 
            // FormTorneo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(356, 256);
            this.Controls.Add(this.cbxModalidad);
            this.Controls.Add(this.cbxFrecuencia);
            this.Controls.Add(this.lblFrecuencia);
            this.Controls.Add(this.lblModalidad);
            this.Controls.Add(this.lblEstorbo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblDecription);
            this.Controls.Add(this.btnOkKarateka);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Name = "FormTorneo2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Karateca";
            this.Load += new System.EventHandler(this.FormTorneo_Load);
            this.VisibleChanged += new System.EventHandler(this.Form_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDecription;
        private System.Windows.Forms.Button btnOkKarateka;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEstorbo;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.Label lblFrecuencia;
        private System.Windows.Forms.ComboBox cbxFrecuencia;
        private System.Windows.Forms.ComboBox cbxModalidad;
    }
}