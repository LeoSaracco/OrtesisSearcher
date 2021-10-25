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
    public partial class formBuscadorElementos : Form
    {
        Clases.claseConexion cc = new Clases.claseConexion();
        DataTable dt;
        public formBuscadorElementos()
        {
            InitializeComponent();
            cc.abrirConexion();
            dt = cc.LeerBD("SELECT * FROM vGetElementos");
            dgvBuscarElementos.DataSource = dt;
            cc.cerrarConexion();
            dgvBuscarElementos.Columns[0].Visible = false;
        }

        private void txtBuscarProductos_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = "Descripcion LIKE '%" + txtBuscarProductos.Text + "%'";
        }
    }
}