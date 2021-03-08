using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projekt.Models;
using Microsoft.EntityFrameworkCore;

namespace Projekt.Data
{
    public class baza_danychContext : DbContext
    {
            public baza_danychContext(DbContextOptions<baza_danychContext> options) : base(options)
            {

            }
            public DbSet<Tasks> tasks { get; set; }
            public DbSet<holdTime> holdTime { get; set; }
            public DbSet<Admini> admini { get; set; }
            public DbSet<Userzy> userzy { get; set; }
    }
}
