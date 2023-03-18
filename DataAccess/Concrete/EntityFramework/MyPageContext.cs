using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class MyPageContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=BURAK;Database=MyPage;Trusted_Connection=True");
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogImage> BlogImages { get; set; }
        public DbSet<AboutMe> AboutMes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillImage> SkillImages { get; set; }
        public DbSet<WelcomePage> WelcomePages { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectImage> ProjectImages { get; set; }
    }
}
