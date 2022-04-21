using Microsoft.EntityFrameworkCore.Migrations;

namespace BookTrackingApp.Migrations.Context_CategoryMigrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryType",
                columns: table => new
                {
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryType", x => x.Type);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    NameToken = table.Column<string>(type: "TEXT", nullable: false),
                    TypeID = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryTypeType = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.NameToken);
                    table.ForeignKey(
                        name: "FK_Category_CategoryType_CategoryTypeType",
                        column: x => x.CategoryTypeType,
                        principalTable: "CategoryType",
                        principalColumn: "Type",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryTypeType",
                table: "Category",
                column: "CategoryTypeType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "CategoryType");
        }
    }
}
