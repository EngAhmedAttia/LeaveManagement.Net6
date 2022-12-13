using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5003t23d-003c-4360-a43d-1681df5b3b5f", "8ebdde31-a4ea-4308-a462-4c40943c4cde", "Administrator", "ADMINISTRATOR" },
                    { "5003t23f-003g-4570-b43d-1681df5d3b5f", "09ed02d4-3242-4d30-9c50-b1ffe8768090", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaksId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "402a47d0-481b-4e2c-b202-2d40abc668ca", 0, "894151fc-287d-4ad8-b19a-c7495b36bc9d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJzTG2/QBYxxWLiB6sDOVlQAgjvTlaqC0xsxkN2LDMyoR3XNftscMskt1SonVhvslQ==", null, false, "a3d69edf-e8fc-4fc9-a226-fdf12e9c7036", null, false, "user@localhost.com" },
                    { "5003a23d-003b-4560-a45d-1687df5b3b5e", 0, "c7414130-05b1-40cf-bec3-e9928d522bf5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEGdy8dRWI4msduLcaRe0+gzI+fq+GB3yNtVTYM/2xdYcZTupSVoK+HvylGprsK84ug==", null, false, "bd491b74-d716-4eaf-8cac-d2a109744cbc", null, false, "admin@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5003t23f-003g-4570-b43d-1681df5d3b5f", "402a47d0-481b-4e2c-b202-2d40abc668ca" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5003t23d-003c-4360-a43d-1681df5b3b5f", "5003a23d-003b-4560-a45d-1687df5b3b5e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5003t23f-003g-4570-b43d-1681df5d3b5f", "402a47d0-481b-4e2c-b202-2d40abc668ca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5003t23d-003c-4360-a43d-1681df5b3b5f", "5003a23d-003b-4560-a45d-1687df5b3b5e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5003t23d-003c-4360-a43d-1681df5b3b5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5003t23f-003g-4570-b43d-1681df5d3b5f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "402a47d0-481b-4e2c-b202-2d40abc668ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5003a23d-003b-4560-a45d-1687df5b3b5e");
        }
    }
}
