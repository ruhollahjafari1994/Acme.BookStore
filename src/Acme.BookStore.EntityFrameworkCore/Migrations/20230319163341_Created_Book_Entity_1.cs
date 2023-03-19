using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.BookStore.Migrations
{
    /// <inheritdoc />
    public partial class CreatedBookEntity1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppYourEntities",
                table: "AppYourEntities");

            migrationBuilder.RenameTable(
                name: "AppYourEntities",
                newName: "AppBooks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppBooks",
                table: "AppBooks",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppBooks",
                table: "AppBooks");

            migrationBuilder.RenameTable(
                name: "AppBooks",
                newName: "AppYourEntities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppYourEntities",
                table: "AppYourEntities",
                column: "Id");
        }
    }
}
