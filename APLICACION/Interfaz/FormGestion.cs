
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
            FormTable formTable = new FormTable();
            this.childDiplomado = new FromCiudad();
            this.childKarateca = new Interfaz.FormTorneo1(formTable);
            this.childnscripcion = new FormInscripcion(formTable);
        }
        private void pasarAForm(Form form)
        {
            this.Visible = false;
            form.ShowDialog(this);
            this.Show();
        }
        public void setModoGestion(string newMode)
        {
            if (aModoGestion == newMode)
                return;
            aModoGestion = newMode;
            this.lblMode.Text =  newMode;
            if(aModoGestion == MOD0_TORNEO)
            {
                this.btnUpdate.Enabled = false;
                this.btnRemove.Enabled = false;
            }
            else
            {
                this.btnUpdate.Enabled = true;
                this.btnRemove.Enabled = true;

            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form nuevoForm;
            if(aModoGestion == MODO_KARATECA)
            {
                this.childKarateca.setModo(OPCION_CREAR);
                nuevoForm = this.childKarateca;
            }
            else
            {
                this.childnscripcion.setModo(OPCION_CREAR);
                nuevoForm = this.childnscripcion;
            }
            pasarAForm(nuevoForm);
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form nuevoForm= null;
            if (aModoGestion == MODO_KARATECA)
            {
                this.childKarateca.setModo(OPCION_ACTUALIZAR);
                nuevoForm = this.childKarateca;
            }
            pasarAForm(nuevoForm);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Form nuevoForm= null;
            if (aModoGestion == MODO_KARATECA)
            {
                this.childKarateca.setModo(OPCION_ELIMINAR);
                nuevoForm = this.childKarateca;
            }
            pasarAForm(nuevoForm);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

     
        private FromCiudad childDiplomado;
        private Interfaz.FormTorneo1 childKarateca;
        private FormInscripcion childnscripcion;
        private string aModoGestion;
        public static string MODO_KARATECA = "KARATECA";
        public static string MOD0_TORNEO=  "TORNEO";

        public static string OPCION_CREAR = "REGISTRAR";
        public static string OPCION_ACTUALIZAR = "ACTUAIZAR";
        public static string OPCION_ELIMINAR = " ELIMINAR";

        private void FormGestion_Load(object sender, EventArgs e)
        {

        }
    }
}
