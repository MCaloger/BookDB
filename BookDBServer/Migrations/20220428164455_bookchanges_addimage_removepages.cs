using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookDBServer.Migrations
{
    public partial class bookchanges_addimage_removepages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentPages",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "MaxPages",
                table: "Books");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Books",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "CurrentPages",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxPages",
                table: "Books",
                type: "int",
                nullable: true);
        }
    }
}
