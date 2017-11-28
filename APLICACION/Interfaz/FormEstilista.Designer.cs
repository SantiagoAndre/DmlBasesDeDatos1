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
            this.txtCodeEst = new System.Windows.Forms.TextBox();
            this.rbtMaleGender = new System.Windows.Forms.RadioButton();
            this.rbtFemaleGender = new System.Windows.Forms.RadioButton();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.ckcNameEst = new System.Windows.Forms.CheckBox();
            this.ckcCodeEst = new System.Windows.Forms.CheckBox();
            this.ckcGenderEst = new System.Windows.Forms.CheckBox();
            this.ckcBirthdate = new System.Windows.Forms.CheckBox();
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
            this.btnOkEstilista.Move += new System.EventHandler(this.btnOkEstilista_Move);
            // 
            // txtNameEst
            // 
            this.txtNameEst.Location = new System.Drawing.Point(100, 88);
            this.txtNameEst.Name = "txtNameEst";
            this.txtNameEst.Size = new System.Drawing.Size(162, 20);
            this.txtNameEst.TabIndex = 30;
            // 
            // txtCodeEst
            // 
            this.txtCodeEst.Location = new System.Drawing.Point(100, 48);
            this.txtCodeEst.Name = "txtCodeEst";
            this.txtCodeEst.Size = new System.Drawing.Size(162, 20);
            this.txtCodeEst.TabIndex = 26;
            this.txtCodeEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_onlyNumbers_KeyPerss);
            // 
            // rbtMaleGender
            // 
            this.rbtMaleGender.AutoSize = true;
            this.rbtMaleGender.Location = new System.Drawing.Point(100, 129);
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
            this.rbtFemaleGender.Location = new System.Drawing.Point(191, 129);
            this.rbtFemaleGender.Name = "rbtFemaleGender";
            this.rbtFemaleGender.Size = new System.Drawing.Size(81, 17);
            this.rbtFemaleGender.TabIndex = 36;
            this.rbtFemaleGender.Text = "FEMENINO";
            this.rbtFemaleGender.UseVisualStyleBackColor = true;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Location = new System.Drawing.Point(127, 162);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(135, 23);
            this.dtpBirthdate.TabIndex = 38;
            this.dtpBirthdate.MaxDate = System.DateTime.Today;
            // 
            // ckcNameEst
            // 
            this.ckcNameEst.AutoSize = true;
            this.ckcNameEst.Checked = true;
            this.ckcNameEst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckcNameEst.Enabled = false;
            this.ckcNameEst.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckcNameEst.Location = new System.Drawing.Point(25, 88);
            this.ckcNameEst.Name = "ckcNameEst";
            this.ckcNameEst.Size = new System.Drawing.Size(75, 19);
            this.ckcNameEst.TabIndex = 39;
            this.ckcNameEst.Text = "NOMBRE:";
            this.ckcNameEst.UseVisualStyleBackColor = true;
            this.ckcNameEst.Visible = false;
            this.ckcNameEst.CheckedChanged += new System.EventHandler(this.ckcNameEst_CheckedChanged);
            // 
            // ckcCodeEst
            // 
            this.ckcCodeEst.AutoSize = true;
            this.ckcCodeEst.Checked = true;
            this.ckcCodeEst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckcCodeEst.Enabled = false;
            this.ckcCodeEst.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckcCodeEst.Location = new System.Drawing.Point(25, 50);
            this.ckcCodeEst.Name = "ckcCodeEst";
            this.ckcCodeEst.Size = new System.Drawing.Size(75, 19);
            this.ckcCodeEst.TabIndex = 40;
            this.ckcCodeEst.Text = "CODIGO:";
            this.ckcCodeEst.UseVisualStyleBackColor = true;
            this.ckcCodeEst.CheckedChanged += new System.EventHandler(this.ckcCodeEst_CheckedChanged);
            // 
            // ckcGenderEst
            // 
            this.ckcGenderEst.AutoSize = true;
            this.ckcGenderEst.Checked = true;
            this.ckcGenderEst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckcGenderEst.Enabled = false;
            this.ckcGenderEst.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckcGenderEst.Location = new System.Drawing.Point(25, 129);
            this.ckcGenderEst.Name = "ckcGenderEst";
            this.ckcGenderEst.Size = new System.Drawing.Size(75, 19);
            this.ckcGenderEst.TabIndex = 41;
            this.ckcGenderEst.Text = "GENERO:";
            this.ckcGenderEst.UseVisualStyleBackColor = true;
            this.ckcGenderEst.CheckedChanged += new System.EventHandler(this.ckcGenderEst_CheckedChanged);
            // 
            // ckcBirthdate
            // 
            this.ckcBirthdate.AutoSize = true;
            this.ckcBirthdate.Checked = true;
            this.ckcBirthdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckcBirthdate.Enabled = false;
            this.ckcBirthdate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckcBirthdate.Location = new System.Drawing.Point(25, 167);
            this.ckcBirthdate.Name = "ckcBirthdate";
            this.ckcBirthdate.Size = new System.Drawing.Size(96, 19);
            this.ckcBirthdate.TabIndex = 42;
            this.ckcBirthdate.Text = "BIRTHDATE:";
            this.ckcBirthdate.UseVisualStyleBackColor = true;
            this.ckcBirthdate.CheckedChanged += new System.EventHandler(this.ckcBirthdate_CheckedChanged);
            // 
            // FormEstilista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.ckcBirthdate);
            this.Controls.Add(this.ckcGenderEst);
            this.Controls.Add(this.ckcCodeEst);
            this.Controls.Add(this.ckcNameEst);
            this.Controls.Add(this.rbtFemaleGender);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.rbtMaleGender);
            this.Controls.Add(this.lblDecription);
            this.Controls.Add(this.btnOkEstilista);
            this.Controls.Add(this.txtNameEst);
            this.Controls.Add(this.txtCodeEst);
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
        private System.Windows.Forms.TextBox txtCodeEst;
        private System.Windows.Forms.RadioButton rbtMaleGender;
        private System.Windows.Forms.RadioButton rbtFemaleGender;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.CheckBox ckcNameEst;
        private System.Windows.Forms.CheckBox ckcCodeEst;
        private System.Windows.Forms.CheckBox ckcGenderEst;
        private System.Windows.Forms.CheckBox ckcBirthdate;
    }
}