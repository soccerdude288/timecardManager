using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace timecardManager.Pages
{
    public class timeCard
    {
        [Key]
        public int timeCardID { get; set; }
        public String startTime { get; set; }
        public string stopTime { get; set; }
        public int userID { get; set; }
        public float totalTime { get; set; }
        public String revisionHistory { get; set; }
        public String lastModDate { get; set; }
        public String comments { get; set; }

        //timeCardID
        //startTime
        //stopTime
        //userID
        //totalTime
        //revisionHistory
        //lastModDate
        //comments

        /*
        public timeCard()
        {
            //revisionHistory = new StringBuilder();
            //comments = new StringBuilder();
        }
        */
    }
}
