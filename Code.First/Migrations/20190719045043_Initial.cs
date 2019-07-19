using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Code.First.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "library");

            migrationBuilder.CreateTable(
                name: "Authors",
                schema: "library",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                schema: "library",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Language = table.Column<string>(type: "varchar(200)", nullable: true),
                    PageNumbers = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalSchema: "library",
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "library",
                table: "Authors",
                columns: new[] { "Id", "LastName", "Name" },
                values: new object[] { 111, "Martin", "Robert" });

            migrationBuilder.InsertData(
                schema: "library",
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Language", "PageNumbers", "Title" },
                values: new object[] { 1, 111, "English", 100, "Clean Architecture" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                schema: "library",
                table: "Books",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books",
                schema: "library");

            migrationBuilder.DropTable(
                name: "Authors",
                schema: "library");
        }
    }
}
