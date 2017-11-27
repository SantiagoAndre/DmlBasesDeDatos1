using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APLICACION.Interfaz;


namespace APLICACION.Interfaz
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            aFormGestion = new FormGestion();
            aFormInscripcion = new FormInscripcion();
            aFormTable = new FormTable();

        }

        private void btnDiplomado_Click(object sender, EventArgs e)
        {
            aFormGestion.setModoGestion(Interfaz.FormGestion.MODO_DIPLOMADO);
            pasarAForm(aFormGestion);
        }

        private void btnEstilista_Click(object sender, EventArgs e)
        {
            aFormGestion.setModoGestion(Interfaz.FormGestion.MODODO_ESTILISTA);
            pasarAForm(aFormGestion);
        }

        private void pasarAForm(Form form)
        {
            this.Visible = false;
            form.ShowDialog(this);
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInscribe_Click(object sender, EventArgs e)
        {
            pasarAForm(aFormInscripcion);
        }

        private void btnShowInscripciones_Click(object sender, EventArgs e)
        {
            DataTable dt = Logica.Inscripcion.getAllInscriptions();
            
            aFormTable.setTable("Inscripciones", dt);
            pasarAForm(aFormTable);

        }
        private void btnFindInscripcion_Click(object sender, EventArgs e)
        {

        }
        private FormGestion aFormGestion;
        private FormInscripcion aFormInscripcion;
        private FormTable aFormTable;
    }
}
