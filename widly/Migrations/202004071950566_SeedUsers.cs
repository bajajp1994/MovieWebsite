namespace Widly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'048e38f8-288a-4ddf-bea4-ba63aca384b9', N'pinkrose5894@gmail.com', 0, N'AJzPWmuI5+CLgAuUg/2eK0u7ReDrb7/Bnegi6xJnc9cFweRdu2jxPReF9c2zplx2Mg==', N'9cd97bef-ab37-466f-9d10-96b4aed549d2', NULL, 0, 0, NULL, 1, 0, N'pinkrose5894@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8c5dcd31-5b39-4dd7-90b5-a0d83831b846', N'admin@vidly.com', 0, N'ANvwmYSunwJ0yUkB8X6uxpQ+qWItOVbKOKYmutJCQcy+oH0re8wkOlK5jko+3/vurQ==', N'2c2927e7-718e-40a3-bcb4-d7380761d6e4', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b403e93f-a936-4d97-829e-b4da17828c6f', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8c5dcd31-5b39-4dd7-90b5-a0d83831b846', N'b403e93f-a936-4d97-829e-b4da17828c6f')

");
        }
        
        public override void Down()
        {
        }
    }
}
