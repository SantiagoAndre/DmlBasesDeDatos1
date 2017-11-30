
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
            this.childDiplomado = new FromDiplomado();
            this.childEstilista = new Interfaz.FormEstilista(formTable);
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
            if(aModoGestion == MODE_INSCRIBIR)
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
            if (this.aModoGestion == MODE_DIPLOMADO)
            {
                this.childDiplomado.setModo(SUB_MODE_RECORDER);
                nuevoForm = this.childDiplomado;
            }
            else if(aModoGestion == MODE_ESTILISTA)
            {
                this.childEstilista.setModo(SUB_MODE_RECORDER);
                nuevoForm = this.childEstilista;
            }
            else
            {
                this.childnscripcion.setMode(SUB_MODE_RECORDER);
                nuevoForm = this.childnscripcion;
            }
            pasarAForm(nuevoForm);
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form nuevoForm;
            if (this.aModoGestion == MODE_DIPLOMADO)
            {
                this.childDiplomado.setModo(SUB_MODE_UPDATE);
                nuevoForm = this.childDiplomado;
            }
            else
            {
                this.childEstilista.setModo(SUB_MODE_UPDATE);
                nuevoForm = this.childEstilista;
            }
            pasarAForm(nuevoForm);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Form nuevoForm;
            if (this.aModoGestion == MODE_DIPLOMADO)
            {
                this.childDiplomado.setModo(SUB_MODE_DROP);
                nuevoForm = this.childDiplomado;
            }
            else
            {
                this.childEstilista.setModo(SUB_MODE_DROP);
                nuevoForm = this.childEstilista;
            }
            pasarAForm(nuevoForm);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btFind_Click(object sender, EventArgs e)
        {
            Form nuevoForm;
            if (this.aModoGestion == MODE_DIPLOMADO)
            {
            }
            else if (aModoGestion == MODE_ESTILISTA)
            {
                childEstilista.setModo(SUB_MODE_FIND);
                nuevoForm = childEstilista;
                pasarAForm(nuevoForm);
            }else
            {
                childnscripcion.setMode(SUB_MODE_FIND);
                nuevoForm = childnscripcion;
                pasarAForm(nuevoForm);
            }
        }
        private FromDiplomado childDiplomado;
        private Interfaz.FormEstilista childEstilista;
        private FormInscripcion childnscripcion;
        private string aModoGestion;
        public static string MODE_DIPLOMADO = "DIPLOMADO";
        public static string MODE_ESTILISTA = "ESTILISTA";
        public static string MODE_INSCRIBIR=  "INSCRIBIR";

        public static string SUB_MODE_RECORDER = "REGISTRAR";
        public static string SUB_MODE_UPDATE = "ACTUAIZAR";
        public static string SUB_MODE_DROP = " ELIMINAR";
        public static string SUB_MODE_FIND = " BUSCAR";

        private void FormGestion_Load(object sender, EventArgs e)
        {

        }
    }
}
