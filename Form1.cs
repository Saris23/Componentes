using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reutilización
{
    public partial class Form1 : Form
    {
        private string ruta = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                lbArchivo.Text = ruta;
            }
        }

        private void btnRepro_Click(object sender, EventArgs e)
        {
            WinMediaPlayer.URL = ruta;
            WinMediaPlayer.Ctlcontrols.play();

        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            WinMediaPlayer.Ctlcontrols.stop();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            WinMediaPlayer.Ctlcontrols.pause();
        }

    }
}
