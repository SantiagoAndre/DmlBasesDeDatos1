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
        public FormEstilista(FormTable formTable)
        {
            InitializeComponent();
            this.aFormTable = formTable;
        }
        private void moveToForm(Form form)
        {
            this.Visible = false;
            form.ShowDialog(this);
            this.Show();
        }
        private Boolean isInFullView()
        {
            return this.dtpBirthdate.Visible;
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
            this.ckcNameEst.Visible = false;
            this.ckcNameEst.Visible = false;
            this.ckcGenderEst.Visible = false;
            this.ckcBirthdate.Visible = false;
            this.txtNameEst.Visible = false;
            this.rbtFemaleGender.Visible = false;
            this.rbtMaleGender.Visible = false;
            this.dtpBirthdate.Visible = false;
        }
        private void showAllComponets()
        {
            this.ckcNameEst.Visible = true;
            this.ckcGenderEst.Visible = true;
            this.ckcBirthdate.Visible = true;
            this.txtNameEst.Visible = true;
            this.rbtFemaleGender.Visible = true;
            this.rbtMaleGender.Visible = true;
            this.dtpBirthdate.Visible = true;

        }
        private void setEnabledAllChecks(Boolean value)
        {
            this.ckcCodeEst.Enabled = value;
            this.ckcNameEst.Enabled = value;
            this.ckcBirthdate.Enabled = value;
            this.ckcGenderEst.Enabled = value;
        }
        private void setCheckedAllChecks(Boolean value)
        {
            this.ckcCodeEst.Checked = value;
            this.ckcNameEst.Checked = value;
            this.ckcBirthdate.Checked = value;
            this.ckcGenderEst.Checked = value;
        }
        private void viewUpdate(String  currentView)
        {
            if (isInFullView() || currentView == null)
            {
                showSomeComponets();
                this.btnOkEstilista.Location = new Point(50, 88);
                this.ClientSize = new System.Drawing.Size(284, 153);
                this.txtCodeEst.Enabled = true;
                setEnabledAllChecks(true);
                setCheckedAllChecks(false);
            }
            else
            {
                showAllComponets();
                setEnabledAllChecks(false);
                setCheckedAllChecks(true);
                this.btnOkEstilista.Location = new Point(50, 213);
                this.ClientSize = new System.Drawing.Size(284, 278);
                this.txtCodeEst.Enabled = false;
            }

            ckcCodeEst.Checked = true;
            ckcCodeEst.Enabled = false;
        }
        private void viewDrop()
        {
            showSomeComponets();
            this.ckcNameEst.Enabled = true;
            this.ckcNameEst.Checked = false;
            this.ckcNameEst.Visible = true;
            this.btnOkEstilista.Location = new Point(50, 130);
            this.ClientSize = new System.Drawing.Size(284, 195);
        }
        private void viewRecorder()
        {
            showAllComponets();
            this.btnOkEstilista.Location = new Point(50, 213);
            this.ClientSize = new System.Drawing.Size(284, 278);
            setEnabledAllChecks(false);
            setCheckedAllChecks(true);
        }
        private void viewFind()
        {
            showAllComponets();
            this.btnOkEstilista.Location = new Point(50, 213);
            this.ClientSize = new System.Drawing.Size(284, 278);
            setEnabledAllChecks(true);
            setCheckedAllChecks(false);
        }
        public void setModo(string newMode)
        {
            if (newMode == currentMode)
                return;
            this.currentMode = newMode;
            this.lblDecription.Text = currentMode + " ESTILISTA";

            if (newMode == FormGestion.SUB_MODE_UPDATE)
            {
                viewUpdate(null);
            }
            else if (newMode == FormGestion.SUB_MODE_DROP)
            {
                viewDrop();
            }
            else if (newMode == FormGestion.SUB_MODE_RECORDER)
            {
                viewRecorder();
            }
            else
                viewFind();

        }
       
        private Boolean getData(ref int code, ref string name, ref char gener, ref string birthdate)
        {
            if (ckcCodeEst.Checked)
            {
                code = getCode();
                if (code == -1)
                    return false;
            }
            else
                code = -1;
            
            try
            {
                if (ckcNameEst.Checked)
                    name = txtNameEst.Text.ToString().Trim();
                else
                    name = null;
                if (ckcGenderEst.Checked)
                {
                    if (rbtFemaleGender.Checked)
                        gener = 'F';
                    else if (rbtMaleGender.Checked)
                        gener = 'M';
                    else
                        return false;
                }else
                    gener = ' ';
                if (ckcBirthdate.Checked)
                    birthdate = dtpBirthdate.Value.ToShortDateString();
                else
                    birthdate = null;
            }
            catch 
            {
                return false;
            }
            if (name!= null && "".Equals(name) )
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
            string gender = table.Rows[0]["GENERO"].ToString().Trim().ToUpper();
            if (gender.Equals("F"))
                rbtFemaleGender.Checked = true;
            else
                rbtMaleGender.Checked = true;
            dtpBirthdate.Value = Convert.ToDateTime(table.Rows[0]["FECHA_NACIMIENTO"].ToString().Trim());
        }

        private string updateFindEstilista()
        {
            int codigo = getCode();
            if (codigo == -1)
                return "debe ingresar el codigo del estilista";
            DataTable table = Logica.Estilista.findEstilista(codigo);
            if (table.Rows.Count!=0)
                fillOutAllInputs(table);
            else
                return "no existe estilista con  ese codigo";
            viewUpdate(currentMode);
            return null;
        }
        private string updateEstilista()
        {
            int code = 0;
            string name = "", fechaNacimiento="";
            char gender = ' ';
            if (getData(ref code, ref name, ref gender, ref fechaNacimiento))
            {
                viewUpdate(currentMode);
                return Logica.Estilista.updateEstilista(code, name, gender, fechaNacimiento);
            }
            return "Error: todas las casillas son obligatorias";
        }
        private string recorderEstilista()
        {
            int code = 0;
            string name = "", birthdate = "";
            char gender = ' ';
            if(getData(ref code,ref name,ref gender,ref birthdate))
                return Logica.Estilista.recorderEstilista(code, name, gender, birthdate);
            return "Error: Las casillas marcadas son obligatorias";
        }
        private string dropEstilista()
        {
            int code = getCode();
            if (code < 0)
                return "Error: tienes que digitar un codigo";
            Boolean dropCascade;
            dropCascade = ckcNameEst.Checked;
            return Logica.Estilista.dropEstilista(code, dropCascade);
        }
        private string findEstilista()
        {
            int code = 0;
            string name = "", birthdate = "";
            char gender = ' ';
            if (!getData(ref code, ref name, ref gender, ref birthdate))
                return "Error: las casillas marcadas son obligatorias.";
            DataTable dt =Logica.Estilista.findEstilista(code, name, gender, birthdate);
            if (dt.Rows.Count == 0)
                return "No hay ninguna coincidencia."; 
            aFormTable.setTable("Resultado busqueda:",dt);
            moveToForm(aFormTable);
            return null;

        }
        
        private void btnOkEstilista_Click(object sender, EventArgs e)
        {
            String msg;
            if (currentMode == FormGestion.SUB_MODE_UPDATE)
            {
                if (isInFullView())
                    msg = updateEstilista();
                else
                    msg = updateFindEstilista();
            }
            else if (currentMode == FormGestion.SUB_MODE_RECORDER)
            {
                msg = recorderEstilista();
            }
            else if(currentMode == FormGestion.SUB_MODE_DROP)
            {
                msg = dropEstilista();
            }
            else
            {
                msg = findEstilista();
            }
            if (msg != null)
                MessageBox.Show(msg);
        }
        private void btnOkEstilista_Move(object sender, EventArgs e)
        {
            if (currentMode == FormGestion.SUB_MODE_DROP)
                this.ckcNameEst.Text = "Eliminar inscripciones asociadas.";
            else
                this.ckcNameEst.Text = "NOMBRE";

        }

        private void txt_onlyNumbers_KeyPerss(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (!char.IsDigit(keypress) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }
        
        private void ckcCodeEst_CheckedChanged(object sender, EventArgs e)
        {
                txtCodeEst.Enabled = (ckcCodeEst.Checked);
        }
        private void ckcNameEst_CheckedChanged(object sender, EventArgs e)
        {

            txtNameEst.Enabled = ((CheckBox)sender).Checked ;
        }
        private void ckcGenderEst_CheckedChanged(object sender, EventArgs e)
        {
            Boolean check = ckcGenderEst.Checked;
            rbtFemaleGender.Enabled = check;
            rbtMaleGender.Enabled = check;
        }
        private void ckcBirthdate_CheckedChanged(object sender, EventArgs e)
        {
            dtpBirthdate.Enabled = ckcBirthdate.Checked;
        }

        private void FormEstilista_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                clearComponents();
                currentMode = null;
            }
        }

        private string currentMode;// when the interface is visible, this is working in a  specific mode
                                   //rerecoder, update, drup, find
        private FormTable aFormTable;

    }
}



