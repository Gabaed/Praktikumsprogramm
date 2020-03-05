
using Praktiku.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum.Interfaces
{ //Muss außerhalb des Interfaces als Public erstellt werden. Ist eine Art Zeiger auf eine Methode 
    //(und muss dieselben Parameter beinhalten wie die Methode, auf die der Delegate später zeigen wird.)
    public delegate void LoginHandler(Benutzer anzumeldenderBenutzer);
    public delegate void PasswortVergessenHandler();

    public interface ILoginView
    {

        //Bezug zum Model, damit die Daten aus der Konkreten View nicht "einzeln" vorhanden sind, sondern nach den generierten Models strukturiert sind.
        Benutzer benutzermodel { get; }

        //Das Event, welches ausgelöst wird, wenn der "Login-Button" geklickt wird.
        event LoginHandler LoeseLoginAus;
        event PasswortVergessenHandler LoesePasswortVergessenAus;


        //Methode zum Anzeigen der View
        void ZeigeView();

    }
}
