using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiku.Interfaces
{ public delegate void StartseiteHandler();
    interface IPasswortVergessenView
    {   
        event StartseiteHandler LoeseStartseiteAus;
        void ZeigeView();
    }
}
