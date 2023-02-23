using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission8.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    TaskID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TaskName = table.Column<string>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: true),
                    Quadrant = table.Column<int>(nullable: false),
                    Completed = table.Column<bool>(nullable: false),
                    CategoryID = table.Column<string>(nullable: true),
                    CategoryNameCategoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.TaskID);
                    table.ForeignKey(
                        name: "FK_responses_Category_CategoryNameCategoryID",
                        column: x => x.CategoryNameCategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Home" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "School" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Work" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 4, "Church" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "TaskID", "CategoryID", "CategoryNameCategoryID", "Completed", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 1, "2", null, false, null, 1, "Study for 404 midterm" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "TaskID", "CategoryID", "CategoryNameCategoryID", "Completed", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 2, "2", null, false, null, 2, "Mission 8 Assignment" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "TaskID", "CategoryID", "CategoryNameCategoryID", "Completed", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 3, "1", null, false, null, 3, "Call Mom" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "TaskID", "CategoryID", "CategoryNameCategoryID", "Completed", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 4, "1", null, false, null, 4, "Therapy" });

            migrationBuilder.CreateIndex(
                name: "IX_responses_CategoryNameCategoryID",
                table: "responses",
                column: "CategoryNameCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
