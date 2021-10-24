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
    public partial class formModificarElementos : Form
    {
        public formModificarElementos()
        {
            InitializeComponent();
            txtDesc.Text = Clases.cElemento.descripcionElemento;
            txtTamano.Text = Clases.cElemento.tamanoElemento;
            txtDonante.Text = Clases.cElemento.donanteElemento;
            txtEquipo.Text = Clases.cElemento.equipoElemento;
            rchObservaciones.Text = Clases.cElemento.observacionesElemento.ToString();
        }

        private void bntModificarElementos_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE elementos SET descripcionElemento='" + txtDesc.Text.Trim().ToUpper() + "', tamanoElemento='" + txtTamano.Text.Trim().ToUpper() + "', donanteElemento='" + txtDonante.Text.Trim().ToUpper() + "', equipoElemento='" + txtEquipo.Text.Trim().ToUpper() + "', observacionesElemento='" + rchObservaciones.Text.Trim().ToUpper() + "' WHERE idElemento=" + Clases.cElemento.idElemento;
            Clases.claseConexion cc = new Clases.claseConexion();
            cc.abrirConexion();
            cc.Ejecutar(sql);
            cc.cerrarConexion();
            this.Close();
        }
    }
}
