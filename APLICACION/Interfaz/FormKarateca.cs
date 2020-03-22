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
    public partial class FormTorneo1 : Form
    {
        public FormTorneo1(FormTable formTable)
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
            this.txtApelido.Clear();
            this.txtPeso.Clear();
            //this.cbxCiudad.SelectedIndex = 0 ;//FALTA CIUDAD
        }
        private void showSomeComponets()
        {
            this.lblNombre.Visible = false;
            this.txtNombre.Visible = false;

            this.lblApellido.Visible = false;
            this.txtApelido.Visible = false;

            this.lblPeso.Visible = false;
            this.txtPeso.Visible = false;

            this.lblCiudad.Visible = false;
            this.cbxCiudad.Visible = false;


        }
        private void showAllComponets()
        {

            this.lblNombre.Visible = true;
            this.txtNombre.Visible = true;

            this.lblApellido.Visible = true;
            this.txtApelido.Visible = true;

            this.lblPeso.Visible = true;
            this.txtPeso.Visible = true;

            this.lblCiudad.Visible = true;
            this.cbxCiudad.Visible = true;




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
            this.ClientSize = new System.Drawing.Size(330, 300);
            this.btnOkKarateka.Location = new System.Drawing.Point(106, 261); ;
           
        }
      
        public void setModo(string newMode)
        {
            if (newMode == currentMode)
                return;
            this.currentMode = newMode;
            this.lblDecription.Text = currentMode + " KARATECA";
            if (newMode == FormGestion.OPCION_ELIMINAR)
            {
                viewDrop();
            }
            else
            {
                viewRecorder();
            }
            
        }

        private Boolean getData(ref int codigo, ref String nombre, ref String apellido, ref int peso, ref int ciudad)
        {
            codigo = getCode();
            if (codigo == -1)
                return false;

            try
            {
                nombre = txtNombre.Text.ToString().Trim();
                apellido = txtApelido.Text.ToString().Trim();
                peso = getPeso();
                ciudad = (int)(cbxCiudad.SelectedItem as dynamic).Codigo;

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
        private int getPeso()
        {
            try
            {
                int peso= Int32.Parse(txtPeso.Text);
                return peso;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private void fillOutAllInputs(DataTable table)
        {
            txtCodigo.Text = table.Rows[0]["CODIGO"].ToString().Trim();
            txtNombre.Text = table.Rows[0]["NOMBRE"].ToString().Trim();

        }


        private string actrualizarKarateca()
        {

            int codigo = 0, edad = 0, ciudad = 0;
            string nombre = "", apellido = "";
            if (getData(ref codigo, ref nombre, ref apellido, ref edad, ref ciudad))
                return Logica.Karateca.actualizar(codigo, nombre, apellido, edad, ciudad);
            return "Error: todas las casillas son obligatorias";
        }
        private string crearKarateca()
        {
            int codigo = 0, edad = 0, ciudad = 0;
            string nombre = "", apellido = "";
            if (getData(ref codigo, ref nombre, ref apellido, ref edad, ref ciudad))
            {
                clearInputs();
                return Logica.Karateca.crear(codigo, nombre, apellido, edad, ciudad);
            }
            return "Error: Las casillas marcadas son obligatorias";
        }
        private string eliminarKarateca()
        {
            int codigo = getCode();
            if (codigo < 0)
                return "Error: tienes que digitar un codigo";

            return Logica.Karateca.eliminar(codigo);
        }
        private string buscarKarateca()
        {
            int codigo = getCode();
            if (codigo<0)
                return "Error: Formato del codigo no valido.";
            DataRow karateca = Logica.Karateca.buscar(codigo);
            karatecaEncontrado = karateca != null;
            if (!karatecaEncontrado)
                return "No existe el carateca";
            txtNombre.Text = karateca.Field<String>("NOMBRE");
            txtApelido.Text = karateca.Field<String>("APELLIDO");
            Single peso = karateca.Field<Single>("PESO");
            txtPeso.Text =String.Format("{0}",peso);
            cbxCiudad.SelectedValue = karateca.Field<Decimal>("CIUDAD").ToString();
            return null;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String msg;
            if (currentMode == FormGestion.OPCION_ACTUALIZAR)
            {
                if (karatecaEncontrado)
                {
                    msg = actrualizarKarateca();
                    clearInputs();
                }
                else
                    msg = "Debes ingresar el codigo del karateca y presionar ENTER.";
            }
            else if (currentMode == FormGestion.OPCION_CREAR)
            {
                msg = crearKarateca();
                
            }
            else if (currentMode == FormGestion.OPCION_ELIMINAR)
            {
                msg = eliminarKarateca();
                clearInputs();
            }
            else
            {
                msg = buscarKarateca();
                clearInputs();
            }
            if (msg != null)
                MessageBox.Show(msg);
        }
        private void btnOk_Move(object sender, EventArgs e)
        {
            if (currentMode == FormGestion.OPCION_ELIMINAR)
            {
                this.lblNombre.Text = "Eliminar inscripciones asociadas.";
                //this.lblNameEst.Text = "ELIMINAR INSCRIPCIONES ASOCIADAS.";

                this.lblNombre.Location = new Point(58, 90);
            }
            else
            {
                this.lblNombre.Text = "NOMBRE";
                this.lblNombre.Location = new Point(38, 90);
            }

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

        private Boolean karatecaEncontrado = false;

        private void FormKarateca_Load(object sender, EventArgs e)
        {
            //cargar informacion de las ciudades
            cbxCiudad.DisplayMember = "Nombre";
            cbxCiudad.ValueMember = "Codigo";
            DataTable ciudades = Logica.Ciudad.listar();
            foreach (DataRow ciudad in ciudades.Rows)
            {
                cbxCiudad.Items.Add(new { Codigo = ciudad["CODIGO"] , Nombre = ciudad["NOMBRE"] });

            }
        }


        private void txtBuscarCodigo(object sender, KeyEventArgs e)
        {
            if (currentMode != FormGestion.OPCION_ACTUALIZAR)
                return;
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                String msg = buscarKarateca();
                if(msg != null)
                    MessageBox.Show(msg);
            }
        }
    }
}



