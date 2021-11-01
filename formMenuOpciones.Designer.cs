
namespace OrtesisSearcher
{
    partial class formMenuOpciones
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
            this.btnIngresoEgreso = new System.Windows.Forms.Button();
            this.btnHistoricoOpcion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresoEgreso
            // 
            this.btnIngresoEgreso.Location = new System.Drawing.Point(18, 12);
            this.btnIngresoEgreso.Name = "btnIngresoEgreso";
            this.btnIngresoEgreso.Size = new System.Drawing.Size(309, 104);
            this.btnIngresoEgreso.TabIndex = 4;
            this.btnIngresoEgreso.Text = "Ingreso/Egreso";
            this.btnIngresoEgreso.UseVisualStyleBackColor = true;
            this.btnIngresoEgreso.Click += new System.EventHandler(this.btnIngresoEgreso_Click);
            // 
            // btnHistoricoOpcion
            // 
            this.btnHistoricoOpcion.Location = new System.Drawing.Point(347, 12);
            this.btnHistoricoOpcion.Name = "btnHistoricoOpcion";
            this.btnHistoricoOpcion.Size = new System.Drawing.Size(309, 104);
            this.btnHistoricoOpcion.TabIndex = 5;
            this.btnHistoricoOpcion.Text = "Histórico";
            this.btnHistoricoOpcion.UseVisualStyleBackColor = true;
            this.btnHistoricoOpcion.Click += new System.EventHandler(this.btnHistoricoOpcion_Click);
            // 
            // formMenuOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 138);
            this.Controls.Add(this.btnHistoricoOpcion);
            this.Controls.Add(this.btnIngresoEgreso);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMenuOpciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione opción";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresoEgreso;
        private System.Windows.Forms.Button btnHistoricoOpcion;
    }
}