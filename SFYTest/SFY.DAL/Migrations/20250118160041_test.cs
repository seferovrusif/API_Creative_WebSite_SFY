using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SFY.DAL.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bag_AspNetUsers_AppUserId",
                table: "Bag");

            migrationBuilder.DropForeignKey(
                name: "FK_Bag_Color_ColorId",
                table: "Bag");

            migrationBuilder.DropForeignKey(
                name: "FK_Bag_Color_Handle_ColorId",
                table: "Bag");

            migrationBuilder.DropForeignKey(
                name: "FK_Bag_Material_Handle_MaterialId",
                table: "Bag");

            migrationBuilder.DropForeignKey(
                name: "FK_Bag_Material_MaterialId",
                table: "Bag");

            migrationBuilder.DropForeignKey(
                name: "FK_Bag_Sizes_Handle_SizeId",
                table: "Bag");

            migrationBuilder.DropForeignKey(
                name: "FK_Bag_Sizes_SizeId",
                table: "Bag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Material",
                table: "Material");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Color",
                table: "Color");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bag",
                table: "Bag");

            migrationBuilder.RenameTable(
                name: "Material",
                newName: "Materials");

            migrationBuilder.RenameTable(
                name: "Color",
                newName: "Colors");

            migrationBuilder.RenameTable(
                name: "Bag",
                newName: "Bags");

            migrationBuilder.RenameIndex(
                name: "IX_Bag_SizeId",
                table: "Bags",
                newName: "IX_Bags_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_Bag_MaterialId",
                table: "Bags",
                newName: "IX_Bags_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Bag_Handle_SizeId",
                table: "Bags",
                newName: "IX_Bags_Handle_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_Bag_Handle_MaterialId",
                table: "Bags",
                newName: "IX_Bags_Handle_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Bag_Handle_ColorId",
                table: "Bags",
                newName: "IX_Bags_Handle_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_Bag_ColorId",
                table: "Bags",
                newName: "IX_Bags_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_Bag_AppUserId",
                table: "Bags",
                newName: "IX_Bags_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materials",
                table: "Materials",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colors",
                table: "Colors",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bags",
                table: "Bags",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bags_AspNetUsers_AppUserId",
                table: "Bags",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bags_Colors_ColorId",
                table: "Bags",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bags_Colors_Handle_ColorId",
                table: "Bags",
                column: "Handle_ColorId",
                principalTable: "Colors",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bags_Materials_Handle_MaterialId",
                table: "Bags",
                column: "Handle_MaterialId",
                principalTable: "Materials",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bags_Materials_MaterialId",
                table: "Bags",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bags_Sizes_Handle_SizeId",
                table: "Bags",
                column: "Handle_SizeId",
                principalTable: "Sizes",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bags_Sizes_SizeId",
                table: "Bags",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bags_AspNetUsers_AppUserId",
                table: "Bags");

            migrationBuilder.DropForeignKey(
                name: "FK_Bags_Colors_ColorId",
                table: "Bags");

            migrationBuilder.DropForeignKey(
                name: "FK_Bags_Colors_Handle_ColorId",
                table: "Bags");

            migrationBuilder.DropForeignKey(
                name: "FK_Bags_Materials_Handle_MaterialId",
                table: "Bags");

            migrationBuilder.DropForeignKey(
                name: "FK_Bags_Materials_MaterialId",
                table: "Bags");

            migrationBuilder.DropForeignKey(
                name: "FK_Bags_Sizes_Handle_SizeId",
                table: "Bags");

            migrationBuilder.DropForeignKey(
                name: "FK_Bags_Sizes_SizeId",
                table: "Bags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materials",
                table: "Materials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colors",
                table: "Colors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bags",
                table: "Bags");

            migrationBuilder.RenameTable(
                name: "Materials",
                newName: "Material");

            migrationBuilder.RenameTable(
                name: "Colors",
                newName: "Color");

            migrationBuilder.RenameTable(
                name: "Bags",
                newName: "Bag");

            migrationBuilder.RenameIndex(
                name: "IX_Bags_SizeId",
                table: "Bag",
                newName: "IX_Bag_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_Bags_MaterialId",
                table: "Bag",
                newName: "IX_Bag_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Bags_Handle_SizeId",
                table: "Bag",
                newName: "IX_Bag_Handle_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_Bags_Handle_MaterialId",
                table: "Bag",
                newName: "IX_Bag_Handle_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Bags_Handle_ColorId",
                table: "Bag",
                newName: "IX_Bag_Handle_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_Bags_ColorId",
                table: "Bag",
                newName: "IX_Bag_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_Bags_AppUserId",
                table: "Bag",
                newName: "IX_Bag_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Material",
                table: "Material",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Color",
                table: "Color",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bag",
                table: "Bag",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bag_AspNetUsers_AppUserId",
                table: "Bag",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bag_Color_ColorId",
                table: "Bag",
                column: "ColorId",
                principalTable: "Color",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bag_Color_Handle_ColorId",
                table: "Bag",
                column: "Handle_ColorId",
                principalTable: "Color",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bag_Material_Handle_MaterialId",
                table: "Bag",
                column: "Handle_MaterialId",
                principalTable: "Material",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bag_Material_MaterialId",
                table: "Bag",
                column: "MaterialId",
                principalTable: "Material",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bag_Sizes_Handle_SizeId",
                table: "Bag",
                column: "Handle_SizeId",
                principalTable: "Sizes",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bag_Sizes_SizeId",
                table: "Bag",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "id");
        }
    }
}
