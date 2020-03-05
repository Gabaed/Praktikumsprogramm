using Praktiku.Interfaces;
using Praktiku.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiku.Presenter
{
    public class FirmenPresenter
    {
        IFirmenView firmenView = new FirmenView();
        public FirmenPresenter()
        {   firmenView.LoeseFirmenViewSchliessenAus += FirmenSchliessen;
            firmenView.LoeseFirmaAnlegenAus += FirmaAnlegen;
            firmenView.ZeigeView();
            
        }
        public void FirmenSchliessen()
        {
            firmenView.SchliesseView();
        }
        public void FirmaAnlegen()
        {
            FirmaAnlegenPresenter firmaAnlegen = new FirmaAnlegenPresenter();
        }
           
    }
}
