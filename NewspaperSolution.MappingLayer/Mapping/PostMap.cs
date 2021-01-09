using NewspaperSolution.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSolution.MappingLayer.Mapping
{
    public class PostMap:BaseMap<Post>
    {
        public PostMap()
        {
            Property(x => x.Header).HasMaxLength(20).HasColumnName("Header");
            Property(x => x.Content).IsRequired();

            HasRequired(x => x.AppUser)
                .WithMany(x => x.Posts)
                .HasForeignKey(x => x.AppUserId)
                .WillCascadeOnDelete(false);

            HasRequired(x => x.Category)
                .WithMany(x => x.Posts)
                .HasForeignKey(x=>x.CategoryId)
                .WillCascadeOnDelete(false);

            HasMany(x => x.Comments)
                .WithRequired(x => x.Post)
                .HasForeignKey(x => x.PostId)
                .WillCascadeOnDelete(false);
        }
    }
}
