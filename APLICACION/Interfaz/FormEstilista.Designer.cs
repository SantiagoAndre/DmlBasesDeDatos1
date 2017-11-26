namespace APLICACION.Interfaz
{
    partial class FormEstilista
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
            this.lblDecripcion = new System.Windows.Forms.Label();
            this.btnOkEstilista = new System.Windows.Forms.Button();
            this.txtNombreEst = new System.Windows.Forms.TextBox();
            this.lblFechaEst = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNombreEst = new System.Windows.Forms.Label();
            this.txtCodEst = new System.Windows.Forms.TextBox();
            this.lblCodEst = new System.Windows.Forms.Label();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.dtpFechaEst = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblDecripcion
            // 
            this.lblDecripcion.AutoSize = true;
            this.lblDecripcion.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecripcion.Location = new System.Drawing.Point(68, 3);
            this.lblDecripcion.Name = "lblDecripcion";
            this.lblDecripcion.Size = new System.Drawing.Size(70, 15);
            this.lblDecripcion.TabIndex = 34;
            this.lblDecripcion.Text = "ESTILISTA";
            // 
            // btnOkEstilista
            // 
            this.btnOkEstilista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnOkEstilista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOkEstilista.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkEstilista.ForeColor = System.Drawing.Color.Black;
            this.btnOkEstilista.Location = new System.Drawing.Point(50, 213);
            this.btnOkEstilista.Name = "btnOkEstilista";
            this.btnOkEstilista.Size = new System.Drawing.Size(200, 45);
            this.btnOkEstilista.TabIndex = 33;
            this.btnOkEstilista.Text = "OK";
            this.btnOkEstilista.UseVisualStyleBackColor = false;
            this.btnOkEstilista.Click += new System.EventHandler(this.btnOkDiplomado_Click);
            // 
            // txtNombreEst
            // 
            this.txtNombreEst.Location = new System.Drawing.Point(100, 88);
            this.txtNombreEst.Name = "txtNombreEst";
            this.txtNombreEst.Size = new System.Drawing.Size(162, 20);
            this.txtNombreEst.TabIndex = 30;
            // 
            // lblFechaEst
            // 
            this.lblFechaEst.AutoSize = true;
            this.lblFechaEst.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEst.Location = new System.Drawing.Point(22, 168);
            this.lblFechaEst.Name = "lblFechaEst";
            this.lblFechaEst.Size = new System.Drawing.Size(77, 28);
            this.lblFechaEst.TabIndex = 29;
            this.lblFechaEst.Text = "FECHA\r\nNACMIENTO:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(22, 128);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(49, 15);
            this.lblSexo.TabIndex = 28;
            this.lblSexo.Text = "SEXO: ";
            // 
            // lblNombreEst
            // 
            this.lblNombreEst.AutoSize = true;
            this.lblNombreEst.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEst.Location = new System.Drawing.Point(22, 88);
            this.lblNombreEst.Name = "lblNombreEst";
            this.lblNombreEst.Size = new System.Drawing.Size(56, 15);
            this.lblNombreEst.TabIndex = 27;
            this.lblNombreEst.Text = "NOMBRE:";
            // 
            // txtCodEst
            // 
            this.txtCodEst.Location = new System.Drawing.Point(100, 48);
            this.txtCodEst.Name = "txtCodEst";
            this.txtCodEst.Size = new System.Drawing.Size(162, 20);
            this.txtCodEst.TabIndex = 26;
            // 
            // lblCodEst
            // 
            this.lblCodEst.AutoSize = true;
            this.lblCodEst.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEst.Location = new System.Drawing.Point(22, 48);
            this.lblCodEst.Name = "lblCodEst";
            this.lblCodEst.Size = new System.Drawing.Size(56, 15);
            this.lblCodEst.TabIndex = 25;
            this.lblCodEst.Text = "CODIGO:";
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(100, 126);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(88, 17);
            this.rbtMasculino.TabIndex = 35;
            this.rbtMasculino.Text = "MASCULINO";
            this.rbtMasculino.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbtMasculino.UseVisualStyleBackColor = true;
            this.rbtMasculino.CheckedChanged += new System.EventHandler(this.rbtMasculino_CheckedChanged);
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(191, 126);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(81, 17);
            this.rbtFemenino.TabIndex = 36;
            this.rbtFemenino.Text = "FEMENINO";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            this.rbtFemenino.CheckedChanged += new System.EventHandler(this.rbtFemenino_CheckedChanged);
            // 
            // dtpFechaEst
            // 
            this.dtpFechaEst.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEst.Location = new System.Drawing.Point(105, 170);
            this.dtpFechaEst.Name = "dtpFechaEst";
            this.dtpFechaEst.Size = new System.Drawing.Size(157, 23);
            this.dtpFechaEst.TabIndex = 38;
            // 
            // FormEstilista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.rbtFemenino);
            this.Controls.Add(this.dtpFechaEst);
            this.Controls.Add(this.rbtMasculino);
            this.Controls.Add(this.lblDecripcion);
            this.Controls.Add(this.btnOkEstilista);
            this.Controls.Add(this.txtNombreEst);
            this.Controls.Add(this.lblFechaEst);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNombreEst);
            this.Controls.Add(this.txtCodEst);
            this.Controls.Add(this.lblCodEst);
            this.Name = "FormEstilista";
            this.Text = "Estilista";
            this.VisibleChanged += new System.EventHandler(this.FormEstilista_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDecripcion;
        private System.Windows.Forms.Button btnOkEstilista;
        private System.Windows.Forms.TextBox txtNombreEst;
        private System.Windows.Forms.Label lblFechaEst;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNombreEst;
        private System.Windows.Forms.TextBox txtCodEst;
        private System.Windows.Forms.Label lblCodEst;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.DateTimePicker dtpFechaEst;
    }
}