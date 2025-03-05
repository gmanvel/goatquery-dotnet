using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace controller.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Firstname = table.Column<string>(type: "varchar(128)", nullable: false),
                    Lastname = table.Column<string>(type: "varchar(128)", nullable: false),
                    Email = table.Column<string>(type: "varchar(320)", nullable: false),
                    AvatarUrl = table.Column<string>(type: "varchar(1024)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    UserName = table.Column<string>(type: "varchar(64)", nullable: false),
                    PersonSex = table.Column<string>(type: "varchar(32)", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
