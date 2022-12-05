namespace Test_Algoritmos
{
    partial class RR_Form
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
            this.pnlRR = new System.Windows.Forms.Panel();
            this.bntRR = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvRR = new System.Windows.Forms.DataGridView();
            this.txtQuantum = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            this.pnlRR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRR)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRR
            // 
            this.pnlRR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(115)))));
            this.pnlRR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRR.Controls.Add(this.bntRR);
            this.pnlRR.Controls.Add(this.label5);
            this.pnlRR.Controls.Add(label6);
            this.pnlRR.Controls.Add(this.dgvRR);
            this.pnlRR.Controls.Add(this.txtQuantum);
            this.pnlRR.Location = new System.Drawing.Point(24, 39);
            this.pnlRR.Name = "pnlRR";
            this.pnlRR.Size = new System.Drawing.Size(983, 524);
            this.pnlRR.TabIndex = 25;
            // 
            // bntRR
            // 
            this.bntRR.AutoSize = true;
            this.bntRR.BackColor = System.Drawing.Color.White;
            this.bntRR.CausesValidation = false;
            this.bntRR.Cursor = System.Windows.Forms.Cursors.Default;
            this.bntRR.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.bntRR.FlatAppearance.BorderSize = 1000;
            this.bntRR.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.bntRR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.bntRR.Location = new System.Drawing.Point(836, 13);
            this.bntRR.Name = "bntRR";
            this.bntRR.Size = new System.Drawing.Size(118, 50);
            this.bntRR.TabIndex = 22;
            this.bntRR.Text = "Ejecutar";
            this.bntRR.UseVisualStyleBackColor = false;
            this.bntRR.Click += new System.EventHandler(this.bntRR_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(344, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 78);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tabla Resultado Round Robin\r\n\r\n";
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
            // dgvRR
            // 
            this.dgvRR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRR.Location = new System.Drawing.Point(111, 136);
            this.dgvRR.Name = "dgvRR";
            this.dgvRR.RowHeadersWidth = 51;
            this.dgvRR.RowTemplate.Height = 24;
            this.dgvRR.Size = new System.Drawing.Size(735, 256);
            this.dgvRR.TabIndex = 11;
            // 
            // txtQuantum
            // 
            this.txtQuantum.Location = new System.Drawing.Point(129, 51);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(64, 22);
            this.txtQuantum.TabIndex = 9;
            // 
            // RR_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 587);
            this.Controls.Add(this.pnlRR);
            this.Name = "RR_Form";
            this.Text = "RR_Form";
            this.Load += new System.EventHandler(this.RR_Form_Load);
            this.pnlRR.ResumeLayout(false);
            this.pnlRR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRR;
        private System.Windows.Forms.Button bntRR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvRR;
        private System.Windows.Forms.TextBox txtQuantum;
    }
}