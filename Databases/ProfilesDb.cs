using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BucketListServer.Databases;

public class ProfilesDb : DbContext
{
    public DbSet<Profile> Users { get; set; }
 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.OpenConnect("users");
    }
}