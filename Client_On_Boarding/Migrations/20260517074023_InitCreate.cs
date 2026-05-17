using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Client_On_Boarding.Migrations
{
    /// <inheritdoc />
    public partial class InitCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessIndustries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndustryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessIndustries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientPageAllowances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientPageAllowances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadPriorities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriorityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadPriorities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadSources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadSourceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadSources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageFieldSetting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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

            migrationBuilder.CreateTable(
                name: "ClientLeads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    LeadSourceID = table.Column<int>(type: "int", nullable: false),
                    LeadStatusID = table.Column<int>(type: "int", nullable: false),
                    PriorityId = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientLeads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientLeads_BusinessIndustries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "BusinessIndustries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientLeads_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientLeads_LeadPriorities_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "LeadPriorities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClientLeads_LeadSources_LeadSourceID",
                        column: x => x.LeadSourceID,
                        principalTable: "LeadSources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientLeads_LeadStatuses_LeadStatusID",
                        column: x => x.LeadStatusID,
                        principalTable: "LeadStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BusinessIndustries",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "IndustryName", "ModifyBy", "ModifyDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1112), 0, "Rice Wholesaler", 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1115) },
                    { 2, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1121), 0, "Medical Wholesaler", 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1121) },
                    { 3, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1122), 0, "Electronics", 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1123) },
                    { 4, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1124), 0, "Restaurant", 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1124) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName", "CreateDate", "CreatedBy", "ModifyBy", "ModifyDate" },
                values: new object[,]
                {
                    { 1, "Bangladesh", new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1262), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1263) },
                    { 2, "India", new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1264), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1265) },
                    { 3, "Pakistan", new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1266), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1266) },
                    { 4, "Sri Lanka", new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1267), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1268) }
                });

            migrationBuilder.InsertData(
                table: "LeadPriorities",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "ModifyBy", "ModifyDate", "PriorityName" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1339), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1339), "Low" },
                    { 2, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1340), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1341), "Medium" },
                    { 3, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1342), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1342), "High" }
                });

            migrationBuilder.InsertData(
                table: "LeadSources",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "LeadSourceName", "ModifyBy", "ModifyDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1289), 0, "Referral", 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1289) },
                    { 2, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1291), 0, "Website", 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1291) },
                    { 3, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1292), 0, "LinkedIn", 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1292) },
                    { 4, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1293), 0, "Cold Call", 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1294) }
                });

            migrationBuilder.InsertData(
                table: "LeadStatuses",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "ModifyBy", "ModifyDate", "StatusName" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1314), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1314), "New" },
                    { 2, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1316), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1316), "Contacted" },
                    { 3, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1317), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1317), "Follow-up" },
                    { 4, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1318), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1319), "Active" }
                });

            migrationBuilder.InsertData(
                table: "PageFieldSetting",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "FieldName", "IsRequired", "IsView", "ModifyBy", "ModifyDate", "PageId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1612), 0, "Product Name", true, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1612), 1 },
                    { 2, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1615), 0, "Company", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1615), 1 },
                    { 3, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1617), 0, "Category", true, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1618), 1 },
                    { 4, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1619), 0, "Main Unit", true, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1619), 1 },
                    { 5, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1620), 0, "Has Alternate Unit?", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1621), 1 },
                    { 6, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1622), 0, "Purchase Rate", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1622), 1 },
                    { 7, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1624), 0, "Sales Rate", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1624), 1 },
                    { 8, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1625), 0, "Opening Stock", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1626), 1 },
                    { 9, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1627), 0, "Active", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1627), 1 },
                    { 10, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1629), 0, "Customer Name", true, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1629), 2 },
                    { 11, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1631), 0, "City", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1632), 2 },
                    { 12, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1633), 0, "Area By City", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1633), 2 },
                    { 13, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1634), 0, "Full Address", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1635), 2 },
                    { 14, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1636), 0, "Office Phone", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1636), 2 },
                    { 15, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1638), 0, "Contact No 1", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1639), 2 },
                    { 16, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1640), 0, "Contact No 2", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1640), 2 },
                    { 17, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1642), 0, "Opening Balance", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1642), 2 },
                    { 18, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1643), 0, "Active", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1643), 2 },
                    { 19, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1645), 0, "Vendor Name", true, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1645), 3 },
                    { 20, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1646), 0, "City", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1647), 3 },
                    { 21, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1648), 0, "Area By City", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1648), 3 },
                    { 22, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1649), 0, "Full Address", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1650), 3 },
                    { 23, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1651), 0, "Office Phone", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1651), 3 },
                    { 24, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1652), 0, "Contact No 1", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1653), 3 },
                    { 25, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1654), 0, "Contact No 2", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1654), 3 },
                    { 26, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1656), 0, "Opening Balance", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1656), 3 },
                    { 27, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1658), 0, "Active", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1658), 3 },
                    { 28, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1660), 0, "Bank Name", true, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1660), 4 },
                    { 29, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1661), 0, "Account Holder", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1662), 4 },
                    { 30, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1663), 0, "Account No", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1663), 4 },
                    { 31, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1665), 0, "Address", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1665), 4 },
                    { 32, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1666), 0, "Opening Balance", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1666), 4 },
                    { 33, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1668), 0, "Active", false, true, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1668), 4 }
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "ModifyBy", "ModifyDate", "PageName" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1477), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1477), "Products" },
                    { 2, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1479), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1479), "Customers" },
                    { 3, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1480), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1480), "Vendors" },
                    { 4, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1481), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1482), "Bank Accounts" },
                    { 5, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1483), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1483), "Opening Cash" },
                    { 6, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1484), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1484), "General Journal Voucher" },
                    { 7, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1485), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1485), "Master Configuration" },
                    { 8, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1486), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1486), "Orders" },
                    { 9, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1487), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1488), "Invoices" },
                    { 10, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1488), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1489), "Receipt" },
                    { 11, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1490), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1490), "Sale Return" },
                    { 12, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1491), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1491), "Purchase Invoices" },
                    { 13, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1492), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1492), "Payment" },
                    { 14, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1493), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1493), "Purchase Return" },
                    { 15, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1494), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1495), "Cash Billing" },
                    { 16, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1495), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1496), "Counter Sale Return" },
                    { 17, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1497), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1497), "Expenses" },
                    { 18, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1498), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1498), "Stock Adjustment" },
                    { 19, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1499), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1499), "Rollback" },
                    { 20, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1500), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1501), "Customer Balance" },
                    { 21, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1501), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1502), "Vendor Balance" },
                    { 22, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1503), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1503), "Bank Balance" },
                    { 23, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1504), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1504), "Stock Report" },
                    { 24, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1505), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1505), "Customer Ledger" },
                    { 25, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1513), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1513), "Vendor Ledger" },
                    { 26, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1515), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1515), "Bank/Cash Ledger" },
                    { 27, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1516), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1516), "Expenses Reports" },
                    { 28, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1517), 0, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1517), "Overall Daily Report" }
                });

            migrationBuilder.InsertData(
                table: "ClientLeads",
                columns: new[] { "Id", "City", "ClientName", "CompanyName", "CountryId", "CreateDate", "CreatedBy", "IndustryId", "LeadSourceID", "LeadStatusID", "ModifyBy", "ModifyDate", "Notes", "PhoneNo", "PhotoPath", "PostalCode", "PriorityId", "Province", "StreetAddress" },
                values: new object[] { 1, "Hyderabad", "By Default", "Software Company", 3, new DateTime(2026, 5, 17, 0, 40, 22, 694, DateTimeKind.Local).AddTicks(1372), 0, 3, 3, 4, 0, new DateTime(2026, 5, 17, 7, 40, 22, 694, DateTimeKind.Utc).AddTicks(1363), "", "", "", "", 2, "", "" });

            migrationBuilder.CreateIndex(
                name: "IX_ClientLeads_CountryId",
                table: "ClientLeads",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientLeads_IndustryId",
                table: "ClientLeads",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientLeads_LeadSourceID",
                table: "ClientLeads",
                column: "LeadSourceID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientLeads_LeadStatusID",
                table: "ClientLeads",
                column: "LeadStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientLeads_PriorityId",
                table: "ClientLeads",
                column: "PriorityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientLeads");

            migrationBuilder.DropTable(
                name: "ClientPageAllowances");

            migrationBuilder.DropTable(
                name: "PageFieldSetting");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "BusinessIndustries");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "LeadPriorities");

            migrationBuilder.DropTable(
                name: "LeadSources");

            migrationBuilder.DropTable(
                name: "LeadStatuses");
        }
    }
}
