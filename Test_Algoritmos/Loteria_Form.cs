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
    public partial class Loteria_Form : Form
    {
        Conexion con = new Conexion();
        Algoritmos algoritmos = new Algoritmos();
        public Loteria_Form()
        {
            InitializeComponent();
        }

        private void btn_Loteria_Click(object sender, EventArgs e)
        {
            if (txtQuantum.Text == "")
            {
                MessageBox.Show("Necesita digitar Quantum en este algoritmo");

            }
            else
            {
                algoritmos.AlgorPorLoteria(int.Parse(txtQuantum.Text));
                dgvLoteriaResult.DataSource = algoritmos.GetLista();
            }
        }

        private void Loteria_Form_Load(object sender, EventArgs e)
        {
            dgvLoteriaResult.DataSource = con.GetPROCESS();
        }
    }
}
