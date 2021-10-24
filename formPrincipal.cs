using System;
using System.Windows.Forms;

namespace OrtesisSearcher
{
    public partial class formPrincipal : Form
    {
        private Form activeForm = null;
        Clases.claseConexion cc = new Clases.claseConexion();
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void bntElementos_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new formElementos());
        }

        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
