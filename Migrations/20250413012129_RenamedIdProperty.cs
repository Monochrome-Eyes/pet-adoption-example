using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace midterm_project.Migrations
{
    /// <inheritdoc />
    public partial class RenamedIdProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Pet",
                newName: "ImgUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImgUrl",
                table: "Pet",
                newName: "Url");
        }
    }
}
