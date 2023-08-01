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
using Materiales;

namespace UI
{
    public partial class AdminCliente : Form
    {
        private static int IdUsuarioSesion = 1;
        private static int IdRegistro = 0;
        public AdminCliente()
        {
            InitializeComponent();
        }

        private void AdminCliente_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        #region Metodos de las UI y Funciones Personalizadas
        private void cargarGrid()
        {
            try
            {
                gridClientes.DataSource = BLL_Clientes.Lista();
                gridClientes.Columns[0].Visible = false;
                gridClientes.Columns[1].HeaderText = "Nombre del Cliente";
                gridClientes.Columns[2].HeaderText = "Celular";
                gridClientes.Columns[4].Visible = false;
                gridClientes.Columns[5].Visible = false;
                gridClientes.Columns[6].Visible = false;
                gridClientes.Columns[7].Visible = false;
                gridClientes.Columns[8].Visible = false;
                Limpiar();
            }
            catch (Exception Error)
            {

                MessageBox.Show(Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el Nombre del Cliente");
                return false;
            }
            if (txtNombre.Text.Length > 200)
            {
                MessageBox.Show("el campo del cliente debe ser al menos de 200 CRTES ");
                return false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Ingrese el Numero de Telefono");
                return false;
            }
            if (txtTelefono.Text.Length < 8)
            {
                MessageBox.Show("Numero no Valido");
                return false;
            }
            if (BLL_Clientes.ExisteNumero(txtTelefono.Text, IdRegistro))
            {
                MessageBox.Show("El Numero ya se Registro");
                return false;
            }
            if (string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Ingrese Un correo");
                return false;
            }
            if (!(txtCorreo.Text.Length < 200))
            {
                MessageBox.Show("El campo del Correo debe ser menos de 200 CRTS");
                return false;
            }
            if (!General.ValidateEmail(txtCorreo.Text))
            {
                MessageBox.Show("Ingreso usted un correo Invalido");
                return false;
            }
            if (BLL_Clientes.ExisteCorreo(txtCorreo.Text, IdRegistro))
            {
                MessageBox.Show("El correo se Registro");
                return false;
            }

            return true;
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }
        private void Guardar()
        {
            if (ValidarFormulario())
            {
                Clientes clientes = new();
                clientes.nombreCliente = txtNombre.Text;
                clientes.Numero = txtTelefono.Text;
                clientes.Correo = txtCorreo.Text;

                if (IdRegistro > 0)
                {
                    //Actualizar
                    clientes.IdClientes = IdRegistro;
                    clientes.IdUsuarioActualiza = IdUsuarioSesion;
                    if (BLL_Clientes.Update(clientes))
                    {
                        MessageBox.Show("registro actualizado con Exito");
                        cargarGrid();
                        return;
                    }
                    MessageBox.Show("El registro no fue Actualizado");
                    return;

                }
                //Insertar
                clientes.IdUsuarioRegistra = IdUsuarioSesion;
                if (BLL_Clientes.Insert(clientes).IdClientes > 0)
                {
                    MessageBox.Show("Registro Exitoso");
                    cargarGrid();
                    return;
                }
            }
        }
        private void Anular()
        {
            try
            {
                Clientes clientes = new();
                clientes.IdClientes = IdRegistro;
                clientes.IdUsuarioActualiza = IdUsuarioSesion;
                if (BLL_Clientes.Anular(clientes))
                {
                    MessageBox.Show("Registro Anulado Exitoso");
                    cargarGrid();
                    return;
                }
                MessageBox.Show("El registro no fue Anulado");
                return;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
        private void cargarCampos()
        {
            try
            {

                IdRegistro = Convert.ToInt32(gridClientes.CurrentRow.Cells[0].Value);
                txtNombre.Text = gridClientes.CurrentRow.Cells[1].Value.ToString();
                txtTelefono.Text = gridClientes.CurrentRow.Cells[2].Value.ToString();
                txtCorreo.Text = gridClientes.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Botones de Funciones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }
        private void gridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCampos();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cargarGrid();
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }



    }
}
#endregion