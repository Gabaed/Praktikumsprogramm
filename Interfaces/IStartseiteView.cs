using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiku.Interfaces
{
    public delegate void BewerbungHandler();
    public delegate void FirmenHandler();
    public delegate void ProfilHandler();
    public delegate void TeilnehmerHandler();
   public interface IStartseiteView
    {  
        void ZeigeView();
        event BewerbungHandler LoeseBewerbungAus;
        event FirmenHandler LoeseFirmenAus;
        event ProfilHandler LoeseProfilAus;
        event TeilnehmerHandler LoeseTeilnehmerAus;
    }
     
}
