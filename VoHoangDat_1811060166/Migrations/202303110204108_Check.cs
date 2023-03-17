namespace VoHoangDat_1811060166.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Check : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Courses", new[] { "LecturerID" });
            DropIndex("dbo.Courses", new[] { "CategoryID" });
            CreateIndex("dbo.Courses", "LecturerId");
            CreateIndex("dbo.Courses", "CategoryId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Courses", new[] { "CategoryId" });
            DropIndex("dbo.Courses", new[] { "LecturerId" });
            CreateIndex("dbo.Courses", "CategoryID");
            CreateIndex("dbo.Courses", "LecturerID");
        }
    }
}
