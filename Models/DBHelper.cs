using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using timecardManager.Pages;

namespace timecardManager.Models
{
    public class DBHelper
    {
        public DbContextOptionsBuilder<ApplicationDbContext> optionsBuilder;

        public DBHelper()
        {
            optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source=myDatabase.db");
        }

        public List<timeCard> getAllTimeCard(){
            using (var db = new ApplicationDbContext(optionsBuilder.Options))
            {
                List<timeCard>timeCardList = new List<timeCard>();
                timeCardList = db.Timecards.FromSql("SELECT * FROM timeCard").ToList();
                return timeCardList;
            }
        }
        //timeCardID
        //startTime
        //stopTime
        //userID
        //totalTime
        //revisionHistory
        //lastModDate
        //comments
        public List<timeCard> getAllUserTimeCard(String userID)
        {
            using (var db = new ApplicationDbContext(optionsBuilder.Options))
            {
                List<timeCard> timeCardList = new List<timeCard>();
                timeCardList = db.Timecards.FromSql("SELECT * FROM timeCard WHERE userID = {0}", userID).ToList();
                return timeCardList;
            }
        }
    }
}
