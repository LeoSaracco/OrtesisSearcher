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
    public partial class formMenuOpciones : Form
    {
        public formMenuOpciones()
        {
            InitializeComponent();
            Clases.cMenu.opcionSeleccionada = "0";
        }

        private void btnIngresoEgreso_Click(object sender, EventArgs e)
        {
            Clases.cMenu.opcionSeleccionada = "1";
            this.Close();
        }

        private void btnHistoricoOpcion_Click(object sender, EventArgs e)
        {
            Clases.cMenu.opcionSeleccionada = "2";
            this.Close();
        }
    }
}
