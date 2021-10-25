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
    public partial class formRecepcionEgreso : Form
    {
        Clases.claseConexion cc = new Clases.claseConexion();
        public formRecepcionEgreso()
        {
            InitializeComponent();
            cc.abrirConexion();
            DataTable dt = cc.LeerBD("SELECT * FROM egresos WHERE idElemento=" + Clases.cElemento.idElemento);
            cc.cerrarConexion();
            if (dt.Rows.Count > 0)
            {
                txtDni.Text = dt.Rows[0]["dniEgreso"].ToString();
                string nombre = dt.Rows[0]["nombreApellidoEgreso"].ToString();
                string[] aux = nombre.Split(' ');
                nombre = aux[0];
                string apellido = aux[1];
                txtNombre.Text = nombre;
                txtApellido.Text = apellido;
                txtLugarEntrega.Text = dt.Rows[0]["direccionEntregaEgreso"].ToString();
                rchObservaciones.Text = dt.Rows[0]["observacionesEgreso"].ToString();
                dtpEntrega.Text = dt.Rows[0]["fechaEntregaEgreso"].ToString();
                dtpDevolucion.Text = dt.Rows[0]["fechaDevolucionEgreso"].ToString();
                cmbEstado.Text = dt.Rows[0]["estadoEgreso"].ToString();
                btnModificar.Visible = true;
                btnEgreso.Visible = false;
            }
            else
            {
                btnModificar.Visible = false;
                btnEgreso.Visible = true;
            }
        }

        private void btnEgreso_Click(object sender, EventArgs e)
        {
            cc.abrirConexion();
            string sql = "INSERT INTO egresos(idElemento,dniEgreso,nombreApellidoEgreso,estadoEgreso,fechaEntregaEgreso,fechaDevolucionEgreso,direccionEntregaEgreso,observacionesEgreso) ";
            sql += "VALUES ("+ Clases.cElemento.idElemento + ",'" + txtDni.Text.Trim() + "','" + txtNombre.Text.Trim().ToUpper() + " " + txtApellido.Text.Trim().ToUpper() + "','" + cmbEstado.Text.Trim() + "','" + dtpEntrega.Text.Trim() + "','" + dtpDevolucion.Text.Trim() + "','" + txtLugarEntrega.Text.Trim().ToUpper() + "','" + rchObservaciones.Text.Trim().ToUpper() + "')";
            cc.Ejecutar(sql);
            cc.cerrarConexion();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE egresos SET dniEgreso='" + txtDni.Text.Trim() + "', nombreApellidoEgreso='" + txtNombre.Text.Trim().ToUpper() + " " + txtApellido.Text.Trim().ToUpper() + "', estadoEgreso='" + cmbEstado.Text + "', fechaEntregaEgreso='" + dtpEntrega.Text.Trim() + "', fechaDevolucionEgreso='" + dtpDevolucion.Text.Trim() + "', direccionEntregaEgreso='" + txtLugarEntrega.Text.Trim().ToUpper() + "', observacionesEgreso='" + rchObservaciones.Text.Trim().ToUpper() + "' WHERE idElemento=" + Clases.cElemento.idElemento;
            cc.abrirConexion();
            cc.Ejecutar(sql);
            cc.cerrarConexion();
            this.Close();
        }
    }
}
