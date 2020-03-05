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
    public partial class FirmenView : Form, IFirmenView
    {
        public FirmenView()
        {
            InitializeComponent();
        }

        public event FirmaAngelenHandler LoeseFirmaAnlegenAus;
        public event FirmenViewSchliesenHandler LoeseFirmenViewSchliessenAus;

        private void btnFirmaAnlegen_Click(object sender, EventArgs e)
        {
            LoeseFirmaAnlegenAus();
        }
        public void ZeigeView()
        {
            this.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FirmenView_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "praktikumsprogrammDataSet.firma". Sie können sie bei Bedarf verschieben oder entfernen.
            this.firmaTableAdapter.Fill(this.praktikumsprogrammDataSet.firma);

        }

        private void btnFirmenViewSchliessen_Click(object sender, EventArgs e)
        {
            LoeseFirmenViewSchliessenAus();
        }

        public void SchliesseView()
        {
            this.Close();
        }
    }
}
