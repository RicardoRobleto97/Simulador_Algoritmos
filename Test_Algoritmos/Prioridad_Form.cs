using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Algoritmos
{
    public partial class Prioridad_Form : Form
    {
        Conexion con = new Conexion();
        Algoritmos algoritmos = new Algoritmos();
        public Prioridad_Form()
        {
            InitializeComponent();
        }

        private void btn_prioridad_Click(object sender, EventArgs e)
        {
            if (txtQuantum.Text == "")
            {
                MessageBox.Show("Necesita digitar Quantum en este algoritmo");

            }
            else
            {
                algoritmos.Prioridad(int.Parse(txtQuantum.Text));
                dgvPrioridadResult.DataSource = algoritmos.GetLista();
            }
        }

        private void Prioridad_Form_Load(object sender, EventArgs e)
        {
            try
            {

                
                dgvPrioridadResult.DataSource = con.GetPROCESS();
                dgvPrioridadResult.Columns[6].Visible=false;
                // pnlPared.Visible = true;
                //pnlPriority.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPrioridadResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
