using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiku.Interfaces
{
   public delegate void FirmaAngelenHandler();
   public delegate void FirmenViewSchliesenHandler();
   public interface IFirmenView
    {
        event FirmenViewSchliesenHandler LoeseFirmenViewSchliessenAus;
        event FirmaAngelenHandler LoeseFirmaAnlegenAus;
        void SchliesseView();
        void ZeigeView();
    }
}
