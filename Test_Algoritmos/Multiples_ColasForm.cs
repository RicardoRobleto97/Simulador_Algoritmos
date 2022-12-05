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
    public partial class Multiples_ColasForm : Form
    {
        Conexion con = new Conexion();
        Algoritmos algoritmos = new Algoritmos();

        public Multiples_ColasForm()
        {
            InitializeComponent();
        }

        private void btn_MultiColass_Click(object sender, EventArgs e)
        {
            if (txtQuantum.Text == "")
            {
                MessageBox.Show("Necesita digitar Quantum en este algoritmo");

            }
            else
            {
                algoritmos.ColasMultiples(int.Parse(txtQuantum.Text));
                dgvMultiColasResult.DataSource = algoritmos.GetLista();
            }
        }

        private void Multiples_ColasForm_Load(object sender, EventArgs e)
        {
            dgvMultiColasResult.DataSource = con.GetPROCESS();
        }
    }
}
