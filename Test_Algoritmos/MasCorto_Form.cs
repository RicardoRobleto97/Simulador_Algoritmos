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
    public partial class MasCorto_Form : Form
    {
        Conexion con = new Conexion();
        Algoritmos algoritmos = new Algoritmos();
        public MasCorto_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            algoritmos.ProcMasCortoContinuacion();
            dgvProcCorto.DataSource = algoritmos.GetLista();
        }

        private void MasCorto_Form_Load(object sender, EventArgs e)
        {
            try
            {

                dgvProcCorto.DataSource = con.GetPROCESS();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
