using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_App.Migrations
{
    public partial class updatingcolm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "968fb88d-8b67-4040-8cf1-b328b96f1fd0");

            migrationBuilder.AlterColumn<long>(
                name: "IBSN",
                table: "Books",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BorrowerID",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "OnLease",
                table: "Books",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Books",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Authors",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            //migrationBuilder.AddColumn<int>(
            //    name: "ReaderId",
            //    table: "Authors",
            //    nullable: true,
            //    defaultValue: 0);

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[] { "21b9732e-f610-4e51-8d5b-f9e5863c3182", "b63ced88-9d6c-4354-b135-6ef8b21aa3ff", "Admin", "ADMIN" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Authors_ReaderId",
            //    table: "Authors",
            //    column: "ReaderId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Authors_Readers_ReaderId",
            //    table: "Authors",
            //    column: "ReaderId",
            //    principalTable: "Readers",
            //    principalColumn: "ReaderId",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Readers_ReaderId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_ReaderId",
                table: "Authors");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21b9732e-f610-4e51-8d5b-f9e5863c3182");

            migrationBuilder.DropColumn(
                name: "BorrowerID",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "OnLease",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ReaderId",
                table: "Authors");

            migrationBuilder.AlterColumn<string>(
                name: "IBSN",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Authors",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "968fb88d-8b67-4040-8cf1-b328b96f1fd0", "347195ff-96e6-451f-aeb0-900581dbb164", "Admin", "ADMIN" });
        }
    }
}
