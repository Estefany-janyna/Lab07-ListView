using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using static Lab06.Person;
using Xamarin.Forms;

namespace Lab06
{
    public class MainViewModel : BindableObject
    {
        public ObservableCollection<ListaPersona> ListOfPeople { get; set; }

        public MainViewModel()
        {
            ListOfPeople = new ObservableCollection<ListaPersona>();
            LoadData();
        }

        private void LoadData()
        {
            var sList = new ListaPersona()
        {
            new Persona() { Nombre = "Sally", Apellido = "Sampson" },
            new Persona() { Nombre = "Taylor", Apellido = "Swift" },
            new Persona() { Nombre = "Juan", Apellido = "Smith" }
        };
            sList.Encabezado = "S";

            var dList = new ListaPersona()
        {
            new Persona() { Nombre = "Jane", Apellido = "Doe" }
        };
            dList.Encabezado = "D";

            var jList = new ListaPersona()
        {
            new Persona() { Nombre = "Billy", Apellido = "Joel" }
        };
            jList.Encabezado = "J";

            ListOfPeople.Add(sList);
            ListOfPeople.Add(dList);
            ListOfPeople.Add(jList);
        }
    }
}
