using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineJobPortal.Models
{
    public class Candidate_Profile
    {
        [Key] 
        public int Profile_Id { get; set; }
        public int User_Id { get; set; }  //(Foreign key from registration table)
        // Navigation property
        [ForeignKey("User_Id")] public virtual Registration Registration { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Contact_No { get; set; }
        public string Address { get; set; }
        public string Carrear_Prefrence { get; set; }//job or Internshippublic string Preferd_Work_location { get; set; }
        public string Highest_Qalification { get; set; }
        public string Colleage_name { get; set; }
        public Double Per_Or_CGPA { get; set; }
        public int Pass_Year { get; set; }
        public string Course_type { get; set; }
        public int twelth_Pass_Year { get; set; }
        public Double Per_Or_CGPA_twelth { get; set; }
        public int tenth_Pass_Year { get; set; }
        public Double Per_Or_CGPA_tenth { get; set; }
        public string key_Skills { get; set; }
        public string Profile_summry { get; set; }
        public string Project_Name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime enddate { get; set; }
        public string Details { get; set; }
        public string Project_url { get; set; }//optional

        public string Comapny_Name { get; set; }
        public string Duration { get; set; }
        public string Project_Name_Intern { get; set; }
        public string YouerRoleIntern { get; set; }
        public string Upload_Resume { get; set; }
    }
}