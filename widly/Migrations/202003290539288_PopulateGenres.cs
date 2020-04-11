namespace Widly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(GenreName) VALUES('ACTION')");
            Sql("INSERT INTO Genres(GenreName) VALUES('COMEDY')");
            Sql("INSERT INTO Genres(GenreName) VALUES('FAMILY')");
            Sql("INSERT INTO Genres(GenreName) VALUES('ROMANCE')");

        }

        public override void Down()
        {
        }
    }
}
