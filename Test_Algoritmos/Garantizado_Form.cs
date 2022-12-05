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
    public partial class Garantizado_Form : Form
    {
        Conexion con = new Conexion();
        Algoritmos algoritmos = new Algoritmos();

        public Garantizado_Form()
        {
            InitializeComponent();
        }

        private void btn_Garantizado_Click(object sender, EventArgs e)
        {
            if (txtQuantum.Text == "")
            {
                MessageBox.Show("Necesita digitar Quantum en este algoritmo");

            }
            else
            {
                algoritmos.PlanifGarantizada(int.Parse(txtQuantum.Text));
                dgvGarantizadoResult.DataSource = algoritmos.GetLista();
            }
        }

        private void Garantizado_Form_Load(object sender, EventArgs e)
        {
            dgvGarantizadoResult.DataSource = con.GetPROCESS();
        }
    }
}
