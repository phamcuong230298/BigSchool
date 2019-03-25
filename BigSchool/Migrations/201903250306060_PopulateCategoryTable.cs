namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES (1,'DEVELOPMENT')");
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES (2,'MARKETING')");
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES (3,'BUSINESS')");
        }
        
        public override void Down()
        {
        }
    }
}
