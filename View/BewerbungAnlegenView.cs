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
    public partial class BewerbungAnlegenView : Form, IBewerbungAnlegenView
    {
        public BewerbungAnlegenView()
        {
            InitializeComponent();
        }

        public event BewerbungHinzufuegenHandler LoeseBewerbungHinzufuegenAus;
        public event BewerbungAnlegenViewSchliessenHandler LoeseBewerbungAnlegenViewSchliessenAus;

        public void ZeigeView()
        {
            this.ShowDialog();
        }

        private void BewerbungAnlegenView_Load(object sender, EventArgs e)
        {
            
        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            LoeseBewerbungAnlegenViewSchliessenAus();
        }

        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            LoeseBewerbungHinzufuegenAus();
        }

        public void SchliesseView()
        {
            this.Close();
        }
    }
}
