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
            aFormTable = new FormTable();

        }

        private void btnDiplomado_Click(object sender, EventArgs e)
        {
            aFormGestion.setModoGestion(Interfaz.FormGestion.MODE_DIPLOMADO);
            pasarAForm(aFormGestion);
        }

        private void btnEstilista_Click(object sender, EventArgs e)
        {
            aFormGestion.setModoGestion(Interfaz.FormGestion.MODE_ESTILISTA);
            pasarAForm(aFormGestion);
        }



        private void btnInscribe_Click(object sender, EventArgs e)
        {
            aFormGestion.setModoGestion(Interfaz.FormGestion.MODE_INSCRIBIR);
            pasarAForm(aFormGestion);
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
        
        private void pasarAForm(Form form)
        {
            this.Visible = false;
            form.ShowDialog(this);
            this.Show();
        }
        private FormGestion aFormGestion;
        private FormTable aFormTable;

        private void btnCoutEst_Click(object sender, EventArgs e)
        {
            int count = Logica.Estilista.counterEstilistasOfMaleGender();
            string msg;
            if (count == 0)
                msg = "No hay estilistas de genero masculino";
            else
                msg = String.Format("Hay {0} estilistas de genero masculino", count);
            MessageBox.Show(msg);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
