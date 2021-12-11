using Lista_zadan.Klasy;
using Lista_zadan.Kontrolki;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_zadan.Formularze
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void PokazLoginControl()
        {
            //czyscimy kontrolki
            Controls.Clear();

            Controls.Add(new LoginControl(this));
        }

        public void PokazRegisterControl()
        {
            //czyscimy kontrolki
            Controls.Clear();

            Controls.Add(new RegisterControl(this));
        }

        public void PokazTasksControl(User user)
        {
            //czyscimy kontrolki
            Controls.Clear();

            Controls.Add(new TasksControl(this, user));
        }
    }
}
