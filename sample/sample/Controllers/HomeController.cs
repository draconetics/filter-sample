using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using sample.Services;
using sample.Models;
using MySql.Data.MySqlClient;

namespace sample.Controllers
{
    public class Persona {
        public string nombre { get; set; }
        public int edad { get; set; }
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        /*
        public ActionResult Index()
        {
            
            string _conStr = "Server=127.0.0.1;Port=3306;Database=mydatabase;Uid=root;Pwd=root;";

            MySqlConnection _con = new MySqlConnection(_conStr);
            DataTable _table = new DataTable();
            MySqlDataAdapter _adp = new MySqlDataAdapter("select * from user", _con);
            _adp.Fill(_table);

            return View(_table);
            
        }*/
        /*
        public FileResult Index()
        {
            var ruta = Server.MapPath("rutas.pdf");
            return File(ruta, "application/pdf", "index-file.pdf");
            //return View();
        }*/
        /*
        public ActionResult Index(){
            
            return View();
        }*/

        /*
    public RedirectToRouteResult Index()
    {
        //return RedirectToAction("About", "Home");
        return RedirectToAction("About");//igual funciona
    }
    */
        /*
            public ActionResult Index()
            {
                //name of routeconfig.cs
                return RedirectToRoute("sample");
            }*/

        /*
    public HttpStatusCodeResult Index()
    {
        return new HttpStatusCodeResult(404, "this is a message");
    }*/

        public ActionResult Redirect() {
            //return Redirect("http://google.com.bo");
            return View();
        }

        /*
        public RedirectResult Redirect()
        {
            return Redirect("http://google.com.bo");
            
        }*/

        /*
    public ContentResult Name() {
        var persona01 = new Persona() { nombre="pedro", edad=2};
        return Content("Felipe");
    }*/

        /*
    public ActionResult Name(string name) {
        //if(name.HasValue)
        ViewBag.Message = "Message " + name;
        return View();
    }*/

        /*
                [HttpGet]
                public ActionResult name() {
                    ViewBag.Message = "Your NAME page";
                    return View();
                }


                [HttpPost]
                public ActionResult name(int edad) {
                    ViewBag.Message = "Your NAME page" + edad.ToString();
                    return View();
                }
                */

        public ActionResult name() {
            ViewBag.Message = "this is a message";
            ViewBag.UnInt = 45;
            ViewBag.UnaFecha = new DateTime(1800, 4, 7);

            ViewData["msg"] = "esto fue con view data";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var peliculaService = new PeliculaService();
            var model = peliculaService.obtenerPeliculas(0,0);
            return View(model);
        }

        public ActionResult Contact2()
        {
            ViewBag.Message = "Your contact page.";

            return View("Contact");
        }

        [HttpGet]
        public ActionResult BusquedaFilter()
        {
            var peliculaService = new PeliculaService();
            //if(duracion != null && anio != null)
            //ViewBag.Message = "duracion : " + duracion.ToString() + "anion : " + anio.ToString() ;

            ViewBag.listaAnios = new List<int>() { 2005, 2006, 2013, 2014, 2015 };
            ViewBag.listaDuraciones = new List<int>() { 115, 150 };

            var peliculas = peliculaService.obtenerPeliculas(0, 0);
            return View(peliculas);

        }

        [HttpPost]
        public ActionResult BusquedaFilter(int duracion, int anio) {
            var peliculaService = new PeliculaService();
            //if(duracion != null && anio != null)
            ViewBag.Message = "duracion : " + duracion.ToString() + " anio : " + anio.ToString() ;
            ViewBag.Anio = anio;
            ViewBag.Duracion = duracion;
            /*
            VistaPeliculas vistaPeliculas = new VistaPeliculas();
            vistaPeliculas.listaAnios = new List<int>() { 2005,2006,2013,2014,2015 };
            vistaPeliculas.listaDuraciones = new List<int>() { 115, 150 };
            var stringArray = new string[2] { "uno","dos" };
            ViewBag.Collection = stringArray;
            ViewData["listDuraciones"] = 
            var intArray = new int[2] { 1, 2 };
            

            vistaPeliculas.listaPeliculas = peliculaService.obtenerPeliculas(anio,duracion);
            return View(vistaPeliculas);*/
            ViewBag.listaAnios = new List<int>() { 2005, 2006, 2013, 2014, 2015 };
            ViewBag.listaDuraciones = new List<int>() { 115, 150 };

            var listaPeliculas = peliculaService.obtenerPeliculas(anio, duracion);
            return View(listaPeliculas); 

        }
    }
}