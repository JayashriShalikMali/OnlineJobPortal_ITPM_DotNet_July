using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineJobPortal.Models
{
    public class Registration
    {
        [Key] 
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string your_Role { get; set; } // candidate / recruter / admin
    }
}