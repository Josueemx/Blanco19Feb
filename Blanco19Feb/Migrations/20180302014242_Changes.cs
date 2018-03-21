using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Blanco19Feb.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactGroupId",
                table: "Contacts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContactGroup",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactGroup", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ContactGroupId",
                table: "Contacts",
                column: "ContactGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_ContactGroup_ContactGroupId",
                table: "Contacts",
                column: "ContactGroupId",
                principalTable: "ContactGroup",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_ContactGroup_ContactGroupId",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "ContactGroup");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_ContactGroupId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "ContactGroupId",
                table: "Contacts");
        }
    }
}
