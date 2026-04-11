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
                    { 1, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(948), 0, "Rice Wholesaler", 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(968) },
                    { 2, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(971), 0, "Medical Wholesaler", 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(971) },
                    { 3, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(972), 0, "Electronics", 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(972) },
                    { 4, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(973), 0, "Restaurant", 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(974) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName", "CreateDate", "CreatedBy", "ModifyBy", "ModifyDate" },
                values: new object[,]
                {
                    { 1, "Bangladesh", new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1129), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1129) },
                    { 2, "India", new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1130), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1130) },
                    { 3, "Pakistan", new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1131), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1132) },
                    { 4, "Sri Lanka", new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1132), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1133) }
                });

            migrationBuilder.InsertData(
                table: "LeadPriorities",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "ModifyBy", "ModifyDate", "PriorityName" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1198), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1199), "Low" },
                    { 2, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1200), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1200), "Medium" },
                    { 3, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1201), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1201), "High" }
                });

            migrationBuilder.InsertData(
                table: "LeadSources",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "LeadSourceName", "ModifyBy", "ModifyDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1152), 0, "Referral", 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1153) },
                    { 2, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1154), 0, "Website", 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1154) },
                    { 3, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1155), 0, "LinkedIn", 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1155) },
                    { 4, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1156), 0, "Cold Call", 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1156) }
                });

            migrationBuilder.InsertData(
                table: "LeadStatuses",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "ModifyBy", "ModifyDate", "StatusName" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1176), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1176), "New" },
                    { 2, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1177), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1177), "Contacted" },
                    { 3, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1178), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1178), "Follow-up" },
                    { 4, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1179), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1180), "Active" }
                });

            migrationBuilder.InsertData(
                table: "PageFieldSetting",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "FieldName", "IsRequired", "IsView", "ModifyBy", "ModifyDate", "PageId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1425), 0, "Product Name", true, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1426), 1 },
                    { 2, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1428), 0, "Company", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1428), 1 },
                    { 3, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1429), 0, "Category", true, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1429), 1 },
                    { 4, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1430), 0, "Main Unit", true, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1431), 1 },
                    { 5, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1432), 0, "Has Alternate Unit?", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1432), 1 },
                    { 6, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1433), 0, "Purchase Rate", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1433), 1 },
                    { 7, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1434), 0, "Sales Rate", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1434), 1 },
                    { 8, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1435), 0, "Opening Stock", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1436), 1 },
                    { 9, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1437), 0, "Active", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1437), 1 },
                    { 10, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1438), 0, "Customer Name", true, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1438), 2 },
                    { 11, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1446), 0, "City", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1447), 2 },
                    { 12, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1448), 0, "Area By City", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1448), 2 },
                    { 13, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1449), 0, "Full Address", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1449), 2 },
                    { 14, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1450), 0, "Office Phone", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1450), 2 },
                    { 15, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1451), 0, "Contact No 1", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1452), 2 },
                    { 16, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1453), 0, "Contact No 2", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1453), 2 },
                    { 17, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1454), 0, "Opening Balance", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1454), 2 },
                    { 18, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1455), 0, "Active", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1455), 2 },
                    { 19, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1456), 0, "Vendor Name", true, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1457), 3 },
                    { 20, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1458), 0, "City", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1458), 3 },
                    { 21, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1459), 0, "Area By City", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1459), 3 },
                    { 22, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1460), 0, "Full Address", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1460), 3 },
                    { 23, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1461), 0, "Office Phone", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1462), 3 },
                    { 24, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1463), 0, "Contact No 1", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1463), 3 },
                    { 25, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1464), 0, "Contact No 2", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1464), 3 },
                    { 26, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1465), 0, "Opening Balance", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1465), 3 },
                    { 27, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1466), 0, "Active", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1467), 3 },
                    { 28, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1468), 0, "Bank Name", true, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1469), 4 },
                    { 29, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1470), 0, "Account Holder", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1471), 4 },
                    { 30, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1472), 0, "Account No", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1472), 4 },
                    { 31, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1475), 0, "Address", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1475), 4 },
                    { 32, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1479), 0, "Opening Balance", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1479), 4 },
                    { 33, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1481), 0, "Active", false, true, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1481), 4 }
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "ModifyBy", "ModifyDate", "PageName" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1319), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1319), "Products" },
                    { 2, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1321), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1321), "Customers" },
                    { 3, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1322), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1322), "Vendors" },
                    { 4, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1323), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1323), "Bank Accounts" },
                    { 5, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1324), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1324), "Opening Cash" },
                    { 6, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1325), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1325), "General Journal Voucher" },
                    { 7, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1326), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1326), "Master Configuration" },
                    { 8, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1327), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1327), "Orders" },
                    { 9, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1328), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1328), "Invoices" },
                    { 10, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1329), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1329), "Receipt" },
                    { 11, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1333), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1333), "Sale Return" },
                    { 12, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1334), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1334), "Purchase Invoices" },
                    { 13, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1335), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1335), "Payment" },
                    { 14, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1336), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1336), "Purchase Return" },
                    { 15, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1337), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1337), "Cash Billing" },
                    { 16, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1338), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1338), "Counter Sale Return" },
                    { 17, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1338), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1339), "Expenses" },
                    { 18, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1339), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1340), "Stock Adjustment" },
                    { 19, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1340), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1341), "Rollback" },
                    { 20, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1341), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1342), "Customer Balance" },
                    { 21, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1342), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1343), "Vendor Balance" },
                    { 22, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1343), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1343), "Bank Balance" },
                    { 23, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1344), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1344), "Stock Report" },
                    { 24, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1345), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1345), "Customer Ledger" },
                    { 25, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1388), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1388), "Vendor Ledger" },
                    { 26, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1389), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1389), "Bank/Cash Ledger" },
                    { 27, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1390), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1390), "Expenses Reports" },
                    { 28, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1391), 0, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1391), "Overall Daily Report" }
                });

            migrationBuilder.InsertData(
                table: "ClientLeads",
                columns: new[] { "Id", "City", "ClientName", "CompanyName", "CountryId", "CreateDate", "CreatedBy", "IndustryId", "LeadSourceID", "LeadStatusID", "ModifyBy", "ModifyDate", "Notes", "PhoneNo", "PhotoPath", "PostalCode", "PriorityId", "Province", "StreetAddress" },
                values: new object[] { 1, "Hyderabad", "By Default", "Software Company", 3, new DateTime(2026, 4, 12, 3, 29, 18, 371, DateTimeKind.Local).AddTicks(1230), 0, 3, 3, 4, 0, new DateTime(2026, 4, 11, 22, 29, 18, 371, DateTimeKind.Utc).AddTicks(1218), "", "", "", "", 2, "", "" });

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
