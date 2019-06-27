using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sample.Models
{
    public class VistaPeliculas
    {
        public List<Pelicula> listaPeliculas { get; set; }
        public List<int> listaDuraciones { get; set; }
        public List<int> listaAnios { get; set; }
    }
}