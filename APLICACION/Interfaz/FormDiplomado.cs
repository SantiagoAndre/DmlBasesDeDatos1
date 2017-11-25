using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALBASES.Interfaz
{
    public partial class FromDiplomado : Form
    {
        public FromDiplomado(Logica.Diplomado dip)
        {
            setDiplomado(dip);

            InitializeComponent();
        }
        public void setDiplomado(Logica.Diplomado dip)
        {
            this.aDiplomado = dip;
        }
        public void setModo(string nuevoModo)
        {
            if (nuevoModo == MODO_REGISTRAR)
            {
                showAllComponets();
                this.btnOkDiplomado.Location = new Point(50, 213);
                this.ClientSize = new System.Drawing.Size(284, 278);
            }
            else
            {
                showSomeComponets();
                this.btnOkDiplomado.Location = new Point(50, 88);
                this.ClientSize = new System.Drawing.Size(284, 153);
            }
            this.modo = nuevoModo;
            this.lblDecripcion.Text = modo + " ESTILISTA";
            this.modo = nuevoModo;
            this.lblDecripcion.Text = modo + " DIPLOMADO";
        }
        private void clearComponents()
        {
            this.txtCodDip.Clear();
            this.txtNombreDip.Clear();
            this.cbxModalidadDip.Text = "";
        }
        private void showSomeComponets()
        {
            this.lblNombreDip.Visible = false;
            this.lblHDuracion.Visible = false;
            this.lblModalidadDip.Visible = false;
            this.txtNombreDip.Visible = false;
            this.txtHDuracionDip.Visible = false;
            this.cbxModalidadDip.Visible = false;
        }
        private void showAllComponets()
        {
            this.lblNombreDip.Visible = true;
            this.lblHDuracion.Visible = true;
            this.lblModalidadDip.Visible = true;
            this.txtNombreDip.Visible = true;
            this.txtHDuracionDip.Visible = true;
            this.cbxModalidadDip.Visible = true;

        }
        private void btnOkDiplomado_Click(object sender, EventArgs e)
        {

        }
        private void FromDiplomado_VisibleChanged(object sender, EventArgs e)
        {
            clearComponents();
        }
        private Logica.Diplomado aDiplomado;
        private string modo;
        public static string MODO_REGISTRAR = "REGISTRAR";
        public static string MODO_ACTUALIZAR ="ACTUAIZAR";
        public static string MODO_ELIMINAR= " ELIMINAR";

        private void cbxModalidadDip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FromDiplomado_Load(object sender, EventArgs e)
        {

        }
    }
}
