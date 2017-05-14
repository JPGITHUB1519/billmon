namespace presentation
{
    partial class PMantBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ttpNotification = new System.Windows.Forms.ToolTip(this.components);
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.chkeliminar = new System.Windows.Forms.CheckBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tabplistado = new System.Windows.Forms.TabPage();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tabpmantenimiento = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.errProv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tabplistado.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabpmantenimiento.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(188, 37);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(423, 22);
            this.txtbuscar.TabIndex = 12;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Buscar";
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "eliminar";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnDelete2
            // 
            this.btnDelete2.Image = global::presentation.Properties.Resources.delete;
            this.btnDelete2.Location = new System.Drawing.Point(224, 75);
            this.btnDelete2.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(141, 89);
            this.btnDelete2.TabIndex = 77;
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // chkeliminar
            // 
            this.chkeliminar.AutoSize = true;
            this.chkeliminar.Location = new System.Drawing.Point(80, 111);
            this.chkeliminar.Margin = new System.Windows.Forms.Padding(4);
            this.chkeliminar.Name = "chkeliminar";
            this.chkeliminar.Size = new System.Drawing.Size(80, 21);
            this.chkeliminar.TabIndex = 76;
            this.chkeliminar.Text = "Eliminar";
            this.chkeliminar.UseVisualStyleBackColor = true;
            this.chkeliminar.CheckedChanged += new System.EventHandler(this.chkeliminar_CheckedChanged);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eliminar});
            this.dgvData.Location = new System.Drawing.Point(60, 185);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(875, 444);
            this.dgvData.TabIndex = 75;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.DoubleClick += new System.EventHandler(this.dgvData_DoubleClick);
            // 
            // tabplistado
            // 
            this.tabplistado.Controls.Add(this.btnDelete2);
            this.tabplistado.Controls.Add(this.chkeliminar);
            this.tabplistado.Controls.Add(this.dgvData);
            this.tabplistado.Controls.Add(this.btnimprimir);
            this.tabplistado.Controls.Add(this.txtbuscar);
            this.tabplistado.Controls.Add(this.label2);
            this.tabplistado.Location = new System.Drawing.Point(4, 25);
            this.tabplistado.Margin = new System.Windows.Forms.Padding(4);
            this.tabplistado.Name = "tabplistado";
            this.tabplistado.Padding = new System.Windows.Forms.Padding(4);
            this.tabplistado.Size = new System.Drawing.Size(1021, 693);
            this.tabplistado.TabIndex = 1;
            this.tabplistado.Text = "Listado";
            this.tabplistado.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = global::presentation.Properties.Resources.print;
            this.btnimprimir.Location = new System.Drawing.Point(657, 8);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(141, 89);
            this.btnimprimir.TabIndex = 73;
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(325, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(420, 36);
            this.label8.TabIndex = 49;
            this.label8.Text = "Mantenimiento de CAMBIAR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Location = new System.Drawing.Point(4, 516);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(987, 150);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::presentation.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(351, 23);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(141, 89);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::presentation.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(201, 23);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 89);
            this.btnSave.TabIndex = 12;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::presentation.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(500, 23);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 89);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::presentation.Properties.Resources.delete1;
            this.btnExit.Location = new System.Drawing.Point(799, 23);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 89);
            this.btnExit.TabIndex = 11;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::presentation.Properties.Resources.Undo_icon;
            this.btnCancel.Location = new System.Drawing.Point(649, 23);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 89);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::presentation.Properties.Resources.add_icon;
            this.btnNew.Location = new System.Drawing.Point(52, 23);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(141, 89);
            this.btnNew.TabIndex = 7;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tabpmantenimiento
            // 
            this.tabpmantenimiento.Controls.Add(this.groupBox2);
            this.tabpmantenimiento.Controls.Add(this.groupBox1);
            this.tabpmantenimiento.Location = new System.Drawing.Point(4, 25);
            this.tabpmantenimiento.Margin = new System.Windows.Forms.Padding(4);
            this.tabpmantenimiento.Name = "tabpmantenimiento";
            this.tabpmantenimiento.Padding = new System.Windows.Forms.Padding(4);
            this.tabpmantenimiento.Size = new System.Drawing.Size(1021, 693);
            this.tabpmantenimiento.TabIndex = 0;
            this.tabpmantenimiento.Text = "Mantenimiento";
            this.tabpmantenimiento.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(983, 476);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CAMBIAR";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpmantenimiento);
            this.tabControl1.Controls.Add(this.tabplistado);
            this.tabControl1.Location = new System.Drawing.Point(62, 83);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 722);
            this.tabControl1.TabIndex = 50;
            // 
            // errProv
            // 
            this.errProv.ContainerControl = this;
            // 
            // PMantBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 825);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabControl1);
            this.Name = "PMantBase";
            this.Text = "PMantBase";
            this.Load += new System.EventHandler(this.PMantBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tabplistado.ResumeLayout(false);
            this.tabplistado.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabpmantenimiento.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolTip ttpNotification;
        public System.Windows.Forms.Button btnimprimir;
        public System.Windows.Forms.TextBox txtbuscar;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eliminar;
        public System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.CheckBox chkeliminar;
        public System.Windows.Forms.DataGridView dgvData;
        public System.Windows.Forms.TabPage tabplistado;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TabPage tabpmantenimiento;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.ErrorProvider errProv;
    }
}