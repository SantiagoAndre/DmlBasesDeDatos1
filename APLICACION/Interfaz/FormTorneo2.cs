using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace APLICACION.Interfaz
{
    public partial class FormTorneo2: Form
    {
        public FormTorneo2(FormTable formTable)
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

            return true;
        }
        private void clearInputs()
        {
            this.txtCodigo.Enabled = true;
            this.txtCodigo.Clear();
            this.txtNombre.Clear();
            this.cbxFrecuencia.Text = "";
            this.cbxModalidad.Text = "";
            //this.cbxCiudad.SelectedIndex = 0 ;//FALTA CIUDAD
        }
        private void showSomeComponets()
        {
            this.lblNombre.Visible = false;
            this.txtNombre.Visible = false;

            this.lblModalidad.Visible = false;
            this.cbxModalidad.Visible = false;

            this.lblFrecuencia.Visible = false;
            this.cbxFrecuencia.Visible = false;

        }
        private void showAllComponets()
        {

            this.lblNombre.Visible = true;
            this.txtNombre.Visible = true;

            this.lblModalidad.Visible = true;
            this.cbxModalidad.Visible = true;

            this.lblFrecuencia.Visible = true;
            this.cbxFrecuencia.Visible = true;




        }


        private void viewDrop()
        {
            showSomeComponets();
            this.btnOkKarateka.Location = new Point(105, 125);
            this.ClientSize = new System.Drawing.Size(330, 170);
        }
        private void viewRecorder()
        {
            showAllComponets();
            this.ClientSize = new System.Drawing.Size(356, 256);
            this.btnOkKarateka.Location = new System.Drawing.Point(124, 205);
           
        }
      
        public void setModo(string newMode)
        {
            if (newMode == currentMode)
                return;
            this.currentMode = newMode;
            this.lblDecription.Text = currentMode + " TORNEO";
            if (newMode == FormGestion.OPCION_ELIMINAR)
            {
                viewDrop();
            }
            else
            {
                viewRecorder();
            }
            
        }

        private Boolean getData(ref int codigo, ref String nombre, ref String modalidad, ref String frecuencia)
        {
            codigo = getCode();
            if (codigo == -1)
                return false;

            try
            {
                nombre = txtNombre.Text.ToString().Trim();
                modalidad = cbxModalidad.SelectedItem.ToString().Trim();

                frecuencia = cbxFrecuencia.SelectedItem.ToString().Trim();

            }
            catch
            {
                return false;
            }
            if (nombre != null && "".Equals(nombre))
                return false;
            return true;
        }
        private int getCode()
        {
            try
            {
                int code = Int32.Parse(txtCodigo.Text);
                return code;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        

        private string actrualizarTorneo()
        {

            int codigo = 0;
            string nombre = "", modalidad = "",frecuencia = "";
            if (getData(ref codigo, ref nombre, ref modalidad, ref frecuencia))
                return Logica.Torneo.actualizar(codigo, nombre, modalidad, frecuencia);
            return "Error: todas las casillas son obligatorias";
        }
        private string crearTorneo()
        {
            int codigo = 0;
            string nombre = "", modalidad = "", frecuencia = "";
            if (getData(ref codigo, ref nombre, ref modalidad, ref frecuencia))
            {
                clearInputs();
                return Logica.Torneo.crear(codigo, nombre, modalidad, frecuencia);
            }
            return "Error: Las casillas marcadas son obligatorias";
        }
        private string eliminarTorneo()
        {
            int codigo = getCode();
            if (codigo < 0)
                return "Error: tienes que digitar un codigo";

            return Logica.Torneo.eliminar(codigo);
        }
        private string buscarTorneo()
        {
            int codigo = getCode();
            if (codigo<0)
                return "Error: Formato del codigo no valido.";
            DataRow torneo = Logica.Torneo.buscar(codigo);
            torneoaEncontrado = torneo != null;
            if (!torneoaEncontrado)
                return "No existe el torneo";
            txtNombre.Text = torneo.Field<String>("NOMBRE");
            cbxModalidad.Text = torneo.Field<String>("MODALIDAD");
            cbxFrecuencia.Text = torneo.Field<String>("Frecuencia");
            return null;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String msg;
            if (currentMode == FormGestion.OPCION_ACTUALIZAR)
            {
                if (torneoaEncontrado)
                {
                    msg = actrualizarTorneo();
                    clearInputs();
                }
                else
                    msg = "Debes ingresar el codigo del torneo y presionar ENTER.";
            }
            else if (currentMode == FormGestion.OPCION_CREAR)
            {
                msg = crearTorneo();
                
            }
            else if (currentMode == FormGestion.OPCION_ELIMINAR)
            {
                msg = eliminarTorneo();
                clearInputs();
            }
            else
            {
                msg = buscarTorneo();
                clearInputs();
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


        private void Form_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                clearInputs();
                currentMode = null;
            }
        }

        private string currentMode;// when the interface is visible, this is working in a  specific mode
                                   //rerecoder, update, drup, find
        private FormTable aFormTable;

        private Boolean torneoaEncontrado = false;

        private void FormTorneo_Load(object sender, EventArgs e)
        {
            //QUEMAR informacion MODALIDADES
            cbxModalidad.Items.Add("infantil" );
            cbxModalidad.Items.Add("juvenil");
            cbxModalidad.Items.Add("adultos");
            //QUEMAR informacion MODALIDADES
            cbxFrecuencia.Items.Add("anual");
            cbxFrecuencia.Items.Add("semestral");

        }


        private void txtBuscarCodigo(object sender, KeyEventArgs e)
        {
            if (currentMode != FormGestion.OPCION_ACTUALIZAR)
                return;
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                String msg = buscarTorneo();
                if(msg != null)
                    MessageBox.Show(msg);
            }
        }
    }
}



