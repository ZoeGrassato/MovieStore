namespace OnlineMovieStoreV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (GenreId, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (GenreId, Name) VALUES (2, 'Thriller')");
            Sql("INSERT INTO Genres (GenreId, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (GenreId, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (GenreId, Name) VALUES (5, 'Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
