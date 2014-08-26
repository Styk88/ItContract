using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItContract.Data.Models;

namespace ItContract.Data
{
    public class ItContractContext :  DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<CandidateWorkExperience> CandidateWorkExperiences { get; set; }

        public ItContractContext() : base("ItContractConnectionString") 
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
