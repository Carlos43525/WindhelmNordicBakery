using Microsoft.EntityFrameworkCore.Migrations;

namespace WindhelmNordicBakery.Data.Migrations
{
    public partial class seedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Gifts", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Breads", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Cakes", null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AllergyInformation", "CategoryId", "ImageFile", "ImageThumbnailFile", "InStock", "LongDescription", "Name", "Popularity", "Price", "ShortDescription" },
                values: new object[] { 1, "", 1, "cookbook.jpg", "cookbook.jpg", true, "Detailed instructions to bring many of our legendary goods home to your kitchen!", "Cookbook", 0, 24.99m, "Our legendary recipe book!" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AllergyInformation", "CategoryId", "ImageFile", "ImageThumbnailFile", "InStock", "LongDescription", "Name", "Popularity", "Price", "ShortDescription" },
                values: new object[] { 2, null, 2, "sourdough.jpg", "sourdough.jpg", true, " Curabitur ullamcorper nulla non enim hendrerit aliquam. Aenean luctus viverra ante a placerat. Nam mollis consectetur varius. Sed eleifend facilisis viverra. Mauris in urna eget mi ullamcorper elementum. Mauris ultrices ante mauris, at congue dui pulvinar faucibus. Nunc eget est a sem blandit placerat quis quis nisl. Nullam condimentum quis eros blandit rutrum. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec et libero nec enim sodales fermentum at a libero.", "Sourdough", 0, 4.99m, "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AllergyInformation", "CategoryId", "ImageFile", "ImageThumbnailFile", "InStock", "LongDescription", "Name", "Popularity", "Price", "ShortDescription" },
                values: new object[] { 3, null, 2, "VikingRye.jpg", "VikingRye.jpg", true, " Curabitur ullamcorper nulla non enim hendrerit aliquam. Aenean luctus viverra ante a placerat. Nam mollis consectetur varius. Sed eleifend facilisis viverra. Mauris in urna eget mi ullamcorper elementum. Mauris ultrices ante mauris, at congue dui pulvinar faucibus. Nunc eget est a sem blandit placerat quis quis nisl. Nullam condimentum quis eros blandit rutrum. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec et libero nec enim sodales fermentum at a libero.", "Viking Rye Bread", 1, 2.99m, "Lorem Ipsum" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
