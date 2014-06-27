using FluentMigrator;

namespace DBMigration
{
    [Migration(1)]
    public class Create_Driver_Table : Migration
    {
        private const string TableName = "Driver";

        public override void Up()
        {
            Create.Table(TableName)
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Name").AsString(32).NotNullable()
                .WithColumn("CarNumber").AsString(9).NotNullable()
                .WithColumn("IdNumber").AsString(20).NotNullable()
                .WithColumn("PhoneNumber").AsString(15).NotNullable();
        }

        public override void Down()
        {
            Delete.Table(TableName);
        }
    }
}
