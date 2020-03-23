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
    public partial class FormKarateca : Form
    {
        public FormKarateca(FormTable formTable)
        {
            InitializeComponent();
        }
        
        private void limpriarEntradas()
        {
            this.txtCodigo.Enabled = true;
            this.txtCodigo.Clear();
            this.txtNombre.Clear();
            this.txtApelido.Clear();
            this.txtPeso.Clear();
            //this.cbxCiudad.SelectedIndex = 0 ;//FALTA CIUDAD
        }
        private void mostrarAlgunosCompnentes()
        {
            //esconde los componentes que no se necesitan cuando se elimina un karateca
            this.lblNombre.Visible = false;
            this.txtNombre.Visible = false;

            this.lblApellido.Visible = false;
            this.txtApelido.Visible = false;

            this.lblPeso.Visible = false;
            this.txtPeso.Visible = false;

            this.lblCiudad.Visible = false;
            this.cbxCiudad.Visible = false;


        }
        private void mostrarTodosCompnentes()
        {//muestra todos los componentes

            this.lblNombre.Visible = true;
            this.txtNombre.Visible = true;

            this.lblApellido.Visible = true;
            this.txtApelido.Visible = true;

            this.lblPeso.Visible = true;
            this.txtPeso.Visible = true;

            this.lblCiudad.Visible = true;
            this.cbxCiudad.Visible = true;




        }


        private void vistaEliminar()
        {//cambia la forma de la vista para eliminar un karateca
            mostrarAlgunosCompnentes();
            this.btnOkKarateka.Location = new Point(105, 125);
            this.ClientSize = new System.Drawing.Size(330, 170);
        }
        private void vistaCompleta()
        {
            //cambia la vista a la forma completa(crear,actualizar)
            mostrarTodosCompnentes();
            this.ClientSize = new System.Drawing.Size(330, 300);
            this.btnOkKarateka.Location = new System.Drawing.Point(106, 261); ;
           
        }
      
        public void cambiarAccion(string nuevaAccion)
        {
            if (nuevaAccion == accionActual)
                return;
            this.accionActual = nuevaAccion;
            this.lblDecription.Text = accionActual + " KARATECA";
            if (nuevaAccion == FormGestion.OPCION_ELIMINAR)
            {
                vistaEliminar();
            }
            else
            {
                vistaCompleta();
            }
            
        }

        private Boolean obtenerDatos(ref int codigo, ref String nombre, ref String apellido, ref int peso, ref int ciudad)
        {
            //recoje los datos de la interfaz, ref significa que el parametro es de salida
            codigo = obtenerCodigo();
            if (codigo == -1)
                return false;

            try
            {
                nombre = txtNombre.Text.ToString().Trim();
                apellido = txtApelido.Text.ToString().Trim();
                peso = obtenerPeso();
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
        private int obtenerCodigo()
        {
            try
            {
                int codigo = Int32.Parse(txtCodigo.Text);
                return codigo;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        private int obtenerPeso()
        {
            //obtiene el peso y lo retorna
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
        // FNCIONES CONTROLADORAS: SE COMUNICAN CON LA CAPA LOGICA

        private string actrualizarKarateca()
        {

            int codigo = 0, edad = 0, ciudad = 0;
            string nombre = "", apellido = "";
            if (obtenerDatos(ref codigo, ref nombre, ref apellido, ref edad, ref ciudad))
                return Logica.Karateca.actualizar(codigo, nombre, apellido, edad, ciudad);
            return "Error: todas las casillas son obligatorias";
        }
        private string crearKarateca()
        {
            int codigo = 0, edad = 0, ciudad = 0;
            string nombre = "", apellido = "";
            if (obtenerDatos(ref codigo, ref nombre, ref apellido, ref edad, ref ciudad))
            {
                limpriarEntradas();
                return Logica.Karateca.crear(codigo, nombre, apellido, edad, ciudad);
            }
            return "Error: Las casillas marcadas son obligatorias";
        }
        private string eliminarKarateca()
        {
            int codigo = obtenerCodigo();
            if (codigo < 0)
                return "Error: tienes que digitar un codigo";

            return Logica.Karateca.eliminar(codigo);
        }
        private string buscarKarateca()
        {
            int codigo = obtenerCodigo();
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
            cbxCiudad.Text = Logica.Ciudad.getNombre(karateca.Field<Decimal>("CIUDAD"));
            return null;
        }
        // FUNCIONES QUE CONTROLAN EL COMPORTAMIENTO DE LOS COMPONENTES DE LA INTERFAZ
        private void btnOk_Click(object sender, EventArgs e)
        {// SE EJECUTA CUANDO SE OPRIME EL BOTON 'OK'
            String msg;
            if (accionActual == FormGestion.OPCION_ACTUALIZAR)
            {
                if (karatecaEncontrado)
                {
                    msg = actrualizarKarateca();
                    limpriarEntradas();
                }
                else
                    msg = "Debes ingresar el codigo del karateca y presionar ENTER.";
            }
            else if (accionActual == FormGestion.OPCION_CREAR)
            {
                msg = crearKarateca();
                
            }
            else if (accionActual == FormGestion.OPCION_ELIMINAR)
            {
                msg = eliminarKarateca();
                limpriarEntradas();
            }
            else
            {
                msg = buscarKarateca();
                limpriarEntradas();
            }
            if (msg != null)
                MessageBox.Show(msg);
        }

        private void txt_onlyNumbers_KeyPerss(object sender, KeyPressEventArgs e)
        {//CONTROLA QUE UN CUADRO DE TEXTO SOLO ACEPTE NUMEROS
            char keypress = e.KeyChar;
            if (!char.IsDigit(keypress) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }


        private void Form_VisibleChanged(object sender, EventArgs e)
        {//SE EJECUTA CUANDO SE CAMBIA LA PROPIEDAD VISIBLE DEL FORMULARIO
            if (!Visible)
            {
                limpriarEntradas();
                accionActual = null;
            }
        }

        private string accionActual;// when the interface is visible, this is working in a  specific mode
                                   //rerecoder, update, drup, find
     

        private Boolean karatecaEncontrado = false;

        private void FormKarateca_Load(object sender, EventArgs e)
        {
            //cargar informacion de las ciudades
            cbxCiudad.DisplayMember = "Nombre";
            cbxCiudad.ValueMember = "Codigo";
            DataTable ciudades = Logica.Ciudad.listar();
            cbxCiudad.Items.Clear();
            foreach (DataRow ciudad in ciudades.Rows)
            {
                cbxCiudad.Items.Add(new { Codigo = ciudad["CODIGO"] , Nombre = ciudad["NOMBRE"] });

            }
        }


        private void txtBuscarCodigo(object sender, KeyEventArgs e)
        {// SE EJECUTA CUANDO SE OPRIME ENTER EN LA CASILLA BUSCAR CODIGO
            //SE ESTA EN LA OPCION ACTUALIZAR BUSCARA EL  KARATECA
            if (accionActual != FormGestion.OPCION_ACTUALIZAR)
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



