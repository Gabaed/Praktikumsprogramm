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
    public partial class PasswortVergessenView : Form, IPasswortVergessenView 
    {
        public PasswortVergessenView()
        {
            InitializeComponent();
        }

        public event StartseiteHandler LoeseStartseiteAus;

        public void ZeigeView()
        {
            this.ShowDialog();
        }

        private void btnWiederherstellen_Click(object sender, EventArgs e)
        {
            LoeseStartseiteAus();
        }
    }
}
