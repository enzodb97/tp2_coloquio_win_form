namespace AdminEmpleadosFront
{
    partial class Grilla
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
            bindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            button1 = new Button();
            empleadoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaIngresoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dptoidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDepartamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anuladoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(AdminEmpleadosEntidades.Empleado);
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { empleadoIdDataGridViewTextBoxColumn, dniDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, fechaIngresoDataGridViewTextBoxColumn, salarioDataGridViewTextBoxColumn, dptoidDataGridViewTextBoxColumn, departamentoDataGridViewTextBoxColumn, nombreDepartamentoDataGridViewTextBoxColumn, anuladoDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(73, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(257, 227);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "cargar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // empleadoIdDataGridViewTextBoxColumn
            // 
            empleadoIdDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.HeaderText = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.Name = "empleadoIdDataGridViewTextBoxColumn";
            // 
            // dniDataGridViewTextBoxColumn
            // 
            dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // fechaIngresoDataGridViewTextBoxColumn
            // 
            fechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "FechaIngreso";
            fechaIngresoDataGridViewTextBoxColumn.HeaderText = "FechaIngreso";
            fechaIngresoDataGridViewTextBoxColumn.Name = "fechaIngresoDataGridViewTextBoxColumn";
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            // 
            // dptoidDataGridViewTextBoxColumn
            // 
            dptoidDataGridViewTextBoxColumn.DataPropertyName = "dpto_id";
            dptoidDataGridViewTextBoxColumn.HeaderText = "dpto_id";
            dptoidDataGridViewTextBoxColumn.Name = "dptoidDataGridViewTextBoxColumn";
            // 
            // departamentoDataGridViewTextBoxColumn
            // 
            departamentoDataGridViewTextBoxColumn.DataPropertyName = "Departamento";
            departamentoDataGridViewTextBoxColumn.HeaderText = "Departamento";
            departamentoDataGridViewTextBoxColumn.Name = "departamentoDataGridViewTextBoxColumn";
            // 
            // nombreDepartamentoDataGridViewTextBoxColumn
            // 
            nombreDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "NombreDepartamento";
            nombreDepartamentoDataGridViewTextBoxColumn.HeaderText = "NombreDepartamento";
            nombreDepartamentoDataGridViewTextBoxColumn.Name = "nombreDepartamentoDataGridViewTextBoxColumn";
            nombreDepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anuladoDataGridViewCheckBoxColumn
            // 
            anuladoDataGridViewCheckBoxColumn.DataPropertyName = "anulado";
            anuladoDataGridViewCheckBoxColumn.HeaderText = "anulado";
            anuladoDataGridViewCheckBoxColumn.Name = "anuladoDataGridViewCheckBoxColumn";
            // 
            // Grilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Grilla";
            Text = "Grilla";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dptoidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDepartamentoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn anuladoDataGridViewCheckBoxColumn;
    }
}