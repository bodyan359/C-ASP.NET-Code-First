using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudiesId",
                table: "Persons",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "Name", "OwnerIdOwner" },
                values: new object[] { 1, 0, "test", null });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_StudiesId",
                table: "Persons",
                column: "StudiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Studies_StudiesId",
                table: "Persons",
                column: "StudiesId",
                principalTable: "Studies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Studies_StudiesId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_StudiesId",
                table: "Persons");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "StudiesId",
                table: "Persons");
        }
    }
}
