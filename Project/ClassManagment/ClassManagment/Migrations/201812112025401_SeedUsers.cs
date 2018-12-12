namespace ClassManagment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8386b54b-e62a-4865-bb65-a3fda5370a8a', N'saad@gmail.com', 0, N'ALNJmomxYsGaw8z2gioRMBR+g/HaMFTREYHWGEYsykTDI+fMjgRkn5kANvmbNfJKEQ==', N'756006f3-aa38-4dc0-a966-d43594c0ca27', NULL, 0, 0, NULL, 1, 0, N'saad@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dbe23d44-759f-4cd4-a5c7-1cace8e524f3', N'shoaib@gmail.com', 0, N'ADC2DR8AFiMiFL8gBAjufiTOhUkq1ijcco8C2XyGj7ilkdGgW9UJEpFx7lR4aFB5XA==', N'5ddc45b8-e9f6-4172-86a3-b3633e5891fd', NULL, 0, 0, NULL, 1, 0, N'shoaib@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bfdaff1d-4ea0-4f0a-a19e-639b706460d6', N'Admin')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7f2af76d-6e52-42ac-b3b7-9e1ebfaddc49', N'Student')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8386b54b-e62a-4865-bb65-a3fda5370a8a', N'7f2af76d-6e52-42ac-b3b7-9e1ebfaddc49')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dbe23d44-759f-4cd4-a5c7-1cace8e524f3', N'bfdaff1d-4ea0-4f0a-a19e-639b706460d6')

");
        }
        
        public override void Down()
        {
        }
    }
}
