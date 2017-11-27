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
    public partial class FormEstilista : Form
    {
        public FormEstilista()
        {
            InitializeComponent();
        }
        private Boolean isInFullView()
        {
            return this.dtpBirthdate.Visible;
        }
        private void rotateView(string newMode)
        {

            if (mode == null && newMode == FormGestion.SUB_MODO_ACTUALIZAR)
            {
                showSomeComponets();
                this.btnOkEstilista.Location = new Point(50, 88);
                this.ClientSize = new System.Drawing.Size(284, 153);
            }
            else if (mode == FormGestion.SUB_MODO_ACTUALIZAR)
            {
                if (isInFullView())
                {
                    showSomeComponets();
                    this.btnOkEstilista.Location = new Point(50, 88);
                    this.ClientSize = new System.Drawing.Size(284, 153);
                    this.txtCodeEst.Enabled = true;
                }
                else
                {
                    showAllComponets();
                    this.btnOkEstilista.Location = new Point(50, 213);
                    this.ClientSize = new System.Drawing.Size(284, 278);
                    this.txtCodeEst.Enabled = false;
                }
            }else if (mode == newMode)
                return;
            else if (newMode == FormGestion.SUB_MODO_REGISTRAR)
            {
                showAllComponets();
                this.btnOkEstilista.Location = new Point(50, 213);
                this.ClientSize = new System.Drawing.Size(284, 278);
            }
            else
            {
                showSomeComponets();
                this.ckcModeDrop.Visible = true;
                this.ckcModeDrop.Checked = false;
                this.btnOkEstilista.Location = new Point(50, 130);
                this.ClientSize = new System.Drawing.Size(284, 195);
            }

        }
        public void setModo(string newMode)
        {
            if (newMode == mode)
                return;
            rotateView(newMode);
            this.mode = newMode;
            this.lblDecription.Text = mode + " ESTILISTA";

        }
        private void clearComponents()
        {
            this.txtCodeEst.Enabled = true;
            this.txtCodeEst.Clear();
            this.txtNameEst.Clear();
            this.rbtFemaleGender.Checked = false;
            this.dtpBirthdate.Text = "";
        }
        private void showSomeComponets()
        {
            this.ckcModeDrop.Visible = false;
            this.lblNameEst.Visible = false;
            this.lblGender.Visible = false;
            this.lblBirthdate.Visible = false;
            this.txtNameEst.Visible = false;
            this.rbtFemaleGender.Visible = false;
            this.rbtMaleGender.Visible = false;
            this.dtpBirthdate.Visible = false;
        }
        private void showAllComponets()
        {
            this.ckcModeDrop.Visible = false;
            this.lblNameEst.Visible = true;
            this.lblGender.Visible = true;
            this.lblBirthdate.Visible = true;
            this.txtNameEst.Visible = true;
            this.rbtFemaleGender.Visible = true;
            this.rbtMaleGender.Visible = true;
            this.dtpBirthdate.Visible = true;

        }

        private Boolean getData(ref int code, ref string name, ref char gener, ref string birthdate)
        {
            code = getCode();
            if (code == -1)
                return false;
            try
            {
                name = txtNameEst.Text.ToString().Trim();
                if (rbtFemaleGender.Checked)
                    gener = 'F';
                else if (rbtMaleGender.Checked)
                    gener = 'M';
                else
                    return false;
                birthdate = dtpBirthdate.Value.ToShortDateString();
            }
            catch 
            {
                return false;
            }
            if ("".Equals(name))
                return false;
            return true;
        }
        private int getCode()
        {
            try
            {
                int code = Int32.Parse(txtCodeEst.Text);
                return code;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        private void fillOutAllInputs(DataTable table)
        {
            txtCodeEst.Text = table.Rows[0]["CODIGO"].ToString().Trim();
            txtNameEst.Text = table.Rows[0]["NOMBRE"].ToString().Trim();
            string sex = table.Rows[0]["GENERO"].ToString().Trim().ToUpper();
            if (sex.Equals("F"))
                rbtFemaleGender.Checked = true;
            else
                rbtMaleGender.Checked = true;
            dtpBirthdate.Text = table.Rows[0]["FECHA_NACIMIENTO"].ToString().Trim();
        }

        private string updateFindEstilista()
        {
            int codigo = getCode();
            if (codigo == -1)
                return "debe ingresar el codigo del estilista";
            DataTable table = Logica.Estilista.buscarEstilista(codigo);
            if (table.Rows.Count!=0)
                fillOutAllInputs(table);
            else
                return "no existe estilista con  ese codigo";
            rotateView(mode);
            return null;
        }
        private string updateEstilista()
        {
            int code = 0;
            string name = "", fechaNacimiento="";
            char gender = ' ';
            rotateView(mode);
            if (getData(ref code, ref name, ref gender, ref fechaNacimiento))
                return Logica.Estilista.updateEstilista(code, name, gender, fechaNacimiento);
            return "Error: todas las casillas son obligatorias";
        }
        private string recorderEstilista()
        {
            int codigo = 0;
            string nombre = "", birthdate = "";
            char sex = ' ';
            if(getData(ref codigo,ref nombre,ref sex,ref birthdate))
                return Logica.Estilista.registrarEstilista(codigo, nombre, 'g', birthdate);
            return "Error: todas las casillas son obligatorias";
        }
        private string dropEstilista()
        {
            int code = getCode();
            Boolean dropCascade;
            dropCascade = ckcModeDrop.Checked;
            return Logica.Estilista.dropEstilista(code, dropCascade);
        }
    
        private void FormEstilista_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                clearComponents();
                mode = null;
            }
        }

        
        private void btnOkEstilista_Click(object sender, EventArgs e)
        {
            String msg;
            if (mode == FormGestion.SUB_MODO_ACTUALIZAR)
            {
                if (!isInFullView())
                    msg = updateFindEstilista();
                else
                    msg = updateEstilista();
            }
            else if (mode == FormGestion.SUB_MODO_REGISTRAR)
            {
                msg = recorderEstilista();
            }
            else
            {
                msg = dropEstilista();
            }
            if (msg != null)
                MessageBox.Show(msg);
        }



        private void txt_onlyNumbers_KeyPerss(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (!char.IsDigit(keypress) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }
        private string mode;// caundo la interfaz es visible, esta trabajando en un modo especifico


        // registrar, actualizar, eliminar
    }
}



