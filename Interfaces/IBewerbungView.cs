using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiku.Interfaces
{   public delegate void BewerbungViewSchliesenHandler();
    public delegate void BewerbungAnlegenHandler();
    public interface IBewerbungView
    {
        event BewerbungViewSchliesenHandler LoeseBewerbungSchliessenAus;
        event BewerbungAnlegenHandler LoeseBewerbungAnlegenAus;
        void SchliesseView();
        void ZeigeView();
    }

}
