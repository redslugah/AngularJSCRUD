using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Loja
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Rua { get; set; }
        public string Url { get; set; }
    }
}