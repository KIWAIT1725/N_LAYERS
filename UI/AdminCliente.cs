using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EL;
using BLL;

namespace UI
{
    public partial class AdminCliente : Form
    {
        public AdminCliente()
        {
            InitializeComponent();
        }

        private void AdminCliente_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }
        private void cargarGrid()
        {
            try
            {
                gridClientes.DataSource = BLL_Clientes.Lista();
                gridClientes.Columns[0].Visible = false;
                gridClientes.Columns[4].Visible = false;
                gridClientes.Columns[5].Visible = false;
                gridClientes.Columns[6].Visible = false;
                gridClientes.Columns[7].Visible = false;
                gridClientes.Columns[8].Visible = false;
            }
            catch (Exception Error)
            {

                MessageBox.Show(Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
