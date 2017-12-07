using System;
using System.ComponentModel.DataAnnotations;

namespace timecardManager.Pages
{
    public class User
    {
        public String name { get; set; }
        public String username { get; set; }
        [Key]
        public int userID { get; set; }
        public int isAdmin { get; set; }
        public String password { get; set; }

        //In a different class
        //public int groupID { get; set; }

        /*
        public User(int userID, String name)
        {
            this.userID = userID;
            this.name = name;
        }
        */
    }
}
