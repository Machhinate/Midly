namespace Midly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bc4c55ae-9b75-4117-acdd-f9c93c066db3', N'admin@midly.com', 0, N'ADmpPacJGbmtUXdttGgXcbvAd4Z87dZyJz02QJ9+716yMp9H4bRbMT/XCmx6XCKIZQ==', N'a08b42ad-42d8-49de-8dee-88f5b51be09d', NULL, 0, 0, NULL, 1, 0, N'admin@midly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ef0b1a39-c2a2-44e2-95d4-3a7e6961d453', N'Guest@Midly.com', 0, N'ACXZX8lL1LL0XIKz4w6rMbJbX3WlA2Lq+AxILZJCzYLO57Icq3PNYY86uPSq4c53yQ==', N'03563c4c-8c0e-428f-b1dc-afb2c5f6fb29', NULL, 0, 0, NULL, 1, 0, N'Guest@Midly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'165a70c9-8503-4cbe-8317-1639e144e8b6', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bc4c55ae-9b75-4117-acdd-f9c93c066db3', N'165a70c9-8503-4cbe-8317-1639e144e8b6')

");
        }
        
        public override void Down()
        {
        }
    }
}
