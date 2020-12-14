using System;
using System.Collections.Generic;
using System.Text;

namespace CCE
{
    class Evento
    {
        private string fecha;   // Hay un tipo DateTime pero no se como funka
        private string nombre;
        private string organizador; //no estoy seguro si dejarlo como string o hacerlo de tipo Usuario

        public Evento()
        {
            fecha = "";
            nombre = "";
            organizador = "";
        } 
    }
}
