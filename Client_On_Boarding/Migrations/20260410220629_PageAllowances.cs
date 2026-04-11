using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Client_On_Boarding.Migrations
{
    /// <inheritdoc />
    public partial class PageAllowances : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PageFieldSetting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    PageId = table.Column<int>(type: "int", nullable: false),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsView = table.Column<bool>(type: "bit", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageFieldSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(4968), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(4975), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(4976), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(4977), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(4977) });

            migrationBuilder.InsertData(
                table: "ClientLeads",
                columns: new[] { "Id", "City", "ClientName", "CompanyName", "CountryId", "CreateDate", "CreatedBy", "IndustryId", "LeadSourceID", "LeadStatusID", "ModifyBy", "ModifyDate", "Notes", "PhoneNo", "PhotoPath", "PostalCode", "PriorityId", "Province", "StreetAddress" },
                values: new object[] { 1, "Hyderabad", "By Default", "Software Company", 3, new DateTime(2026, 4, 11, 3, 6, 29, 237, DateTimeKind.Local).AddTicks(5188), 0, 3, 3, 4, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5179), "", "", "", "", 2, "", "" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5103), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5105), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5106), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5106) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5107), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5162), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5163), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5164), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5125), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5126), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5127), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5128), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5144), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5145), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5146), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5147), new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.InsertData(
                table: "PageFieldSetting",
                columns: new[] { "Id", "ClientId", "CreateDate", "CreatedBy", "FieldName", "IsRequired", "IsView", "ModifyBy", "ModifyDate", "PageId" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5339), 0, "Product Name", true, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5340), 1 },
                    { 2, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5341), 0, "Company", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5341), 1 },
                    { 3, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5343), 0, "Category", true, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5343), 1 },
                    { 4, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5344), 0, "Main Unit", true, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5344), 1 },
                    { 5, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5345), 0, "Has Alternate Unit?", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5346), 1 },
                    { 6, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5347), 0, "Purchase Rate", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5347), 1 },
                    { 7, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5348), 0, "Sales Rate", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5348), 1 },
                    { 8, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5349), 0, "Opening Stock", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5349), 1 },
                    { 9, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5350), 0, "Active", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5351), 1 },
                    { 10, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5351), 0, "Customer Name", true, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5352), 2 },
                    { 11, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5353), 0, "City", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5353), 2 },
                    { 12, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5354), 0, "Area By City", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5354), 2 },
                    { 13, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5355), 0, "Full Address", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5355), 2 },
                    { 14, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5356), 0, "Office Phone", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5357), 2 },
                    { 15, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5357), 0, "Contact No 1", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5358), 2 },
                    { 16, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5359), 0, "Contact No 2", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5359), 2 },
                    { 17, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5360), 0, "Opening Balance", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5360), 2 },
                    { 18, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5361), 0, "Active", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5361), 2 },
                    { 19, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5362), 0, "Vendor Name", true, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5363), 3 },
                    { 20, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5364), 0, "City", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5364), 3 },
                    { 21, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5365), 0, "Area By City", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5365), 3 },
                    { 22, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5366), 0, "Full Address", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5366), 3 },
                    { 23, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5367), 0, "Office Phone", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5367), 3 },
                    { 24, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5368), 0, "Contact No 1", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5369), 3 },
                    { 25, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5370), 0, "Contact No 2", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5370), 3 },
                    { 26, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5371), 0, "Opening Balance", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5371), 3 },
                    { 27, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5372), 0, "Active", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5372), 3 },
                    { 28, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5373), 0, "Bank Name", true, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5374), 4 },
                    { 29, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5375), 0, "Account Holder", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5375), 4 },
                    { 30, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5376), 0, "Account No", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5376), 4 },
                    { 31, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5377), 0, "Address", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5377), 4 },
                    { 32, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5378), 0, "Opening Balance", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5378), 4 },
                    { 33, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5379), 0, "Active", false, true, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5380), 4 }
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "ModifyBy", "ModifyDate", "PageName" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5245), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5246), "Products" },
                    { 2, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5283), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5284), "Customers" },
                    { 3, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5285), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5285), "Vendors" },
                    { 4, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5286), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5286), "Bank Accounts" },
                    { 5, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5287), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5287), "Opening Cash" },
                    { 6, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5288), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5288), "General Journal Voucher" },
                    { 7, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5289), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5289), "Master Configuration" },
                    { 8, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5290), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5290), "Orders" },
                    { 9, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5291), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5291), "Invoices" },
                    { 10, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5292), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5292), "Receipt" },
                    { 11, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5292), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5293), "Sale Return" },
                    { 12, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5293), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5294), "Purchase Invoices" },
                    { 13, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5294), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5295), "Payment" },
                    { 14, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5295), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5296), "Purchase Return" },
                    { 15, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5296), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5297), "Cash Billing" },
                    { 16, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5297), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5298), "Counter Sale Return" },
                    { 17, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5298), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5298), "Expenses" },
                    { 18, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5299), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5299), "Stock Adjustment" },
                    { 19, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5300), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5300), "Rollback" },
                    { 20, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5301), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5301), "Customer Balance" },
                    { 21, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5302), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5302), "Vendor Balance" },
                    { 22, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5303), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5303), "Bank Balance" },
                    { 23, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5304), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5304), "Stock Report" },
                    { 24, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5305), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5305), "Customer Ledger" },
                    { 25, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5305), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5306), "Vendor Ledger" },
                    { 26, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5306), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5307), "Bank/Cash Ledger" },
                    { 27, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5307), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5308), "Expenses Reports" },
                    { 28, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5308), 0, 0, new DateTime(2026, 4, 10, 22, 6, 29, 237, DateTimeKind.Utc).AddTicks(5309), "Overall Daily Report" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PageFieldSetting");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DeleteData(
                table: "ClientLeads",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(613), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(621), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(622), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(624), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(841), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(843), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(844), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(846), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(1002), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(1004), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(1005), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(870), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(872), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(873), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(874), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(975), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(977), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(979), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(980), new DateTime(2026, 4, 9, 18, 4, 42, 548, DateTimeKind.Utc).AddTicks(980) });
        }
    }
}
