namespace MyVidleyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6676579d-8d1e-422b-9acd-041a0d640097', N'Admin@vidly.com', 0, N'AGENR3mb/CMnJUbm+z6jGjOKBq7xyNVN3jtBoymhlbDEgB3M+hqzWEdyoD/0H8luNA==', N'5ff4744c-7ef7-4991-bb18-77a4d2f31a19', NULL, 0, 0, NULL, 1, 0, N'Admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a1b0592a-59a3-46e3-8942-150d0ec1cb27', N'guest@vidly.com', 0, N'AOh33Hh6PPwNjV2K44n/L+DghFuqBp96rYz48CEB+eaGPXceK4IXacKYanEg9PhEfw==', N'8d1540b2-39ce-40bf-9c31-fa047d4601ac', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'70630ae8-966a-4db6-a4b1-f3d1d25b3eb5', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6676579d-8d1e-422b-9acd-041a0d640097', N'70630ae8-966a-4db6-a4b1-f3d1d25b3eb5')

");
        }
        
        public override void Down()
        {
        }
    }
}
