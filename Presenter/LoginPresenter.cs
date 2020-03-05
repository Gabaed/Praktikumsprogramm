using Praktiku.Model;
using Praktiku.View;
using Praktikum;
using Praktikum.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiku.Presenter
{
    public class LoginPresenter
    {
        ILoginView loginView = new LoginView();

        public LoginPresenter()
        {
            loginView.LoesePasswortVergessenAus += PasswortVergessen;
            loginView.LoeseLoginAus += Login;
            loginView.ZeigeView();
        }

        public void Login(Benutzer benutzer)
        {
            StartseitePresenter startseitePresenter = new StartseitePresenter();
        }
        public void PasswortVergessen()
        {
            PasswortVergessenPresenter passwortVergessenPresenter = new PasswortVergessenPresenter();
        }
    }
}
