using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using TraversalCoreProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;


namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [AllowAnonymous]
    public class BookingHotelSearchController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<BookingHotelSearchViewModel> bookingHotelSearchViews = new List<BookingHotelSearchViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?dest_id=-1456928&order_by=popularity&checkout_date=2025-01-19&children_number=2&filter_by_currency=AED&locale=en-gb&dest_type=city&checkin_date=2025-01-18&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_ages=5%2C0&include_adjacency=true&page_number=0&adults_number=2&room_number=1&units=metric"),
                Headers =
    {
        { "x-rapidapi-key", "346952ad39msh7c6fa779b7c03ccp1d1f3ajsnaf29fa8a1e4e" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values  = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(body);
                return View(values.results);
            }
        }





        [HttpGet]
        public IActionResult GetCityDestID()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> GetCityDestID(string p)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=en-gb&name={p}"),
                Headers =
    {
        { "x-rapidapi-key", "346952ad39msh7c6fa779b7c03ccp1d1f3ajsnaf29fa8a1e4e" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                return View();
            }
        }









    }
}
