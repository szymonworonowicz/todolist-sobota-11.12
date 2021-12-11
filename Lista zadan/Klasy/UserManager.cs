using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_zadan.Klasy
{
    //klasa do zarzadzania uzytkownikami
    public class UserManager
    {
        //lista do trzymania uzytkownikow
        private List<User> uzytkownicy;

        public UserManager()
        {
            //tworzymy obiekt listy
            uzytkownicy = new List<User>();

            //dodamy defaultowego uzytkownika
            uzytkownicy.Add(new User(Guid.NewGuid(), "test", "test", "test"));
        }

        // metoda WyszukajUzytkownika zwraca użytkownika
        // o podanym loginie i haśle jeżeli istnieje taki na liście
        // jeżeli nie istnieje to zwraca nulla
        // wykorzystamy ją do logowania
        public User WyszukajUzytkownika(string login, string haslo)
        {
            // iterujemy po wszystkich użytkownikach
            foreach (User user in uzytkownicy)
            {
                // jezeli użytkownik z listy ma takei samo hasło i login
                if (user.Login == login && user.Haslo == haslo)
                {
                    // to go zwracamy
                    return user;
                }
            }

            // jak nie ma żadnego pasującego użytkownika
            // to zwracamy null

            return null; 
        }

        // metoda do sprawdzania czy podany login jest wolny
        // w aplikacji nie możemy mieć dwóch użytkowników
        // z tym samym loginem, więc zanim zapiszemy nowego użytkownika
        // to musimy sprawdzić czy już taki nie istnieje
        public bool CzyLoginWolny(string login)
        {
            foreach(User user in uzytkownicy)
            {
                // jeżeli użytkownik z listy ma podany login
                if (user.Login == login)
                {
                    return false;
                }
            }
            // jak nie ma takiego użytkownika to zwracamy informację
            // że login jest wolny
            return true;
        }

        // ponieważ lista użytkowników jest prywatna
        // dodajemy publiczną metodę do dodania nowego użytkownika

        public void DodajUzytkownika(User user)
        {
            uzytkownicy.Add(user);
        }
    }
}
