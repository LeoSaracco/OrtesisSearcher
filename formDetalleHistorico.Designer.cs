
namespace OrtesisSearcher
{
    partial class formDetalleHistorico
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
            this.gbEgresoHistorico = new System.Windows.Forms.GroupBox();
            this.dgvEgresosHistorico = new System.Windows.Forms.DataGridView();
            this.gbIngresoHistorico = new System.Windows.Forms.GroupBox();
            this.dgvIngresoHistoricos = new System.Windows.Forms.DataGridView();
            this.gbEgresoHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresosHistorico)).BeginInit();
            this.gbIngresoHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoHistoricos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEgresoHistorico
            // 
            this.gbEgresoHistorico.Controls.Add(this.dgvEgresosHistorico);
            this.gbEgresoHistorico.Location = new System.Drawing.Point(13, 12);
            this.gbEgresoHistorico.Name = "gbEgresoHistorico";
            this.gbEgresoHistorico.Size = new System.Drawing.Size(1282, 235);
            this.gbEgresoHistorico.TabIndex = 0;
            this.gbEgresoHistorico.TabStop = false;
            this.gbEgresoHistorico.Text = "Egresos";
            // 
            // dgvEgresosHistorico
            // 
            this.dgvEgresosHistorico.AllowUserToAddRows = false;
            this.dgvEgresosHistorico.AllowUserToDeleteRows = false;
            this.dgvEgresosHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEgresosHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEgresosHistorico.Location = new System.Drawing.Point(15, 19);
            this.dgvEgresosHistorico.Name = "dgvEgresosHistorico";
            this.dgvEgresosHistorico.ReadOnly = true;
            this.dgvEgresosHistorico.RowHeadersVisible = false;
            this.dgvEgresosHistorico.Size = new System.Drawing.Size(1261, 210);
            this.dgvEgresosHistorico.TabIndex = 0;
            // 
            // gbIngresoHistorico
            // 
            this.gbIngresoHistorico.Controls.Add(this.dgvIngresoHistoricos);
            this.gbIngresoHistorico.Location = new System.Drawing.Point(13, 253);
            this.gbIngresoHistorico.Name = "gbIngresoHistorico";
            this.gbIngresoHistorico.Size = new System.Drawing.Size(1282, 235);
            this.gbIngresoHistorico.TabIndex = 1;
            this.gbIngresoHistorico.TabStop = false;
            this.gbIngresoHistorico.Text = "Ingresos";
            // 
            // dgvIngresoHistoricos
            // 
            this.dgvIngresoHistoricos.AllowUserToAddRows = false;
            this.dgvIngresoHistoricos.AllowUserToDeleteRows = false;
            this.dgvIngresoHistoricos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngresoHistoricos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresoHistoricos.Location = new System.Drawing.Point(21, 19);
            this.dgvIngresoHistoricos.Name = "dgvIngresoHistoricos";
            this.dgvIngresoHistoricos.ReadOnly = true;
            this.dgvIngresoHistoricos.RowHeadersVisible = false;
            this.dgvIngresoHistoricos.Size = new System.Drawing.Size(1255, 210);
            this.dgvIngresoHistoricos.TabIndex = 1;
            // 
            // formDetalleHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 495);
            this.Controls.Add(this.gbIngresoHistorico);
            this.Controls.Add(this.gbEgresoHistorico);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formDetalleHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle del elemento";
            this.gbEgresoHistorico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresosHistorico)).EndInit();
            this.gbIngresoHistorico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoHistoricos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEgresoHistorico;
        private System.Windows.Forms.DataGridView dgvEgresosHistorico;
        private System.Windows.Forms.GroupBox gbIngresoHistorico;
        private System.Windows.Forms.DataGridView dgvIngresoHistoricos;
    }
}