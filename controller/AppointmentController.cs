using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.controller
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RandevuKaydet()
        {
            ViewData["D"] = "MUHAMMED";
            return View("AddAppointment");

        }
        public string RouteDataBinding(int id)
        {
            return id + "";
        }
        public string QueryStringDataBinding(string isim, int yas)
        {
            return isim + " " + yas;
        }
      
        public string  RequestNoktaQueryString()
        {
            return " \r\n" + Request.QueryString.Value + " \r\n" + Request.Query["isim"] + " \r\n" + Request.Query["yas"] ;
        }
    }
    {
    public string  RequestNoktaQueryString()
    }
public string QueryStringDataBinding(string isim, int yas)
        {
            return isim + " " + yas;
        }
      
        public string  RequestNoktaQueryString()
        {
            return " \r\n" + Request.QueryString.Value + " \r\n" + Request.Query["isim"] + " \r\n" + Request.Query["yas"] ;
        }
    }
    {
    public string  RequestNoktaQueryString()
    }
public string  RequestNoktaQueryString()
        {
            return " \r\n" + Request.QueryString.Value + " \r\n" + Request.Query["isim"] + " \r\n" + Request.Query["yas"] ;
        }
    }
    {
    public string  RequestNoktaQueryString()
    }
