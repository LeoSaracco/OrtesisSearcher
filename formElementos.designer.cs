
namespace OrtesisSearcher
{
    partial class formElementos
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
            this.dgvElementosCRUD = new System.Windows.Forms.DataGridView();
            this.bntAgregarElemento = new System.Windows.Forms.Button();
            this.btnBorrarElemento = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gbElementos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementosCRUD)).BeginInit();
            this.SuspendLayout();
            // 
            // gbElementos
            // 
            this.gbElementos.Controls.Add(this.dgvElementosCRUD);
            this.gbElementos.Location = new System.Drawing.Point(10, 56);
            this.gbElementos.Name = "gbElementos";
            this.gbElementos.Size = new System.Drawing.Size(687, 380);
            this.gbElementos.TabIndex = 0;
            this.gbElementos.TabStop = false;
            this.gbElementos.Text = "Elementos";
            // 
            // dgvElementosCRUD
            // 
            this.dgvElementosCRUD.AllowUserToAddRows = false;
            this.dgvElementosCRUD.AllowUserToDeleteRows = false;
            this.dgvElementosCRUD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvElementosCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElementosCRUD.Location = new System.Drawing.Point(12, 19);
            this.dgvElementosCRUD.Name = "dgvElementosCRUD";
            this.dgvElementosCRUD.ReadOnly = true;
            this.dgvElementosCRUD.RowHeadersVisible = false;
            this.dgvElementosCRUD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvElementosCRUD.RowTemplate.Height = 25;
            this.dgvElementosCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElementosCRUD.Size = new System.Drawing.Size(668, 355);
            this.dgvElementosCRUD.TabIndex = 0;
            // 
            // bntAgregarElemento
            // 
            this.bntAgregarElemento.Location = new System.Drawing.Point(22, 10);
            this.bntAgregarElemento.Name = "bntAgregarElemento";
            this.bntAgregarElemento.Size = new System.Drawing.Size(111, 41);
            this.bntAgregarElemento.TabIndex = 1;
            this.bntAgregarElemento.Text = "Agregar";
            this.bntAgregarElemento.UseVisualStyleBackColor = true;
            this.bntAgregarElemento.Click += new System.EventHandler(this.bntAgregarElemento_Click);
            // 
            // btnBorrarElemento
            // 
            this.btnBorrarElemento.Location = new System.Drawing.Point(148, 10);
            this.btnBorrarElemento.Name = "btnBorrarElemento";
            this.btnBorrarElemento.Size = new System.Drawing.Size(111, 41);
            this.btnBorrarElemento.TabIndex = 2;
            this.btnBorrarElemento.Text = "Borrar";
            this.btnBorrarElemento.UseVisualStyleBackColor = true;
            this.btnBorrarElemento.Click += new System.EventHandler(this.btnBorrarElemento_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(265, 10);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 41);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // formElementos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 446);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrarElemento);
            this.Controls.Add(this.bntAgregarElemento);
            this.Controls.Add(this.gbElementos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formElementos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elementos";
            this.gbElementos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementosCRUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbElementos;
        private System.Windows.Forms.DataGridView dgvElementosCRUD;
        private System.Windows.Forms.Button bntAgregarElemento;
        private System.Windows.Forms.Button btnBorrarElemento;
        private System.Windows.Forms.Button btnModificar;
    }
}