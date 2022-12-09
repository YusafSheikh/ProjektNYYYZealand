using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using System.Collections;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Pages.UnderviserPage
{
    public class GetUnderviserModel : PageModel
    {
       IEnumerable<Underviser> Undervisers { get; set; }

        IUnderviserService service;
        public GetUnderviserModel(IUnderviserService services)
        {
            this.service = services;
        }

        public void OnGet()
        {
            Undervisers = this.service.GetUnderviser();
        }
    }
}
