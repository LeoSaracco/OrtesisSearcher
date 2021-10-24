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
    public partial class formElementos : Form
    {
        Clases.claseConexion cc = new Clases.claseConexion();
        DataTable dt;
        public formElementos()
        {
            InitializeComponent();
            cargarElementos();
        }

        private void cargarElementos()
        {
            cc.abrirConexion();
            dt = cc.LeerBD("SELECT * FROM vGetElementos");
            dgvElementosCRUD.DataSource = dt;
            cc.cerrarConexion();
            dgvElementosCRUD.Columns[0].Visible = false;
        }

        private void bntAgregarElemento_Click(object sender, EventArgs e)
        {
            formAgregarElementos FAE = new formAgregarElementos();
            FAE.ShowDialog();
            cargarElementos();
        }

        private void btnBorrarElemento_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Querés eliminar el elemento " + dgvElementosCRUD.CurrentRow.Cells[1].Value + "?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string sql = "DELETE FROM elementos WHERE idElemento = " + dgvElementosCRUD.CurrentRow.Cells[0].Value;
                cc.abrirConexion();
                cc.Ejecutar(sql);
                cc.cerrarConexion();
                cargarElementos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.cElemento.idElemento = dgvElementosCRUD.CurrentRow.Cells[0].Value.ToString();
            Clases.cElemento.descripcionElemento = dgvElementosCRUD.CurrentRow.Cells[1].Value.ToString();
            Clases.cElemento.tamanoElemento = dgvElementosCRUD.CurrentRow.Cells[2].Value.ToString();
            Clases.cElemento.donanteElemento = dgvElementosCRUD.CurrentRow.Cells[3].Value.ToString();
            Clases.cElemento.equipoElemento = dgvElementosCRUD.CurrentRow.Cells[4].Value.ToString();
            Clases.cElemento.observacionesElemento = dgvElementosCRUD.CurrentRow.Cells[5].Value.ToString();
            formModificarElementos FME = new formModificarElementos();
            FME.ShowDialog();
            cargarElementos();
        }
    }
}