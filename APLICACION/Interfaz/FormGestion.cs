
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
    public partial class FormGestion : Form
    {
        public FormGestion( ) 
        {
            InitializeComponent();
            
            initChildren();
        }
        public void initChildren()
        {
            this.childDiplomado = new FromDiplomado();
            this.childEstilista = new Interfaz.FormEstilista();

        }
        private void pasarAForm(Form form)
        {
            this.Visible = false;
            form.ShowDialog(this);
            this.Show();
        }
        public void setModoGestion(string newMode)
        {
            aModoGestion = newMode;
            this.lblModo.Text = "GESTION " + newMode;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form nuevoForm;
            if (this.aModoGestion == MODO_DIPLOMADO)
            {
                this.childDiplomado.setModo(SUB_MODO_REGISTRAR);
                nuevoForm = this.childDiplomado;
            }
            else
            {
                this.childEstilista.setModo(SUB_MODO_REGISTRAR);
                nuevoForm = this.childEstilista;
            }
            pasarAForm(nuevoForm);
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form nuevoForm;
            if (this.aModoGestion == MODO_DIPLOMADO)
            {
                this.childDiplomado.setModo(SUB_MODO_ACTUALIZAR);
                nuevoForm = this.childDiplomado;
            }
            else
            {
                this.childEstilista.setModo(SUB_MODO_ACTUALIZAR);
                nuevoForm = this.childEstilista;
            }
            pasarAForm(nuevoForm);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Form nuevoForm;
            if (this.aModoGestion == MODO_DIPLOMADO)
            {
                this.childDiplomado.setModo(SUB_MODO_ELIMINAR);
                nuevoForm = this.childDiplomado;
            }
            else
            {
                this.childEstilista.setModo(SUB_MODO_ELIMINAR);
                nuevoForm = this.childEstilista;
            }
            pasarAForm(nuevoForm);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private FromDiplomado childDiplomado;
        private Interfaz.FormEstilista childEstilista;
        private string aModoGestion = "DIPLOMADO";
        public static string MODO_DIPLOMADO = " DIPLOMADO ";
        public static string MODODO_ESTILISTA = "ESTILISTA";

        public static string SUB_MODO_REGISTRAR = "REGISTRAR";
        public static string SUB_MODO_ACTUALIZAR = "ACTUAIZAR";
        public static string SUB_MODO_ELIMINAR = " ELIMINAR";

    }
}
