using Contact_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact_API.Data
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options){}

        public DbSet<User> Users { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<PersonnalSkill> PersonnalSkills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PersonnalSkill>()
                .HasKey(ps => new { ps.PersonId, ps.SkillId });

            modelBuilder.Entity("Contact_API.Models.PersonnalSkill", b =>
            {
                b.HasOne("Contact_API.Models.Person", "Person")
                    .WithMany("PersonnalSkills")
                    .HasForeignKey("PersonId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
                b.HasOne("Contact_API.Models.Skill", "Skill")
                    .WithMany("PersonnalSkills")
                    .HasForeignKey("SkillId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });
        }
    }
}
