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
        public void setModo(string nuevoModo)
        {
            rotateView(nuevoModo);
            this.modo = nuevoModo;
            this.lblDecripcion.Text = modo + " DIPLOMADO";
            this.modo = nuevoModo;
            this.lblDecripcion.Text = modo + " DIPLOMADO";
        }

        private Boolean isInFullView()
        {
            return this.lblModalidadDip.Visible;
        }
        private void rotateView(string nuevoModo)
        {
            if(modo == null && nuevoModo == FormGestion.SUB_MODO_ACTUALIZAR)
            {
                showSomeComponets();
                this.btnOkDiplomado.Location = new Point(50, 90);
                this.ClientSize = new System.Drawing.Size(284, 155);
            }else if (modo == FormGestion.SUB_MODO_ACTUALIZAR)
            {
                if (isInFullView())
                {
                    showSomeComponets();
                    this.btnOkDiplomado.Location = new Point(50, 90);
                    this.ClientSize = new System.Drawing.Size(284, 155);
                    this.txtCodDip.Enabled = true;
                }
                else
                {
                    showAllComponets();
                    this.txtCodDip.Enabled = false;
                    this.btnOkDiplomado.Location = new Point(50, 213);
                    this.ClientSize = new System.Drawing.Size(284, 278);
                }
            }else if (modo == nuevoModo)
                return;
            else if (nuevoModo == FormGestion.SUB_MODO_REGISTRAR)
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
            this.txtCodDip.Enabled = true;
            this.txtCodDip.Clear();
            this.txtNombreDip.Clear();
            this.cbxModalidadDip.Text = "";

        }
        private void showSomeComponets()
        {
            this.lblNombreDip.Visible = false;
            this.lblHDuracion.Visible = false;
            this.lblModalidadDip.Visible = false;
            this.txtNombreDip.Visible = false;
            this.txtHDuracionDip.Visible = false;
            this.cbxModalidadDip.Visible = false;
        }
        private void showAllComponets()
        {
            this.lblNombreDip.Visible = true;
            this.lblHDuracion.Visible = true;
            this.lblModalidadDip.Visible = true;
            this.txtNombreDip.Visible = true;
            this.txtHDuracionDip.Visible = true;
            this.cbxModalidadDip.Visible = true;
            this.ckcModeDrop.Visible = false;
        }
        
        private Boolean obtenerDatos(ref int codigo, ref string nombre, ref int horas, ref string modalidad)
        {
            codigo = obtenerCodigo();
            if (codigo == -1)
                return false;
            try
            {
                nombre = txtNombreDip.Text.ToString().Trim();
                horas = Int32.Parse(txtHDuracionDip.Text);
                modalidad = cbxModalidadDip.Text.ToString().Trim();
            }
            catch (Exception ex)
            {
                return false;
            }
            if ("".Equals(nombre) || "".Equals(modalidad) )
                return false;
            return true;
        }
        private int obtenerCodigo()
        {
            try {
                int codigo = Int32.Parse(txtCodDip.Text);
                return codigo;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        private string actualizarBuscarDiplomado()
        {
            int codBuscar;
            codBuscar = obtenerCodigo();
            if (codBuscar == -1)
                return "Tienes que digitar un codigo";
            DataTable tabla = Logica.Diplomado.buscarDiplomado(codBuscar);
            if (tabla != null)
            {
                fillOutAllInputs(tabla);
                rotateView(modo);
            }
            else
            {
                return "no existe Diplomado con ese codigo";
            }
            return null;
        }
        private string actualiarDiplomado()
        {
            int codigo =-1, horas_duracion=-1;
            string nombre="", modalidad="";
            if (!obtenerDatos(ref codigo, ref nombre, ref horas_duracion, ref modalidad))
                return "Error: todas las casillas son obligatorias";
            return Logica.Diplomado.actualizarDiplomado(codigo, nombre, horas_duracion, modalidad);
        }
        private string registrarDiplomado()
        {
            int codigo = -1, horas_duracion = -1;
            string nombre = "", modalidad = "";
            if (!obtenerDatos(ref codigo, ref nombre, ref horas_duracion, ref modalidad))
                return "Error: todas las casillas son obligatorias";
            return Logica.Diplomado.registrarDiplomado(codigo, nombre, horas_duracion, modalidad);
        }
        private string eliminarDiplomado()
        {
            int codigo = obtenerCodigo();
            Boolean borrarCascada;
            if (ckcModeDrop.Checked)
                borrarCascada = true;
            else
                borrarCascada = false;
            
            return Logica.Diplomado.eliminarDiplomado(codigo, borrarCascada);
        }
        private void fillOutAllInputs(DataTable tabla)
        {
            txtCodDip.Text = tabla.Rows[0]["CODIGO"].ToString().Trim();
            txtNombreDip.Text = tabla.Rows[0]["NOMBRE"].ToString().Trim();
            txtHDuracionDip.Text = tabla.Rows[0]["HORAS_DURACION"].ToString().Trim();
            cbxModalidadDip.Text = tabla.Rows[0]["MODALIDAD"].ToString().Trim();
        }

        private void btnOkDiplomado_Click(object sender, EventArgs e)
        {
            String msg = null;
            if(modo == FormGestion.SUB_MODO_ACTUALIZAR)
            {
                if (!isInFullView())
                    msg = actualizarBuscarDiplomado();
                else
                    msg = actualiarDiplomado(); 
            }else if(modo == FormGestion.SUB_MODO_REGISTRAR)
            {
                msg = registrarDiplomado();
            }
            else
            {
                msg = eliminarDiplomado();
            }
            if(msg != null)
                MessageBox.Show(msg);
        }

        private void FromDiplomado_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                clearComponents();
                this.modo = null;
            }
        }
       


        
        private void txt_onlyNumbers_KeyPerss(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (!char.IsDigit(keypress) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }
        private string modo;


    }
}

