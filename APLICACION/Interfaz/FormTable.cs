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
            this.resizeTable(dgvTable);

        }
        private void resizeTable(DataGridView grd)
        {
            //set autosize mode
            grd.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grd.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grd.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //datagrid has calculated it's widths so we can store them
            for (int i = 0; i <= grd.Columns.Count - 1; i++)
            {
                //store autosized widths
                int colw = grd.Columns[i].Width;
                //remove autosizing
                grd.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //set width to calculated by autosize
                grd.Columns[i].Width = colw;
            }
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
