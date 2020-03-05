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
    public partial class BewerbungView : Form, IBewerbungView
    {

        public BewerbungView()
        {
            InitializeComponent();
        }

        public event BewerbungViewSchliesenHandler LoeseBewerbungSchliessenAus;
        public event BewerbungAnlegenHandler LoeseBewerbungAnlegenAus;

        public void SchliesseView()
        {
            this.Close();
        }

        public void ZeigeView()
        {
            this.ShowDialog();
        }

        private void BewerbungView_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "praktikumsprogrammBewerbungAnsicht.bewerbung". Sie können sie bei Bedarf verschieben oder entfernen.
            this.bewerbungTableAdapter.Fill(this.praktikumsprogrammBewerbungAnsicht.bewerbung);

        }

        private void btnStartseite_Click(object sender, EventArgs e)
        {
            LoeseBewerbungSchliessenAus();
        }

        private void btnBewerbungAnlegen_Click(object sender, EventArgs e)
        {
            LoeseBewerbungAnlegenAus();
        }
    }    
 }       
    

