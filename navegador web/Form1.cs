using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace navegador_web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnIr_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(txtURL.Text);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }
    }
}
