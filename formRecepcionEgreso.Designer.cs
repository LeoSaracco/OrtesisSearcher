
namespace OrtesisSearcher
{
    partial class formRecepcionEgreso
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPageEgreso = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEgreso = new System.Windows.Forms.Button();
            this.rchObservaciones = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtLugarEntrega = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEstadoEgreso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tbPageRecepcion = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLugarRecepcion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDevolucionIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnDevolverElemento = new System.Windows.Forms.Button();
            this.rchObservacionesIngreso = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEstadoIngreso = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbPageEgreso.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbPageRecepcion.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPageEgreso);
            this.tabControl1.Controls.Add(this.tbPageRecepcion);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 510);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPageEgreso
            // 
            this.tbPageEgreso.Controls.Add(this.groupBox2);
            this.tbPageEgreso.Controls.Add(this.groupBox1);
            this.tbPageEgreso.Location = new System.Drawing.Point(4, 22);
            this.tbPageEgreso.Name = "tbPageEgreso";
            this.tbPageEgreso.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageEgreso.Size = new System.Drawing.Size(589, 484);
            this.tbPageEgreso.TabIndex = 0;
            this.tbPageEgreso.Text = "Egreso";
            this.tbPageEgreso.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnEgreso);
            this.groupBox2.Controls.Add(this.rchObservaciones);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpDevolucion);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpEntrega);
            this.groupBox2.Controls.Add(this.txtLugarEntrega);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbEstadoEgreso);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 311);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del elemento";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(9, 272);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(559, 33);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar datos";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEgreso
            // 
            this.btnEgreso.Location = new System.Drawing.Point(9, 272);
            this.btnEgreso.Name = "btnEgreso";
            this.btnEgreso.Size = new System.Drawing.Size(559, 33);
            this.btnEgreso.TabIndex = 12;
            this.btnEgreso.Text = "Dar salida";
            this.btnEgreso.UseVisualStyleBackColor = true;
            this.btnEgreso.Click += new System.EventHandler(this.btnEgreso_Click);
            // 
            // rchObservaciones
            // 
            this.rchObservaciones.Location = new System.Drawing.Point(100, 158);
            this.rchObservaciones.Name = "rchObservaciones";
            this.rchObservaciones.Size = new System.Drawing.Size(468, 98);
            this.rchObservaciones.TabIndex = 11;
            this.rchObservaciones.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Observaciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Devolución";
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucion.Location = new System.Drawing.Point(99, 85);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(133, 20);
            this.dtpDevolucion.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Entrega";
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrega.Location = new System.Drawing.Point(99, 52);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(133, 20);
            this.dtpEntrega.TabIndex = 8;
            // 
            // txtLugarEntrega
            // 
            this.txtLugarEntrega.Location = new System.Drawing.Point(100, 120);
            this.txtLugarEntrega.Name = "txtLugarEntrega";
            this.txtLugarEntrega.Size = new System.Drawing.Size(305, 20);
            this.txtLugarEntrega.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lugar de entrega";
            // 
            // cmbEstadoEgreso
            // 
            this.cmbEstadoEgreso.FormattingEnabled = true;
            this.cmbEstadoEgreso.Items.AddRange(new object[] {
            "Bueno",
            "Regular",
            "Malo"});
            this.cmbEstadoEgreso.Location = new System.Drawing.Point(99, 19);
            this.cmbEstadoEgreso.Name = "cmbEstadoEgreso";
            this.cmbEstadoEgreso.Size = new System.Drawing.Size(133, 21);
            this.cmbEstadoEgreso.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Estado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtDomicilio);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtCel);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 118);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la persona";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(33, 70);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(125, 20);
            this.txtTel.TabIndex = 4;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(402, 70);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(172, 20);
            this.txtDomicilio.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Tel.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(347, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Domicilio";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(182, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Cel.";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(213, 70);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(125, 20);
            this.txtCel.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(33, 29);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(125, 20);
            this.txtDni.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(402, 29);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(125, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(213, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // tbPageRecepcion
            // 
            this.tbPageRecepcion.Controls.Add(this.groupBox3);
            this.tbPageRecepcion.Location = new System.Drawing.Point(4, 22);
            this.tbPageRecepcion.Name = "tbPageRecepcion";
            this.tbPageRecepcion.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageRecepcion.Size = new System.Drawing.Size(589, 484);
            this.tbPageRecepcion.TabIndex = 1;
            this.tbPageRecepcion.Text = "Recepción";
            this.tbPageRecepcion.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLugarRecepcion);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dtpDevolucionIngreso);
            this.groupBox3.Controls.Add(this.btnDevolverElemento);
            this.groupBox3.Controls.Add(this.rchObservacionesIngreso);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmbEstadoIngreso);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(15, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(536, 300);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del elemento";
            // 
            // txtLugarRecepcion
            // 
            this.txtLugarRecepcion.Location = new System.Drawing.Point(110, 95);
            this.txtLugarRecepcion.Name = "txtLugarRecepcion";
            this.txtLugarRecepcion.Size = new System.Drawing.Size(305, 20);
            this.txtLugarRecepcion.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Lugar de recepción";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Devolución";
            // 
            // dtpDevolucionIngreso
            // 
            this.dtpDevolucionIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucionIngreso.Location = new System.Drawing.Point(110, 60);
            this.dtpDevolucionIngreso.Name = "dtpDevolucionIngreso";
            this.dtpDevolucionIngreso.Size = new System.Drawing.Size(122, 20);
            this.dtpDevolucionIngreso.TabIndex = 2;
            // 
            // btnDevolverElemento
            // 
            this.btnDevolverElemento.Location = new System.Drawing.Point(12, 259);
            this.btnDevolverElemento.Name = "btnDevolverElemento";
            this.btnDevolverElemento.Size = new System.Drawing.Size(518, 33);
            this.btnDevolverElemento.TabIndex = 5;
            this.btnDevolverElemento.Text = "Recepcionar elemento";
            this.btnDevolverElemento.UseVisualStyleBackColor = true;
            this.btnDevolverElemento.Click += new System.EventHandler(this.btnDevolverElemento_Click);
            // 
            // rchObservacionesIngreso
            // 
            this.rchObservacionesIngreso.Location = new System.Drawing.Point(110, 134);
            this.rchObservacionesIngreso.Name = "rchObservacionesIngreso";
            this.rchObservacionesIngreso.Size = new System.Drawing.Size(420, 119);
            this.rchObservacionesIngreso.TabIndex = 4;
            this.rchObservacionesIngreso.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Observaciones";
            // 
            // cmbEstadoIngreso
            // 
            this.cmbEstadoIngreso.FormattingEnabled = true;
            this.cmbEstadoIngreso.Items.AddRange(new object[] {
            "Bueno",
            "Regular",
            "Malo"});
            this.cmbEstadoIngreso.Location = new System.Drawing.Point(110, 19);
            this.cmbEstadoIngreso.Name = "cmbEstadoIngreso";
            this.cmbEstadoIngreso.Size = new System.Drawing.Size(122, 21);
            this.cmbEstadoIngreso.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Estado";
            // 
            // formRecepcionEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 526);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formRecepcionEgreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepción - Egreso";
            this.tabControl1.ResumeLayout(false);
            this.tbPageEgreso.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbPageRecepcion.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPageEgreso;
        private System.Windows.Forms.TabPage tbPageRecepcion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.TextBox txtLugarEntrega;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEstadoEgreso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RichTextBox rchObservaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEgreso;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDevolverElemento;
        private System.Windows.Forms.RichTextBox rchObservacionesIngreso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEstadoIngreso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDevolucionIngreso;
        private System.Windows.Forms.TextBox txtLugarRecepcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCel;
    }
}