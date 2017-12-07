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
        
        public DBHelper dbhelper { get; set; }
        public User newUser { get; set; }

        public void OnGet()
        {
            dbhelper = new DBHelper();
            newUser = new User();

        }
    }
}
