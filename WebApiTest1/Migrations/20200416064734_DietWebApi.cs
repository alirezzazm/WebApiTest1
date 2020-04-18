using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiTest1.Migrations
{
    public partial class DietWebApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DietApi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameDiet = table.Column<string>(nullable: true),
                    ImageDiet = table.Column<string>(nullable: true),
                    ValueDiet = table.Column<string>(nullable: true),
                    PropertiesDiet = table.Column<string>(nullable: true),
                    IngredientDiet = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietApi", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DietApi");
        }
    }
}
