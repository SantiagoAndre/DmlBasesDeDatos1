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
            //pasa de un formulario o otro
            this.Visible = false;
            form.ShowDialog(this);
            this.Show();
        }

        private String obtenerFecha()
        {
            //obtiene la fecha
            return  dtpFecha.Value.ToShortDateString();
               
        }
        private void filtrarParticipaciones()
        {
            //metodo principal que se comunica con la capa logica
            //obtiene los datos de las entradas y se los manda a la logica
            string fecha = obtenerFecha();
            DataTable dt = Logica.Participacion.filtrarPorFecha(fecha);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay coincidencias de busqueda");
            }
            else
            {
                aFormTable.setTable("Participaciones", dt);
                pasarAForm(aFormTable);
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            //se ejecuta cuando se oprime el boton OK
            filtrarParticipaciones();
            
            
        }

       


        
    }
}
