using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Documento
    {
        public int Codice { get; set; }
        public String Titolo { get; set; }
        public int Anno { get; set; }
        public String Categoria { get; set; }
        public Stato Stato { get; set; }
        public Autore Autore { get; set; }
        public Scaffale Scaffale { get; set; }
    }
}
