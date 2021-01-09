using NewspaperSolution.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSolution.MappingLayer.Mapping
{
    public class BaseMap<T>:EntityTypeConfiguration<T> where T:BaseEntity
    {
        public BaseMap()
        {
            // Id Identity verildi.
            Property(x => x.id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            // CreateDate boş geçilmez olarak atandı.
            Property(x => x.CreateDate).IsRequired();
            // Modified nullable olarak atandı.
            Property(x => x.ModifiedDate).IsOptional();
        
            Property(x => x.PassiveDate).IsOptional();
            //Status boş geçilemez olarak atandı.
            Property(x => x.status).IsRequired();
        }

    }

}
