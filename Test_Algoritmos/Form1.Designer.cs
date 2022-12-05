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
            System.Windows.Forms.Label label1;
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
            this.txtQuantum = new System.Windows.Forms.TextBox();
            this.pnlPriority = new System.Windows.Forms.Panel();
            this.btn_prioridad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPrioridadResult = new System.Windows.Forms.DataGridView();
            this.dgvEntrada = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProcesoCorto = new System.Windows.Forms.Button();
            this.btnGarantizada = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMultiplesColas = new System.Windows.Forms.Button();
            this.btnPrioridadIR = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlPriority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrioridadResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(16, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 27);
            label1.TabIndex = 12;
            label1.Text = "Quantum";
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
            // txtQuantum
            // 
            this.txtQuantum.Location = new System.Drawing.Point(129, 51);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(64, 22);
            this.txtQuantum.TabIndex = 9;
            // 
            // pnlPriority
            // 
            this.pnlPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(115)))));
            this.pnlPriority.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPriority.Controls.Add(this.btn_prioridad);
            this.pnlPriority.Controls.Add(this.label4);
            this.pnlPriority.Controls.Add(label1);
            this.pnlPriority.Controls.Add(this.dgvPrioridadResult);
            this.pnlPriority.Controls.Add(this.txtQuantum);
            this.pnlPriority.Location = new System.Drawing.Point(368, 407);
            this.pnlPriority.Name = "pnlPriority";
            this.pnlPriority.Size = new System.Drawing.Size(972, 443);
            this.pnlPriority.TabIndex = 10;
            this.pnlPriority.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPriority_Paint);
            // 
            // btn_prioridad
            // 
            this.btn_prioridad.AutoSize = true;
            this.btn_prioridad.BackColor = System.Drawing.Color.White;
            this.btn_prioridad.CausesValidation = false;
            this.btn_prioridad.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_prioridad.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_prioridad.FlatAppearance.BorderSize = 1000;
            this.btn_prioridad.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_prioridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.btn_prioridad.Location = new System.Drawing.Point(842, 18);
            this.btn_prioridad.Name = "btn_prioridad";
            this.btn_prioridad.Size = new System.Drawing.Size(118, 50);
            this.btn_prioridad.TabIndex = 22;
            this.btn_prioridad.Text = "Ejecutar";
            this.btn_prioridad.UseVisualStyleBackColor = false;
            this.btn_prioridad.Click += new System.EventHandler(this.btn_prioridad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(320, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 31);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tabla Resultado Prioridad";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPrioridadResult
            // 
            this.dgvPrioridadResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrioridadResult.Location = new System.Drawing.Point(111, 76);
            this.dgvPrioridadResult.Name = "dgvPrioridadResult";
            this.dgvPrioridadResult.RowHeadersWidth = 51;
            this.dgvPrioridadResult.RowTemplate.Height = 24;
            this.dgvPrioridadResult.Size = new System.Drawing.Size(807, 353);
            this.dgvPrioridadResult.TabIndex = 11;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(2027, 1036);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEntrada);
            this.Controls.Add(this.pnlPriority);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlPriority.ResumeLayout(false);
            this.pnlPriority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrioridadResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.TextBox txtQuantum;
        private System.Windows.Forms.Panel pnlPriority;
        private System.Windows.Forms.DataGridView dgvPrioridadResult;
        private System.Windows.Forms.DataGridView dgvEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_prioridad;
        private System.Windows.Forms.Button algCPU;
        private System.Windows.Forms.Button btn_RR;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button ProcesoCorto;
        private System.Windows.Forms.Button btnGarantizada;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMultiplesColas;
        private System.Windows.Forms.Button btnPrioridadIR;
    }
}

