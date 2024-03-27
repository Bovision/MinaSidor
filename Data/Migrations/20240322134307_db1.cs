using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class db1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d95d3300-1d28-4340-b849-353bf3ec7ac1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebc6eabf-9fac-47c2-94fe-b5888da62f5b", "aff251bb-8536-4bf7-96f0-3274f09f2052" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebc6eabf-9fac-47c2-94fe-b5888da62f5b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aff251bb-8536-4bf7-96f0-3274f09f2052");

            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    address1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    address2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    address3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    countrycode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    postalcode = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    postalarea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    deliveryaddress1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    deliveryaddress2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    deliveryaddress3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    deliverycountrycode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    deliverypostalcode = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    deliverypostalarea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    phone = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    fax = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    orgnr = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    vatno = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    contactemail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    mailingemail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    webadress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    passwordservices = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    currency = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    export = table.Column<int>(type: "int", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SpecialExpFee = table.Column<int>(type: "int", nullable: false),
                    SpecialDiscount = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((0.0))"),
                    Logotype = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    InvoiceEmail = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ToBlocket = table.Column<bool>(type: "bit", nullable: false),
                    System = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActiveViaOrders = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveViaInvoice = table.Column<bool>(type: "bit", nullable: false),
                    InvoicedAmount2015 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    IsSpider = table.Column<bool>(type: "bit", nullable: false),
                    SystemKundId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__customer__3213E83F29ECEF59", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerArchived",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Customer = table.Column<string>(type: "xml", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerArchived", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "customercontact",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    phone = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__customer__3213E83F2DBD803D", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerEvent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Change = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerEvent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "customergroup",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerid = table.Column<int>(type: "int", nullable: true),
                    groupid = table.Column<int>(type: "int", nullable: true),
                    created = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__customer__3213E83F455FFFA4", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customernote",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerid = table.Column<int>(type: "int", nullable: true),
                    text = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    created = table.Column<DateTime>(type: "datetime", nullable: true),
                    createdby = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    deleted = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__customer__3213E83F318E1121", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customertagset",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tagid = table.Column<int>(type: "int", nullable: true),
                    customerid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__customer__3213E83F63256CB5", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceArchived",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Invoice = table.Column<string>(type: "xml", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceArchived", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "invoicematerial",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerid = table.Column<int>(type: "int", nullable: false),
                    invoiceto = table.Column<int>(type: "int", nullable: false),
                    period = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    productid = table.Column<int>(type: "int", nullable: false),
                    productcode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    details = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    quantity = table.Column<double>(type: "float", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    vatpct = table.Column<double>(type: "float", nullable: false),
                    amount = table.Column<double>(type: "float", nullable: false),
                    currencycode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    discountamount = table.Column<double>(type: "float", nullable: false),
                    sent = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    reference = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    invoiceid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__invoicem__3213E83F0ECEE4C9", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "invoicerow",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    invoiceid = table.Column<int>(type: "int", nullable: false),
                    code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    quantity = table.Column<double>(type: "float", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    vatpct = table.Column<double>(type: "float", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    currency = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    discount = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((0.0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoicerow", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "invoice",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    address1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    address2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    address3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    countrycode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    postalcode = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    postalarea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    deliveryname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    deliveryaddress1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    deliveryaddress2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    deliveryaddress3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    deliverycountrycode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    deliverypostalcode = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    deliverypostalarea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    iscredit = table.Column<bool>(type: "bit", nullable: true),
                    invoiceid = table.Column<int>(type: "int", nullable: false),
                    customerid = table.Column<int>(type: "int", nullable: false),
                    customervat = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ourvat = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    reference = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    deliveryterms = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    deliverymode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    termspayment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    duedate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ourreference = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    orderno = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    domicile = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    freight = table.Column<double>(type: "float", nullable: false),
                    expfee = table.Column<double>(type: "float", nullable: false),
                    vat = table.Column<double>(type: "float", nullable: false),
                    evenout = table.Column<double>(type: "float", nullable: false),
                    sum = table.Column<double>(type: "float", nullable: false),
                    totalsum = table.Column<double>(type: "float", nullable: false),
                    currency = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    invoicedate = table.Column<DateTime>(type: "datetime", nullable: false),
                    created = table.Column<DateTime>(type: "datetime", nullable: false),
                    sent = table.Column<DateTime>(type: "datetime", nullable: false),
                    reminder = table.Column<DateTime>(type: "datetime", nullable: false),
                    claim = table.Column<DateTime>(type: "datetime", nullable: false),
                    payed = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted = table.Column<DateTime>(type: "datetime", nullable: false),
                    credit = table.Column<DateTime>(type: "datetime", nullable: false),
                    PertainsToCredit = table.Column<int>(type: "int", nullable: false),
                    ExternalSystem = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: ""),
                    ExternalId = table.Column<string>(type: "nchar(40)", fixedLength: true, maxLength: 40, nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoice", x => x.id);
                    table.ForeignKey(
                        name: "fk_invoice_customer",
                        column: x => x.customerid,
                        principalTable: "customer",
                        principalColumn: "id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_invoice_customerid",
                table: "invoice",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_invoice_invoiceid",
                table: "invoice",
                column: "invoiceid");

            migrationBuilder.CreateIndex(
                name: "IX_invoicematerial_customerid",
                table: "invoicematerial",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_invoicerow_invoiceid",
                table: "invoicerow",
                column: "invoiceid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerArchived");

            migrationBuilder.DropTable(
                name: "customercontact");

            migrationBuilder.DropTable(
                name: "CustomerEvent");

            migrationBuilder.DropTable(
                name: "customergroup");

            migrationBuilder.DropTable(
                name: "customernote");

            migrationBuilder.DropTable(
                name: "customertagset");

            migrationBuilder.DropTable(
                name: "invoice");

            migrationBuilder.DropTable(
                name: "InvoiceArchived");

            migrationBuilder.DropTable(
                name: "invoicematerial");

            migrationBuilder.DropTable(
                name: "invoicerow");

            migrationBuilder.DropTable(
                name: "customer");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d95d3300-1d28-4340-b849-353bf3ec7ac1", null, "User", "User" },
                    { "ebc6eabf-9fac-47c2-94fe-b5888da62f5b", null, "Administrator", "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aff251bb-8536-4bf7-96f0-3274f09f2052", 0, "27cf316b-4fa7-411a-bbdd-cc594394210a", "admin@bovision.se", false, false, null, "admin@bovision.se", "admin@bovision.se", "AQAAAAIAAYagAAAAEMSWX7t0MmsDzbvZ7vKgGKfO2mUUyMGcm+P8Ej82Ylry5sYtL1X+gsRV3TjmNY2BBw==", null, false, "6cddcb7a-6eee-4913-b232-e53f15077cd5", false, "admin@bovision.se" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ebc6eabf-9fac-47c2-94fe-b5888da62f5b", "aff251bb-8536-4bf7-96f0-3274f09f2052" });
        }
    }
}
