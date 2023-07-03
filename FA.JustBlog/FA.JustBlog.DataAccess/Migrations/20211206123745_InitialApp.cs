using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FA.JustBlog.DataAccess.Migrations
{
    public partial class InitialApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    AboutMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: false),
                    UrlFacebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlSlug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlSlug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlSlug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    RateCount = table.Column<int>(type: "int", nullable: false),
                    Totalrate = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PostTags_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ED09F0E5-6627-4EE4-94DC-A446B52921B0", "012c21f7-c342-4f88-94c3-0af3ef96fe43", "User", "USER" },
                    { "A7F098E4-D8F9-43EF-BAD6-65034FDEDC45", "ed7a5be0-237d-42f6-b0a5-358685275653", "Contributor", "CONTRIBUTOR" },
                    { "B6812DFE-3F6B-4128-90B3-DE050C5FFF46", "f0f17ded-80b0-4baf-be41-b0f29699baa4", "Blog Owner", "BLOG OWNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Sex", "TwoFactorEnabled", "UrlFacebook", "UserName" },
                values: new object[] { "590c7a5d-7c2f-485d-f27a-08d9b894db0a", null, 0, 0, "7c881424-62e0-4e52-b0b2-0b9500783a9a", "test@gmail.com", true, false, null, "TEST@GMAIL.COM", "TEST@GMAIL.COM", "AQAAAAEAACcQAAAAELY90+pWj8esXEfaKBnDxvpflRSfxGtA3ywCXlRREccwMRfM5cB70qbe4quz5biOAg==", null, false, "XSH4GERHMS5GC6F4OQD6P62EO5LQWM33", false, false, null, "test@gmail.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "InsertAt", "IsDeleted", "Name", "UpdateAt", "UrlSlug" },
                values: new object[,]
                {
                    { new Guid("b20c815f-5f83-449d-9102-c74b4f11db6b"), "All products relate to Food or Drinks", new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Food or Drinks", new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empty" },
                    { new Guid("ff85e290-573f-477b-bc75-3afef7acb469"), "All posts relate to .Net or other.", new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Technololy", new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empty" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Count", "Description", "InsertAt", "IsDeleted", "Name", "UpdateAt", "UrlSlug" },
                values: new object[,]
                {
                    { new Guid("e36b9bab-596c-47da-90ca-99999e8881a2"), 10, "All tea will be tag #Teas.", new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "#Teas", new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empty" },
                    { new Guid("27e03338-543d-4c60-9ccc-2f8da894980c"), 11, "All tea will be tag #Coffees.", new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "#Coffees", new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empty" },
                    { new Guid("732c6995-d666-4b24-b7ff-5e7538f49975"), 12, "All tea will be tag #Drinks.", new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "#Drinks", new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empty" },
                    { new Guid("87d23734-54ff-43e3-a4e2-2e05a4384af0"), 15, "All tea will be tag #Milks.", new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "#Milks", new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empty" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ED09F0E5-6627-4EE4-94DC-A446B52921B0", "590c7a5d-7c2f-485d-f27a-08d9b894db0a" },
                    { "A7F098E4-D8F9-43EF-BAD6-65034FDEDC45", "590c7a5d-7c2f-485d-f27a-08d9b894db0a" },
                    { "B6812DFE-3F6B-4128-90B3-DE050C5FFF46", "590c7a5d-7c2f-485d-f27a-08d9b894db0a" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CategoryId", "ImageUrl", "InsertAt", "IsDeleted", "PostContent", "PublishDate", "Published", "RateCount", "ShortDescription", "Title", "Totalrate", "UpdateAt", "UrlSlug", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("fa680590-599c-4b70-a3ed-3dc42f0a79c6"), new Guid("b20c815f-5f83-449d-9102-c74b4f11db6b"), "https://th.bing.com/th/id/OIP.IrCcZG0OwJUJ_6a1mhQHqwHaFZ?pid=ImgDet&rs=1", new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?. Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?", new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 10, "Tea is the most drink for people.", "Some thing about Tea #Tea", 10, new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empty", 120 },
                    { new Guid("b11d633c-6c67-47aa-8ff5-36f219473a73"), new Guid("b20c815f-5f83-449d-9102-c74b4f11db6b"), "https://th.bing.com/th/id/OIP.IrCcZG0OwJUJ_6a1mhQHqwHaFZ?pid=ImgDet&rs=1", new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?. Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?", new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 10, "Coffee is the most drink for people.", "Some thing about Coffee #Coffee", 10, new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empty", 120 },
                    { new Guid("6c6f1427-8e1c-4a5a-a53c-5ea5d040e080"), new Guid("b20c815f-5f83-449d-9102-c74b4f11db6b"), "https://th.bing.com/th/id/OIP.IrCcZG0OwJUJ_6a1mhQHqwHaFZ?pid=ImgDet&rs=1", new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?. Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?", new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 10, "Milks is the most drink for people.", "Some thing about Milks #Milks", 10, new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empty", 120 },
                    { new Guid("2da4df58-d2b8-4442-97c1-6b43e6bb520d"), new Guid("b20c815f-5f83-449d-9102-c74b4f11db6b"), "https://th.bing.com/th/id/OIP.IrCcZG0OwJUJ_6a1mhQHqwHaFZ?pid=ImgDet&rs=1", new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?. Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?", new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 10, "Drinks is the most drink for people.", "Some thing about Sting #Drinks", 10, new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empty", 120 },
                    { new Guid("96d1d69d-613a-484d-9f31-aac1a65c17d5"), new Guid("b20c815f-5f83-449d-9102-c74b4f11db6b"), "https://th.bing.com/th/id/OIP.IrCcZG0OwJUJ_6a1mhQHqwHaFZ?pid=ImgDet&rs=1", new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?. Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?", new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 7, "Milks is the most drink for people.", "Some thing about OngTho #Milks", 8, new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empty", 5000 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "CommentHeader", "CommentText", "CommentTime", "Email", "InsertAt", "IsDeleted", "Name", "PostId", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("a39a34ab-67d0-4c76-9075-238da9cb3fde"), "For comments", "hahaha good", new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "mous@example.com", new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cáo ẩn danh", new Guid("fa680590-599c-4b70-a3ed-3dc42f0a79c6"), new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cab6fb6b-d118-47b2-b862-e06a41c66ab4"), "For comments", "Hảo sản phẩm", new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "mous@example.com", new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Sóc nâu", new Guid("fa680590-599c-4b70-a3ed-3dc42f0a79c6"), new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d02d4926-3ad8-47dd-b77c-714c86ab613a"), "For comments", "Ngon !", new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "mous@example.com", new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Mèo mướp ẩn danh", new Guid("fa680590-599c-4b70-a3ed-3dc42f0a79c6"), new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e704b5a7-9609-4d59-80c5-65578c9ed19a"), "For comments", "Very good", new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "mous@example.com", new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Thỏ mũm mĩm", new Guid("b11d633c-6c67-47aa-8ff5-36f219473a73"), new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dcff144c-4ce2-4a4d-bba8-139790c9fb5b"), "For comments", "Excellent !", new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "mous@example.com", new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cá sấu hoa cà", new Guid("6c6f1427-8e1c-4a5a-a53c-5ea5d040e080"), new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("afa431cd-f436-4d4b-93a3-6a8d7a596223"), "For comments", "5 stars", new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "mous@example.com", new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Chuột chũi đại dương", new Guid("2da4df58-d2b8-4442-97c1-6b43e6bb520d"), new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5d79493f-41a3-4c6f-bba4-d457b1a20696"), "For comments", "Yo Yo", new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "mous@example.com", new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cá mập biển sâu", new Guid("96d1d69d-613a-484d-9f31-aac1a65c17d5"), new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { new Guid("fa680590-599c-4b70-a3ed-3dc42f0a79c6"), new Guid("e36b9bab-596c-47da-90ca-99999e8881a2") },
                    { new Guid("b11d633c-6c67-47aa-8ff5-36f219473a73"), new Guid("732c6995-d666-4b24-b7ff-5e7538f49975") },
                    { new Guid("6c6f1427-8e1c-4a5a-a53c-5ea5d040e080"), new Guid("27e03338-543d-4c60-9ccc-2f8da894980c") },
                    { new Guid("6c6f1427-8e1c-4a5a-a53c-5ea5d040e080"), new Guid("87d23734-54ff-43e3-a4e2-2e05a4384af0") },
                    { new Guid("2da4df58-d2b8-4442-97c1-6b43e6bb520d"), new Guid("e36b9bab-596c-47da-90ca-99999e8881a2") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagId",
                table: "PostTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
