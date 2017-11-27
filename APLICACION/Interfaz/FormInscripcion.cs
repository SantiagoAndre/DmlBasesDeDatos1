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
    public partial class FormInscripcion : Form
    {
        public FormInscripcion()
        {
            InitializeComponent();
        }
        private Boolean getData(ref int codeEst, ref int codeDip, ref string startDate , ref string endDate)
        {
            try {
                codeEst = Int32.Parse(txtCodeEst.Text);
                codeDip = Int32.Parse(txtCodeDip.Text);
                startDate = dtpStartDate.Value.ToShortDateString();
                endDate = dtpEndDate.Value.ToShortDateString();
                return true;
            }catch
            {
                return false;
            }
        }

        private void txtOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (!char.IsDigit(keypress) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }

        private void btnOkInscripcion_Click(object sender, EventArgs e)
        {
            int codeDip = 0, codeEst = 0;
            string startDate = "", endDate = "";
            string msg;
            if (getData(ref codeEst, ref codeDip, ref startDate, ref endDate))
                msg = Logica.Inscripcion.enrollingEstilistaInDiplomado(codeEst, codeDip, startDate, endDate);
            else
                msg = "Error: todos los campos son obligatorios";
            MessageBox.Show(msg);
        }
    }
}
