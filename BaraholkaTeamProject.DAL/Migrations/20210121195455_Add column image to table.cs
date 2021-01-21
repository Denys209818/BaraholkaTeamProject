using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BaraholkaTeamProject.DAL.Migrations
{
    public partial class Addcolumnimagetotable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "tblUsersTeamProject",
                type: "bytea",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "tblUsersTeamProject");
        }
    }
}
