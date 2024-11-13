﻿namespace AdminEmpleadosFront
{
    partial class FrmAdminEmpleados
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            FechaIngreso = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            NombreDepartamento = new DataGridViewTextBoxColumn();
            anuladoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            empleadoBindingSource = new BindingSource(components);
            txtBuscar = new TextBox();
            btnAlta = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnBuscar = new Button();
            btnConsultar = new Button();
            btnModificar = new Button();
            btnBaja = new Button();
            btnCerrar = new Button();
            btnDelete = new Button();
            chkAnulados = new CheckBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Dni, Nombre, Direccion, FechaIngreso, Salario, NombreDepartamento, anuladoDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = empleadoBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(108, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(837, 460);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "EmpleadoId";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // Dni
            // 
            Dni.DataPropertyName = "Dni";
            Dni.HeaderText = "Dni";
            Dni.Name = "Dni";
            Dni.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // FechaIngreso
            // 
            FechaIngreso.DataPropertyName = "FechaIngreso";
            FechaIngreso.HeaderText = "FechaIngreso";
            FechaIngreso.Name = "FechaIngreso";
            FechaIngreso.ReadOnly = true;
            // 
            // Salario
            // 
            Salario.DataPropertyName = "Salario";
            Salario.HeaderText = "Salario";
            Salario.Name = "Salario";
            Salario.ReadOnly = true;
            // 
            // NombreDepartamento
            // 
            NombreDepartamento.DataPropertyName = "NombreDepartamento";
            NombreDepartamento.HeaderText = "NombreDepartamento";
            NombreDepartamento.Name = "NombreDepartamento";
            NombreDepartamento.ReadOnly = true;
            // 
            // anuladoDataGridViewCheckBoxColumn
            // 
            anuladoDataGridViewCheckBoxColumn.DataPropertyName = "anulado";
            anuladoDataGridViewCheckBoxColumn.HeaderText = "anulado";
            anuladoDataGridViewCheckBoxColumn.Name = "anuladoDataGridViewCheckBoxColumn";
            anuladoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // empleadoBindingSource
            // 
            empleadoBindingSource.DataSource = typeof(AdminEmpleadosEntidades.Empleado);
            empleadoBindingSource.CurrentChanged += empleadoBindingSource_CurrentChanged_1;
            // 
            // txtBuscar
            // 
            txtBuscar.Dock = DockStyle.Fill;
            txtBuscar.Location = new Point(0, 0);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar";
            txtBuscar.Size = new Size(837, 23);
            txtBuscar.TabIndex = 2;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(3, 47);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(99, 38);
            btnAlta.TabIndex = 0;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnBuscar);
            flowLayoutPanel1.Controls.Add(btnAlta);
            flowLayoutPanel1.Controls.Add(btnConsultar);
            flowLayoutPanel1.Controls.Add(btnModificar);
            flowLayoutPanel1.Controls.Add(btnBaja);
            flowLayoutPanel1.Controls.Add(btnCerrar);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(chkAnulados);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(108, 488);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(3, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(99, 38);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(3, 91);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(99, 38);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(3, 135);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(99, 38);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(3, 179);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(99, 38);
            btnBaja.TabIndex = 2;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(3, 223);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(99, 38);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Salir";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(3, 267);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 38);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Borrar anulados";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // chkAnulados
            // 
            chkAnulados.AutoSize = true;
            chkAnulados.Location = new Point(3, 311);
            chkAnulados.Name = "chkAnulados";
            chkAnulados.Size = new Size(93, 19);
            chkAnulados.TabIndex = 7;
            chkAnulados.Text = "Ver anulados";
            chkAnulados.UseVisualStyleBackColor = true;
            chkAnulados.CheckedChanged += chkAnulados_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(108, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 28);
            panel1.TabIndex = 4;
            // 
            // FrmAdminEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 488);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "FrmAdminEmpleados";
            Text = "Administración de empleados";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private Button btnAlta;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnModificar;
        private Button btnBaja;
        private Button btnConsultar;
        private Button btnCerrar;
        private Panel panel1;
        private Button btnBuscar;
        private Button btnDelete;
        private BindingSource empleadoBindingSource;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn FechaIngreso;
        private DataGridViewTextBoxColumn Salario;
        private DataGridViewTextBoxColumn NombreDepartamento;
        private DataGridViewCheckBoxColumn anuladoDataGridViewCheckBoxColumn;
        private CheckBox chkAnulados;
    }
}