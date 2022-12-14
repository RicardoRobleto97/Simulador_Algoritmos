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
    public partial class RR_Form : Form
    {
        Conexion con = new Conexion();
        Algoritmos algoritmos = new Algoritmos();
        public RR_Form()
        {
            InitializeComponent();
        }

        private void bntRR_Click(object sender, EventArgs e)
        {
            if (txtQuantum.Text == "")
            {
                MessageBox.Show("Necesita digitar Quantum en este algoritmo");

            }
            else
            {
                algoritmos.RoundRobin(int.Parse(txtQuantum.Text));
                dgvRR.DataSource = algoritmos.GetLista();
            }
        }

        private void RR_Form_Load(object sender, EventArgs e)
        {
            dgvRR.DataSource = con.GetPROCESS();
        }
    }
}
