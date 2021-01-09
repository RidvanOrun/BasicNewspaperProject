using NewspaperSolution.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSolution.MappingLayer.Mapping
{
    public class AppUserMap:BaseMap<AppUser>
    {
        public AppUserMap()
        {
            Property(x => x.FirstName).HasColumnName("First Name").HasMaxLength(20).IsRequired();
            Property(x => x.LastName).HasColumnName("Last Name").HasMaxLength(20).IsRequired();
            Property(x => x.UserName).HasColumnName("User Name").HasMaxLength(20).IsRequired();
            Property(x => x.Password).HasMaxLength(10).HasColumnName("Password").IsRequired();
            Property(x => x.Role).HasColumnName("Role").IsRequired();

            HasMany(x => x.Posts) 
                .WithRequired(x => x.AppUser)
                .HasForeignKey(x => x.AppUserId)
                .WillCascadeOnDelete(false); //Db ile kendi oluştruduğumuz mapping arasıdan çatışma yaşanmaması için kullanılmıştır.

            HasMany(x => x.Comments)
                .WithRequired(x => x.AppUser)
                .HasForeignKey(x => x.AppUserId)
                .WillCascadeOnDelete(false);
        }
    }
}
