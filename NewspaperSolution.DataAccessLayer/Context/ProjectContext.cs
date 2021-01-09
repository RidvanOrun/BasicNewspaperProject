using NewspaperSolution.EntityLayer.Entities.Concrete;
using NewspaperSolution.MappingLayer.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSolution.DataAccessLayer.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-8318CGB\MSSQLSERVER01; Database=NewsPaper; Integrated Security=True;";
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }

        // "OnModelCreating" methodu Mapping işlemlerinin db ye aktarılması için kullanılır.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new PostMap());
            modelBuilder.Configurations.Add(new CommentMap());

            modelBuilder.Properties<DateTime>().Configure(x => x.HasColumnType("datetime2")); // oluşturduğumuz datetime tipindeki veriler db ye datetime 2 olarak kayıt edilecektir.

            base.OnModelCreating(modelBuilder);
        }

    }
}
