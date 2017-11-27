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
    public partial class FormTable : Form
    {
        public FormTable()
        {
            InitializeComponent();
        }
        public void setTable(string tableName,DataTable table)
        {
            Text = tableName;
            dgvTable.DataSource = table;


        }

        private void FormTable_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                this.Width = dgvTable.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
                this.Height = dgvTable.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 83;
                
            }
            
        }
    }
}
