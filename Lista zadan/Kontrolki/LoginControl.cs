using Lista_zadan.Formularze;
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
    public partial class LoginControl : UserControl
    {
        //zmienna na formularz
        private MainForm _form;
        public LoginControl(MainForm form)
        {
            InitializeComponent();
            //przypisujemy zmienna formularza
            _form = form;
            //kontrolka zajmuje cala wielkosc okna
            Dock = DockStyle.Fill;
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            _form.PokazTasksControl();
        }

        private void btnZalozKonto_Click(object sender, EventArgs e)
        {
            _form.PokazRegisterControl();
        }
    }
}
