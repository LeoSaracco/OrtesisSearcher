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
        public formElementos()
        {
            InitializeComponent();
        }

        private void bntAgregarElemento_Click(object sender, EventArgs e)
        {
            formAgregarElementos FAE = new formAgregarElementos();
            FAE.ShowDialog();
        }
    }
}
