
using Praktiku.Model;
using Praktikum;
using Praktikum.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktiku.View

{
    public partial class LoginView : Form, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
            benutzermodel = new Benutzer();
        }

        public Benutzer benutzermodel { get; set; }



        public event LoginHandler LoeseLoginAus;
        public event PasswortVergessenHandler LoesePasswortVergessenAus;

        public void ZeigeView()
        {
            this.ShowDialog();
        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Befüllen des Models, ggf. Überprüfung auf "Enthält E-Mail ein @-Zeichen" etc
            benutzermodel.Email = txtEmail.Text;
            benutzermodel.Passwort = txtPasswort.Text;

            //Auslösen des Events //LoeseLoginAus(benutzermodel);
            LoeseLoginAus(benutzermodel);
        }

        private void txtPasswort_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnPasswortVergessen_Click(object sender, EventArgs e)
        {
            LoesePasswortVergessenAus();
        }
    }
}
