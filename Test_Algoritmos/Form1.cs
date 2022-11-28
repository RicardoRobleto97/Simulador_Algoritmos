using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Test_Algoritmos
{
    public partial class Form1 : Form
    {
        Conexion con = new Conexion();
        Algoritmos algoritmos = new Algoritmos();

        public Form1()
        {
            InitializeComponent();
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessForm pf = new ProcessForm();
            pf.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void pnlPriority_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            algoritmos.Prioridad(int.Parse(txtQuantum.Text));

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
