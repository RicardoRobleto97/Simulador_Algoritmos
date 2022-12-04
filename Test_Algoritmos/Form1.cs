﻿using System;
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
            try
            {

               dgvEntrada.DataSource = con.GetPROCESS();
               // pnlPared.Visible = true;
                //pnlPriority.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pnlPriority_Paint(object sender, PaintEventArgs e)
        {
            
        }


       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void alg_prioridad_Click(object sender, EventArgs e)
        {
            //pnlPared.Visible = false;
            pnlCPU.Visible = false;
            RRPnl.Visible = false;
            pnlPriority.Visible = true;
            dgvPrioridadResult.DataSource = con.GetPROCESS();
            
        }

        private void btn_prioridad_Click(object sender, EventArgs e)
        {
            if (txtQuantum.Text=="")
            {
                MessageBox.Show("Necesita digitar Quantum en este algoritmo");

            }
            else
            {
                algoritmos.Prioridad(int.Parse(txtQuantum.Text));
                dgvPrioridadResult.DataSource = algoritmos.GetLista();
            }


            
        }

        private void algCPU_Click(object sender, EventArgs e)
        {
            //pnlPared.Visible = false;
            pnlPriority.Visible = false;
            pnlCPU.Visible = true;
            RRPnl.Visible = false;
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
            algoritmos.ProcMasCortoContinuacion();
            //algoritmos.RoundRobin(int.Parse(txtQuantumCPU.Text));
            dgvCPU.DataSource = algoritmos.GetLista();
        }

        private void btn_RR_Click(object sender, EventArgs e)
        {
            //pnlPared.Visible = false;
            pnlPriority.Visible = false;
            pnlCPU.Visible = false;
            RRPnl.Visible = true;   
            //pnlPriority.Hide();
        }
    }
}
