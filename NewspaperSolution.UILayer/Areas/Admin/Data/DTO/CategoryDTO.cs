using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewspaperSolution.UILayer.Areas.Admin.Data.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must to type into category name")]
        public string Name { get; set; }

    }
}