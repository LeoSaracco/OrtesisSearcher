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
    }
}
