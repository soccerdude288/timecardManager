using System;
using System.Text;
namespace timecardManager.Pages
{
    public class Timecard
    {
        public int timeCardID { get; set; }
        public String startDateTime { get; set; }
        public string endDateTime { get; set; }
        public int userID { get; set; }
        public float totalTime { get; set; }
        public StringBuilder revisionHistory { get; set; }
        public String lastModDate { get; set; }
        public StringBuilder comments { get; set; }

        public Timecard()
        {
            revisionHistory = new StringBuilder();
            comments = new StringBuilder();
        }
    }
}
