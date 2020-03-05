using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiku.Interfaces
{
    public delegate void FirmaAnlegenHandler(string txtNeueFirmaBewerbungEMailadresse,string txtNeueFirmaHausnummer,string txtNeueFirmaHinweise,string txtNeueFirmaLand,string txtNeueFirmaName,string txtNeueFirmaOrt,string txtNeueFirmaPostleitzahl,string txtNeueFirmaStrasse,string txtNeuFirmaBewerbungTelefonnummer);
    public delegate void FirmaAnlegenSchliessenHandler();
    public interface IFirmaAnlegenView
    { 
        event FirmaAnlegenHandler LoeseFirmaAnlegenAus;
        event FirmaAnlegenSchliessenHandler LoeseFirmaAnlegenSchliessenAus;
        void ZeigeView();
        void SchlisseView();
    }
}
