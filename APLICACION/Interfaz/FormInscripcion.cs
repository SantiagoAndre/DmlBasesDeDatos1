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
        private void clearInpus()
        {
            this.txtCodeDip.Text = string.Empty;
            this.txtCodeEst.Text = string.Empty;
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


        public void setModo(string newMode)
        {
            this.currentMode = newMode;

            if (newMode == FormGestion.OPCION_CREAR)
            {
                setEnabledAllChecks(false);
                setCheckAllChecks(true);
                this.lblDecription.Text = "REALIZAR INSCRIPCION";
            }
            else
            {
                setCheckAllChecks(false);
                setEnabledAllChecks(true);
                this.lblDecription.Text = currentMode + " INSCRIPCION";
            }

        }

        private Boolean getData(ref int codeDip, ref int codeEst, ref string startDate , ref string endDate)
        {
            try {
                if (ckcCodeEst.Checked)
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
            if (getData(ref codeDip, ref codeEst, ref startDate, ref endDate))
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
            if (currentMode == FormGestion.OPCION_CREAR)
                msg = recorderInscripcion();
            else
                msg = findInscripcion();
            if(msg != null)
                MessageBox.Show(msg);
            clearInpus();
            
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


        private void pcb_Click(object sender, EventArgs e)
        {
            string msg;
            if (currentMode == FormGestion.OPCION_CREAR)
                msg = descriptionRecorder;
            else
                msg = descriptionFind;
            if(msg != null)
                    MessageBox.Show(msg);
            clearInpus();

        }
        private string currentMode;
        private FormTable aFormTable;
        private string descriptionRecorder = "ingrese el codigo del estilista, el diplomado, y las fechas de inicio y de fin.";
        private string descriptionFind = "selecciones las casillas por las cuales quiere filtrar.";

        private void FormInscripcion_VisibleChanged(object sender, EventArgs e)
        {
            clearInpus();
        }
    }
}
