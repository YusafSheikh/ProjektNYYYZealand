using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using ProjektNYYYZealand.Services;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Pages.BogPage
{

        public class GetBøgerModel : PageModel

        {

            public IEnumerable<Bog> Bøger { get; set; }
            IBogservice bogservice;

            public GetBøgerModel(IBogservice service)
            {

                bogservice = service;

            }

            [BindProperty(SupportsGet = true)]

            public string Title { get; set; }



            [BindProperty(SupportsGet = true)]

            public string Forfatter { get; set; }



            [BindProperty(SupportsGet = true)] 
        public double ISBN { get; set; }



            public void OnGet()

            {

                Bøger = bogservice.GetBog(Title, Forfatter, ISBN);

            }

        }

    }






 