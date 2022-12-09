using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using ProjektNYYYZealand.Services;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Pages.BogPage
{

        public class GetB�gerModel : PageModel

        {

            public IEnumerable<Bog> B�ger { get; set; }
            IBogservice bogservice;

            public GetB�gerModel(IBogservice service)
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

                B�ger = bogservice.GetBog(Title, Forfatter, ISBN);

            }

        }

    }






 