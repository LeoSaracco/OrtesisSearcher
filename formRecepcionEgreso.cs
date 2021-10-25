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
                cmbEstadoEgreso.Text = dt.Rows[0]["estadoEgreso"].ToString();
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
            sql += "VALUES ("+ Clases.cElemento.idElemento + ",'" + txtDni.Text.Trim() + "','" + txtNombre.Text.Trim().ToUpper() + " " + txtApellido.Text.Trim().ToUpper() + "','" + cmbEstadoEgreso.Text.Trim() + "','" + dtpEntrega.Text.Trim() + "','" + dtpDevolucion.Text.Trim() + "','" + txtLugarEntrega.Text.Trim().ToUpper() + "','" + rchObservaciones.Text.Trim().ToUpper() + "')";
            cc.Ejecutar(sql);
            string sql2 = "INSERT INTO egresosHistorico(idElemento,dniEgresoHistorico,nombreApellidoEgresoHistorico,estadoEgresoHistorico,fechaEntregaEgresoHistorico,fechaDevolucionEgresoHistorico,direccionEntregaEgresoHistorico,observacionesEgresoHistorico) ";
            sql2 += "VALUES (" + Clases.cElemento.idElemento + ",'" + txtDni.Text.Trim() + "','" + txtNombre.Text.Trim().ToUpper() + " " + txtApellido.Text.Trim().ToUpper() + "','" + cmbEstadoEgreso.Text.Trim() + "','" + dtpEntrega.Text.Trim() + "','" + dtpDevolucion.Text.Trim() + "','" + txtLugarEntrega.Text.Trim().ToUpper() + "','" + rchObservaciones.Text.Trim().ToUpper() + "')";
            cc.Ejecutar(sql2);
            cc.cerrarConexion();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE egresos SET dniEgreso='" + txtDni.Text.Trim() + "', nombreApellidoEgreso='" + txtNombre.Text.Trim().ToUpper() + " " + txtApellido.Text.Trim().ToUpper() + "', estadoEgreso='" + cmbEstadoEgreso.Text + "', fechaEntregaEgreso='" + dtpEntrega.Text.Trim() + "', fechaDevolucionEgreso='" + dtpDevolucion.Text.Trim() + "', direccionEntregaEgreso='" + txtLugarEntrega.Text.Trim().ToUpper() + "', observacionesEgreso='" + rchObservaciones.Text.Trim().ToUpper() + "' WHERE idElemento=" + Clases.cElemento.idElemento;
            cc.abrirConexion();
            cc.Ejecutar(sql);
            string sql2 = "UPDATE egresosHistorico SET dniEgresoHistorico='" + txtDni.Text.Trim() + "', nombreApellidoEgresoHistorico='" + txtNombre.Text.Trim().ToUpper() + " " + txtApellido.Text.Trim().ToUpper() + "', estadoEgresoHistorico='" + cmbEstadoEgreso.Text + "', fechaEntregaEgresoHistorico='" + dtpEntrega.Text.Trim() + "', fechaDevolucionEgresoHistorico='" + dtpDevolucion.Text.Trim() + "', direccionEntregaEgresoHistorico='" + txtLugarEntrega.Text.Trim().ToUpper() + "', observacionesEgresoHistorico='" + rchObservaciones.Text.Trim().ToUpper() + "' WHERE idElemento=" + Clases.cElemento.idElemento;
            cc.Ejecutar(sql2);
            cc.cerrarConexion();
            this.Close();
        }

        private void btnDevolverElemento_Click(object sender, EventArgs e)
        {
            cc.abrirConexion();
            string sql = "INSERT INTO ingresosHistorico([idElemento] ,[dniIngresoHistorico] ,[nombreApellidoIngresoHistorico] ,[estadoIngresoHistorico] ,[estadoEgresoHistorico] ,[fechaEntregaEgresoHistorico] ,[fechaDevolucionIngresoHistorico] ,[direccionEntregaIngresoHistorico],[observacionesIngresoHistorico], [observacionesEgresoHistorico]) ";
            sql += "VALUES (" + Clases.cElemento.idElemento + ",'" + txtDni.Text.Trim() + "','" + txtNombre.Text.Trim().ToUpper() + " " + txtApellido.Text.Trim().ToUpper() + "','" + cmbEstadoIngreso.Text.Trim() + "','" + cmbEstadoEgreso.Text.Trim() + "','" + dtpEntrega.Text.Trim() + "','" + dtpDevolucionIngreso.Text.Trim() + "', '" + txtLugarRecepcion.Text.Trim().ToUpper() + "','" + rchObservacionesIngreso.Text.Trim().ToUpper() + "','" + rchObservaciones.Text.Trim().ToUpper() + "')";
            cc.Ejecutar(sql);
            cc.Ejecutar("DELETE FROM egresos WHERE idElemento=" + Clases.cElemento.idElemento);
            cc.cerrarConexion();
            this.Close();
        }
    }
}
