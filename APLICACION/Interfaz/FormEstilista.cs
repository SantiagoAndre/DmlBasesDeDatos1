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
        public void setModo(string nuevoModo)
        {
            
            if (nuevoModo == Interfaz.FromDiplomado.MODO_REGISTRAR)
            {
                showAllComponets();
                this.btnOkEstilista.Location = new Point(50, 213);
                this.ClientSize = new System.Drawing.Size(284, 278);
            }
            else
            {
                showSomeComponets();
                this.btnOkEstilista.Location = new Point(50, 88);
                this.ClientSize = new System.Drawing.Size(284, 153);
            }
            this.modo = nuevoModo;
            this.lblDecripcion.Text = modo + " ESTILISTA";

        }
        private void clearComponents()
        {
            this.txtCodEst.Clear();
            this.txtNombreEst.Clear();
            this.rbtFemenino.Checked = false;
            this.dtpFechaEst.Text ="";
        }
        private void showSomeComponets(){
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

        private void btnOkDiplomado_Click(object sender, EventArgs e)
        {

        }

       
        private string modo;

        private void FormEstilista_VisibleChanged(object sender, EventArgs e)
        {
            clearComponents();
        }
    }
}
