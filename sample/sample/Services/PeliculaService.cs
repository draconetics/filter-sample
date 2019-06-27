using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sample.Models;

namespace sample.Services
{
    public class PeliculaService
    {
        public Pelicula obtenerPelicula() {
            return new Pelicula()
            {
                titulo = "Spiderman, far from home.",
                duracion = 115,
                pais = "usa",
                publicacion = new DateTime(2013, 12, 5)
            };
        }

        public List<Pelicula> obtenerPeliculas(int anio, int duracion) {
            var pelicula01 = new Pelicula()
            {
                titulo = "Spiderman, far from home.",
                duracion = 115,
                pais = "usa",
                publicacion = new DateTime(2013, 12, 5)
            };

            var pelicula02 = new Pelicula()
            {
                titulo = "Batman",
                duracion = 150,
                pais = "Sweden",
                publicacion = new DateTime(2014, 12, 5)
            };

            var pelicula03 = new Pelicula()
            {
                titulo = "Avengers",
                duracion = 115,
                pais = "England",
                publicacion = new DateTime(2015, 12, 5)
            };
            var pelicula04 = new Pelicula()
            {
                titulo = "Big bang theory",
                duracion = 115,
                pais = "Portugal",
                publicacion = new DateTime(2005, 12, 5)
            };
            var pelicula05 = new Pelicula()
            {
                titulo = "Flash",
                duracion = 150,
                pais = "Spain",
                publicacion = new DateTime(2006, 12, 5)
            };

            var list = new List<Pelicula> { pelicula01, pelicula02, pelicula03, pelicula04, pelicula05 };
            var selected = new List<Pelicula>();

            foreach (var item in list)
            {
                if (duracion == 0 && anio == 0)
                {
                    selected.Add(item);
                }
                else {
                    if (duracion > 0 && anio > 0)
                    {
                        if (item.duracion == duracion && item.publicacion.Year == anio)
                        {
                            selected.Add(item);
                        }
                    }
                    else {
                        if (duracion == 0 && anio == item.publicacion.Year)
                        {
                            selected.Add(item);
                        }
                        else
                        {
                            if (anio == 0 && duracion == item.duracion)
                                selected.Add(item);
                        }
                    }
                }
            }
            return selected;
        }
    }
}