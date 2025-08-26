using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using CODECRAFT_FS_01.Models;

namespace CODECRAFT_FS_01.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }
        public DbSet<UserModel> Users { get; set; }
    }
}
