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
    public partial class TeilnehmerView : Form, ITeilnehmerView
    {
        public TeilnehmerView()
        {
            InitializeComponent();
        }

        public void ZeigeView()
        {
           this.ShowDialog();
        }
    }
}
