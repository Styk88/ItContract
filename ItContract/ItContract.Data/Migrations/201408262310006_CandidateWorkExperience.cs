namespace ItContract.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CandidateWorkExperience : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CandidateWorkExperiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        DateStart = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CandidateWorkExperiences");
        }
    }
}
