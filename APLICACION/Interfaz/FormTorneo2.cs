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
            //QUEMAR informacion MODALIDADES
            cbxModalidad.Items.Add("infantil");
            cbxModalidad.Items.Add("juvenil");
            cbxModalidad.Items.Add("adultos");
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
        private void limpiarEntradas()
        {
            this.txtCodigo.Enabled = true;
            this.txtCodigo.Clear();
            this.txtNombre.Clear();
            this.cbxModalidad.Text = "";
            //this.cbxCiudad.SelectedIndex = 0 ;//FALTA CIUDAD
        }
        //FUNCIONES QUE CAMBIAN LA INTERFAZ
        private void mostrarAlgunosComponentes()
        {
            this.lblNombre.Visible = false;
            this.txtNombre.Visible = false;

            this.lblModalidad.Visible = false;
            this.cbxModalidad.Visible = false;

            this.lblFrecuencia.Visible = false;
            this.rbSemestral.Visible = false;
            this.rbAnual.Visible = false;

        }
        private void mostrarTodoslosComponentes()
        {

            this.lblNombre.Visible = true;
            this.txtNombre.Visible = true;

            this.lblModalidad.Visible = true;
            this.cbxModalidad.Visible = true;

            this.lblFrecuencia.Visible = true;
            this.rbSemestral.Visible = true;
            this.rbAnual.Visible = true;



        }
        private void vistaEliminar()
        {
            mostrarAlgunosComponentes();
            this.btnOkKarateka.Location = new Point(105, 125);
            this.ClientSize = new System.Drawing.Size(330, 170);
        }
        private void vistaCompleta()
        {
            mostrarTodoslosComponentes();
            this.ClientSize = new System.Drawing.Size(356, 256);
            this.btnOkKarateka.Location = new System.Drawing.Point(124, 205);
           
        }
      
        public void cambiarAccion(string nuevaAccion)
        {//esta funcion cambia la accion de la interfaz, esa accion cambia el comportamiento 
        // de la iterfaz cuando se oprime el boton OK
        // si se selecciona elimianar, entonces se cambia la interfaz  a la vista eliminar
        //cuando se oprima el boton OK  se ejecutara ela funcion elimianr torneo.
            if (nuevaAccion == accionActual)
                return;
            this.accionActual = nuevaAccion;
            this.lblDecription.Text = accionActual + " TORNEO";
            if (nuevaAccion == FormGestion.OPCION_ELIMINAR)
            {
                vistaEliminar();
            }
            else
            {
                vistaCompleta();
            }
            
        }
        // FUNCIONES QUE OBTIENEN LOS DATOS DE LA INTERFAZ
        private Boolean obtenerDatos(ref int codigo, ref String nombre, ref String modalidad, ref String frecuencia)
        {
            codigo = obtenerCodigo();
            if (codigo == -1)
                return false;

            try
            {
                nombre = txtNombre.Text.ToString().Trim();
                modalidad = cbxModalidad.SelectedItem.ToString().Trim();
                if(this.rbAnual.Checked)
                    frecuencia = "anual";
                else
                    frecuencia = "semestral";

            }
            catch
            {
                return false;
            }
            if (nombre != null && "".Equals(nombre))
                return false;
            return true;
        }
        private int obtenerCodigo()
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

        // FNCIONES CONTROLADORAS: SE COMUNICAN CON LA CAPA LOGICA

        private string actualizarTorneo()
        {

            int codigo = 0;
            string nombre = "", modalidad = "",frecuencia = "";
            if (obtenerDatos(ref codigo, ref nombre, ref modalidad, ref frecuencia))
                return Logica.Torneo.actualizar(codigo, nombre, modalidad, frecuencia);
            return "Error: todas las casillas son obligatorias";
        }
        private string crearTorneo()
        {
            int codigo = 0;
            string nombre = "", modalidad = "", frecuencia = "";
            if (obtenerDatos(ref codigo, ref nombre, ref modalidad, ref frecuencia))
            {
                limpiarEntradas();
                return Logica.Torneo.crear(codigo, nombre, modalidad, frecuencia);
            }
            return "Error: Las casillas marcadas son obligatorias";
        }
        private string eliminarTorneo()
        {
            int codigo = obtenerCodigo();
            if (codigo < 0)
                return "Error: tienes que digitar un codigo";

            return Logica.Torneo.eliminar(codigo);
        }
        private string buscarTorneo()
        {
            int codigo = obtenerCodigo();
            if (codigo<0)
                return "Error: Formato del codigo no valido.";
            DataRow torneo = Logica.Torneo.buscar(codigo);
            torneoaEncontrado = torneo != null;
            if (!torneoaEncontrado)
                return "No existe el torneo";
            txtNombre.Text = torneo.Field<String>("NOMBRE");
            cbxModalidad.Text = torneo.Field<String>("MODALIDAD");
            String frecuencia = torneo.Field<String>("Frecuencia");
            if (frecuencia == "semestral")
                this.rbSemestral.Checked = true;
            else
                this.rbAnual.Checked = true;
            return null;
        }
        // FUNCIONES QUE CONTROLAN EL COMPORTAMIENTO DE LOS COMPONENTES DE LA INTERFAZ

        private void btnOk_Click(object sender, EventArgs e)
        {// SE EJECUTA CUANDO SE OPRIME EL BOTON 'OK'
            String msg;
            if (accionActual == FormGestion.OPCION_ACTUALIZAR)
            {
                if (torneoaEncontrado)
                {
                    msg = actualizarTorneo();
                    limpiarEntradas();
                }
                else
                    msg = "Debes ingresar el codigo del torneo y presionar ENTER.";
            }
            else if (accionActual == FormGestion.OPCION_CREAR)
            {
                msg = crearTorneo();
                
            }
            else if (accionActual == FormGestion.OPCION_ELIMINAR)
            {
                msg = eliminarTorneo();
                limpiarEntradas();
            }
            else
            {
                msg = buscarTorneo();
                limpiarEntradas();
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
                limpiarEntradas();
                accionActual = null;
            }
        }

        private string accionActual;// when the interface is visible, this is working in a  specific mode
                                   //rerecoder, update, drup, find
        private FormTable aFormTable;

        private Boolean torneoaEncontrado = false;

        private void FormTorneo_Load(object sender, EventArgs e)
        {
           

        }


        private void txtBuscarCodigo(object sender, KeyEventArgs e)
        {
            if (accionActual != FormGestion.OPCION_ACTUALIZAR)
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



