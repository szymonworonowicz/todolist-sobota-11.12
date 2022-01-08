using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_zadan.Klasy
{
    public class TodoTaskManager
    {
        // lista zadań
        private List<TodoTask> _wszystkieZadania;
        // konstruktor
        public TodoTaskManager()
        {
            // tworzymy pustą listę zadań
            _wszystkieZadania = new List<TodoTask>();
        }
        // metoda zwracająca zadanie znalezione po Id
        public TodoTask ZnajdzZadanie(int id)
        {
            // iterujemy po wszystkich zadaniacj
            foreach (TodoTask task in _wszystkieZadania)
            {
                // jak znalezione zadanie ma id takie jak przekazane
                // to je zwracamy
                if (task.Id == id)
                {
                    return task;
                }
            }
            // jeżeli nie ma zadania o podanym id to zwraqcamy nulla
            return null;
        }
        // metoda dodająca zadanie do listy
        public void DodajZadanie(TodoTask task)
        {
            _wszystkieZadania.Add(task);
        }
        // metoda usuwajaca zadanie z listy
        public void UsunZadanie(int taskId)
        {
            // najpierw szukamy zadania o podanym Id
            TodoTask task = ZnajdzZadanie(taskId);
            _wszystkieZadania.Remove(task);
        }
        // metoda zwracająca wszystkie zadania zalogowanego użytkownika z listy
        public List<TodoTask> PobierzZadania(Guid idZalogowanego)
        {
            // szukamy wszystkich zadań, których userId
            // jest takie jak zalogowanego użytkownika
            List<TodoTask> zadaniaZalogowanego = new List<TodoTask>();
            foreach (TodoTask zadanie in _wszystkieZadania)
            {
                if (zadanie.UserId == idZalogowanego)
                {
                    zadaniaZalogowanego.Add(zadanie);
                }
            }
            return zadaniaZalogowanego;
        }
        // metoda obliczająca id dla następnego zadania
        public int ObliczNastepneId()
        {
            // tworzymy zmienną na maksymalne id zdań z listy
            int max = 0;
            // iterujemy po wszystkich zadaniach
            foreach (var task in _wszystkieZadania)
            {
                // jeżeli id kolejnego zadania większe
                if (task.Id > max)
                {
                    // to je przypisujemy z listy
                    max = task.Id;
                }
            }
            // numer następnego zadania będzie o jeden większy
            // od maksymalnego numeru zadań, które są na liście
            return max + 1;
        }
    }
}
