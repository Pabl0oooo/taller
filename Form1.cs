using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            conec.Cclientes objetosclientes = new conec.Cclientes();
            objetosclientes.mostarClientes(totalclientes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conec.cconexion objetoconexion = new conec.cconexion();
            objetoconexion.establecerConexion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            conec.Cclientes objetosclientes = new conec.Cclientes();
            objetosclientes.guardarclientes(txtid,txtnombre,txtapellido,txttelefono);
            objetosclientes.mostarClientes(totalclientes);
        }

        private void totalclientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            conec.Cclientes objetosclientes = new conec.Cclientes();
            objetosclientes.selecionarclientes(totalclientes, txtid, txtnombre, txtapellido, txttelefono);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            conec.Cclientes objetosclientes = new conec.Cclientes();
            objetosclientes.modeficarclientes(txtid, txtnombre, txtapellido, txttelefono);
            objetosclientes.mostarClientes(totalclientes);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            conec.Cclientes objetosclientes = new conec.Cclientes();
            objetosclientes.eliminarclientes(txtid, txtnombre, txtapellido, txttelefono);
            objetosclientes.mostarClientes(totalclientes);
        }
    }
}
