using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Utente : Persona
    {
        public string Indirizzo { get; set; }
        public int Cap { get; set; }
        public string Citta { get; set; }
        public string Provincia { get; set; }
        public string CodiceFiscale {get; set ;}
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Telefono { get; set; }
    }
}
