namespace OnlineMovieStoreV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePhoneNumbertoInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "PhoneNum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "PhoneNum", c => c.Byte(nullable: false));
        }
    }
}
