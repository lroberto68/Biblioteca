using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Prestito
    {
        public int Codice { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public Documento Documento { get; set; }
        public Utente Utente { get; set; }
    }
}
