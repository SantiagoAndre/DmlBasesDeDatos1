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
            this.lblCodeEst = new System.Windows.Forms.Label();
            this.lblNameEst = new System.Windows.Forms.Label();
            this.lblGenderEst = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblEstorbo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDecription
            // 
            this.lblDecription.AutoSize = true;
            this.lblDecription.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDecription.Location = new System.Drawing.Point(90, 5);
            this.lblDecription.Name = "lblDecription";
            this.lblDecription.Size = new System.Drawing.Size(150, 16);
            this.lblDecription.TabIndex = 34;
            this.lblDecription.Text = "ACTUALIZAR ESTILISTA";
            // 
            // btnOkEstilista
            // 
            this.btnOkEstilista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnOkEstilista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOkEstilista.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOkEstilista.ForeColor = System.Drawing.Color.Black;
            this.btnOkEstilista.Location = new System.Drawing.Point(100, 210);
            this.btnOkEstilista.Name = "btnOkEstilista";
            this.btnOkEstilista.Size = new System.Drawing.Size(120, 30);
            this.btnOkEstilista.TabIndex = 33;
            this.btnOkEstilista.Text = "OK";
            this.btnOkEstilista.UseVisualStyleBackColor = false;
            this.btnOkEstilista.Click += new System.EventHandler(this.btnOkEstilista_Click);
            this.btnOkEstilista.Move += new System.EventHandler(this.btnOkEstilista_Move);
            // 
            // txtNameEst
            // 
            this.txtNameEst.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNameEst.Location = new System.Drawing.Point(129, 86);
            this.txtNameEst.Name = "txtNameEst";
            this.txtNameEst.Size = new System.Drawing.Size(169, 22);
            this.txtNameEst.TabIndex = 30;
            // 
            // txtCodeEst
            // 
            this.txtCodeEst.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCodeEst.Location = new System.Drawing.Point(129, 45);
            this.txtCodeEst.Name = "txtCodeEst";
            this.txtCodeEst.Size = new System.Drawing.Size(169, 22);
            this.txtCodeEst.TabIndex = 26;
            this.txtCodeEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_onlyNumbers_KeyPerss);
            // 
            // rbtMaleGender
            // 
            this.rbtMaleGender.AutoSize = true;
            this.rbtMaleGender.Font = new System.Drawing.Font("Crimson Text SemiBold", 11F, System.Drawing.FontStyle.Italic);
            this.rbtMaleGender.Location = new System.Drawing.Point(129, 123);
            this.rbtMaleGender.Name = "rbtMaleGender";
            this.rbtMaleGender.Size = new System.Drawing.Size(84, 23);
            this.rbtMaleGender.TabIndex = 35;
            this.rbtMaleGender.Text = "Masculino";
            this.rbtMaleGender.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbtMaleGender.UseVisualStyleBackColor = true;
            // 
            // rbtFemaleGender
            // 
            this.rbtFemaleGender.AutoSize = true;
            this.rbtFemaleGender.Font = new System.Drawing.Font("Crimson Text SemiBold", 11F, System.Drawing.FontStyle.Italic);
            this.rbtFemaleGender.Location = new System.Drawing.Point(218, 123);
            this.rbtFemaleGender.Name = "rbtFemaleGender";
            this.rbtFemaleGender.Size = new System.Drawing.Size(80, 23);
            this.rbtFemaleGender.TabIndex = 36;
            this.rbtFemaleGender.Text = "Femenino";
            this.rbtFemaleGender.UseVisualStyleBackColor = true;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Font = new System.Drawing.Font("Crimson Text SemiBold", 10.5F, System.Drawing.FontStyle.Bold);
            this.dtpBirthdate.Location = new System.Drawing.Point(129, 163);
            this.dtpBirthdate.MaxDate = new System.DateTime(2017, 11, 29, 0, 0, 0, 0);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(169, 23);
            this.dtpBirthdate.TabIndex = 38;
            this.dtpBirthdate.Value = new System.DateTime(2017, 11, 29, 0, 0, 0, 0);
            // 
            // ckcNameEst
            // 
            this.ckcNameEst.AutoSize = true;
            this.ckcNameEst.Checked = true;
            this.ckcNameEst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckcNameEst.Enabled = false;
            this.ckcNameEst.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ckcNameEst.Location = new System.Drawing.Point(17, 91);
            this.ckcNameEst.Name = "ckcNameEst";
            this.ckcNameEst.Size = new System.Drawing.Size(15, 14);
            this.ckcNameEst.TabIndex = 39;
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
            this.ckcCodeEst.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ckcCodeEst.Location = new System.Drawing.Point(17, 53);
            this.ckcCodeEst.Name = "ckcCodeEst";
            this.ckcCodeEst.Size = new System.Drawing.Size(15, 14);
            this.ckcCodeEst.TabIndex = 40;
            this.ckcCodeEst.UseVisualStyleBackColor = true;
            this.ckcCodeEst.CheckedChanged += new System.EventHandler(this.ckcCodeEst_CheckedChanged);
            // 
            // ckcGenderEst
            // 
            this.ckcGenderEst.AutoSize = true;
            this.ckcGenderEst.Checked = true;
            this.ckcGenderEst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckcGenderEst.Enabled = false;
            this.ckcGenderEst.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ckcGenderEst.Location = new System.Drawing.Point(17, 129);
            this.ckcGenderEst.Name = "ckcGenderEst";
            this.ckcGenderEst.Size = new System.Drawing.Size(15, 14);
            this.ckcGenderEst.TabIndex = 41;
            this.ckcGenderEst.UseVisualStyleBackColor = true;
            this.ckcGenderEst.CheckedChanged += new System.EventHandler(this.ckcGenderEst_CheckedChanged);
            // 
            // ckcBirthdate
            // 
            this.ckcBirthdate.AutoSize = true;
            this.ckcBirthdate.Checked = true;
            this.ckcBirthdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckcBirthdate.Enabled = false;
            this.ckcBirthdate.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ckcBirthdate.Location = new System.Drawing.Point(17, 170);
            this.ckcBirthdate.Name = "ckcBirthdate";
            this.ckcBirthdate.Size = new System.Drawing.Size(15, 14);
            this.ckcBirthdate.TabIndex = 42;
            this.ckcBirthdate.UseVisualStyleBackColor = true;
            this.ckcBirthdate.CheckedChanged += new System.EventHandler(this.ckcBirthdate_CheckedChanged);
            // 
            // lblCodeEst
            // 
            this.lblCodeEst.AutoSize = true;
            this.lblCodeEst.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCodeEst.Location = new System.Drawing.Point(37, 51);
            this.lblCodeEst.Name = "lblCodeEst";
            this.lblCodeEst.Size = new System.Drawing.Size(58, 16);
            this.lblCodeEst.TabIndex = 43;
            this.lblCodeEst.Text = "CODIGO:";
            this.lblCodeEst.Click += new System.EventHandler(this.lblCode_Click);
            // 
            // lblNameEst
            // 
            this.lblNameEst.AutoSize = true;
            this.lblNameEst.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNameEst.Location = new System.Drawing.Point(38, 90);
            this.lblNameEst.Name = "lblNameEst";
            this.lblNameEst.Size = new System.Drawing.Size(64, 16);
            this.lblNameEst.TabIndex = 44;
            this.lblNameEst.Text = "NOMBRE:";
            this.lblNameEst.Visible = false;
            this.lblNameEst.Click += new System.EventHandler(this.lblNameEst_Click);
            // 
            // lblGenderEst
            // 
            this.lblGenderEst.AutoSize = true;
            this.lblGenderEst.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblGenderEst.Location = new System.Drawing.Point(38, 127);
            this.lblGenderEst.Name = "lblGenderEst";
            this.lblGenderEst.Size = new System.Drawing.Size(61, 16);
            this.lblGenderEst.TabIndex = 45;
            this.lblGenderEst.Text = "GENERO:";
            this.lblGenderEst.Click += new System.EventHandler(this.lblGenderEst_Click);
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBirthdate.Location = new System.Drawing.Point(38, 168);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(80, 16);
            this.lblBirthdate.TabIndex = 46;
            this.lblBirthdate.Text = "BIRTHDATE:";
            this.lblBirthdate.Click += new System.EventHandler(this.lblBirthDateEst_Click);
            // 
            // lblEstorbo
            // 
            this.lblEstorbo.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.lblEstorbo.Font = new System.Drawing.Font("Crimson Text SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEstorbo.Location = new System.Drawing.Point(14, 45);
            this.lblEstorbo.Name = "lblEstorbo";
            this.lblEstorbo.Size = new System.Drawing.Size(20, 161);
            this.lblEstorbo.TabIndex = 47;
            this.lblEstorbo.Visible = false;
            // 
            // FormEstilista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(330, 265);
            this.Controls.Add(this.lblEstorbo);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblGenderEst);
            this.Controls.Add(this.lblNameEst);
            this.Controls.Add(this.lblCodeEst);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Label lblCodeEst;
        private System.Windows.Forms.Label lblNameEst;
        private System.Windows.Forms.Label lblGenderEst;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblEstorbo;
    }
}