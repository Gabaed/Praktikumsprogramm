using Praktiku.Interfaces;
using Praktiku.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiku.Presenter
{
    
    public class StartseitePresenter
    {
        IStartseiteView startseiteView = new StartseiteView();
        public StartseitePresenter()
        {
            startseiteView.LoeseProfilAus += Profil;
            startseiteView.LoeseFirmenAus += Firmen;
            startseiteView.LoeseBewerbungAus += Bewerbung;
            startseiteView.LoeseTeilnehmerAus += Teilnehmer; 
            startseiteView.ZeigeView();
        }

        private void Teilnehmer()
        {
            TeilnehmerPresenter teilnehmerPresenter = new TeilnehmerPresenter();
        }

        public void Bewerbung()
        {
            BewerbungPresenter bewerbungPresenter = new BewerbungPresenter();
        }
        public void Firmen()
        {
            FirmenPresenter firmenPresenter = new FirmenPresenter();
        }
        public void Profil()
        {
            ProfilPresenter profilPresenter = new ProfilPresenter();
        }
    }
}
