using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public class Person
    {
        //se define el modelo de la clase Persona
        public class Persona
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string DisplayName => $"{Apellido}, {Nombre}";
        }
    }

}
