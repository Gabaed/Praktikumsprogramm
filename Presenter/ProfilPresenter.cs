using Praktiku.Interfaces;
using Praktiku.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiku.Presenter
{
    class ProfilPresenter
    {
        IProfilView profilView = new ProfilView();
        public ProfilPresenter()

        {
            profilView.LoeseProfilSchliessenAus += ProfilSchliessen;
            profilView.ZeigeView();
        }

        private void ProfilSchliessen()
        {
            profilView.SchliesseView();
        }
    }
}
