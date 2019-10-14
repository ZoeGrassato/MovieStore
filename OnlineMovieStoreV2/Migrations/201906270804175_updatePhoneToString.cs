namespace OnlineMovieStoreV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePhoneToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "PhoneNum", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "PhoneNum", c => c.Int(nullable: false));
        }
    }
}
