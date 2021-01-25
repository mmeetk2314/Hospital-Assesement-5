using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hospital_Assesement_5.Models;

namespace Hospital_Assesement_5.Data
{
    public class Hospital_Assesement_5Context : DbContext
    {
        public Hospital_Assesement_5Context (DbContextOptions<Hospital_Assesement_5Context> options)
            : base(options)
        {
        }

        public DbSet<Hospital_Assesement_5.Models.Hospital> Hospital { get; set; }

        public DbSet<Hospital_Assesement_5.Models.Doctor> Doctor { get; set; }

        public DbSet<Hospital_Assesement_5.Models.Patient> Patient { get; set; }

        public DbSet<Hospital_Assesement_5.Models.Medicine> Medicine { get; set; }
    }
}
