namespace ClassManagment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        Fid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ContactNo = c.String(nullable: false),
                        EmailId = c.String(nullable: false),
                        Salary = c.Int(nullable: false),
                        Lecture = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Fid);
            
            CreateTable(
                "dbo.Holidays",
                c => new
                    {
                        Holidayid = c.Int(nullable: false, identity: true),
                        Holiday1 = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Holidayid);
            
            CreateTable(
                "dbo.Lectures",
                c => new
                    {
                        Lid = c.Int(nullable: false, identity: true),
                        Lect = c.String(nullable: false),
                        TeacherName = c.String(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Days = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Lid);
            
            CreateTable(
                "dbo.Notices",
                c => new
                    {
                        Eventid = c.Int(nullable: false, identity: true),
                        EventName = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Eventid);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Secid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Secid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sections");
            DropTable("dbo.Notices");
            DropTable("dbo.Lectures");
            DropTable("dbo.Holidays");
            DropTable("dbo.Faculties");
        }
    }
}
