using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Praktiku
{
    

    
        public class Datenbankverbindung
        {
            string connectionstring = "Server='localhost'; Database='praktikumsprogramm'; Uid='root'; pwd='Sobachka-1'";
            MySqlConnection connection;
            public Datenbankverbindung()
            {
                connection = new MySqlConnection(connectionstring);
            }

            public void FirmaInDatenbankHinzufuegen(string Firmenname, int BewerbungTelefonnummer, string BewerbungEMailadresse, string Hinweise, string Porstleitzahl, string Ort, string Strasse, string Hausnummer, string Land)
            {
                MySqlParameter mySqlParameter = new MySqlParameter("Firmenname", Firmenname);
                MySqlParameter mySqlParameter1 = new MySqlParameter("BewerbungTelefonnummert", BewerbungTelefonnummer);
                MySqlParameter mySqlParameter2 = new MySqlParameter("BewerbungEMailadresse", BewerbungEMailadresse);
                MySqlParameter mySqlParameter3 = new MySqlParameter("Hinweise", Hinweise);
                MySqlParameter mySqlParameter4 = new MySqlParameter("Porstleitzahl", Porstleitzahl);
                MySqlParameter mySqlParameter5 = new MySqlParameter("Ort", Ort);
                MySqlParameter mySqlParameter6 = new MySqlParameter("Strasse", Strasse);
                MySqlParameter mySqlParameter7 = new MySqlParameter("Hausnummer", Hausnummer);
                MySqlParameter mySqlParameter8 = new MySqlParameter("Land", Land);
                MySqlCommand query = new MySqlCommand("insert into firma (Firmenname,BewerbungTelefonnummer,BewerbungEMailadresse,Hinweise,Porstleitzahl,Ort,Straße,Hausnummer,Land ) values(@Firmenname,@BewerbungTelefonnummert,@BewerbungEMailadresse,@Hinweise, @Porstleitzahl,@Ort,@Strasse,@Hausnummer,@Land)", connection);
                query.Parameters.Add(mySqlParameter);
                query.Parameters.Add(mySqlParameter1);
                query.Parameters.Add(mySqlParameter2);
                query.Parameters.Add(mySqlParameter3);
                query.Parameters.Add(mySqlParameter4);
                query.Parameters.Add(mySqlParameter5);
                query.Parameters.Add(mySqlParameter6);
                query.Parameters.Add(mySqlParameter7);
                query.Parameters.Add(mySqlParameter8);

                 try
                {
                    connection.Open();
                    query.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }


            //public void delete(double deletezahl)
            //{
            //    try
            //    {
            //        MySqlCommand deletezeile = new MySqlCommand("delete from nahrungsmittel where artikel_nummer =" + deletezahl + ";", connection);
            //        connection.Open();
            //        deletezeile.ExecuteNonQuery();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    finally
            //    {
            //        connection.Close();
            //    }
            //}
            //Lager lager1 = new Lager();

            //public void updatebezeichnung(double dataupdate, string updatebezeichnung, string anderung)
            //{
            //    try
            //    {
            //        MySqlCommand updatadata = new MySqlCommand("update nahrungsmittel set " + anderung + " ='" + updatebezeichnung + "' where artikel_nummer =" + dataupdate + ";", connection);
            //        connection.Open();
            //        updatadata.ExecuteNonQuery();

            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show("Geben Sie bitte korrekte Ablaufsdatum");
            //    }
            //    finally
            //    {
            //        connection.Close();
            //    }
        }
    }

