using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Client_On_Boarding.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    { 1, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4794), 0, "Rice Wholesaler", 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4797) },
                    { 2, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4798), 0, "Medical Wholesaler", 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4798) },
                    { 3, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4799), 0, "Electronics", 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4799) },
                    { 4, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4800), 0, "Restaurant", 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4800) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName", "CreateDate", "CreatedBy", "ModifyBy", "ModifyDate" },
                values: new object[,]
                {
                    { 1, "Bangladesh", new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4908), 0, 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4908) },
                    { 2, "India", new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4910), 0, 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4910) },
                    { 3, "Pakistan", new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4911), 0, 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4911) },
                    { 4, "Sri Lanka", new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4912), 0, 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4912) }
                });

            migrationBuilder.InsertData(
                table: "LeadPriorities",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "ModifyBy", "ModifyDate", "PriorityName" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4964), 0, 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4965), "Low" },
                    { 2, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4966), 0, 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4966), "Medium" },
                    { 3, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4967), 0, 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4967), "High" }
                });

            migrationBuilder.InsertData(
                table: "LeadSources",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "LeadSourceName", "ModifyBy", "ModifyDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4928), 0, "Referral", 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4928) },
                    { 2, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4929), 0, "Website", 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4929) },
                    { 3, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4930), 0, "LinkedIn", 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4930) },
                    { 4, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4931), 0, "Cold Call", 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4932) }
                });

            migrationBuilder.InsertData(
                table: "LeadStatuses",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "ModifyBy", "ModifyDate", "StatusName" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4947), 0, 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4947), "New" },
                    { 2, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4948), 0, 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4949), "Contacted" },
                    { 3, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4949), 0, 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4950), "Follow-up" },
                    { 4, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4950), 0, 0, new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4951), "Active" }
                });

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
