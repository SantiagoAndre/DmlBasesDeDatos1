namespace APLICACION.Interfaz
{
    partial class FormKarateca
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
            this.btnOkEstilista = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEstorbo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cbxCiudad = new System.Windows.Forms.ComboBox();
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
            // btnOkEstilista
            // 
            this.btnOkEstilista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnOkEstilista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOkEstilista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOkEstilista.ForeColor = System.Drawing.Color.Black;
            this.btnOkEstilista.Location = new System.Drawing.Point(106, 261);
            this.btnOkEstilista.Name = "btnOkEstilista";
            this.btnOkEstilista.Size = new System.Drawing.Size(120, 30);
            this.btnOkEstilista.TabIndex = 33;
            this.btnOkEstilista.Text = "OK";
            this.btnOkEstilista.UseVisualStyleBackColor = false;
            this.btnOkEstilista.Click += new System.EventHandler(this.btnOkEstilista_Click);
            this.btnOkEstilista.Move += new System.EventHandler(this.btnOkEstilista_Move);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNombre.Location = new System.Drawing.Point(129, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 22);
            this.txtNombre.TabIndex = 30;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCodigo.Location = new System.Drawing.Point(129, 45);
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
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblApellido.Location = new System.Drawing.Point(35, 125);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(84, 16);
            this.lblApellido.TabIndex = 49;
            this.lblApellido.Text = "APELLIDO:";
            this.lblApellido.Visible = false;
            // 
            // txtApelido
            // 
            this.txtApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtApelido.Location = new System.Drawing.Point(129, 124);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(169, 22);
            this.txtApelido.TabIndex = 48;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPeso.Location = new System.Drawing.Point(37, 168);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(53, 16);
            this.lblPeso.TabIndex = 51;
            this.lblPeso.Text = "PESO:";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPeso.Location = new System.Drawing.Point(129, 162);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(169, 22);
            this.txtPeso.TabIndex = 50;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCiudad.Location = new System.Drawing.Point(40, 203);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(69, 16);
            this.lblCiudad.TabIndex = 52;
            this.lblCiudad.Text = "CIUDAD:";
            // 
            // cbxCiudad
            // 
            this.cbxCiudad.FormattingEnabled = true;
            this.cbxCiudad.Location = new System.Drawing.Point(129, 203);
            this.cbxCiudad.Name = "cbxCiudad";
            this.cbxCiudad.Size = new System.Drawing.Size(169, 21);
            this.cbxCiudad.TabIndex = 54;
            // 
            // FormKarateca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(330, 303);
            this.Controls.Add(this.cbxCiudad);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.lblEstorbo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblDecription);
            this.Controls.Add(this.btnOkEstilista);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Name = "FormKarateca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estilista";
            this.Load += new System.EventHandler(this.FormKarateca_Load);
            this.VisibleChanged += new System.EventHandler(this.FormEstilista_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDecription;
        private System.Windows.Forms.Button btnOkEstilista;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEstorbo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.ComboBox cbxCiudad;
    }
}