using Praktiku.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktiku.View
{
    public partial class FirmaAnlegenView : Form, IFirmaAnlegenView
    {
        public FirmaAnlegenView()
        {
            InitializeComponent();
        }



        public event FirmaAnlegenHandler LoeseFirmaAnlegenAus;
        public event FirmaAnlegenSchliessenHandler LoeseFirmaAnlegenSchliessenAus;

        public void ZeigeView()
        {
            this.ShowDialog();
        }

        private void FirmaAnlegenView_Load(object sender, EventArgs e)
        {

        }

        private void btnFirmaHinzufuegen_Click(object sender, EventArgs e)
        {   
            LoeseFirmaAnlegenAus(txtNeueFirmaBewerbungEMailadresse.Text,txtNeueFirmaHausnummer.Text, txtNeueFirmaHinweise.Text, txtNeueFirmaLand.Text, txtNeueFirmaName.Text, txtNeueFirmaOrt.Text, txtNeueFirmaPostleitzahl.Text,txtNeueFirmaStrasse.Text, txtNeuFirmaBewerbungTelefonnummer.Text);
        }

        private void btnStartseite_Click(object sender, EventArgs e)
        {
            LoeseFirmaAnlegenSchliessenAus();
        }

        public void SchlisseView()
        {
            this.Close();
        }

        private void FirmaAnlegenView_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
