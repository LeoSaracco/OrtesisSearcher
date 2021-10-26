
namespace OrtesisSearcher
{
    partial class formHistorico
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
            this.gbElementos = new System.Windows.Forms.GroupBox();
            this.dgvHistoricoElementos = new System.Windows.Forms.DataGridView();
            this.gbElementos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoElementos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbElementos
            // 
            this.gbElementos.Controls.Add(this.dgvHistoricoElementos);
            this.gbElementos.Location = new System.Drawing.Point(12, 12);
            this.gbElementos.Name = "gbElementos";
            this.gbElementos.Size = new System.Drawing.Size(695, 380);
            this.gbElementos.TabIndex = 1;
            this.gbElementos.TabStop = false;
            this.gbElementos.Text = "Elementos";
            // 
            // dgvHistoricoElementos
            // 
            this.dgvHistoricoElementos.AllowUserToAddRows = false;
            this.dgvHistoricoElementos.AllowUserToDeleteRows = false;
            this.dgvHistoricoElementos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistoricoElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoricoElementos.Location = new System.Drawing.Point(12, 19);
            this.dgvHistoricoElementos.Name = "dgvHistoricoElementos";
            this.dgvHistoricoElementos.ReadOnly = true;
            this.dgvHistoricoElementos.RowHeadersVisible = false;
            this.dgvHistoricoElementos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvHistoricoElementos.RowTemplate.Height = 25;
            this.dgvHistoricoElementos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoricoElementos.Size = new System.Drawing.Size(677, 355);
            this.dgvHistoricoElementos.TabIndex = 0;
            this.dgvHistoricoElementos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistoricoElementos_CellDoubleClick);
            // 
            // formHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 399);
            this.Controls.Add(this.gbElementos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico";
            this.gbElementos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoElementos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbElementos;
        private System.Windows.Forms.DataGridView dgvHistoricoElementos;
    }
}