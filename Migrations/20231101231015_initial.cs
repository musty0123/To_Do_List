using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace To_Do_List.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    task = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecievedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "tasks",
                columns: new[] { "Id", "DueDate", "IsCompleted", "RecievedTime", "task" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 1, 23, 10, 15, 347, DateTimeKind.Local).AddTicks(1766), false, new DateTime(2023, 11, 1, 23, 10, 15, 347, DateTimeKind.Local).AddTicks(1726), "Do the laundry" },
                    { 2, new DateTime(2023, 11, 8, 23, 10, 15, 347, DateTimeKind.Local).AddTicks(1772), false, new DateTime(2023, 11, 1, 23, 10, 15, 347, DateTimeKind.Local).AddTicks(1770), "Watch all episodes of One Piece" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tasks");
        }
    }
}
