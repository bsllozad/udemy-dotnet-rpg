using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_rpg_31.Migrations
{
    public partial class FinalSeedings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, new byte[] { 218, 37, 140, 137, 141, 77, 201, 160, 141, 161, 36, 71, 70, 54, 181, 111, 90, 4, 166, 60, 180, 175, 96, 173, 229, 198, 128, 47, 236, 174, 54, 88 }, new byte[] { 211, 93, 226, 125, 253, 103, 45, 13, 202, 119, 35, 103, 2, 48, 62, 109, 100, 19, 56, 91, 123, 106, 253, 52, 105, 228, 139, 51, 245, 175, 89, 247, 42, 228, 148, 72, 189, 19, 71, 33, 238, 179, 250, 127, 51, 6, 210, 60, 111, 206, 137, 213, 206, 99, 215, 129, 165, 230, 55, 199, 208, 202, 124, 139 }, "User1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 2, new byte[] { 218, 37, 140, 137, 141, 77, 201, 160, 141, 161, 36, 71, 70, 54, 181, 111, 90, 4, 166, 60, 180, 175, 96, 173, 229, 198, 128, 47, 236, 174, 54, 88 }, new byte[] { 211, 93, 226, 125, 253, 103, 45, 13, 202, 119, 35, 103, 2, 48, 62, 109, 100, 19, 56, 91, 123, 106, 253, 52, 105, 228, 139, 51, 245, 175, 89, 247, 42, 228, 148, 72, 189, 19, 71, 33, 238, 179, 250, 127, 51, 6, 210, 60, 111, 206, 137, 213, 206, 99, 215, 129, 165, 230, 55, 199, 208, 202, 124, 139 }, "User2" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 1, 0, 0, 10, 0, 100, 10, "Aragorn", 15, 1, 0 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 2, 1, 0, 5, 0, 100, 20, "Gandalf", 5, 2, 0 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 1, 1, 20, "The Master Sword" });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 2, 2, 5, "Crystal Wand" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
