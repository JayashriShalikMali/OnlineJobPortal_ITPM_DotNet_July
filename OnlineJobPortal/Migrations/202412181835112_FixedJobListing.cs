namespace OnlineJobPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class FixedJobListing : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin_Actions",
                c => new
                {
                    ActionID = c.Int(nullable: false, identity: true),
                    AdminID = c.Int(nullable: false),
                    ActionDescription = c.String(),
                    ActionDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.ActionID)
                .ForeignKey("dbo.Registrations", t => t.AdminID, cascadeDelete: false) // Disabled cascade delete
                .Index(t => t.AdminID);

            CreateTable(
                "dbo.Registrations",
                c => new
                {
                    UserID = c.Int(nullable: false, identity: true),
                    Username = c.String(),
                    Email = c.String(),
                    password = c.String(),
                    your_Role = c.String(),
                })
                .PrimaryKey(t => t.UserID);

            CreateTable(
                "dbo.Applicationscs",
                c => new
                {
                    Application_Id = c.Int(nullable: false, identity: true),
                    Job_Id = c.Int(nullable: false),
                    Candidate_Id = c.Int(nullable: false),
                    Status = c.String(),
                    AppliedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Application_Id)
                .ForeignKey("dbo.Job_Listing", t => t.Job_Id, cascadeDelete: false) // Disabled cascade delete
                .ForeignKey("dbo.Registrations", t => t.Candidate_Id, cascadeDelete: false) // Disabled cascade delete
                .Index(t => t.Job_Id)
                .Index(t => t.Candidate_Id);

            CreateTable(
                "dbo.Job_Listing",
                c => new
                {
                    Job_Id = c.Int(nullable: false, identity: true),
                    Recuriter_Id = c.Int(nullable: false),
                    Job_Tittle = c.String(),
                    Company_Name = c.String(),
                    Job_Location = c.String(),
                    Job_Type = c.String(),
                    Salary = c.Int(nullable: false),
                    Description = c.String(),
                    Job_PstedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Job_Id)
                .ForeignKey("dbo.Registrations", t => t.Recuriter_Id, cascadeDelete: false) // Disabled cascade delete
                .Index(t => t.Recuriter_Id);

            CreateTable(
                "dbo.Candidate_Profile",
                c => new
                {
                    Profile_Id = c.Int(nullable: false, identity: true),
                    User_Id = c.Int(nullable: false),
                    Name = c.String(),
                    Gender = c.String(),
                    Contact_No = c.String(),
                    Address = c.String(),
                    Carrear_Prefrence = c.String(),
                    Highest_Qalification = c.String(),
                    Colleage_name = c.String(),
                    Per_Or_CGPA = c.Double(nullable: false),
                    Pass_Year = c.Int(nullable: false),
                    Course_type = c.String(),
                    twelth_Pass_Year = c.Int(nullable: false),
                    Per_Or_CGPA_twelth = c.Double(nullable: false),
                    tenth_Pass_Year = c.Int(nullable: false),
                    Per_Or_CGPA_tenth = c.Double(nullable: false),
                    key_Skills = c.String(),
                    Profile_summry = c.String(),
                    Project_Name = c.String(),
                    startDate = c.DateTime(nullable: false),
                    enddate = c.DateTime(nullable: false),
                    Details = c.String(),
                    Project_url = c.String(),
                    Comapny_Name = c.String(),
                    Duration = c.String(),
                    Project_Name_Intern = c.String(),
                    YouerRoleIntern = c.String(),
                    Upload_Resume = c.String(),
                })
                .PrimaryKey(t => t.Profile_Id)
                .ForeignKey("dbo.Registrations", t => t.User_Id, cascadeDelete: false) // Disabled cascade delete
                .Index(t => t.User_Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Candidate_Profile", "User_Id", "dbo.Registrations");
            DropForeignKey("dbo.Applicationscs", "Candidate_Id", "dbo.Registrations");
            DropForeignKey("dbo.Applicationscs", "Job_Id", "dbo.Job_Listing");
            DropForeignKey("dbo.Job_Listing", "Recuriter_Id", "dbo.Registrations");
            DropForeignKey("dbo.Admin_Actions", "AdminID", "dbo.Registrations");
            DropIndex("dbo.Candidate_Profile", new[] { "User_Id" });
            DropIndex("dbo.Job_Listing", new[] { "Recuriter_Id" });
            DropIndex("dbo.Applicationscs", new[] { "Candidate_Id" });
            DropIndex("dbo.Applicationscs", new[] { "Job_Id" });
            DropIndex("dbo.Admin_Actions", new[] { "AdminID" });
            DropTable("dbo.Candidate_Profile");
            DropTable("dbo.Job_Listing");
            DropTable("dbo.Applicationscs");
            DropTable("dbo.Registrations");
            DropTable("dbo.Admin_Actions");
        }
    }
}
