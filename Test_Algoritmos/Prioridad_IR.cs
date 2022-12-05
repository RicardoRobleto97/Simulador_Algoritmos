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

    public partial class Prioridad_IR : Form
    {
        Conexion con = new Conexion();
        Algoritmos algoritmos = new Algoritmos();
        public Prioridad_IR()
        {
            InitializeComponent();
        }

        private void btn_prioridadIR_Click(object sender, EventArgs e)
        {
            if(txtQuantum.Text == "")
            {
                MessageBox.Show("Necesita digitar Quantum en este algoritmo");

            }
            else
            {
                algoritmos.Prioridad(int.Parse(txtQuantum.Text));
                dgvPrioridadIR_Result.DataSource = algoritmos.GetLista();
            }
        }

        private void Prioridad_IR_Load(object sender, EventArgs e)
        {
            dgvPrioridadIR_Result.DataSource = con.GetPROCESS();
            dgvPrioridadIR_Result.Columns[6].Visible = false;
            dgvPrioridadIR_Result.Columns[7].Visible = false;
        }
    }
}
