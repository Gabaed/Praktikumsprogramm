using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiku.Interfaces
{
    public delegate void BewerbungHinzufuegenHandler();
    public delegate void BewerbungAnlegenViewSchliessenHandler();
    public interface IBewerbungAnlegenView
    {
        event BewerbungHinzufuegenHandler LoeseBewerbungHinzufuegenAus;
        event BewerbungAnlegenViewSchliessenHandler LoeseBewerbungAnlegenViewSchliessenAus;
        void ZeigeView();
        void SchliesseView();

    }
}
