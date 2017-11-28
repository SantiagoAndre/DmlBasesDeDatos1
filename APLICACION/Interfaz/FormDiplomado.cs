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
    public partial class FromDiplomado : Form
    {
        public FromDiplomado()
        {
            InitializeComponent();
        }
        public void setModo(string newMode)
        {
            rotateView(newMode);
            this.mode = newMode;
            this.lblDecripcion.Text = mode + " DIPLOMADO";
            this.mode = newMode;
            this.lblDecripcion.Text = mode + " DIPLOMADO";
        }

        private Boolean isInFullView()
        {
            return this.lblModalityDip.Visible;
        }
        private void rotateView(string newMode)
        {
            if(mode == null && newMode == FormGestion.SUB_MODE_UPDATE)
            {
                showSomeComponets();
                this.btnOkDiplomado.Location = new Point(50, 90);
                this.ClientSize = new System.Drawing.Size(284, 155);
            }else if (mode == FormGestion.SUB_MODE_UPDATE)
            {
                if (isInFullView())
                {
                    showSomeComponets();
                    this.btnOkDiplomado.Location = new Point(50, 90);
                    this.ClientSize = new System.Drawing.Size(284, 155);
                    this.txtCodeDip.Enabled = true;
                }
                else
                {
                    showAllComponets();
                    this.txtCodeDip.Enabled = false;
                    this.btnOkDiplomado.Location = new Point(50, 213);
                    this.ClientSize = new System.Drawing.Size(284, 278);
                }
            }else if (mode == newMode)
                return;
            else if (newMode == FormGestion.SUB_MODE_RECORDER)
            {
                showAllComponets();
                this.btnOkDiplomado.Location = new Point(50, 213);
                this.ClientSize = new System.Drawing.Size(284, 278);
            }
            else
            {
                showSomeComponets();
                this.ckcModeDrop.Visible = true;
                this.ckcModeDrop.Checked = false;
                this.btnOkDiplomado.Location = new Point(50, 130);
                this.ClientSize = new System.Drawing.Size(284, 195);
            }

        }
        private void clearComponents()
        {
            this.txtCodeDip.Enabled = true;
            this.txtCodeDip.Clear();
            this.txtNameDip.Clear();
            this.cbxModalityDip.Text = "";

        }
        private void showSomeComponets()
        {
            this.lblNameDip.Visible = false;
            this.lblDurationH.Visible = false;
            this.lblModalityDip.Visible = false;
            this.txtNameDip.Visible = false;
            this.txtDurationH.Visible = false;
            this.cbxModalityDip.Visible = false;
        }
        private void showAllComponets()
        {
            this.lblNameDip.Visible = true;
            this.lblDurationH.Visible = true;
            this.lblModalityDip.Visible = true;
            this.txtNameDip.Visible = true;
            this.txtDurationH.Visible = true;
            this.cbxModalityDip.Visible = true;
            this.ckcModeDrop.Visible = false;
        }
        
        private Boolean getData(ref int code, ref string name, ref int durationHours, ref string modality)
        {
            code = getCode();
            if (code == -1)
                return false;
            try
            {
                name = txtNameDip.Text.ToString().Trim();
                durationHours = Int32.Parse(txtDurationH.Text);
                modality = cbxModalityDip.Text.ToString().Trim();
            }
            catch 
            {
                return false;
            }
            if ("".Equals(name) || "".Equals(modality))
                return false;
            return true;
        }
        private int getCode()
        {
            try {
                int codigo = Int32.Parse(txtCodeDip.Text);
                return codigo;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        private string updateFindDiplomado()
        {
            int codBuscar;
            codBuscar = getCode();
            if (codBuscar == -1)
                return "Tienes que digitar un codigo";
            DataTable table = Logica.Diplomado.findDiplomado(codBuscar);
            if (table.Rows.Count != 0)
            {
                fillOutAllInputs(table);
                rotateView(mode);
            }
            else
            {
                return "no existe Diplomado con ese codigo";
            }
            return null;
        }
        private string updateDiplomado()
        {
            int codigo =-1, horas_duracion=-1;
            string nombre="", modalidad="";
            if (!getData(ref codigo, ref nombre, ref horas_duracion, ref modalidad))
                return "Error: todas las casillas son obligatorias";
            rotateView(mode);
            return Logica.Diplomado.updateDiplomado(codigo, nombre, horas_duracion, modalidad);
        }
        private string recorderDiplomado()
        {
            int codigo = -1, horas_duracion = -1;
            string nombre = "", modalidad = "";
            if (!getData(ref codigo, ref nombre, ref horas_duracion, ref modalidad))
                return "Error: todas las casillas son obligatorias";
            return Logica.Diplomado.recorderDiplomado(codigo, nombre, horas_duracion, modalidad);
        }
        private string dropDiplomado()
        {
            int codigo = getCode();
            Boolean dropCascada;
            if (ckcModeDrop.Checked)
                dropCascada = true;
            else
                dropCascada = false;
            
            return Logica.Diplomado.dropDiplomado(codigo, dropCascada);
        }
        private void fillOutAllInputs(DataTable tabla)
        {
            txtCodeDip.Text = tabla.Rows[0]["CODIGO"].ToString().Trim();
            txtNameDip.Text = tabla.Rows[0]["NOMBRE"].ToString().Trim();
            txtDurationH.Text = tabla.Rows[0]["HORAS_DURACION"].ToString().Trim();
            cbxModalityDip.Text = tabla.Rows[0]["MODALIDAD"].ToString().Trim();
        }

        private void btnOkDiplomado_Click(object sender, EventArgs e)
        {
            String msg = null;
            if(mode == FormGestion.SUB_MODE_UPDATE)
            {
                if (!isInFullView())
                    msg = updateFindDiplomado();
                else
                    msg = updateDiplomado(); 
            }else if(mode == FormGestion.SUB_MODE_RECORDER)
            {
                msg = recorderDiplomado();
            }
            else
            {
                msg = dropDiplomado();
            }
            if(msg != null)
                MessageBox.Show(msg);
        }

        private void FromDiplomado_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                clearComponents();
                this.mode = null;
            }
        }
       


        
        private void txt_onlyNumbers_KeyPerss(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (!char.IsDigit(keypress) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }
        private string mode; // caundo la interfaz es visible, esta trabajando en un modo especifico
                             // registrar, actualizar, eliminar


    }
}

