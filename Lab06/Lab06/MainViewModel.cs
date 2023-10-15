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
        // define una propiedad llamada "ListOfPeople" que es una colección
        // observable de objetos "ListaPersona."
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
            new Persona() { Nombre = "Jane", Apellido = "Doe" },
            new Persona() { Nombre = "Paola", Apellido = "Dominguez" },
            new Persona() { Nombre = "Estefany", Apellido = "Docker" }
        };
            dList.Encabezado = "D";

            var jList = new ListaPersona()
        {
            new Persona() { Nombre = "Cristal", Apellido = "Joel" },
            new Persona() { Nombre = "Taylor", Apellido = "Juárez" }
          
        };
            jList.Encabezado = "J";

            var tList = new ListaPersona()

            {
                new Persona() { Nombre = "Janyna", Apellido = "Taipe" },
                new Persona() { Nombre = "Margaret", Apellido = "Torres" }
          
        };
            tList.Encabezado = "T";
            //Se agregan  a la Lista de Personas a la coleccion "ListOfPeople."
            ListOfPeople.Add(sList);
            ListOfPeople.Add(dList);
            ListOfPeople.Add(jList);
            ListOfPeople.Add(tList);
        }
    }
}
