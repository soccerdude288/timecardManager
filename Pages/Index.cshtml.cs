using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using timecardManager.Models;

namespace timecardManager.Pages
{
    public class IndexModel : PageModel
    {
        

        public void OnGet()
        {
            DBHelper dbhelper = new DBHelper();
            User newUser = new User();
        }
    }
}
