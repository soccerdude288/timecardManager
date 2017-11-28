using System;
using System.ComponentModel.DataAnnotations;

namespace timecardManager.Pages
{
    public class Group
    {
        [Key]
        public int groupID { get; set;}
        public String name { get; set; }
        public bool isActive { get; set; }

        /*
        public Group()
        {
            groupID = 0;
            name = null;
            isActive = false;
        }
        */
    }
}
