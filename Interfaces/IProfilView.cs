using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiku.Interfaces
{
    public delegate void ProfilSchliessenView();
    
    interface IProfilView
    {
        event ProfilSchliessenView LoeseProfilSchliessenAus;
        void SchliesseView();
        void ZeigeView();
    }
}
