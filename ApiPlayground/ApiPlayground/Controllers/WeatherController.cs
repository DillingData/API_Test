using Microsoft.AspNetCore.Mvc;
using ApiPlayground.Models;
using System.Net.Http;
using System.Text.Json;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Diagnostics;

namespace ApiPlayground.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {

            Root? root = new Root();

            //string lat = null;
            var lat = HttpContext.Session.GetString("LAT");
            var longt = HttpContext.Session.GetString("LONGT");

            string apiKey = "bef904c9d4916fca8184a376a9534a49";

            if(lat == null || longt == null)
            {
                return RedirectToAction("LocationError", "Error");
            } else
            {
                try
                {
                    //Request for OneCallAPI
                    var requestURI = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat=" + lat + "&lon=" + longt + "&units=metric&appid=" + apiKey);
                    var request = WebRequest.Create(requestURI);
                    var response = request.GetResponse();

                    Stream stream = response.GetResponseStream();
                    Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                    StreamReader readstream = new StreamReader(stream, encode);
                    string s = readstream.ReadToEnd();

                    try
                    {
                        root = JsonConvert.DeserializeObject<Root>(s);

                        return View(root);
                    }
                    catch
                    {
                        return RedirectToAction("JSONError", "Error");
                    }

                }
                catch
                {
                    return RedirectToAction("APIError", "Error");
                }

            }
        }

        public void StoreCoord(string lat, string longt)
        {
            HttpContext.Session.SetString("LAT", lat);
            HttpContext.Session.SetString("LONGT", longt);
            Debug.WriteLine("Data saved in session");
        }
    }
}
