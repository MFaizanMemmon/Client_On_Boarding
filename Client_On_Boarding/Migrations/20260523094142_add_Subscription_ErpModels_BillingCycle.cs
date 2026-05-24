using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Client_On_Boarding.Migrations
{
    /// <inheritdoc />
    public partial class add_Subscription_ErpModels_BillingCycle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConnectionString",
                table: "ClientLeads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InternalNotes",
                table: "ClientLeads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "ClientLeads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "ClientLeads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BillingCycle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountPercentage = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingCycle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ErpModules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErpModules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionPlain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ComaSeperated_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionPlain", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BillingCycle",
                columns: new[] { "Id", "BillingName", "CreateDate", "CreatedBy", "DiscountPercentage", "ModifyBy", "ModifyDate" },
                values: new object[,]
                {
                    { 1, "Monthly", new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9280), 0, 0, 0, new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9281) },
                    { 2, "Quarterly ", new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9282), 0, 10, 0, new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9282) },
                    { 3, "Yearly", new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9283), 0, 25, 0, new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9283) }
                });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(8926), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(8933), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(8934), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(8935), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "ClientLeads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConnectionString", "CreateDate", "InternalNotes", "ModifyDate", "Password", "UserName" },
                values: new object[] { null, new DateTime(2026, 5, 23, 2, 41, 37, 267, DateTimeKind.Local).AddTicks(9182), null, new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9173), null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9059), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9084), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9086), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9087), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9087) });

            migrationBuilder.InsertData(
                table: "ErpModules",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "ModifyBy", "ModifyDate", "ModuleName" },
                values: new object[] { 1, new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9299), 0, 0, new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9300), "Accounting" });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9153), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9155), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9156), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9103), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9104), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9105), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9106), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9127), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9129), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9130), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9131), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9383), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9385), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9386), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9387), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9388), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9429), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9430), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9431), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9433), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9434), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9435), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9436), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9437), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9438), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9439), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9441), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9442), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9443), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9444), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9445), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9446), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9447), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9448), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9450), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9451), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9452), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9453), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9454), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9455), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9456), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9458), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9459), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9460), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9332), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9333), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9334), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9335), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9336), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9337), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9337), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9338), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9339), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9340), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9341), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9342), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9343), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9344), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9344), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9345), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9346), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9347), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9348), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9349), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9349), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9350), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9351), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9352), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9353), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9354), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9355), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9355), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9356) });

            migrationBuilder.InsertData(
                table: "SubscriptionPlain",
                columns: new[] { "Id", "Amount", "ComaSeperated_Description", "CreateDate", "CreatedBy", "ModifyBy", "ModifyDate", "PlainName" },
                values: new object[] { 1, 0m, "Single User,Single Branch", new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9318), 0, 0, new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9318), "Starter" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillingCycle");

            migrationBuilder.DropTable(
                name: "ErpModules");

            migrationBuilder.DropTable(
                name: "SubscriptionPlain");

            migrationBuilder.DropColumn(
                name: "ConnectionString",
                table: "ClientLeads");

            migrationBuilder.DropColumn(
                name: "InternalNotes",
                table: "ClientLeads");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "ClientLeads");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "ClientLeads");

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(467), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(473), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(475), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(476), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "ClientLeads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 1, 37, 24, 405, DateTimeKind.Local).AddTicks(726), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(613), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(614), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(616), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(617), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(693), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(695), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(696), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(644), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(646), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(647), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(649), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(649) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(669), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(671), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(672), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(674), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(938), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(939) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(941), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(941) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(943), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(945), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(946), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(948), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(950), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(951), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(953), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(955), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(956), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(958), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(959), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(961), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(963), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(964), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(966), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(968), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(969), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(971), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(973), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(974), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(976), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(977), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(979), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(980), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(982), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(984), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(985), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(987), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(988), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(990), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(992), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(864), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(866), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(867), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(869), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(870), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(871), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(872), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(874), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(875), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(876), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(877), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(879), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(880), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(881), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(882), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(884), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(885), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(886), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(887), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(889), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(890), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(891), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(892), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(894), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(895), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(896), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(897), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(898) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(899), new DateTime(2026, 5, 17, 8, 37, 24, 405, DateTimeKind.Utc).AddTicks(899) });
        }
    }
}
