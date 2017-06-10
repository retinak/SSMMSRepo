using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;
using SASSMMS.Domain.Entities;
using SASSMMS.Repository.EntityConfiguration;


namespace SASSMMS.Repository
{
   public class MainContext : DbContext 
    {
        public MainContext()
            : base("SASSMSContext")
        {
            //Database.SetInitializer<SASSMSContext>(null);


        }

        public DbSet<Division> Divisions { get; set; }
        public DbSet<Comment> Comments { get; set; } 
        public DbSet<Member> Members { get; set; }
        public DbSet<Attendance> Attendances { get; set; } 
        public DbSet<TemporaryClassA> TemporaryClassA { get; set; }
        public DbSet<TemporaryMember> TemporaryMembers { get; set; }
        public DbSet<PermanetMember> PermanetMembers { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Address> Addresses { get; set; } 
        public DbSet<Woreda> Woredas { get; set; } 
        public DbSet<Subcity> Subcities { get; set; } 
        public DbSet<Category> CategoryLevels { get; set; }
        public DbSet<Parent> Parents { get; set; } 
      //  public DbSet<Applicant> Applicants { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<MemberOccupation> MemberOccupations { get; set; } 
        public DbSet<MemberQualification> MemberQualifications { get; set; } 
        public DbSet<MemberCategory> MemberCategories { get; set; }
        public DbSet<MemberPosition> MemberPositions { get; set; } 
        public DbSet<MemberStatus>MemberStatuses { get; set; } 
        public DbSet<Club> Clubs { get; set; } 
        public DbSet<ClubMember>ClubMembers { get; set; } 
        //public DbSet<AppUser> AppUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Member>().HasRequired(d => d.Division).WithMany().HasForeignKey(fk => fk.DivisionId).WillCascadeOnDelete(false);
            
            modelBuilder.Conventions.Add<PluralizingTableNameConvention>();
           
            //modelBuilder.Entity<Member>().HasMany(q => q.Statuses).WithMany(m => m.Members)
            //    .Map(mq =>
            //    {
            //        mq.MapLeftKey("MemberId");
            //        mq.MapRightKey("StatusId");
                
            //    });
       
        }

        
    }
}
