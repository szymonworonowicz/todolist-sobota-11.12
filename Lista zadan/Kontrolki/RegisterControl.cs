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
    public partial class RegisterControl : UserControl
    {
        //zmienna na formularz
        private MainForm _form;
        public RegisterControl(MainForm form)
        {
            InitializeComponent();
            //przypisujemy zmienna formularza
            _form = form;
            //kontrolka zajmuje cala wielkosc okna
            Dock = DockStyle.Fill;
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            _form.PokazLoginControl();
        }

        private void btnZarejestruj_Click(object sender, EventArgs e)
        {
            _form.PokazTasksControl();
        }
    }
}
