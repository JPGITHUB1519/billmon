using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utils;
using presentation.Reports;

namespace presentation
{
    public partial class PMantBase : Form
    {
        public PMantBase()
        {
            InitializeComponent();
        }

        private void PMantBase_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.fillDatagrid();
            this.enable(false);
            this.setButtons();
            this.setImageButtons();
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.Columns[0].Visible = false;
        }

        public bool isNew = false;
        public bool isEdit = false;
        // variable for validations during Mantenimiento
        public bool validated = true;

        public string idrecord = "";
        // Parent enable / disable buttons method
        public virtual void enable(bool cond) { }
        // Parent clean Textboxes
        public virtual void clearTextBoxes() { }
        // Buttons Change logic on save, edit etc..
        public virtual void guardar() { }
        // fill datagrid
        public virtual void fillDatagrid() { }
        // call generateReportFunction
        public virtual void callReport() { }
        // datagrid filted by na,e
        public virtual void searchByName() { }
        // fill textboxes from datagrid
        public virtual void fillTextBoxesFromDatagrid() { }
        // to set the id textbox to the idrecord parent
        public virtual void setIdRecordToParent() { }
        // delete record parent
        public virtual void deleteRecord() { }
        // delete multiple for datagridview
        public virtual int deleteMultipleFromDatagridView(int codigo) { return 0; }
        // set images buttons enable/disable
        public virtual void setImageButtons() { }
        public void setButtons()
        {
            if (this.isNew || this.isEdit)
            {
                enable(true);
                this.btnNew.Enabled = false;
                this.btnEdit.Enabled = false;
                this.btnSave.Enabled = true;
                this.btnCancel.Enabled = true;
            }
            else
            {
                enable(false);
                this.btnNew.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
            }

        }

        // call reportForm
        public void generateReport(string reportName, DataSet ds)
        {
            PReport frmreport = new PReport(reportName, ds);
            frmreport.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.isNew = true;
            this.isEdit = false;
            this.setButtons();
            // will only execute for forms that have this method
            this.setImageButtons();
            this.clearTextBoxes();
            this.enable(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.guardar();
            // si esta todo correcto
            if (this.validated)
            {
                this.isNew = false;
                this.isEdit = false;
                this.setButtons();
                this.setImageButtons();
                this.clearTextBoxes();
                this.fillDatagrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // to set the id textbox to the idrecord parent
            this.setIdRecordToParent();
            if (!idrecord.Equals(""))
            {
                this.isEdit = true;
                this.setButtons();
                this.setImageButtons();
                this.enable(true);
            }
            else
            {
                Messages.errorMessage("Debe seleccionar primero el registro a modificar");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // to set the id textbox to the idrecord parent
            this.setIdRecordToParent();
            if (!idrecord.Equals(""))
            {
                // confirmation on delete
                DialogResult result = MessageBox.Show("Estas seguro que deseas eliminar el registro seleccionado?", Configuration.system_name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result.Equals(DialogResult.OK))
                {
                    this.deleteRecord();
                    this.clearTextBoxes();
                    this.fillDatagrid();
                }
            }
            else
            {
                Messages.errorMessage("Debe seleccionar primero el registro a eliminar");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.isNew = false;
            this.isEdit = false;
            this.setButtons();
            this.clearTextBoxes();
            this.enable(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            this.callReport();
        }

        private void chkeliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkeliminar.Checked)
            {
                this.dgvData.Columns[0].Visible = true;
            }
            else
            {
                this.dgvData.Columns[0].Visible = false;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvData.Columns["eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)dgvData.Rows[e.RowIndex].Cells["eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            if (this.chkeliminar.Checked)
            {
                // eliminar multiple desde el datagridview;
                DialogResult result = MessageBox.Show("Estas seguro que deseas eliminar los registros seleccionados?", Configuration.system_name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result.Equals(DialogResult.OK))
                {
                    int codigo;
                    int rpta = 0;
                    int cont = 0;
                    foreach (DataGridViewRow row in dgvData.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            rpta = deleteMultipleFromDatagridView(codigo);
                            if (rpta == 1)
                            {
                                cont++;
                            }
                            else
                            {
                                Messages.errorMessage(Configuration.error_message);
                            }

                        }
                    }
                    if (cont == 0)
                    {
                        Messages.successMessage("No se ha eliminado ningún registro");
                    }
                    else if (cont == 1)
                    {
                        Messages.successMessage("Se ha eliminado un registro exitosamente");
                    }
                    else
                    {
                        Messages.successMessage("Se han eliminado " + cont + " registros exitosamente");
                    }

                    this.fillDatagrid();
                }
            }
            else
            {
                Messages.exclamationMessage("Debe seleccionar el/los registros a eliminar");
            }
        }

        private void dgvData_DoubleClick(object sender, EventArgs e)
        {
            this.fillTextBoxesFromDatagrid();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.searchByName();
        }


    }
}
