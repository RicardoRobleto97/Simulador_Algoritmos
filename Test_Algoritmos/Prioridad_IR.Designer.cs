namespace Test_Algoritmos
{
    partial class Prioridad_IR
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
            System.Windows.Forms.Label label1;
            this.pnlPriority = new System.Windows.Forms.Panel();
            this.btn_prioridadIR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPrioridadIR_Result = new System.Windows.Forms.DataGridView();
            this.txtQuantum = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            this.pnlPriority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrioridadIR_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPriority
            // 
            this.pnlPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(115)))));
            this.pnlPriority.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPriority.Controls.Add(this.btn_prioridadIR);
            this.pnlPriority.Controls.Add(this.label4);
            this.pnlPriority.Controls.Add(label1);
            this.pnlPriority.Controls.Add(this.dgvPrioridadIR_Result);
            this.pnlPriority.Controls.Add(this.txtQuantum);
            this.pnlPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPriority.Location = new System.Drawing.Point(0, 0);
            this.pnlPriority.Name = "pnlPriority";
            this.pnlPriority.Size = new System.Drawing.Size(1140, 598);
            this.pnlPriority.TabIndex = 12;
            // 
            // btn_prioridadIR
            // 
            this.btn_prioridadIR.AutoSize = true;
            this.btn_prioridadIR.BackColor = System.Drawing.Color.White;
            this.btn_prioridadIR.CausesValidation = false;
            this.btn_prioridadIR.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_prioridadIR.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_prioridadIR.FlatAppearance.BorderSize = 1000;
            this.btn_prioridadIR.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_prioridadIR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.btn_prioridadIR.Location = new System.Drawing.Point(842, 18);
            this.btn_prioridadIR.Name = "btn_prioridadIR";
            this.btn_prioridadIR.Size = new System.Drawing.Size(118, 50);
            this.btn_prioridadIR.TabIndex = 22;
            this.btn_prioridadIR.Text = "Ejecutar";
            this.btn_prioridadIR.UseVisualStyleBackColor = false;
            this.btn_prioridadIR.Click += new System.EventHandler(this.btn_prioridadIR_Click);
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
            // dgvPrioridadIR_Result
            // 
            this.dgvPrioridadIR_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrioridadIR_Result.Location = new System.Drawing.Point(129, 94);
            this.dgvPrioridadIR_Result.Name = "dgvPrioridadIR_Result";
            this.dgvPrioridadIR_Result.RowHeadersWidth = 51;
            this.dgvPrioridadIR_Result.RowTemplate.Height = 24;
            this.dgvPrioridadIR_Result.Size = new System.Drawing.Size(807, 353);
            this.dgvPrioridadIR_Result.TabIndex = 11;
            // 
            // txtQuantum
            // 
            this.txtQuantum.Location = new System.Drawing.Point(129, 51);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(64, 22);
            this.txtQuantum.TabIndex = 9;
            // 
            // Prioridad_IR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 598);
            this.Controls.Add(this.pnlPriority);
            this.Name = "Prioridad_IR";
            this.Text = "Prioridad_IR";
            this.Load += new System.EventHandler(this.Prioridad_IR_Load);
            this.pnlPriority.ResumeLayout(false);
            this.pnlPriority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrioridadIR_Result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPriority;
        private System.Windows.Forms.Button btn_prioridadIR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPrioridadIR_Result;
        private System.Windows.Forms.TextBox txtQuantum;
    }
}