namespace Test_Algoritmos
{
    partial class CPU_Form
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
            System.Windows.Forms.Label label6;
            this.pnlCPU = new System.Windows.Forms.Panel();
            this.bntCPU = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCPU = new System.Windows.Forms.DataGridView();
            this.txtQuantumCPU = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            this.pnlCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCPU
            // 
            this.pnlCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(115)))));
            this.pnlCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCPU.Controls.Add(this.bntCPU);
            this.pnlCPU.Controls.Add(this.label5);
            this.pnlCPU.Controls.Add(label6);
            this.pnlCPU.Controls.Add(this.dgvCPU);
            this.pnlCPU.Controls.Add(this.txtQuantumCPU);
            this.pnlCPU.Location = new System.Drawing.Point(33, 66);
            this.pnlCPU.Name = "pnlCPU";
            this.pnlCPU.Size = new System.Drawing.Size(1014, 470);
            this.pnlCPU.TabIndex = 25;
            // 
            // bntCPU
            // 
            this.bntCPU.AutoSize = true;
            this.bntCPU.BackColor = System.Drawing.Color.White;
            this.bntCPU.CausesValidation = false;
            this.bntCPU.Cursor = System.Windows.Forms.Cursors.Default;
            this.bntCPU.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.bntCPU.FlatAppearance.BorderSize = 1000;
            this.bntCPU.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.bntCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.bntCPU.Location = new System.Drawing.Point(836, 13);
            this.bntCPU.Name = "bntCPU";
            this.bntCPU.Size = new System.Drawing.Size(118, 50);
            this.bntCPU.TabIndex = 22;
            this.bntCPU.Text = "Ejecutar";
            this.bntCPU.UseVisualStyleBackColor = false;
            this.bntCPU.Click += new System.EventHandler(this.bntCPU_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(344, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 31);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tabla Resultado CPU";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(16, 46);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(107, 27);
            label6.TabIndex = 12;
            label6.Text = "Quantum";
            // 
            // dgvCPU
            // 
            this.dgvCPU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCPU.Location = new System.Drawing.Point(111, 136);
            this.dgvCPU.Name = "dgvCPU";
            this.dgvCPU.RowHeadersWidth = 51;
            this.dgvCPU.RowTemplate.Height = 24;
            this.dgvCPU.Size = new System.Drawing.Size(735, 256);
            this.dgvCPU.TabIndex = 11;
            // 
            // txtQuantumCPU
            // 
            this.txtQuantumCPU.Location = new System.Drawing.Point(129, 51);
            this.txtQuantumCPU.Name = "txtQuantumCPU";
            this.txtQuantumCPU.Size = new System.Drawing.Size(64, 22);
            this.txtQuantumCPU.TabIndex = 9;
            // 
            // CPU_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 614);
            this.Controls.Add(this.pnlCPU);
            this.Name = "CPU_Form";
            this.Text = "CPU_Form";
            this.Load += new System.EventHandler(this.CPU_Form_Load);
            this.pnlCPU.ResumeLayout(false);
            this.pnlCPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCPU;
        private System.Windows.Forms.Button bntCPU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCPU;
        private System.Windows.Forms.TextBox txtQuantumCPU;
    }
}