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
    public partial class FromCiudad : Form
    {
        public FromCiudad()
        {
            InitializeComponent();
        }      
        private void clearAllInputs()
        {
            this.txtCodeDip.Enabled = true;
            this.txtCodeDip.Clear();
            this.txtNameDip.Clear();
         

        }
     
        
        private Boolean obtenerDatos(ref int code, ref string name)
        {
            code = obtenerCodigo();
            if (code == -1)
                return false;
            try
            {
                name = txtNameDip.Text.ToString().Trim();
                
                
            }
            catch 
            {
                return false;
            }
            if ("".Equals(name))
                return false;
            return true;
        }
        private int obtenerCodigo()
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
      
       
        private string guardarCiudad()
        {
            int codigo = -1;
            string nombre = "";
            if (!obtenerDatos(ref codigo, ref nombre))
                return "Error: todas las casillas son obligatorias";
            return Logica.Ciudad.guardar(codigo, nombre);
        }
      

        private void fillOutAllInputs(DataTable tabla)
        {
            txtCodeDip.Text = tabla.Rows[0]["CODIGO"].ToString().Trim();
            txtNameDip.Text = tabla.Rows[0]["NOMBRE"].ToString().Trim();
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String msg = guardarCiudad();
            if (msg != null)
                MessageBox.Show(msg);
            clearAllInputs();
            
        }

       
              
        private void txt_onlyNumbers_KeyPerss(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (!char.IsDigit(keypress) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }
 


    }
}

