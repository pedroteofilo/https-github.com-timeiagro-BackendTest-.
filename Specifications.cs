using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicação_WEB.Models
{
    public class Specifications
    {
        public string Originallypublished { get; set; }
        public string Author { get; set; }
        public int Pagecount { get; set; }
        public List<string> Illustrator { get; set; }
        public List<string> Genres { get; set; }
    }
}
