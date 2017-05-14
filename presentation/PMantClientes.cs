using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using data;
using utils;

namespace presentation
{
    public partial class PMantClientes : PMantBase
    {
        public PMantClientes()
        {
            InitializeComponent();
            this.ttpNotification.SetToolTip(txtnombre, "Ingrese Nombre");
            this.ttpNotification.SetToolTip(txtapellido, "Inserte Apellido");
            this.ttpNotification.SetToolTip(txttelefono, "Inserte Telefono");
            this.ttpNotification.SetToolTip(txtdireccion, "Inserte Direccion");
            this.ttpNotification.SetToolTip(txtemail, "Inserte Email");
            this.ttpNotification.SetToolTip(chkis_active, "Esta Activo?");
        }

        private void PMantClientes_Load(object sender, EventArgs e)
        {

        }

        public override void fillDatagrid()
        {
            Cliente cliente = new Cliente();
            this.dgvData.DataSource = cliente.getClientes();
        }

        public override void enable(bool cond)
        {
            this.txtid.ReadOnly = !cond;
            this.txtnombre.ReadOnly = !cond;
            this.txtapellido.ReadOnly = !cond;
            this.txttelefono.ReadOnly = !cond;
            this.txtdireccion.ReadOnly = !cond;
            this.txtemail.ReadOnly = !cond;
            this.chkis_active.Enabled = cond;
        }

        public override void clearTextBoxes()
        {
            this.txtid.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            this.txtapellido.Text = string.Empty;
            this.txttelefono.Text = string.Empty;
            this.txtdireccion.Text = string.Empty;
            this.txtemail.Text = string.Empty;
            this.chkis_active.Checked = false;
        }

        public override void searchByName()
        {
            Cliente cliente = new Cliente();
            this.dgvData.DataSource = cliente.searchClientesByName(this.txtbuscar.Text.Trim());
        }

        public override void guardar()
        {
            int rpta = 0;
            Cliente cliente = new Cliente();

            try
            {
                if (this.isNew)
                {
                    // creating new
                    cliente.Nombre = this.txtnombre.Text.Trim();
                    cliente.Apellido = this.txtapellido.Text.Trim();
                    cliente.Telefono = this.txttelefono.Text.Trim();
                    cliente.Direccion = this.txtdireccion.Text.Trim();
                    cliente.Email = this.txtemail.Text.Trim();
                    cliente.Is_active = this.chkis_active.Checked;
                    rpta = cliente.insertCliente(cliente);
                }
                else
                {
                    // updating new
                    cliente.Idcliente = Convert.ToInt32(this.txtid.Text.Trim());
                    cliente.Nombre = this.txtnombre.Text.Trim();
                    cliente.Apellido = this.txtapellido.Text.Trim();
                    cliente.Telefono = this.txttelefono.Text.Trim();
                    cliente.Direccion = this.txtdireccion.Text.Trim();
                    cliente.Email = this.txtemail.Text.Trim();
                    cliente.Is_active = this.chkis_active.Checked;
                    rpta = cliente.updateCliente(cliente);
                }


                if (rpta == 1)
                {
                    if (this.isNew)
                    {
                        Messages.successMessage(Configuration.insert_sucess);
                    }
                    else
                    {
                        Messages.successMessage(Configuration.update_success);
                    }
                }
                else
                {
                    Messages.errorMessage(Configuration.error_message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // fill textboxes from datagrid
        public override void fillTextBoxesFromDatagrid()
        {
            this.txtid.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["id"].Value);
            this.txtnombre.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["nombre"].Value);
            this.txtapellido.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["apellido"].Value);
            this.txttelefono.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["telefono"].Value);
            this.txtdireccion.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["direccion"].Value);
            this.txtemail.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["email"].Value);
            this.chkis_active.Checked = Convert.ToBoolean(this.dgvData.CurrentRow.Cells["Is_active"].Value);
            this.tabControl1.SelectedIndex = 0;
        }

        public override void setIdRecordToParent()
        {
            this.idrecord = this.txtid.Text.Trim();
        }

        // delete cliente individually override
        public override int deleteMultipleFromDatagridView(int codigo)
        {
            Cliente cliente = new Cliente();
            return cliente.deleteCliente(codigo);
        }

        public override void deleteRecord()
        {
            Cliente cliente = new Cliente();
            int rpta = cliente.deleteCliente(Convert.ToInt32(this.txtid.Text.Trim()));
            if (rpta == 1)
            {
                Messages.successMessage(Configuration.delete_success);
            }
            else
            {
                Messages.errorMessage(Configuration.error_message);
            }

        }
    }
}
