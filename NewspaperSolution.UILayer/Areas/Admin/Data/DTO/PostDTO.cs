using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewspaperSolution.UILayer.Areas.Admin.Data.DTO
{
    public class PostDTO
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public int AppUserId { get; set; }

    }
}