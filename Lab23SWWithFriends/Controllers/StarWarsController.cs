using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Lab23SWWithFriends.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab23SWWithFriends.Controllers
{
    public class StarWarsController : Controller
    {
        public async Task<IActionResult> GetPersonById(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");

            var response = await client.GetAsync($"people/{id}");
            var result = await response.Content.ReadAsAsync<Person>();
            
            return View(result);
        }

        public async Task<IActionResult> GetPlanetById(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");

            var response = await client.GetAsync($"planets/{id}");
            var result = await response.Content.ReadAsAsync<Planet>();

            return View(result);
        }

        public async Task<IActionResult> GetPeopleList()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");

            var response = await client.GetAsync("people");
            var result = await response.Content.ReadAsAsync<PeopleRoot>();

            return View(result);
        }

    }
}