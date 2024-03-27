using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class db2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7f9357d-a30d-4153-97a8-28832b1a4343");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63bd1968-4d32-4503-8034-cf93ec31ae0f", "006d0ee5-1d05-4204-9a0a-f1a4ccc587a4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63bd1968-4d32-4503-8034-cf93ec31ae0f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "006d0ee5-1d05-4204-9a0a-f1a4ccc587a4");

            migrationBuilder.CreateTable(
                name: "OVFAKTURAHISTORIK",
                columns: table => new
                {
                    YEAR = table.Column<int>(type: "int", nullable: false),
                    MONTH = table.Column<int>(type: "int", nullable: false),
                    N_MAKLARID = table.Column<int>(type: "int", nullable: false),
                    N_OV_ANNONSPAKET = table.Column<int>(type: "int", nullable: true),
                    N_SUMMA = table.Column<int>(type: "int", nullable: true),
                    N_ANTAL = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OVFAKTURAHISTORI__481183C6", x => new { x.YEAR, x.MONTH, x.N_MAKLARID });
                });

            migrationBuilder.CreateTable(
                name: "OVFakturaunderlag",
                columns: table => new
                {
                    l_OVFakturaunderlagID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    n_maklarid = table.Column<short>(type: "smallint", nullable: false),
                    l_objektnr = table.Column<int>(type: "int", nullable: false),
                    dat_datum = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(convert(datetime,(convert(varchar(10),getdate(),102) + ' 00:00:00')))"),
                    b_fakturerad = table.Column<bool>(type: "bit", nullable: false),
                    n_typ = table.Column<short>(type: "smallint", nullable: false),
                    n_lankom = table.Column<short>(type: "smallint", nullable: true),
                    s_omrade = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    s_adress = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    dat_fakturadatum = table.Column<DateTime>(type: "datetime", nullable: true),
                    n_fakturatyp = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)1),
                    DAT_STOP = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVFakturaunderlag", x => x.l_OVFakturaunderlagID);
                });

            migrationBuilder.CreateTable(
                name: "OVRabatt",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    n_maklarid = table.Column<int>(type: "int", nullable: true),
                    RABATTPROCENT = table.Column<int>(type: "int", nullable: true),
                    DAT_UPPHOR = table.Column<DateTime>(type: "datetime", nullable: true),
                    RABATTPROCENT_INFO = table.Column<int>(type: "int", nullable: true),
                    PAKETTYP = table.Column<int>(type: "int", nullable: true),
                    b_aktiv = table.Column<bool>(type: "bit", nullable: true),
                    dat_skapad = table.Column<DateTime>(type: "datetime", nullable: true),
                    dat_andrad = table.Column<DateTime>(type: "datetime", nullable: true),
                    s_kommentar = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OVRabatt__3214EC276BBAB2B6", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    price = table.Column<double>(type: "float", nullable: true),
                    notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    rules = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    vatid = table.Column<int>(type: "int", nullable: true),
                    pricetype = table.Column<int>(type: "int", nullable: true),
                    unit = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    currency = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    InvoiceCyclesInMoths = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    OrderCanOverridePrice = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__product__3213E83F57B3BA09", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProductPrice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "orderitem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    address1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    address2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    address3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    countrycode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    postalcode = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    postalarea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    productid = table.Column<int>(type: "int", nullable: true),
                    customerid = table.Column<int>(type: "int", nullable: true),
                    contractstarts = table.Column<DateTime>(type: "datetime", nullable: true),
                    contractends = table.Column<DateTime>(type: "datetime", nullable: true),
                    invoicecyclesinmonths = table.Column<int>(type: "int", nullable: true),
                    bywho = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    how = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    reference = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ordernr = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    orderdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted = table.Column<DateTime>(type: "datetime", nullable: true),
                    discount = table.Column<double>(type: "float", nullable: true),
                    currency = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    vatid = table.Column<int>(type: "int", nullable: true),
                    invoiceto = table.Column<int>(type: "int", nullable: true),
                    specialprice = table.Column<double>(type: "float", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true, computedColumnSql: "(CONVERT([bit],case when [deleted]<='1901-01-01' AND ([contractends]<='1901-01-01' OR [contractends]>getdate()) AND ([contractstarts]<='1901-01-01' OR [contractstarts]<getdate()) then (1) else (0) end,0))", stored: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__orderite__3213E83F5B844AED", x => x.id);
                    table.ForeignKey(
                        name: "fk_orderitem_product",
                        column: x => x.productid,
                        principalTable: "product",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8fc9d591-a9ee-42f3-9187-73beaa59e519", null, "Administrator", "Administrator" },
                    { "fa15c2cd-2e3d-4857-b695-1ac55079e4bc", null, "User", "User" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5fb558cb-3aac-47c2-804d-171e283bb4e7", 0, "985e96f0-46cf-4e46-9a8b-289c8979555e", "admin@bovision.se", false, false, null, "admin@bovision.se", "admin@bovision.se", "AQAAAAIAAYagAAAAENdOfXZzKblXzZokst32vCrfnC7u3HmDgM4dSQwqWUHU9+xmJ9/kNaQQFtgaw2bZDg==", null, false, "d7873d41-a0a0-4de1-97ea-c2d8f0ce04e9", false, "admin@bovision.se" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8fc9d591-a9ee-42f3-9187-73beaa59e519", "5fb558cb-3aac-47c2-804d-171e283bb4e7" });

            migrationBuilder.CreateIndex(
                name: "IX_orderitem_productid",
                table: "orderitem",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IDX_OVFakturaunderlag_MaklaridDatumObjektnr",
                table: "OVFakturaunderlag",
                columns: new[] { "n_maklarid", "dat_datum", "l_objektnr", "n_fakturatyp" },
                unique: true,
                filter: "[n_fakturatyp] IS NOT NULL")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "ix_ProductId",
                table: "ProductPrice",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orderitem");

            migrationBuilder.DropTable(
                name: "OVFAKTURAHISTORIK");

            migrationBuilder.DropTable(
                name: "OVFakturaunderlag");

            migrationBuilder.DropTable(
                name: "OVRabatt");

            migrationBuilder.DropTable(
                name: "ProductPrice");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa15c2cd-2e3d-4857-b695-1ac55079e4bc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8fc9d591-a9ee-42f3-9187-73beaa59e519", "5fb558cb-3aac-47c2-804d-171e283bb4e7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fc9d591-a9ee-42f3-9187-73beaa59e519");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fb558cb-3aac-47c2-804d-171e283bb4e7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "63bd1968-4d32-4503-8034-cf93ec31ae0f", null, "Administrator", "Administrator" },
                    { "a7f9357d-a30d-4153-97a8-28832b1a4343", null, "User", "User" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "006d0ee5-1d05-4204-9a0a-f1a4ccc587a4", 0, "db157c3f-03c6-47f2-af5e-1729137e4778", "admin@bovision.se", false, false, null, "admin@bovision.se", "admin@bovision.se", "AQAAAAIAAYagAAAAEMqjyq1rTsBAXXC970rI2CKCOhmXKOW/uvwM6g+kg1N5/q/RrcbyNGXHGmw0VdiwbQ==", null, false, "4fbfb7fa-2ef4-4e56-96cf-1fcf6f5de5cb", false, "admin@bovision.se" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "63bd1968-4d32-4503-8034-cf93ec31ae0f", "006d0ee5-1d05-4204-9a0a-f1a4ccc587a4" });
        }
    }
}
