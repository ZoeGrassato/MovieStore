namespace OnlineMovieStoreV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                
                INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc],[LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'7a223fe2-6dfb-4387-9992-73c9d0f87981', N'admin@gmail.com', 0, N'AEqfjD6lon5DmYEO3LXcdhbMgq9irhETCHI5O3Mtkkls8WS2G/Un+IOWg+5vYmOT0w==', N'95d99a47-9ee2-4972-9415-cf64177fda78', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
                
                INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'd02bf16f-c98a-4046-bfc4-852d769b9a75', N'guestuser@gmail.com', 0, N'ACzT0damOpPvHzZBnRaa9ndsZSUpkKJ27a0Gtes/Lvjgqxn1ndeMIqi3Qg+yN0bIRg==', N'4b205638-9d44-40d5-a314-310fe19d0490', NULL, 0, 0, NULL, 1, 0, N'guestuser@gmail.com')
               
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4d58efe7-ab65-4f63-bf3c-9cca31600d4b', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7a223fe2-6dfb-4387-9992-73c9d0f87981', N'4d58efe7-ab65-4f63-bf3c-9cca31600d4b')
                ");
        }

        public override void Down()
        {
        }
    }
}
