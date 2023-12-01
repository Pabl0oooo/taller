using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller.conec
{
    internal class Cclientes
    {
        public void mostarClientes(DataGridView tablaClientes)
        {
            try
            {
                cconexion objetoconexion = new cconexion();
                string query = "select * from clientes";
                tablaClientes.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoconexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaClientes.DataSource = dt;
                objetoconexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se mostraron los datos de la base de datos" + ex.ToString());
            }
        }
        public void guardarclientes(TextBox id, TextBox nombre, TextBox apellido, TextBox telefono)
        {
            try
            {
                cconexion objetoconexion = new cconexion();
                string query = "insert into clientes (id,nombre,apellido,telefono)" + "values ('" + id.Text + "','" + nombre.Text + "','" + apellido.Text + "','" + telefono.Text + "')";
                MySqlCommand myComand = new MySqlCommand(query, objetoconexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("se guardo los reguistro");
                while (reader.Read())
                {
                    
                }
                objetoconexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se mostraron los datos de la base de datos" + ex.ToString());
            }
        }
        public void selecionarclientes(DataGridView tablaClientes,TextBox id, TextBox nombre, TextBox apellido, TextBox telefono)
        {
            try
            {
                id.Text = tablaClientes.CurrentRow.Cells[0].Value.ToString();
                nombre.Text = tablaClientes.CurrentRow.Cells[1].Value.ToString();
                apellido.Text = tablaClientes.CurrentRow.Cells[2].Value.ToString();
                telefono.Text = tablaClientes.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro seleccionar" + ex.ToString());
            }
        }
        public void modeficarclientes(TextBox id, TextBox nombre, TextBox apellido, TextBox telefono)
        {
            try
            {
                if (id.Text == "" || nombre.Text == "" || apellido.Text == "" || telefono.Text == "")
                {
                    MessageBox.Show("No se pueden dejar campos vacíos.");
                    return;
                }

                cconexion objetoconexion = new cconexion();
                string query = "update clientes set nombre='" + nombre.Text + "', apellido='" + apellido.Text + "', telefono='" + telefono.Text + "' where id='" + id.Text + "'";
                MySqlCommand myComand = new MySqlCommand(query, objetoconexion.establecerConexion());
                myComand.ExecuteNonQuery();
                MessageBox.Show("Se modificó correctamente.");
                objetoconexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar el registro. " + ex.ToString());
            }
        }
        public void eliminarclientes(TextBox id, TextBox nombre, TextBox apellido, TextBox telefono)
        {
            try
            {
                if (id.Text == "" || nombre.Text == "" || apellido.Text == "" || telefono.Text == "")
                {
                    MessageBox.Show("No se pueden dejar campos vacíos.");
                    return;
                }

                cconexion objetoconexion = new cconexion();
                string query = "delete from clientes where id= '" + id.Text + "';";
                MySqlCommand myComand = new MySqlCommand(query, objetoconexion.establecerConexion());
                myComand.ExecuteNonQuery();
                MessageBox.Show("Se elimino correctamente.");
                objetoconexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se eliminaron los datos del registro. " + ex.ToString());
            }
        }
    }



}

    
