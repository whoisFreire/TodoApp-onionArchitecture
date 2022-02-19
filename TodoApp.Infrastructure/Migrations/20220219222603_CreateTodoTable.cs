using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApp.Infrastructure.Migrations
{
    public partial class CreateTodoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    ID = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    TODO_TITLE = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    CREATED_AT = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UPDATED_AT = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DONE = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TODO_ID", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todo");
        }
    }
}
