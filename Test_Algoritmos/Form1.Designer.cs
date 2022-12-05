namespace Test_Algoritmos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_RR = new System.Windows.Forms.Button();
            this.algCPU = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.alg_prioridad = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porMemoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvEntrada = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProcesoCorto = new System.Windows.Forms.Button();
            this.btnGarantizada = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMultiplesColas = new System.Windows.Forms.Button();
            this.btnPrioridadIR = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Reloj = new System.Windows.Forms.Button();
            this.btn_IIOportunidad = new System.Windows.Forms.Button();
            this.btn_NRU = new System.Windows.Forms.Button();
            this.btn_Optimo = new System.Windows.Forms.Button();
            this.btnFIFO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Referenciass = new System.Windows.Forms.Button();
            this.txtMarcos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQuantum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnPrioridadIR);
            this.panel1.Controls.Add(this.btnMultiplesColas);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnGarantizada);
            this.panel1.Controls.Add(this.ProcesoCorto);
            this.panel1.Controls.Add(this.btn_RR);
            this.panel1.Controls.Add(this.algCPU);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.alg_prioridad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 1036);
            this.panel1.TabIndex = 5;
            // 
            // btn_RR
            // 
            this.btn_RR.BackColor = System.Drawing.Color.White;
            this.btn_RR.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_RR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.btn_RR.Location = new System.Drawing.Point(64, 287);
            this.btn_RR.Name = "btn_RR";
            this.btn_RR.Size = new System.Drawing.Size(140, 51);
            this.btn_RR.TabIndex = 23;
            this.btn_RR.Text = "Round Robin";
            this.btn_RR.UseVisualStyleBackColor = false;
            this.btn_RR.Click += new System.EventHandler(this.btn_RR_Click);
            // 
            // algCPU
            // 
            this.algCPU.AutoSize = true;
            this.algCPU.BackColor = System.Drawing.Color.White;
            this.algCPU.CausesValidation = false;
            this.algCPU.Cursor = System.Windows.Forms.Cursors.Default;
            this.algCPU.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.algCPU.FlatAppearance.BorderSize = 1000;
            this.algCPU.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.algCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.algCPU.Location = new System.Drawing.Point(64, 231);
            this.algCPU.Name = "algCPU";
            this.algCPU.Size = new System.Drawing.Size(140, 50);
            this.algCPU.TabIndex = 22;
            this.algCPU.Text = "CPU";
            this.algCPU.UseVisualStyleBackColor = false;
            this.algCPU.Click += new System.EventHandler(this.algCPU_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "Algoritmos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alg_prioridad
            // 
            this.alg_prioridad.AutoSize = true;
            this.alg_prioridad.BackColor = System.Drawing.Color.White;
            this.alg_prioridad.CausesValidation = false;
            this.alg_prioridad.Cursor = System.Windows.Forms.Cursors.Default;
            this.alg_prioridad.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.alg_prioridad.FlatAppearance.BorderSize = 1000;
            this.alg_prioridad.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.alg_prioridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.alg_prioridad.Location = new System.Drawing.Point(64, 175);
            this.alg_prioridad.Name = "alg_prioridad";
            this.alg_prioridad.Size = new System.Drawing.Size(140, 50);
            this.alg_prioridad.TabIndex = 0;
            this.alg_prioridad.Text = "Prioridad";
            this.alg_prioridad.UseVisualStyleBackColor = false;
            this.alg_prioridad.Click += new System.EventHandler(this.alg_prioridad_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmosToolStripMenuItem,
            this.procesosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(335, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1692, 35);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmosToolStripMenuItem
            // 
            this.algoritmosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porCPUToolStripMenuItem,
            this.porMemoriaToolStripMenuItem});
            this.algoritmosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoritmosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.algoritmosToolStripMenuItem.Name = "algoritmosToolStripMenuItem";
            this.algoritmosToolStripMenuItem.Size = new System.Drawing.Size(138, 31);
            this.algoritmosToolStripMenuItem.Text = "Algoritmos";
            // 
            // porCPUToolStripMenuItem
            // 
            this.porCPUToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.porCPUToolStripMenuItem.Name = "porCPUToolStripMenuItem";
            this.porCPUToolStripMenuItem.Size = new System.Drawing.Size(276, 32);
            this.porCPUToolStripMenuItem.Text = "Por CPU";
            // 
            // porMemoriaToolStripMenuItem
            // 
            this.porMemoriaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.porMemoriaToolStripMenuItem.Name = "porMemoriaToolStripMenuItem";
            this.porMemoriaToolStripMenuItem.Size = new System.Drawing.Size(276, 32);
            this.porMemoriaToolStripMenuItem.Text = "MMU-Paginacion";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procesosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(115, 31);
            this.procesosToolStripMenuItem.Text = "Procesos";
            this.procesosToolStripMenuItem.Click += new System.EventHandler(this.procesosToolStripMenuItem_Click);
            // 
            // dgvEntrada
            // 
            this.dgvEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrada.Location = new System.Drawing.Point(385, 116);
            this.dgvEntrada.Name = "dgvEntrada";
            this.dgvEntrada.RowHeadersWidth = 51;
            this.dgvEntrada.RowTemplate.Height = 24;
            this.dgvEntrada.Size = new System.Drawing.Size(735, 256);
            this.dgvEntrada.TabIndex = 10;
            this.dgvEntrada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(677, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tabla Inicial";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ProcesoCorto
            // 
            this.ProcesoCorto.AutoSize = true;
            this.ProcesoCorto.BackColor = System.Drawing.Color.White;
            this.ProcesoCorto.CausesValidation = false;
            this.ProcesoCorto.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProcesoCorto.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.ProcesoCorto.FlatAppearance.BorderSize = 1000;
            this.ProcesoCorto.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcesoCorto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.ProcesoCorto.Location = new System.Drawing.Point(64, 344);
            this.ProcesoCorto.Name = "ProcesoCorto";
            this.ProcesoCorto.Size = new System.Drawing.Size(140, 57);
            this.ProcesoCorto.TabIndex = 24;
            this.ProcesoCorto.Text = "Proceso+Corto";
            this.ProcesoCorto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProcesoCorto.UseVisualStyleBackColor = false;
            this.ProcesoCorto.Click += new System.EventHandler(this.ProcesoCorto_Click);
            // 
            // btnGarantizada
            // 
            this.btnGarantizada.AutoSize = true;
            this.btnGarantizada.BackColor = System.Drawing.Color.White;
            this.btnGarantizada.CausesValidation = false;
            this.btnGarantizada.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGarantizada.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnGarantizada.FlatAppearance.BorderSize = 1000;
            this.btnGarantizada.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGarantizada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.btnGarantizada.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGarantizada.Location = new System.Drawing.Point(64, 407);
            this.btnGarantizada.Name = "btnGarantizada";
            this.btnGarantizada.Size = new System.Drawing.Size(140, 58);
            this.btnGarantizada.TabIndex = 25;
            this.btnGarantizada.Text = "Garantizada";
            this.btnGarantizada.UseVisualStyleBackColor = false;
            this.btnGarantizada.Click += new System.EventHandler(this.btnGarantizada_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.CausesValidation = false;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.button2.FlatAppearance.BorderSize = 1000;
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button2.Location = new System.Drawing.Point(64, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 58);
            this.button2.TabIndex = 26;
            this.button2.Text = "Loteria";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnMultiplesColas
            // 
            this.btnMultiplesColas.AutoSize = true;
            this.btnMultiplesColas.BackColor = System.Drawing.Color.White;
            this.btnMultiplesColas.CausesValidation = false;
            this.btnMultiplesColas.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMultiplesColas.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnMultiplesColas.FlatAppearance.BorderSize = 1000;
            this.btnMultiplesColas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplesColas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.btnMultiplesColas.Location = new System.Drawing.Point(64, 535);
            this.btnMultiplesColas.Name = "btnMultiplesColas";
            this.btnMultiplesColas.Size = new System.Drawing.Size(140, 57);
            this.btnMultiplesColas.TabIndex = 27;
            this.btnMultiplesColas.Text = "Multiples Colas";
            this.btnMultiplesColas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMultiplesColas.UseVisualStyleBackColor = false;
            this.btnMultiplesColas.Click += new System.EventHandler(this.btnMultiplesColas_Click);
            // 
            // btnPrioridadIR
            // 
            this.btnPrioridadIR.AutoSize = true;
            this.btnPrioridadIR.BackColor = System.Drawing.Color.White;
            this.btnPrioridadIR.CausesValidation = false;
            this.btnPrioridadIR.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPrioridadIR.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnPrioridadIR.FlatAppearance.BorderSize = 1000;
            this.btnPrioridadIR.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrioridadIR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.btnPrioridadIR.Location = new System.Drawing.Point(64, 610);
            this.btnPrioridadIR.Name = "btnPrioridadIR";
            this.btnPrioridadIR.Size = new System.Drawing.Size(140, 57);
            this.btnPrioridadIR.TabIndex = 28;
            this.btnPrioridadIR.Text = "Prioridad IR";
            this.btnPrioridadIR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrioridadIR.UseVisualStyleBackColor = false;
            this.btnPrioridadIR.Click += new System.EventHandler(this.btnPrioridadIR_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtQuantum);
            this.panel2.Controls.Add(this.txtMarcos);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btn_Referenciass);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_Reloj);
            this.panel2.Controls.Add(this.btn_IIOportunidad);
            this.panel2.Controls.Add(this.btn_NRU);
            this.panel2.Controls.Add(this.btn_Optimo);
            this.panel2.Controls.Add(this.btnFIFO);
            this.panel2.Location = new System.Drawing.Point(1583, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 999);
            this.panel2.TabIndex = 23;
            // 
            // btn_Reloj
            // 
            this.btn_Reloj.AutoSize = true;
            this.btn_Reloj.BackColor = System.Drawing.Color.White;
            this.btn_Reloj.CausesValidation = false;
            this.btn_Reloj.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Reloj.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_Reloj.FlatAppearance.BorderSize = 1000;
            this.btn_Reloj.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reloj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.btn_Reloj.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_Reloj.Location = new System.Drawing.Point(137, 429);
            this.btn_Reloj.Name = "btn_Reloj";
            this.btn_Reloj.Size = new System.Drawing.Size(140, 58);
            this.btn_Reloj.TabIndex = 30;
            this.btn_Reloj.Text = "Reloj";
            this.btn_Reloj.UseVisualStyleBackColor = false;
            this.btn_Reloj.Click += new System.EventHandler(this.btn_Reloj_Click);
            // 
            // btn_IIOportunidad
            // 
            this.btn_IIOportunidad.AutoSize = true;
            this.btn_IIOportunidad.BackColor = System.Drawing.Color.White;
            this.btn_IIOportunidad.CausesValidation = false;
            this.btn_IIOportunidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_IIOportunidad.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_IIOportunidad.FlatAppearance.BorderSize = 1000;
            this.btn_IIOportunidad.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IIOportunidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.btn_IIOportunidad.Location = new System.Drawing.Point(137, 350);
            this.btn_IIOportunidad.Name = "btn_IIOportunidad";
            this.btn_IIOportunidad.Size = new System.Drawing.Size(140, 57);
            this.btn_IIOportunidad.TabIndex = 29;
            this.btn_IIOportunidad.Text = "II Oportunidad";
            this.btn_IIOportunidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_IIOportunidad.UseVisualStyleBackColor = false;
            this.btn_IIOportunidad.Click += new System.EventHandler(this.btn_IIOportunidad_Click);
            // 
            // btn_NRU
            // 
            this.btn_NRU.BackColor = System.Drawing.Color.White;
            this.btn_NRU.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_NRU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.btn_NRU.Location = new System.Drawing.Point(137, 279);
            this.btn_NRU.Name = "btn_NRU";
            this.btn_NRU.Size = new System.Drawing.Size(140, 51);
            this.btn_NRU.TabIndex = 28;
            this.btn_NRU.Text = "NRU";
            this.btn_NRU.UseVisualStyleBackColor = false;
            this.btn_NRU.Click += new System.EventHandler(this.btn_NRU_Click);
            // 
            // btn_Optimo
            // 
            this.btn_Optimo.AutoSize = true;
            this.btn_Optimo.BackColor = System.Drawing.Color.White;
            this.btn_Optimo.CausesValidation = false;
            this.btn_Optimo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Optimo.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_Optimo.FlatAppearance.BorderSize = 1000;
            this.btn_Optimo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Optimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.btn_Optimo.Location = new System.Drawing.Point(137, 209);
            this.btn_Optimo.Name = "btn_Optimo";
            this.btn_Optimo.Size = new System.Drawing.Size(140, 50);
            this.btn_Optimo.TabIndex = 27;
            this.btn_Optimo.Text = "Optimo";
            this.btn_Optimo.UseVisualStyleBackColor = false;
            this.btn_Optimo.Click += new System.EventHandler(this.btn_Optimo_Click);
            // 
            // btnFIFO
            // 
            this.btnFIFO.AutoSize = true;
            this.btnFIFO.BackColor = System.Drawing.Color.White;
            this.btnFIFO.CausesValidation = false;
            this.btnFIFO.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFIFO.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnFIFO.FlatAppearance.BorderSize = 1000;
            this.btnFIFO.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnFIFO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.btnFIFO.Location = new System.Drawing.Point(137, 139);
            this.btnFIFO.Name = "btnFIFO";
            this.btnFIFO.Size = new System.Drawing.Size(140, 50);
            this.btnFIFO.TabIndex = 26;
            this.btnFIFO.Text = "FIFO";
            this.btnFIFO.UseVisualStyleBackColor = false;
            this.btnFIFO.Click += new System.EventHandler(this.btnFIFO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 39);
            this.label1.TabIndex = 31;
            this.label1.Text = "Paginacion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Referenciass
            // 
            this.btn_Referenciass.AutoSize = true;
            this.btn_Referenciass.BackColor = System.Drawing.Color.White;
            this.btn_Referenciass.CausesValidation = false;
            this.btn_Referenciass.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Referenciass.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_Referenciass.FlatAppearance.BorderSize = 1000;
            this.btn_Referenciass.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Referenciass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.btn_Referenciass.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_Referenciass.Location = new System.Drawing.Point(0, 930);
            this.btn_Referenciass.Name = "btn_Referenciass";
            this.btn_Referenciass.Size = new System.Drawing.Size(140, 58);
            this.btn_Referenciass.TabIndex = 32;
            this.btn_Referenciass.Text = "Generar  Referencia";
            this.btn_Referenciass.UseVisualStyleBackColor = false;
            this.btn_Referenciass.Click += new System.EventHandler(this.btn_Referenciass_Click);
            // 
            // txtMarcos
            // 
            this.txtMarcos.Location = new System.Drawing.Point(210, 829);
            this.txtMarcos.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarcos.Name = "txtMarcos";
            this.txtMarcos.Size = new System.Drawing.Size(132, 22);
            this.txtMarcos.TabIndex = 34;
            this.txtMarcos.Text = "4";
            this.txtMarcos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(237, 789);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 24);
            this.label11.TabIndex = 33;
            this.label11.Text = "Marcos";
            // 
            // txtQuantum
            // 
            this.txtQuantum.Location = new System.Drawing.Point(30, 829);
            this.txtQuantum.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(132, 22);
            this.txtQuantum.TabIndex = 35;
            this.txtQuantum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 789);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 30);
            this.label4.TabIndex = 36;
            this.label4.Text = "Quantum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(2027, 1036);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEntrada);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button alg_prioridad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porMemoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button algCPU;
        private System.Windows.Forms.Button btn_RR;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button ProcesoCorto;
        private System.Windows.Forms.Button btnGarantizada;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMultiplesColas;
        private System.Windows.Forms.Button btnPrioridadIR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Reloj;
        private System.Windows.Forms.Button btn_IIOportunidad;
        private System.Windows.Forms.Button btn_NRU;
        private System.Windows.Forms.Button btn_Optimo;
        private System.Windows.Forms.Button btnFIFO;
        private System.Windows.Forms.Button btn_Referenciass;
        private System.Windows.Forms.TextBox txtMarcos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantum;
    }
}

