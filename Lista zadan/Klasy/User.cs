using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_zadan.Klasy
{
    public class User
    {
        public Guid Id;
        public string Login;
        public string Imie;
        public string Haslo;

        public User(Guid id, string login, string imie, string haslo)
        {
            Id = id;
            Login = login;
            Imie = imie;
            Haslo = haslo;
        }
    }
}
