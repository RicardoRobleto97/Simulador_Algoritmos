using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace Test_Algoritmos
{
    public partial class ProcessForm : Form
    {
        Conexion con = new Conexion();
        public ProcessForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Limpiar()
        {
            
            txtID.Clear();
            txtName.Clear();
            txtCPU.Clear();
            txtPriority.Clear();
            txtTiempoLLegada.Clear();
            
        }
        private List<PROCESS> Encontrado(int ID)
        {
            List<PROCESS> LU = new List<PROCESS>();
            if (txtID.Text != "")
            {
                LU = con.Find(ID);
            }
            else
            {
                MessageBox.Show("Digite ID del Proceso");
                txtID.Focus();
            }
            return LU;
        }
        private void ProcessForm_Load(object sender, EventArgs e)
        {
            try
            {
                
                dgvProcesos.DataSource = con.GetPROCESS();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
 
        private void addbtn_Click(object sender, EventArgs e)
        {

            //string nombre = txtName.Text;
            // string cpu = txtCPU.Text;
            // string tiLlegada = txtTiempoLLegada.Text;
            // string priority = txtPriority.Text;
            try
            {   
                 int id = Convert.ToInt32(txtID.Text);
                bool encontrado = false;
                encontrado = con.ValidarCode(id);
                if (encontrado)
                {
                    MessageBox.Show("Proceso ya existe digite uno nuevo!");

                }
                else
                {
                    con.GuardarProcess(Convert.ToInt32(txtID.Text), txtName.Text, Convert.ToInt32(txtCPU.Text), Convert.ToInt32(txtTiempoLLegada.Text), Convert.ToInt32(txtPriority.Text));
                    MessageBox.Show("Proceso Ingresado a Base de Datos");
                    dgvProcesos.DataSource = con.GetPROCESS();
                }
     

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                List<PROCESS> lista_process = new List<PROCESS>();

                lista_process = Encontrado(Convert.ToInt32(txtID.Text));
                if(lista_process.Count > 0)
                {
                    MessageBox.Show("Proceso Encontrado");
                    foreach(var li in lista_process)
                    {
                        txtID.Text = li.ID.ToString();
                        txtName.Text = li.Nombre.ToString();
                        txtCPU.Text = li.CPU.ToString();
                        txtPriority.Text=li.Prioridad.ToString();
                        txtTiempoLLegada.Text=li.Prioridad.ToString();
                    }
                }
                else
                {
                    MessageBox.Show(" No encontrado. Crear Nuevo");
                    txtID.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<PROCESS> lista_process = new List<PROCESS>();
            lista_process = Encontrado(Convert.ToInt32(txtID.Text));

            if (lista_process.Count > 0)
            {
                con.DeleteProcesss(Convert.ToInt32(txtID.Text));
                MessageBox.Show("Proceso eliminado");
                Limpiar();
                dgvProcesos.DataSource = con.GetPROCESS();
            }
            else
            {
                MessageBox.Show("Digite Codigo de Usuario");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                List<PROCESS> lista_process = new List<PROCESS>();

                lista_process = Encontrado(Convert.ToInt32(txtID.Text));
                if(lista_process.Count > 0)
                {
                   
                    con.UpdateProcess(Convert.ToInt32(txtID.Text), txtName.Text, 
                        Convert.ToInt32(txtCPU.Text), 
                        Convert.ToInt32(txtTiempoLLegada.Text), 
                        Convert.ToInt32(txtPriority.Text));
                    MessageBox.Show("Proceso Actualizado");
                    dgvProcesos.DataSource = con.GetPROCESS();
                }
                else
                {
                    MessageBox.Show(" No encontrado. Crear Nuevo");
                    txtID.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
