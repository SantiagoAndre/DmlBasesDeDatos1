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
            aFromCiudad = new FromCiudad();
            aFormTable = new FormTable();
            aFromParicipacion = new FormParticipa();
            aFromFiltarParticipaciones = new FormFiltrarParticipaciones();
        }

        private void btnCiudad_Click(object sender, EventArgs e)
        {
            pasarAForm(aFromCiudad);
        }

        private void btnEstilista_Click(object sender, EventArgs e)
        {
            aFormGestion.setModoGestion(Interfaz.FormGestion.TABLA_KARATECA);
            pasarAForm(aFormGestion);
        }



        private void btnInscribe_Click(object sender, EventArgs e)
        {
            aFormGestion.setModoGestion(Interfaz.FormGestion.TABLA_TORNEO);
            pasarAForm(aFormGestion);
        }

        private void btnShowInscripciones_Click(object sender, EventArgs e)
        {
            DataTable dt = Logica.Participacion.obtenerTodas();
            
            aFormTable.setTable("Participaciones", dt);
            pasarAForm(aFormTable);

        }
        private void btnParticipacion_Click(object sender, EventArgs e)
        {
            pasarAForm(aFromParicipacion);

        }
        
        private void pasarAForm(Form form)
        {
            this.Visible = false;
            form.ShowDialog(this);
            this.Show();
        }
        private FormGestion aFormGestion;
        private FromCiudad aFromCiudad;
        private FormTable aFormTable;
        private FormParticipa aFromParicipacion;
        private FormFiltrarParticipaciones aFromFiltarParticipaciones;

        private void btnCoutEst_Click(object sender, EventArgs e)
        {
            pasarAForm(aFromFiltarParticipaciones);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = Logica.Karateca.contarParticipanModalidadAnio("infantil", 2019);
            string msg;
            if (count == 0)
                msg = "No coincidencias con la busqueda";
            else
                msg = String.Format("Participaron {0} karatecas en la modalidad infantil en el año 2019. ", count);
            MessageBox.Show(msg);
        }
    }
}
