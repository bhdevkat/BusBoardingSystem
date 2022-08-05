using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusBoardingSystem.Migrations
{
    public partial class studentDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Students_PersonId",
                table: "Students",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_People_PersonId",
                table: "Students",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_People_PersonId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_PersonId",
                table: "Students");
        }
    }
}
