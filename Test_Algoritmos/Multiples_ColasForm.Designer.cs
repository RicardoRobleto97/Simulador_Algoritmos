namespace Test_Algoritmos
{
    partial class Multiples_ColasForm
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
            this.btn_MultiColass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMultiColasResult = new System.Windows.Forms.DataGridView();
            this.txtQuantum = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            this.pnlPriority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultiColasResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPriority
            // 
            this.pnlPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(115)))));
            this.pnlPriority.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPriority.Controls.Add(this.btn_MultiColass);
            this.pnlPriority.Controls.Add(this.label4);
            this.pnlPriority.Controls.Add(label1);
            this.pnlPriority.Controls.Add(this.dgvMultiColasResult);
            this.pnlPriority.Controls.Add(this.txtQuantum);
            this.pnlPriority.Location = new System.Drawing.Point(12, 12);
            this.pnlPriority.Name = "pnlPriority";
            this.pnlPriority.Size = new System.Drawing.Size(972, 443);
            this.pnlPriority.TabIndex = 11;
            // 
            // btn_MultiColass
            // 
            this.btn_MultiColass.AutoSize = true;
            this.btn_MultiColass.BackColor = System.Drawing.Color.White;
            this.btn_MultiColass.CausesValidation = false;
            this.btn_MultiColass.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_MultiColass.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_MultiColass.FlatAppearance.BorderSize = 1000;
            this.btn_MultiColass.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_MultiColass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.btn_MultiColass.Location = new System.Drawing.Point(842, 18);
            this.btn_MultiColass.Name = "btn_MultiColass";
            this.btn_MultiColass.Size = new System.Drawing.Size(118, 50);
            this.btn_MultiColass.TabIndex = 22;
            this.btn_MultiColass.Text = "Ejecutar";
            this.btn_MultiColass.UseVisualStyleBackColor = false;
            this.btn_MultiColass.Click += new System.EventHandler(this.btn_MultiColass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(282, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 31);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tabla Resultado Multiples Colas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(16, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 27);
            label1.TabIndex = 12;
            label1.Text = "Quantum";
            // 
            // dgvMultiColasResult
            // 
            this.dgvMultiColasResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMultiColasResult.Location = new System.Drawing.Point(111, 76);
            this.dgvMultiColasResult.Name = "dgvMultiColasResult";
            this.dgvMultiColasResult.RowHeadersWidth = 51;
            this.dgvMultiColasResult.RowTemplate.Height = 24;
            this.dgvMultiColasResult.Size = new System.Drawing.Size(807, 353);
            this.dgvMultiColasResult.TabIndex = 11;
            // 
            // txtQuantum
            // 
            this.txtQuantum.Location = new System.Drawing.Point(129, 33);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(64, 22);
            this.txtQuantum.TabIndex = 9;
            // 
            // Multiples_ColasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 477);
            this.Controls.Add(this.pnlPriority);
            this.Name = "Multiples_ColasForm";
            this.Text = "Multiples_ColasForm";
            this.Load += new System.EventHandler(this.Multiples_ColasForm_Load);
            this.pnlPriority.ResumeLayout(false);
            this.pnlPriority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultiColasResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPriority;
        private System.Windows.Forms.Button btn_MultiColass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMultiColasResult;
        private System.Windows.Forms.TextBox txtQuantum;
    }
}