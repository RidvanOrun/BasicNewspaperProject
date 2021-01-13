using NewspaperSolution.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewspaperSolution.UILayer.Areas.Admin.Data.DTO
{
    public class AppUserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public string ImagePath { get; set; }
        public string UserImage { get; set; }
        public string XSmallUserImage { get; set; }
        public string CruptedUserImage { get; set; }

    }
}