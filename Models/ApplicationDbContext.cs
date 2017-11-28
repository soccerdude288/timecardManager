using System;
using Microsoft.EntityFrameworkCore;
using timecardManager.Models;
using timecardManager.Pages;

namespace timecardManager.Models
{

    //Group
    //Project
    //User
    //timeCard
        //timeCardID
        //startTime
        //stopTime
        //userID
        //totalTime
        //revisionHistory
        //lastModDate
        //comments


    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<timeCard> Timecards { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
