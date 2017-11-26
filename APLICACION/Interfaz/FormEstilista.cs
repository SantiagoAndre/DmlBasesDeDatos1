using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APLICACION.Interfaz
{
    public partial class FormEstilista : Form
    {
        public FormEstilista()
        {
            InitializeComponent();
        }
        private Boolean isInFullView()
        {
            return this.dtpFechaEst.Visible;
        }
        private void rotateView(string nuevoModo)
        {

            if (modo == null && nuevoModo == FormGestion.SUB_MODO_ACTUALIZAR)
            {
                showSomeComponets();
                this.btnOkEstilista.Location = new Point(50, 88);
                this.ClientSize = new System.Drawing.Size(284, 153);
            }
            else if (modo == FormGestion.SUB_MODO_ACTUALIZAR)
            {
                if (isInFullView())
                {
                    showSomeComponets();
                    this.btnOkEstilista.Location = new Point(50, 88);
                    this.ClientSize = new System.Drawing.Size(284, 153);
                    this.txtCodEst.Enabled = true;
                }
                else
                {
                    showAllComponets();
                    this.btnOkEstilista.Location = new Point(50, 213);
                    this.ClientSize = new System.Drawing.Size(284, 278);
                    this.txtCodEst.Enabled = false;
                }
            }else if (modo == nuevoModo)
                return;
            else if (nuevoModo == FormGestion.SUB_MODO_REGISTRAR)
            {
                showAllComponets();
                this.btnOkEstilista.Location = new Point(50, 213);
                this.ClientSize = new System.Drawing.Size(284, 278);
            }
            else
            {
                showSomeComponets();
                this.ckcModeDrop.Visible = true;
                this.ckcModeDrop.Checked = false;
                this.btnOkEstilista.Location = new Point(50, 130);
                this.ClientSize = new System.Drawing.Size(284, 195);
            }

        }
        public void setModo(string nuevoModo)
        {
            if (nuevoModo == modo)
                return;
            rotateView(nuevoModo);
            this.modo = nuevoModo;
            this.lblDecripcion.Text = modo + " ESTILISTA";

        }
        private void clearComponents()
        {
            this.txtCodEst.Enabled = true;
            this.txtCodEst.Clear();
            this.txtNombreEst.Clear();
            this.rbtFemenino.Checked = false;
            this.dtpFechaEst.Text = "";
        }
        private void showSomeComponets()
        {
            this.ckcModeDrop.Visible = false;
            this.lblNombreEst.Visible = false;
            this.lblSexo.Visible = false;
            this.lblFechaEst.Visible = false;
            this.txtNombreEst.Visible = false;
            this.rbtFemenino.Visible = false;
            this.rbtMasculino.Visible = false;
            this.dtpFechaEst.Visible = false;
        }
        private void showAllComponets()
        {
            this.ckcModeDrop.Visible = false;
            this.lblNombreEst.Visible = true;
            this.lblSexo.Visible = true;
            this.lblFechaEst.Visible = true;
            this.txtNombreEst.Visible = true;
            this.rbtFemenino.Visible = true;
            this.rbtMasculino.Visible = true;
            this.dtpFechaEst.Visible = true;

        }

        private void rbtFemenino_CheckedChanged(object sender, EventArgs e)
        {
            rbtMasculino.Checked = false;
        }
        private void rbtMasculino_CheckedChanged(object sender, EventArgs e)
        {
            rbtFemenino.Checked = false;
        }



        

        private void FormEstilista_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                clearComponents();
                modo = null;
            }
        }

        
        private void btnOkEstilista_Click(object sender, EventArgs e)
        {

            rotateView(modo);
        }



        private void txt_onlyNumbers_KeyPerss(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (!char.IsDigit(keypress) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }
        private string modo;
    }
}



