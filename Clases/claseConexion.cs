using System;
using System.Data;
//SqLite
using System.Data.SQLite;
using System.Windows.Forms;

namespace OrtesisSearcher.Clases
{
    class claseConexion
    {
        SQLiteConnection con = new SQLiteConnection("Data Source = ortesisbd.s3db;Version=3;Journal Mode=Off;", true);
        SQLiteCommand Orden;
        SQLiteDataReader Lector;
        public Boolean abrirConexion()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (Exception msj)
            {
                Console.WriteLine(msj);
                return false;
            }
        }
        public Boolean cerrarConexion()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception msj)
            {
                Console.WriteLine(msj);
                return false;
            }
        }
        public DataTable LeerBD(string Consulta)
        {
            DataTable tabla = new DataTable();
            Orden = new SQLiteCommand(Consulta, con);
            Lector = Orden.ExecuteReader();
            tabla.Load(Lector);
            return tabla;
        }
        public void Ejecutar(string Consulta)
        {
            try
            {
                Orden = new SQLiteCommand(Consulta, con);
                Orden.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public string LeerDato(string campo, string Consulta)
        {
            string dato;
            Orden = new SQLiteCommand(Consulta, con);
            Lector = Orden.ExecuteReader();
            Lector.Read();
            try
            {
                dato = Lector[campo].ToString();
                Lector.Close();
                return (dato);
            }
            catch (Exception e)
            {
                Lector.Close();
                return (e.Message);
            }
        }

        public void CargaDGV(DataGridView dgv, string Consulta, string tabla, string origen)
        {
            switch (origen)
            {
                case "CargarMesa":
                    {
                        Orden = new SQLiteCommand(Consulta, con);
                        Lector = Orden.ExecuteReader();
                        dgv.Columns.Add("Cantidad", "Cantidad");
                        dgv.Columns.Add("Descripción", "Descripción");
                        dgv.Columns.Add("Precio", "Precio");
                        dgv.Columns.Add("idProd", "idProd");
                        dgv.Columns["idProd"].Visible = false;

                        while (Lector.Read())
                        {
                            dgv.Rows.Add();
                            dgv[0, dgv.Rows.Count - 1].Value = Lector["Unidades"];
                            dgv[1, dgv.Rows.Count - 1].Value = Lector["Producto"];
                            dgv[2, dgv.Rows.Count - 1].Value = Lector["Valor"];
                            dgv[3, dgv.Rows.Count - 1].Value = Lector["idProd"];
                        }
                        break;
                    }
                default:
                    {
                        SQLiteDataAdapter dstabla = new SQLiteDataAdapter(Consulta, con);
                        DataSet dtabla = new DataSet();
                        dstabla.Fill(dtabla, tabla);
                        dgv.DataSource = dtabla;
                        dgv.DataMember = tabla;
                        break;
                    }
            }
        }
        public void ExportarDataGridViewExcel(DataGridView tabla, DataGridView tabla2)
        {

            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

                //Tabla egresos
                excel.Application.Workbooks.Add(true);
                Microsoft.Office.Interop.Excel.Worksheet sheet = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
                sheet.Name = "Egresos";
                int IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns) // Columnas
                {

                    IndiceColumna++;

                    excel.Cells[1, IndiceColumna] = col.Name;

                }

                int IndeceFila = 0;

                foreach (DataGridViewRow row in tabla.Rows) // Filas
                {

                    IndeceFila++;

                    IndiceColumna = 0;

                    foreach (DataGridViewColumn col in tabla.Columns)
                    {

                        IndiceColumna++;

                        excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                    }

                }

                //Tabla ingresos
                excel.Sheets.Add();
                Microsoft.Office.Interop.Excel.Worksheet sheet2 = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
                sheet2.Name = "Ingresos";
                int IndiceColumna2 = 0;

                foreach (DataGridViewColumn col in tabla2.Columns) // Columnas
                {

                    IndiceColumna2++;

                    excel.Cells[1, IndiceColumna2] = col.Name;

                }

                int IndeceFila2 = 0;

                foreach (DataGridViewRow row in tabla2.Rows) // Filas
                {

                    IndeceFila2++;

                    IndiceColumna2 = 0;

                    foreach (DataGridViewColumn col in tabla2.Columns)
                    {

                        IndiceColumna2++;

                        excel.Cells[IndeceFila2 + 1, IndiceColumna2] = row.Cells[col.Name].Value;

                    }

                }
                excel.Visible = true;
            }
            catch (Exception MsjError)
            {
                MessageBox.Show(MsjError.Message);
            }
        }
    }
}
