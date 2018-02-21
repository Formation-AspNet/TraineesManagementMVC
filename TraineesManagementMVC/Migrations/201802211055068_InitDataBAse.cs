namespace TraineesManagementMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDataBAse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trainees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.GroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trainees", "GroupId", "dbo.Groups");
            DropIndex("dbo.Trainees", new[] { "GroupId" });
            DropTable("dbo.Trainees");
            DropTable("dbo.Groups");
        }
    }
}
