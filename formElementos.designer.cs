
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bntAgregarElemento = new System.Windows.Forms.Button();
            this.gbElementos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbElementos
            // 
            this.gbElementos.Controls.Add(this.dataGridView1);
            this.gbElementos.Location = new System.Drawing.Point(12, 65);
            this.gbElementos.Name = "gbElementos";
            this.gbElementos.Size = new System.Drawing.Size(802, 438);
            this.gbElementos.TabIndex = 0;
            this.gbElementos.TabStop = false;
            this.gbElementos.Text = "Elementos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(779, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // bntAgregarElemento
            // 
            this.bntAgregarElemento.Location = new System.Drawing.Point(26, 12);
            this.bntAgregarElemento.Name = "bntAgregarElemento";
            this.bntAgregarElemento.Size = new System.Drawing.Size(130, 47);
            this.bntAgregarElemento.TabIndex = 1;
            this.bntAgregarElemento.Text = "Agregar";
            this.bntAgregarElemento.UseVisualStyleBackColor = true;
            this.bntAgregarElemento.Click += new System.EventHandler(this.bntAgregarElemento_Click);
            // 
            // formElementos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 515);
            this.Controls.Add(this.bntAgregarElemento);
            this.Controls.Add(this.gbElementos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formElementos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elementos";
            this.gbElementos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbElementos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bntAgregarElemento;
    }
}