using Praktiku.Interfaces;
using Praktiku.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktiku.Presenter
{
   public class FirmaAnlegenPresenter
    {   
        
        IFirmaAnlegenView firmaAnlegenView = new FirmaAnlegenView();
        Datenbankverbindung DbFirma = new Datenbankverbindung(); 
        public FirmaAnlegenPresenter()
        {
            firmaAnlegenView.LoeseFirmaAnlegenSchliessenAus += FirmaSchliessen;
            firmaAnlegenView.LoeseFirmaAnlegenAus += FirmaHinzufuegen;
            firmaAnlegenView.ZeigeView();
        }
        
        private void FirmaSchliessen()
        {
            firmaAnlegenView.SchlisseView();
        }

        private void FirmaHinzufuegen(string txtNeueFirmaBewerbungEMailadresse, string txtNeueFirmaHausnummer, string txtNeueFirmaHinweise, string txtNeueFirmaLand, string txtNeueFirmaName, string txtNeueFirmaOrt, string txtNeueFirmaPostleitzahl, string txtNeueFirmaStrasse, string txtNeuFirmaBewerbungTelefonnummer)
        {  
            if(txtNeueFirmaName=="")
            {
                MessageBox.Show("Tragen Sie bitte eine Firmaname ein");
            }
            //else if (txtNeuFirmaBewerbungTelefonnummer == A,b,c,d)
            //{
            //    MessageBox.Show("Tragen Sie bitte Bewerbungstelefonnummer ein");
            //}
            else if (txtNeueFirmaPostleitzahl=="")
            {
                MessageBox.Show("Tragen Sie bitte ein Postleitzahl ein");
            }
            else if(txtNeueFirmaOrt=="")
            {
                MessageBox.Show("Tragen Sie bitte ein Ort ein");
            }
            else if(txtNeueFirmaStrasse=="")
            {
                MessageBox.Show("Tragen Sie bitte eine Straße ein");
            }
            else if(txtNeueFirmaHausnummer=="")
            {
                MessageBox.Show("Tragen Sie bitte ein Hausnummer ein");
            }
            else if(txtNeueFirmaLand=="")
            {
                MessageBox.Show("Tragen Sie bitte ein Land ein");
            }
            else 
            { 
            DbFirma.FirmaInDatenbankHinzufuegen(txtNeueFirmaName,Convert.ToInt32(txtNeuFirmaBewerbungTelefonnummer),txtNeueFirmaBewerbungEMailadresse,txtNeueFirmaHinweise,txtNeueFirmaPostleitzahl,txtNeueFirmaOrt,txtNeueFirmaStrasse,txtNeueFirmaHausnummer,txtNeueFirmaLand);
            firmaAnlegenView.SchlisseView();
            }
        }
    }
}
