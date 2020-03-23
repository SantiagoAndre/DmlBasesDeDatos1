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
    public partial class FormParticipa : Form
    {
        public FormParticipa()
        {
            InitializeComponent();
        }
        private void limpiarEntradas()
        {
            this.txtCodigoKarateca.Text = string.Empty;
            this.txtCodigoTorneo.Text = string.Empty;
        }
    
       

        private Boolean getData(ref int codigoKarateca, ref int codigoTorneo, ref string fecha , ref string hora)
        {
            try {
               
                    codigoTorneo = Int32.Parse(txtCodigoTorneo.Text);
                    codigoKarateca = Int32.Parse(txtCodigoKarateca.Text);
                    fecha = dtpFecha.Value.ToShortDateString();
                    hora = dtpHora.Value.ToString("HH:mm:ss");
                return true;
            }catch
            {
                return false;
            }
        }
        private string registrarParticipacion()
        {
            int codigoKarateca = 0, codigoTorneo = 0;
            string fecha = "", hora = "";
            if (getData(ref  codigoKarateca, ref  codigoTorneo, ref  fecha, ref  hora))
                return Logica.Participacion.registrar( codigoKarateca,  codigoTorneo,  fecha,  hora);
            else
                return "Error: todos los campos  son obligatorios";

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            String msg = registrarParticipacion();
            if(msg != null)
                MessageBox.Show(msg);
            
        }

        private void txtOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (!char.IsDigit(keypress) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }


        
        private void FormInscripcion_VisibleChanged(object sender, EventArgs e)
        {
            limpiarEntradas();
        }
    }
}
