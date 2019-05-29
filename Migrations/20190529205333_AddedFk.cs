using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class AddedFk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerIdOwner",
                table: "Animals",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animals_OwnerIdOwner",
                table: "Animals",
                column: "OwnerIdOwner");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Owners_OwnerIdOwner",
                table: "Animals",
                column: "OwnerIdOwner",
                principalTable: "Owners",
                principalColumn: "IdOwner",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Owners_OwnerIdOwner",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_OwnerIdOwner",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "OwnerIdOwner",
                table: "Animals");
        }
    }
}
