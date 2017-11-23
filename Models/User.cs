using System;
namespace timecardManager.Pages
{
    public class User
    {
        public String name;
        public String username;
        public int userID;
        public bool isAdmin;
        public int groupID;

        public User(int userID, String name)
        {
            this.userID = userID;
            this.name = name;
        }
    }
}
