
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
        //ESTA CLASE GESTIONA EL CRUD DE UNA TABLA
        // LE PERMITE AL USUARIO ELEGIR UNA DE LAS SIGUIENTES OPCIONES CON LA TABLA SELECCIONADA
        // CREAR: 
        // EDITAR
        // ELIMINAR
        // LLAMARA AL COMPONENTE RELACIONADO CON ESA TABLA.
        public FormGestion( ) 
        {
            InitializeComponent();
            
            initChildren();
        }
        public void initChildren()
        { 
            FormTable formTable = new FormTable();
            this.childKarateca = new Interfaz.FormKarateca(formTable);
            this.childTorneo = new Interfaz.FormTorneo2(formTable);

            //this.childnscripcion = new FormInscripcion(formTable);
        }
        private void pasarAForm(Form form)
        {
            this.Visible = false;
            form.ShowDialog(this);
            this.Show();
        }
        public void setModoGestion(string newMode)
        {
            if (aTabla == newMode)
                return;
            aTabla = newMode;
            this.lblMode.Text =  newMode;
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form nuevoForm;
            if(aTabla == TABLA_KARATECA)
            {
                this.childKarateca.cambiarAccion(OPCION_CREAR);
                nuevoForm = this.childKarateca;
            }
            else
            {
                this.childTorneo.cambiarAccion(OPCION_CREAR);
                nuevoForm = this.childTorneo;
            }
            pasarAForm(nuevoForm);
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form nuevoForm= null;
            if (aTabla == TABLA_KARATECA)
            {
                this.childKarateca.cambiarAccion(OPCION_ACTUALIZAR);
                nuevoForm = this.childKarateca;
            }
            else if (aTabla == TABLA_TORNEO)
            {
                this.childTorneo.cambiarAccion(OPCION_ACTUALIZAR);
                nuevoForm = this.childTorneo;
            }
            pasarAForm(nuevoForm);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Form nuevoForm= null;
            if (aTabla == TABLA_KARATECA)
            {
                this.childKarateca.cambiarAccion(OPCION_ELIMINAR);
                nuevoForm = this.childKarateca;
            }
            else
            {
                this.childTorneo.cambiarAccion(OPCION_ELIMINAR);
                nuevoForm = this.childTorneo;
            }
            pasarAForm(nuevoForm);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

     
        private Interfaz.FormKarateca childKarateca;
        private FormTorneo2 childTorneo;
        private string aTabla;
        public static string TABLA_KARATECA = "KARATECA";
        public static string TABLA_TORNEO =  "TORNEO";

        public static string OPCION_CREAR = "REGISTRAR";
        public static string OPCION_ACTUALIZAR = "ACTUAIZAR";
        public static string OPCION_ELIMINAR = " ELIMINAR";

        private void FormGestion_Load(object sender, EventArgs e)
        {

        }
    }
}
