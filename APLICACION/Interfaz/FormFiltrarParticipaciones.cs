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
    public partial class FormFiltrarParticipaciones : Form
    {
        private FormTable aFormTable;

        public FormFiltrarParticipaciones()
        {
            InitializeComponent();
            aFormTable = new FormTable();
        }
        private void pasarAForm(Form form)
        {
            this.Visible = false;
            form.ShowDialog(this);
            this.Show();
        }

        private String obtenerFecha()
        {
            return  dtpFecha.Value.ToShortDateString();
               
        }
        private void filtrarParticipaciones()
        {
            string fecha = obtenerFecha();
            DataTable dt = Logica.Participacion.filtrarPorFecha(fecha);

            aFormTable.setTable("Participaciones", dt);
            pasarAForm(aFormTable);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            filtrarParticipaciones();
            
            
        }

       


        
    }
}
