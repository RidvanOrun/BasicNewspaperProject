using NewspaperSolution.EntityLayer.Entities.Interface;
using NewspaperSolution.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSolution.EntityLayer.Entities.Concrete
{
    public class BaseEntity : IBaseEntity<int>
    {
        public int id { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get=>_createDate; set=>_createDate=value; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? PassiveDate { get; set; }

        private Status _status=Status.Active;
        public Status status { get=>_status; set=>_status=value; }
     
    }
}
