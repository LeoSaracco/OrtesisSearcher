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

        private void dgvBuscarElementos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.cElemento.idElemento = dgvBuscarElementos.CurrentRow.Cells[0].Value.ToString();
            Clases.cElemento.descripcionElemento = dgvBuscarElementos.CurrentRow.Cells[1].Value.ToString();
            Clases.cElemento.tamanoElemento = dgvBuscarElementos.CurrentRow.Cells[2].Value.ToString();
            Clases.cElemento.donanteElemento = dgvBuscarElementos.CurrentRow.Cells[3].Value.ToString();
            Clases.cElemento.equipoElemento = dgvBuscarElementos.CurrentRow.Cells[4].Value.ToString();
            Clases.cElemento.observacionesElemento = dgvBuscarElementos.CurrentRow.Cells[5].Value.ToString();
            formMenuOpciones FMO = new formMenuOpciones();
            FMO.ShowDialog();
            switch (Clases.cMenu.opcionSeleccionada)
            {
                case "1":
                    formRecepcionEgreso FRE = new formRecepcionEgreso();
                    FRE.ShowDialog();
                    break;

                case "2":
                    formDetalleHistorico FDH = new formDetalleHistorico();
                    FDH.ShowDialog();
                    break;
                default:
                    cargarElementos();
                    break;
            }
            
           
            cargarElementos();
        }
        private void cargarElementos()
        {
            cc.abrirConexion();
            dt = cc.LeerBD("SELECT * FROM vGetElementos");
            dgvBuscarElementos.DataSource = dt;
            cc.cerrarConexion();
            dgvBuscarElementos.Columns[0].Visible = false;
        }
    }
}