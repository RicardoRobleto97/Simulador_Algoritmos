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
    public partial class CPU_Form : Form
    {
        Conexion con = new Conexion();
        Algoritmos algoritmos = new Algoritmos();
        public CPU_Form()
        {
            InitializeComponent();
        }

        private void CPU_Form_Load(object sender, EventArgs e)
        {
            dgvCPU.DataSource = con.GetPROCESS();
        }

        private void bntCPU_Click(object sender, EventArgs e)
        {
            if (txtQuantumCPU.Text == "")
            {
                MessageBox.Show("Necesita digitar Quantum en este algoritmo");

            }
            else
            {
                algoritmos.CPU(int.Parse(txtQuantumCPU.Text));
                dgvCPU.DataSource = algoritmos.GetLista();
            }
        }
    }
}
