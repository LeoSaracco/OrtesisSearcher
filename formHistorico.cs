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
    public partial class formHistorico : Form
    {
        Clases.claseConexion cc = new Clases.claseConexion();
        DataTable dt;
        public formHistorico()
        {
            InitializeComponent();
            cc.abrirConexion();
            dt = cc.LeerBD("SELECT * FROM vGetElementos");
            dgvHistoricoElementos.DataSource = dt;
            cc.cerrarConexion();
            dgvHistoricoElementos.Columns[0].Visible = false;
        }

        private void dgvHistoricoElementos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.cElemento.idElemento = dgvHistoricoElementos.CurrentRow.Cells[0].Value.ToString();
            formDetalleHistorico FDH = new formDetalleHistorico();
            FDH.ShowDialog();
        }
    }
}
