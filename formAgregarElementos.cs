using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrtesisSearcher
{
    public partial class formAgregarElementos : Form
    {
        Clases.claseConexion cc = new Clases.claseConexion();
        public formAgregarElementos()
        {
            InitializeComponent();
        }

        private void bntGuardarElementos_Click(object sender, EventArgs e)
        {
            cc.abrirConexion();
            string str = "INSERT INTO elementos(descripcionElemento,tamanoElemento, donanteElemento, equipoElemento, observacionesElemento)";
            str += "VALUES ('" + txtDesc.Text.Trim().ToUpper() + "','" + txtTamano.Text.Trim().ToUpper() + "','" + txtDonante.Text.Trim().ToUpper() + "','" + txtEquipo.Text.Trim().ToUpper() + "','" + rchObservaciones.Text.Trim().ToUpper() + "')";
            cc.Ejecutar(str);
            cc.cerrarConexion();
            this.Close();
        }
    }
}
