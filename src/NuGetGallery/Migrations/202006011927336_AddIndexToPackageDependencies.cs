﻿namespace NuGetGallery.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddIndexToPackageDependencies : DbMigration
    {
        public override void Up()
        {
            Sql("CREATE NONCLUSTERED INDEX [IX_PackageDependencies_Id] ON [dbo].[PackageDependencies] ([Id]) INCLUDE ([PackageKey]) WITH (ONLINE = ON)");
        }

        public override void Down()
        {
            DropIndex(table: "PackageDependencies", name: "IX_PackageDependencies_Id");
        }
    }
}