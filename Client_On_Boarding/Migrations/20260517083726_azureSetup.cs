using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Client_On_Boarding.Migrations
{
    /// <inheritdoc />
    public partial class azureSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6090), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6099), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6101), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6102), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "ClientLeads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 1, 16, 3, 528, DateTimeKind.Local).AddTicks(6442), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6284), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6287), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6289), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6291), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6399), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6401), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6403), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6324), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6327), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6329), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6331), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6363), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6365), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6367), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6368), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7799), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7802), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7804), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7806), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7808), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7810), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7811), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7813), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7815), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7817), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7819), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7821), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7823), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7825), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7827), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7829), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7831), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7833), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7835), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7837), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7840), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7842), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7844), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7846), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7848), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7850), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7852), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7854), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7856), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7858), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7860), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7861), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7863), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7606), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7611), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7613), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7615), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7695), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7697), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7698), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7700), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7701), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7703), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7705), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7707), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7708), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7710), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7711), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7713), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7715), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7716), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7718), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7719), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7721), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7722), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7724), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7725), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7727), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7728), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7730), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7731), new DateTime(2026, 5, 17, 8, 16, 3, 528, DateTimeKind.Utc).AddTicks(7732) });
        }
    }
}
