using AdminEmpleadosEntidades;
using AdminEmpleadosNegocio;

namespace AdminEmpleadosFront
{
    public partial class FrmAdminEmpleados : Form
    {
        List<Empleado> empleadosList = new List<Empleado>();

        public FrmAdminEmpleados()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarEmpleados();
        }
        private void buscarEmpleados()
        {
            //Obtengo el nombre y DNI ingresado por el usuario
            string textoBuscar = txtBuscar.Text.Trim().ToUpper();

            //declaro el parametro
            Empleado parametro = new Empleado();

            //asigno el nombre ingresado
            if (!String.IsNullOrEmpty(textoBuscar.Trim()))
            {
                parametro.Nombre = textoBuscar;
                parametro.Dni = textoBuscar;
            }

            parametro.anulado = chkAnulados.Checked;

            //Busco la lista de empleados en la capa de negocio, pasandole el parametro ingresado
            empleadosList = EmpleadosNegocio.Get(parametro);
            //Actualizo la grilla
            refreshGrid();
        }

        private void refreshGrid()
        {
            //Actualizo el Binding con la lista de empleados que viene desde la BD
            empleadoBindingSource.DataSource = null;
            empleadoBindingSource.DataSource = empleadosList;

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Llamo al metodo buscar al presionar la tecla "Enter"
            if (e.KeyChar == (char)Keys.Enter)
            {
                buscarEmpleados();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmEditEmpleados frm = new FrmEditEmpleados();

            frm.modo = EnumModoForm.Alta;
            frm.ShowDialog();

            buscarEmpleados();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (empleadoBindingSource.Current == null)
                return;

            FrmEditEmpleados frm = new FrmEditEmpleados();

            frm.modo = EnumModoForm.Modificacion;
            frm._empleado = (Empleado)empleadoBindingSource.Current;

            frm.ShowDialog();

            buscarEmpleados();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (empleadoBindingSource.Current == null) //Si es nulo no hago nada
                return;

            FrmEditEmpleados frm = new FrmEditEmpleados(); //Se instancia el objeto de EditEmpleado

            frm.modo = EnumModoForm.Consulta; //Se asigna el modo consulta
            frm._empleado = (Empleado)empleadoBindingSource.Current; //Se asigna el empleado que lo tomo del BindingSource

            frm.ShowDialog(); //Muestro el formulario

            buscarEmpleados();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (empleadoBindingSource.Current == null)
                return;

            Empleado emp = (Empleado)empleadoBindingSource.Current;

            //pregunto si quiere guardar los datos
            DialogResult res = MessageBox.Show("¿Confirma anular el empleado " + emp.Nombre + " ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }

            try
            {
                EmpleadosNegocio.Anular((int)emp.EmpleadoId);
                MessageBox.Show("El empleado " + emp.Nombre + " se anuló correctamente", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            buscarEmpleados();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Confirmar eliminación de empleados anulados
            if (MessageBox.Show("¿Desea quitar de la BD todos los empleados anulados?", "Confirmar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("¿Confirma quitar los empleados anulados definitivamente?", "Confirmar",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        EmpleadosNegocio.DeleteAnulados();
                        MessageBox.Show("Los empleados se borraron correctamente", "Delete",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    buscarEmpleados();
                }
            }
        }

        /*private void btnDelete_Click(object sender, EventArgs e)
        {

            //pregunto si quiere guardar los datos
            DialogResult res = MessageBox.Show("¿Desea quitar de la BD todos los empleados anulados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }

            res = MessageBox.Show("¿Confirma quitar los empleados anulados definitivamente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }




            try
            {
                EmpleadosNegocio.DeleteAnulados();
                MessageBox.Show("Los empleados se borraron correctamente", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            buscarEmpleados();
        }*/

        private void chkAnulados_CheckedChanged(object sender, EventArgs e)
        {
            buscarEmpleados();
        }

        private void empleadoBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void empleadoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void empleadoBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }
    }
}
