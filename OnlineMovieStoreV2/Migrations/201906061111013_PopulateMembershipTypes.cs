namespace OnlineMovieStoreV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee,Name, DurationInMonths, DiscountRate) VALUES (1, 0, 'Pay as you go', 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee,Name, DurationInMonths, DiscountRate) VALUES (2, 30, 'Monthly', 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee,Name, DurationInMonths, DiscountRate) VALUES (3, 90, 'Quarterly', 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee,Name, DurationInMonths, DiscountRate) VALUES (4, 300, 'Annual', 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
