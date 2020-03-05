using Praktiku.Interfaces;
using System;
using System.Windows.Forms;

namespace Praktiku.View
{
    public partial class StartseiteView : Form, IStartseiteView
    {
        public StartseiteView()
        {
            InitializeComponent();
        }
        
        public event BewerbungHandler LoeseBewerbungAus;
        public event FirmenHandler LoeseFirmenAus;
        public event ProfilHandler LoeseProfilAus;
        public event TeilnehmerHandler LoeseTeilnehmerAus;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFirmenForm_Click(object sender, EventArgs e)
        {
            LoeseFirmenAus();
        }

        private void btnBewerbungForm_Click(object sender, EventArgs e)
        {
            LoeseBewerbungAus();
        }
        private void btnProfilForm_Click(object sender, EventArgs e)
        {
            LoeseProfilAus();
        }
        public void ZeigeView()
        {
            this.ShowDialog();
        }

        private void btnTeilnehmerForm_Click(object sender, EventArgs e)
        {
            LoeseTeilnehmerAus();
        }
    }
}
