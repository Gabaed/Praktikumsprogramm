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
    public partial class ProfilView : Form, IProfilView 
    {
        public ProfilView()
        {
            InitializeComponent();
        }

        public event ProfilSchliessenView LoeseProfilSchliessenAus;

        public void SchliesseView()
        {
            this.Close();
        }

        public void ZeigeView()
        {
                this.ShowDialog();
        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            LoeseProfilSchliessenAus();
        }
    }
}
