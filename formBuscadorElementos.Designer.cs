
namespace OrtesisSearcher
{
    partial class formBuscadorElementos
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
            this.gbBuscadorElemento = new System.Windows.Forms.GroupBox();
            this.dgvBuscarElementos = new System.Windows.Forms.DataGridView();
            this.gbBuscadorInput = new System.Windows.Forms.GroupBox();
            this.txtBuscarProductos = new System.Windows.Forms.TextBox();
            this.gbBuscadorElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarElementos)).BeginInit();
            this.gbBuscadorInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBuscadorElemento
            // 
            this.gbBuscadorElemento.Controls.Add(this.dgvBuscarElementos);
            this.gbBuscadorElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscadorElemento.Location = new System.Drawing.Point(3, 56);
            this.gbBuscadorElemento.Name = "gbBuscadorElemento";
            this.gbBuscadorElemento.Size = new System.Drawing.Size(704, 382);
            this.gbBuscadorElemento.TabIndex = 46;
            this.gbBuscadorElemento.TabStop = false;
            this.gbBuscadorElemento.Text = "Elementos";
            // 
            // dgvBuscarElementos
            // 
            this.dgvBuscarElementos.AllowUserToAddRows = false;
            this.dgvBuscarElementos.AllowUserToDeleteRows = false;
            this.dgvBuscarElementos.AllowUserToResizeRows = false;
            this.dgvBuscarElementos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuscarElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarElementos.Location = new System.Drawing.Point(6, 20);
            this.dgvBuscarElementos.MultiSelect = false;
            this.dgvBuscarElementos.Name = "dgvBuscarElementos";
            this.dgvBuscarElementos.ReadOnly = true;
            this.dgvBuscarElementos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvBuscarElementos.RowHeadersVisible = false;
            this.dgvBuscarElementos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarElementos.Size = new System.Drawing.Size(692, 356);
            this.dgvBuscarElementos.TabIndex = 3;
            // 
            // gbBuscadorInput
            // 
            this.gbBuscadorInput.Controls.Add(this.txtBuscarProductos);
            this.gbBuscadorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscadorInput.Location = new System.Drawing.Point(3, 1);
            this.gbBuscadorInput.Name = "gbBuscadorInput";
            this.gbBuscadorInput.Size = new System.Drawing.Size(297, 51);
            this.gbBuscadorInput.TabIndex = 45;
            this.gbBuscadorInput.TabStop = false;
            this.gbBuscadorInput.Text = "Ingrese datos";
            // 
            // txtBuscarProductos
            // 
            this.txtBuscarProductos.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBuscarProductos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarProductos.ForeColor = System.Drawing.SystemColors.Info;
            this.txtBuscarProductos.Location = new System.Drawing.Point(6, 20);
            this.txtBuscarProductos.Name = "txtBuscarProductos";
            this.txtBuscarProductos.Size = new System.Drawing.Size(263, 24);
            this.txtBuscarProductos.TabIndex = 0;
            this.txtBuscarProductos.TextChanged += new System.EventHandler(this.txtBuscarProductos_TextChanged);
            // 
            // formBuscadorElementos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.gbBuscadorInput);
            this.Controls.Add(this.gbBuscadorElemento);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formBuscadorElementos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador";
            this.gbBuscadorElemento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarElementos)).EndInit();
            this.gbBuscadorInput.ResumeLayout(false);
            this.gbBuscadorInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscadorElemento;
        private System.Windows.Forms.DataGridView dgvBuscarElementos;
        private System.Windows.Forms.GroupBox gbBuscadorInput;
        private System.Windows.Forms.TextBox txtBuscarProductos;
    }
}