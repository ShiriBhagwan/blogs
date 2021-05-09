using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PostAndBlogging.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "ID", "Content", "CreationDate", "Email", "Title", "Updatedate" },
                values: new object[] { 1L, "Why should go North India", new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "sachinjain9891@gmail.com", "Travelling", new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "ID", "Content", "CreationDate", "Email", "Title", "Updatedate" },
                values: new object[] { 2L, "popular India Street food", new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "sachinjain9891@gmail.com", "Foodie", new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
