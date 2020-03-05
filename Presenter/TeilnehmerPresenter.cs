using Praktiku.Interfaces;
using Praktiku.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiku.Presenter
{

    public class TeilnehmerPresenter
    {
        ITeilnehmerView teilnehmerView = new TeilnehmerView();
        public TeilnehmerPresenter()
    {
        teilnehmerView.ZeigeView();
    }
    }
   
}
