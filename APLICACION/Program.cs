using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APLICACION
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Interfaz.FormPrincipal());
            //            Logica.Inscripcion.buscarInscripcion("4/22/2014");
            //            Datos.Datos.executeNonQuery("INSERT INTO SADSAD(1,2,1,2)");
//            Console.WriteLine(Logica.Ciudad.guardar(12, "ADASDA"));
        }
    }
}
