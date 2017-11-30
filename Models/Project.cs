using System;
using System.ComponentModel.DataAnnotations;

namespace timecardManager.Pages
{
    public class Project
    {
        public String name { get; set; }
        [Key]
        public int projectID { get; set; }
        public int activeStatus { get; set; }

        /*
        public Project()
        {
            name = null;
            projectID = 0;
            isActive = false;
        }
        */
    }
}
