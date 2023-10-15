using System;
using System.Collections.Generic;
using System.Text;
using static Lab06.Person;

namespace Lab06
{
    //Esta clase permite reprentar la lista
    //con el fin de organizar y agrupar informacion
    public class ListaPersona : List<Persona>
    {
        public string Encabezado { get; set; }
        public List<Persona> Personas => this;
    }

}
