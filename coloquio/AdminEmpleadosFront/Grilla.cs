using AdminEmpleadosEntidades;
using AdminEmpleadosNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEmpleadosFront
{
    public partial class Grilla : Form
    {
        public Grilla()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarEmpleados();
        }
        private void buscarEmpleados()
        {
            List<Empleado> list = new List<Empleado>();

            list.Add(new Empleado { EmpleadoId = 1, Nombre = "Lionel" });//Agrega empleado a la lista
            list.Add(new Empleado { EmpleadoId = 2, Nombre = "Messi" });//Agrega empleado a la lista

            bindingSource1.DataSource = list; //Asocia el Bindingsource a la lista
        }

        private void empleadoBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void empleadoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
