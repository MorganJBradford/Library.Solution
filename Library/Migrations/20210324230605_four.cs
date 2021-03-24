using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_AspNetUsers_LibrarianId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_AspNetUsers_PatronUserId",
                table: "Patrons");

            migrationBuilder.RenameColumn(
                name: "PatronUserId",
                table: "Patrons",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Patrons_PatronUserId",
                table: "Patrons",
                newName: "IX_Patrons_UserId");

            migrationBuilder.RenameColumn(
                name: "CopyId",
                table: "Checkout",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "LibrarianId",
                table: "Books",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_LibrarianId",
                table: "Books",
                newName: "IX_Books_UserId");

            migrationBuilder.AddColumn<bool>(
                name: "CheckedOut",
                table: "Books",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_BookId",
                table: "Checkout",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_AspNetUsers_UserId",
                table: "Books",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkout_Books_BookId",
                table: "Checkout",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_AspNetUsers_UserId",
                table: "Patrons",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_AspNetUsers_UserId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkout_Books_BookId",
                table: "Checkout");

            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_AspNetUsers_UserId",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_Checkout_BookId",
                table: "Checkout");

            migrationBuilder.DropColumn(
                name: "CheckedOut",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Patrons",
                newName: "PatronUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Patrons_UserId",
                table: "Patrons",
                newName: "IX_Patrons_PatronUserId");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Checkout",
                newName: "CopyId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Books",
                newName: "LibrarianId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_UserId",
                table: "Books",
                newName: "IX_Books_LibrarianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_AspNetUsers_LibrarianId",
                table: "Books",
                column: "LibrarianId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_AspNetUsers_PatronUserId",
                table: "Patrons",
                column: "PatronUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
