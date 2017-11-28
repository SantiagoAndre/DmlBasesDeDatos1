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
        public FormInscripcion(FormTable formTable)
        {
            this.aFormTable = formTable;
            InitializeComponent();
        }
        private void moveToForm(Form form)
        {
            this.Visible = false;
            form.ShowDialog(this);
            this.Show();
        }
        private void setEnabledAllChecks(Boolean value)
        {
            ckcCodeDip.Enabled = value;
            ckcCodeEst.Enabled = value;
            ckcStarDate.Enabled = value;
            ckcEndDate.Enabled = value;
        }
        private void setCheckAllChecks(Boolean value)
        {
            ckcCodeDip.Checked = value;
             ckcCodeEst.Checked = value;
            ckcStarDate.Checked = value;
            ckcEndDate.Checked = value;
        }


        public void setMode(string newMode)
        {
            if (newMode == currentMode)
                return;
            this.currentMode = newMode;
            this.lblDecription.Text = currentMode + " INSCRIPCION";

            if (newMode == FormGestion.SUB_MODE_RECORDER)
            {
                setEnabledAllChecks(false);
                setCheckAllChecks(true);
            }
            else
            {
                setEnabledAllChecks(true);
                setCheckAllChecks(false);
            }

        }

        private Boolean getData(ref int codeDip, ref int codeEst, ref string startDate , ref string endDate)
        {
            try {
                if (true)
                    codeEst = Int32.Parse(txtCodeEst.Text);
                else
                    codeEst = -1;
                if (ckcCodeDip.Checked)
                    codeDip = Int32.Parse(txtCodeDip.Text);
                else
                    codeDip= -1;
                if (ckcStarDate.Checked)
                    startDate = dtpStartDate.Value.ToShortDateString();
                else
                    startDate = null;
                if (ckcEndDate.Checked)
                    endDate = dtpEndDate.Value.ToShortDateString();
                else
                    endDate = null;
                return true;
            }catch
            {
                return false;
            }
        }
        private string recorderInscripcion()
        {
            int codeDip = 0, codeEst = 0;
            string startDate = "", endDate = "";
            if (getData(ref codeEst, ref codeDip, ref startDate, ref endDate))
                return Logica.Inscripcion.enrollingEstilistaInDiplomado(codeEst, codeDip, startDate, endDate);
            else
                return "Error: todos los campos checkeados son obligatorios";

        }
        private string findInscripcion()
        {
            int codeDip = 0, codeEst = 0;
            string startDate = "", endDate = "";
            if (!getData(ref codeDip, ref codeEst, ref startDate, ref endDate))
                return "Error: todos los campos checkeados son obligatorios";
            DataTable results =  Logica.Inscripcion.findInscription(codeDip,codeEst,startDate,endDate);
            if(results.Rows.Count == 0)
                return "No hay ninguna coincidencia."; 
            aFormTable.setTable("Resultado busqueda:", results);
            moveToForm(aFormTable);
            return null;
        }
        private void btnOkInscripcion_Click(object sender, EventArgs e)
        {
            string msg;
            if (currentMode == FormGestion.SUB_MODE_RECORDER)
                msg =recorderInscripcion();
            else
                msg = findInscripcion();
            MessageBox.Show(msg);
        }

        private void txtOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (!char.IsDigit(keypress) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }

        private void ckcCodeDip_CheckedChanged(object sender, EventArgs e)
        {
            txtCodeDip.Enabled = ((CheckBox)sender).Checked;
        }
        private void ckcCodeEst_CheckedChanged(object sender, EventArgs e)
        {
            txtCodeEst.Enabled = ((CheckBox)sender).Checked;
        }
        private void ckcStarDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = ((CheckBox)sender).Checked;
        }
        private void ckcEndDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpEndDate.Enabled = ((CheckBox)sender).Checked;
        }

        private string currentMode;
        private FormTable aFormTable;
    }
}
