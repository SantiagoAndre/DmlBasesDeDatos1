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
            this.lblDecription = new System.Windows.Forms.Label();
            this.btnOkEstilista = new System.Windows.Forms.Button();
            this.txtNameEst = new System.Windows.Forms.TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNameEst = new System.Windows.Forms.Label();
            this.txtCodeEst = new System.Windows.Forms.TextBox();
            this.lblCodeEst = new System.Windows.Forms.Label();
            this.rbtMaleGender = new System.Windows.Forms.RadioButton();
            this.rbtFemaleGender = new System.Windows.Forms.RadioButton();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.ckcModeDrop = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblDecription
            // 
            this.lblDecription.AutoSize = true;
            this.lblDecription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecription.Location = new System.Drawing.Point(68, 3);
            this.lblDecription.Name = "lblDecription";
            this.lblDecription.Size = new System.Drawing.Size(70, 15);
            this.lblDecription.TabIndex = 34;
            this.lblDecription.Text = "ESTILISTA";
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
            this.btnOkEstilista.Click += new System.EventHandler(this.btnOkEstilista_Click);
            // 
            // txtNameEst
            // 
            this.txtNameEst.Location = new System.Drawing.Point(100, 88);
            this.txtNameEst.Name = "txtNameEst";
            this.txtNameEst.Size = new System.Drawing.Size(162, 20);
            this.txtNameEst.TabIndex = 30;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.Location = new System.Drawing.Point(22, 168);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(77, 28);
            this.lblBirthdate.TabIndex = 29;
            this.lblBirthdate.Text = "FECHA\r\nNACMIENTO:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(22, 128);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(49, 15);
            this.lblGender.TabIndex = 28;
            this.lblGender.Text = "SEXO: ";
            // 
            // lblNameEst
            // 
            this.lblNameEst.AutoSize = true;
            this.lblNameEst.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEst.Location = new System.Drawing.Point(22, 88);
            this.lblNameEst.Name = "lblNameEst";
            this.lblNameEst.Size = new System.Drawing.Size(56, 15);
            this.lblNameEst.TabIndex = 27;
            this.lblNameEst.Text = "NOMBRE:";
            // 
            // txtCodeEst
            // 
            this.txtCodeEst.Location = new System.Drawing.Point(100, 48);
            this.txtCodeEst.Name = "txtCodeEst";
            this.txtCodeEst.Size = new System.Drawing.Size(162, 20);
            this.txtCodeEst.TabIndex = 26;
            this.txtCodeEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_onlyNumbers_KeyPerss);
            // 
            // lblCodeEst
            // 
            this.lblCodeEst.AutoSize = true;
            this.lblCodeEst.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeEst.Location = new System.Drawing.Point(22, 48);
            this.lblCodeEst.Name = "lblCodeEst";
            this.lblCodeEst.Size = new System.Drawing.Size(56, 15);
            this.lblCodeEst.TabIndex = 25;
            this.lblCodeEst.Text = "CODIGO:";
            // 
            // rbtMaleGender
            // 
            this.rbtMaleGender.AutoSize = true;
            this.rbtMaleGender.Location = new System.Drawing.Point(100, 126);
            this.rbtMaleGender.Name = "rbtMaleGender";
            this.rbtMaleGender.Size = new System.Drawing.Size(88, 17);
            this.rbtMaleGender.TabIndex = 35;
            this.rbtMaleGender.Text = "MASCULINO";
            this.rbtMaleGender.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbtMaleGender.UseVisualStyleBackColor = true;
            // 
            // rbtFemaleGender
            // 
            this.rbtFemaleGender.AutoSize = true;
            this.rbtFemaleGender.Location = new System.Drawing.Point(191, 126);
            this.rbtFemaleGender.Name = "rbtFemaleGender";
            this.rbtFemaleGender.Size = new System.Drawing.Size(81, 17);
            this.rbtFemaleGender.TabIndex = 36;
            this.rbtFemaleGender.Text = "FEMENINO";
            this.rbtFemaleGender.UseVisualStyleBackColor = true;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Location = new System.Drawing.Point(105, 170);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(157, 23);
            this.dtpBirthdate.TabIndex = 38;
            // 
            // ckcModeDrop
            // 
            this.ckcModeDrop.AutoSize = true;
            this.ckcModeDrop.Location = new System.Drawing.Point(25, 90);
            this.ckcModeDrop.Name = "ckcModeDrop";
            this.ckcModeDrop.Size = new System.Drawing.Size(222, 17);
            this.ckcModeDrop.TabIndex = 39;
            this.ckcModeDrop.Text = "BORRAR INSCRIPCIONES ASOCIADAS";
            this.ckcModeDrop.UseVisualStyleBackColor = true;
            this.ckcModeDrop.Visible = false;
            // 
            // FormEstilista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.ckcModeDrop);
            this.Controls.Add(this.rbtFemaleGender);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.rbtMaleGender);
            this.Controls.Add(this.lblDecription);
            this.Controls.Add(this.btnOkEstilista);
            this.Controls.Add(this.txtNameEst);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblNameEst);
            this.Controls.Add(this.txtCodeEst);
            this.Controls.Add(this.lblCodeEst);
            this.Name = "FormEstilista";
            this.Text = "Estilista";
            this.VisibleChanged += new System.EventHandler(this.FormEstilista_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDecription;
        private System.Windows.Forms.Button btnOkEstilista;
        private System.Windows.Forms.TextBox txtNameEst;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNameEst;
        private System.Windows.Forms.TextBox txtCodeEst;
        private System.Windows.Forms.Label lblCodeEst;
        private System.Windows.Forms.RadioButton rbtMaleGender;
        private System.Windows.Forms.RadioButton rbtFemaleGender;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.CheckBox ckcModeDrop;
    }
}