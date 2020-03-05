using Praktiku.Interfaces;
using Praktiku.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiku.Presenter
{
    public class PasswortVergessenPresenter
    {
        IPasswortVergessenView passwortvergessenView = new PasswortVergessenView();
        public PasswortVergessenPresenter()
        {
            
            passwortvergessenView.LoeseStartseiteAus += Startseite;
            passwortvergessenView.ZeigeView();
        }
        public void Startseite()
            
        {
            StartseitePresenter startseitePresenter = new StartseitePresenter();
        }
    }
    
   
}

