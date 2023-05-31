using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rectangles.Migrations
{
    /// <inheritdoc />
    public partial class Performance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Rectangles_X1_Y1_X2_Y2",
                table: "Rectangles",
                columns: new[] { "X1", "Y1", "X2", "Y2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rectangles_X1_Y1_X2_Y2",
                table: "Rectangles");
        }
    }
}
