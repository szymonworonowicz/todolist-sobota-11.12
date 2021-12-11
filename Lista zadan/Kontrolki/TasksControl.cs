using Lista_zadan.Formularze;
using Lista_zadan.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_zadan.Kontrolki
{
    public partial class TasksControl : UserControl
    {
        //zmienna na formularz
        private MainForm _form;

        //zmienna na uzytkownika
        private User _user;

        public TasksControl(MainForm form, User user)
        {
            InitializeComponent();
            //przypisujemy zmienna formularza
            _form = form;
            //kontrolka zajmuje cala wielkosc okna
            Dock = DockStyle.Fill;

            //przypisujemy konkretnego uzytkownika
            _user = user;

            lblZalogowanyWartosc.Text = user.Imie;
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            _form.PokazLoginControl();
        }
    }
}
