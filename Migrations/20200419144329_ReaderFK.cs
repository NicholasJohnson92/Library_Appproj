using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_App.Migrations
{
    public partial class ReaderFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.AddColumn<int>(
                name: "ReaderId",
                table: "Books",
                nullable: false,
                defaultValue: 0);

           
            migrationBuilder.CreateIndex(
                name: "IX_Books_ReaderId",
                table: "Books",
                column: "ReaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Readers_ReaderId",
                table: "Books",
                column: "ReaderId",
                principalTable: "Readers",
                principalColumn: "ReaderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Readers_ReaderId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_ReaderId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "968fb88d-8b67-4040-8cf1-b328b96f1fd0");

            migrationBuilder.DropColumn(
                name: "ReaderId",
                table: "Books");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8149292e-d030-4247-bbd2-f734dcd45ed0", "d6b98485-168c-4764-ae2e-d4adeb1ee640", "Admin", "ADMIN" });
        }
    }
}
