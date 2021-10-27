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
    public partial class formDetalleHistorico : Form
    {
        Clases.claseConexion cc = new Clases.claseConexion();
        DataTable dt;
        public formDetalleHistorico()
        {
            InitializeComponent();
            cc.abrirConexion();
            string str = "SELECT e.dniEgresoHistorico as Dni, e.nombreApellidoEgresoHistorico as Nombre, e.telEgresoHistorico as Tel, e.celEgresoHistorico as Cel, e.estadoEgresoHistorico as Estado, e.fechaEntregaEgresoHistorico as [Fecha Entrega], e.fechaDevolucionEgresoHistorico as [Fecha devolucion], e.direccionEntregaEgresoHistorico as Direccion, e.observacionesEgresoHistorico as Observaciones  FROM egresosHistorico e WHERE e.idElemento=" + Clases.cElemento.idElemento;
            dt = cc.LeerBD(str);
            dgvEgresosHistorico.DataSource = dt;
            str = "SELECT e.dniIngresoHistorico as Dni, e.nombreApellidoIngresoHistorico as Nombre, e.telIngresoHistorico as Tel, e.celIngresoHistorico as Cel, e.domicilioIngresoHistorico as Domicilio, e.estadoEgresoHistorico as [Estado egreso], e.estadoIngresoHistorico as [Estado ingreso], e.fechaEntregaEgresoHistorico as [Fecha entrega], e.fechaDevolucionIngresoHistorico as [Fecha devolucion], e.direccionEntregaIngresoHistorico as [Direc. entrega], e.observacionesIngresoHistorico as [Obs. ingreso], e.observacionesEgresoHistorico as [Obs. egreso] FROM ingresosHistorico e WHERE e.idElemento=" + Clases.cElemento.idElemento;
            dt = cc.LeerBD(str);
            dgvIngresoHistoricos.DataSource = dt;
            cc.cerrarConexion();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            cc.ExportarDataGridViewExcel(dgvEgresosHistorico, dgvIngresoHistoricos);
        }
    }
}
