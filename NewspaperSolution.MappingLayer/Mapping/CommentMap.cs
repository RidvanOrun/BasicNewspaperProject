using NewspaperSolution.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSolution.MappingLayer.Mapping
{
    public class CommentMap:BaseMap<Comment>
    {
        public CommentMap()
        {
            Property(x => x.CommentText).HasMaxLength(250).IsRequired();

            HasRequired(x => x.AppUser)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.AppUserId)
                .WillCascadeOnDelete(false);

            HasRequired(x => x.Post)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.PostId)
                .WillCascadeOnDelete(false);


            
        }
    }
}
