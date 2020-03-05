using Praktiku.Interfaces;
using Praktiku.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiku.Presenter
{
    
   public class BewerbungPresenter
    {
        IBewerbungView bewerbungView = new BewerbungView();
        public BewerbungPresenter()
        {
            bewerbungView.LoeseBewerbungAnlegenAus += BewerbungAnlegen;
            bewerbungView.LoeseBewerbungSchliessenAus += FirmenSchliessen;
            bewerbungView.ZeigeView();
        }

        private void BewerbungAnlegen()
        {
            BewerbungAnlegenPresenter bewebungAnlegen = new BewerbungAnlegenPresenter(); 
        }

        private void FirmenSchliessen()
        {
            bewerbungView.SchliesseView();
        }
    }
}
