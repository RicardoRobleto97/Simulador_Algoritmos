namespace Test_Algoritmos
{
    partial class MasCorto_Form
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
            this.pnlProcesoMasCorto = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvProcCorto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProcesoMasCorto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcCorto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProcesoMasCorto
            // 
            this.pnlProcesoMasCorto.Controls.Add(this.label1);
            this.pnlProcesoMasCorto.Controls.Add(this.button1);
            this.pnlProcesoMasCorto.Controls.Add(this.dgvProcCorto);
            this.pnlProcesoMasCorto.Location = new System.Drawing.Point(49, 33);
            this.pnlProcesoMasCorto.Name = "pnlProcesoMasCorto";
            this.pnlProcesoMasCorto.Size = new System.Drawing.Size(889, 566);
            this.pnlProcesoMasCorto.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.CausesValidation = false;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.button1.FlatAppearance.BorderSize = 1000;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(135)))), ((int)(((byte)(80)))));
            this.button1.Location = new System.Drawing.Point(736, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 50);
            this.button1.TabIndex = 23;
            this.button1.Text = "Ejecutar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvProcCorto
            // 
            this.dgvProcCorto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcCorto.Location = new System.Drawing.Point(52, 71);
            this.dgvProcCorto.Name = "dgvProcCorto";
            this.dgvProcCorto.RowHeadersWidth = 51;
            this.dgvProcCorto.RowTemplate.Height = 24;
            this.dgvProcCorto.Size = new System.Drawing.Size(802, 464);
            this.dgvProcCorto.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "*Tiempo de Llegada es Tiempo Global en esta tabla";
            // 
            // MasCorto_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 647);
            this.Controls.Add(this.pnlProcesoMasCorto);
            this.Name = "MasCorto_Form";
            this.Text = "MasCorto_Form";
            this.Load += new System.EventHandler(this.MasCorto_Form_Load);
            this.pnlProcesoMasCorto.ResumeLayout(false);
            this.pnlProcesoMasCorto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcCorto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProcesoMasCorto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvProcCorto;
        private System.Windows.Forms.Label label1;
    }
}