using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSolution.EntityLayer.Entities.Interface
{
    public interface IBaseEntity<T>
    {
        T id { get; set; }
    }
}
