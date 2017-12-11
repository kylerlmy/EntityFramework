namespace EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyCourseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Score", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Score");
        }
    }
}
