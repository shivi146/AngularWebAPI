using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using VisaTracking.Models;

namespace VisaTracking.DBContext
{
    public class ApplContext : DbContext
    {
        public DbSet<VisaDetails> VisaDetails { get; set; }
    }
}