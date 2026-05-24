using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Client_On_Boarding.Migrations
{
    /// <inheritdoc />
    public partial class BillingOrSubcriptionMap_ClientLead : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "SubscriptionPlain",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "BillingCycleId",
                table: "ClientLeads",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BillingId",
                table: "ClientLeads",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionPlainId",
                table: "ClientLeads",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubsrcriptionId",
                table: "ClientLeads",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BillingCycle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7525), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "BillingCycle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7527), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "BillingCycle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7529), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7085), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7092), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7094), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "BusinessIndustries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7096), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "ClientLeads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BillingCycleId", "BillingId", "CreateDate", "ModifyDate", "SubscriptionPlainId", "SubsrcriptionId" },
                values: new object[] { null, null, new DateTime(2026, 5, 24, 11, 31, 45, 881, DateTimeKind.Local).AddTicks(7426), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7416), null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7240), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7242), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7244), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7245), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "ErpModules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7549), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7394), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7396), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "LeadPriorities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7397), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7335), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7337), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7339), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "LeadSources",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7340), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7367), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7369), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7371), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "LeadStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7372), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7663), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7668), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7670), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7672), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7674), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7678), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7679), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7681), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7683), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7684), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7686), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7687), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7689), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7738), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7740), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7742), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7744), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7745), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7747), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7749), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7750), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7752), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7754), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7755), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7757), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7758), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7760), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7762), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7763), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7765), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7767), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7768), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "PageFieldSetting",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7770), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7587), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7589), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7590), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7592), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7593), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7594), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7595), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7597), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7598), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7599), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7600), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7601), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7603), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7604), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7605), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7606), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7608), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7609), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7610), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7611), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7612), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7614), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7615), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7616), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7618), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7619), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7620), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7621), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlain",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "CreateDate", "ModifyDate" },
                values: new object[] { null, new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7567), new DateTime(2026, 5, 24, 18, 31, 45, 881, DateTimeKind.Utc).AddTicks(7568) });

            migrationBuilder.CreateIndex(
                name: "IX_ClientLeads_BillingCycleId",
                table: "ClientLeads",
                column: "BillingCycleId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientLeads_SubscriptionPlainId",
                table: "ClientLeads",
                column: "SubscriptionPlainId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientLeads_BillingCycle_BillingCycleId",
                table: "ClientLeads",
                column: "BillingCycleId",
                principalTable: "BillingCycle",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientLeads_SubscriptionPlain_SubscriptionPlainId",
                table: "ClientLeads",
                column: "SubscriptionPlainId",
                principalTable: "SubscriptionPlain",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientLeads_BillingCycle_BillingCycleId",
                table: "ClientLeads");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientLeads_SubscriptionPlain_SubscriptionPlainId",
                table: "ClientLeads");

            migrationBuilder.DropIndex(
                name: "IX_ClientLeads_BillingCycleId",
                table: "ClientLeads");

            migrationBuilder.DropIndex(
                name: "IX_ClientLeads_SubscriptionPlainId",
                table: "ClientLeads");

            migrationBuilder.DropColumn(
                name: "BillingCycleId",
                table: "ClientLeads");

            migrationBuilder.DropColumn(
                name: "BillingId",
                table: "ClientLeads");

            migrationBuilder.DropColumn(
                name: "SubscriptionPlainId",
                table: "ClientLeads");

            migrationBuilder.DropColumn(
                name: "SubsrcriptionId",
                table: "ClientLeads");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "SubscriptionPlain",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BillingCycle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9280), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "BillingCycle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9282), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "BillingCycle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9283), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9283) });

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
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 2, 41, 37, 267, DateTimeKind.Local).AddTicks(9182), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9173) });

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

            migrationBuilder.UpdateData(
                table: "ErpModules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9299), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9300) });

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

            migrationBuilder.UpdateData(
                table: "SubscriptionPlain",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "CreateDate", "ModifyDate" },
                values: new object[] { 0m, new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9318), new DateTime(2026, 5, 23, 9, 41, 37, 267, DateTimeKind.Utc).AddTicks(9318) });
        }
    }
}
