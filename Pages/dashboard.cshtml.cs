using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using timecardManager.Models;

namespace timecardManager.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }
        public List<String> testList { get; set; }
        public List<timeCard> timeCardList { get; set; }
        public List<Project> allProjects { get; set; }
        public List<Group> projectGroups { get; set; }
        public List<User> groupUsers { get; set; }

        public void OnGet()
        {
            Message = "Your contact page.";
            testList = new List<string>();
            testList.Add("test1");
            testList.Add("test2");
            testList.Add("test3");
            timeCardList = new List<timeCard>();
            /*
            for (int i = 0; i < 10; i++){
                Timecard tc = new Timecard();
                tc.comments.Append("testing + " + i);
                tc.endDateTime = "11/17/17";
                tc.startDateTime = "11/16/17";
                tc.timeCardID = i;
                tc.userID = i + 10;
                timeCardList.Add(tc);
            }
            */
            DBHelper dbhelp = new DBHelper();
            timeCard tc = new timeCard();
            tc.comments = "testing";
            tc.stopTime = "11/17/17";
            tc.startTime = "11/16/17";
            tc.timeCardID = 111111;
            tc.userID = 13;
            dbhelp.insertTimeCard(tc);
            timeCardList = dbhelp.getAllUserTimeCard("13");
            allProjects = dbhelp.getAllProject();


        }
    }
}
