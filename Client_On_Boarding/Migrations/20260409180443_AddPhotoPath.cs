using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Client_On_Boarding.Migrations
{
    /// <inheritdoc />
    public partial class AddPhotoPath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "ClientLeads",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "ClientLeads");

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4794), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4798), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4799), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4800), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4908), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4910), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4911), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4912), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4964), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4966), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4967), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4928), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4929), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4930), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4931), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4947), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4948), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4949), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4950), new DateTime(2026, 4, 9, 17, 16, 22, 999, DateTimeKind.Utc).AddTicks(4951) });
        }
    }
}
