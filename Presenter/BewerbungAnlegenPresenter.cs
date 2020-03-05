using Praktiku.Interfaces;
using Praktiku.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiku.Presenter
{
    class BewerbungAnlegenPresenter
    {
        IBewerbungAnlegenView bewerbungAnlegenView = new BewerbungAnlegenView();
        public BewerbungAnlegenPresenter()
        {
            bewerbungAnlegenView.LoeseBewerbungHinzufuegenAus += BewebungAnlegen;
            bewerbungAnlegenView.LoeseBewerbungAnlegenViewSchliessenAus += BewerbungAnlegenSchliessen;
            bewerbungAnlegenView.ZeigeView();
        }

        private void BewebungAnlegen()
        {
            bewerbungAnlegenView.SchliesseView();
        }

        private void BewerbungAnlegenSchliessen()
        {
            bewerbungAnlegenView.SchliesseView();
        }
    }
}
