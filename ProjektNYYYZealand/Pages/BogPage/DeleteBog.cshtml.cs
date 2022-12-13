using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;

namespace ProjektNYYYZealand.Pages.BogPage
{
    public class DeleteBogModel : PageModel
    {
        public DeleteBogModel(IBogservice service)
        {
            bogservice = service;
        }

        IBogservice bogservice;
        [BindProperty]
        public Bog bog { get; set; }
        public void OnGet(int sid)
        {
            bog = IBogservice.GetBogs(sid);
        }

        public IActionResult OnPost(int sid)
        {
            bogservice.DeleteBog(sid);
            return RedirectToPage("GetBøger");
        }
    }
}