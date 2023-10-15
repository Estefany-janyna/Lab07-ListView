using System;
using System.Collections.Generic;
using System.Text;
using static Lab06.Person;

namespace Lab06
{
    public class ListaPersona : List<Persona>
    {
        public string Encabezado { get; set; }
        public List<Persona> Personas => this;
    }

}
