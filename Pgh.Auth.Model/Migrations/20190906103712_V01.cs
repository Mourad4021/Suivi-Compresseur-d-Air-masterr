using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pgh.Auth.Model.Migrations
{
    public partial class V01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Applications_FkAppId",
                table: "Menus");

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "AppId",
                keyValue: new Guid("63419a1c-f347-4f7f-8667-0277d407e4eb"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "AppId",
                keyValue: new Guid("cc94c8ff-fc72-46ab-90d6-e04a24d5ef72"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("a1722eb6-99d4-49d4-a0c5-f00bf6f8ac40"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("a3394ab4-faf9-4deb-b305-4de44408e25f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("ccdef048-281e-4015-b5bf-a02cd9c26f25"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("fa94a36a-1b99-45b2-9ac4-8812aceadebe"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("fb174caf-8ba8-45d8-a810-026dc977793a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("179e3214-badd-4fac-8312-a3c8d45a027d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("b9a340fa-0274-4634-81df-c5cd6d9d377d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UsersId",
                keyValue: new Guid("384f0912-cc5b-4504-ad61-a314dac749cf"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UsersId",
                keyValue: new Guid("5816a32f-5b69-4bdf-8910-ceb00b649569"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UsersId",
                keyValue: new Guid("aca05877-f204-4ac8-9ec2-15466d263d0e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UsersId",
                keyValue: new Guid("d1ae9d96-2d1e-4585-b4f5-7a8b99adaf01"));

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "AppId", "AppCode", "AppDescription", "AppDisplayName", "AppName", "AppState" },
                values: new object[,]
                {
                    { new Guid("65e582f2-e513-4164-ae8a-9f2aed435222"), "0012", "Cette application gérer le processus d'analyse des échantillons par le labo Dick", "Gestion de laboratoire Dick", "LaboDick", false },
                    { new Guid("ea445968-9398-4058-bd2c-23293428765e"), "0013", "Mise a jour de l'ancienne application Laboratoir Dick", "Gestion de laboratoire Dick V2", "LaboDick V2", false }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermId", "PermDescription", "PermDisplayName", "PermName", "PermState" },
                values: new object[,]
                {
                    { new Guid("ca33b4da-a217-43e5-aefc-22c9b73a0d89"), "Users Will Have Read Permission.", "Affichage", "Read", true },
                    { new Guid("5bdadf51-9c3d-4964-9733-7378e469cf44"), "Users Will Have Create Permission.", "Creation", "Create", true },
                    { new Guid("4f47cd97-e586-471a-b428-d43c84141573"), "Users Will Have Update Permission.", "Mise à jour", "Update", true },
                    { new Guid("0d0cda2c-826c-445f-b52b-4aacb438e1e8"), "Users Will Have Delete Permission.", "Suppression", "Delete", true },
                    { new Guid("380117cd-58c7-4a53-a290-87e5b431cfde"), "Users Will Have Permission To View Reporting Pages.", "View Reporting", "ViewReporting", true }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleDescription", "RoleDisplayName", "RoleName", "RoleState" },
                values: new object[,]
                {
                    { new Guid("48da03cd-03fc-42df-85d2-cdfb8aa3ac8f"), "Ce rôle vous permet de lire les données spécifique de l'application.", "Readers LaboDick", "Readers", true },
                    { new Guid("e616fca0-d7f3-4288-85dc-7f30d55f36f2"), "Ce rôle vous permet de Modifier les données spécifique de l'application.", "Editors LaboDick", "Editors", true }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UsersId", "FkUsersId", "UsersBirthDate", "UsersCode", "UsersDateLeave", "UsersFilialeCode", "UsersFilialeName", "UsersGenderCode", "UsersJoinDate", "UsersLastName", "UsersMail", "UsersMailIntern", "UsersName", "UsersPersonalNumber", "UsersPhoneNumber", "UsersPosteName", "UsersState" },
                values: new object[,]
                {
                    { new Guid("2b6db602-4730-4c15-925a-8ca338a70e6b"), null, new DateTime(2019, 9, 6, 11, 37, 11, 818, DateTimeKind.Local).AddTicks(4528), "00000000", new DateTime(2019, 9, 6, 11, 37, 11, 821, DateTimeKind.Local).AddTicks(3282), "DD01", "PoulinaGroupeHolding", "M", new DateTime(2019, 9, 6, 11, 37, 11, 821, DateTimeKind.Local).AddTicks(4305), "Admin", "Admin@poulina.com", "Admin@poulina.com", "Admin", "63524163", "63524141", "Admin Poste", false },
                    { new Guid("0afb105d-5e9a-4306-934d-72f78f5d2768"), null, new DateTime(2019, 9, 6, 11, 37, 11, 822, DateTimeKind.Local).AddTicks(3230), "00000001", new DateTime(2019, 9, 6, 11, 37, 11, 822, DateTimeKind.Local).AddTicks(3242), "DD01", "PoulinaGroupeHolding", "M", new DateTime(2019, 9, 6, 11, 37, 11, 822, DateTimeKind.Local).AddTicks(3251), "SupAdmin", "SupAdmin@poulina.com", "SupAdmin@poulina.com", "SupAdmin", "63524163", "63524141", "SupAdmin Poste", false },
                    { new Guid("6e9544e5-1b31-44f1-995f-aebe22b9c6dd"), null, new DateTime(2019, 9, 6, 11, 37, 11, 822, DateTimeKind.Local).AddTicks(3320), "00000002", new DateTime(2019, 9, 6, 11, 37, 11, 822, DateTimeKind.Local).AddTicks(3323), "DD01", "PoulinaGroupeHolding", "M", new DateTime(2019, 9, 6, 11, 37, 11, 822, DateTimeKind.Local).AddTicks(3324), "Test", "User1@poulina.com", "User1@poulina.com", "User1", "63524163", "63524141", "User1 Poste", false },
                    { new Guid("48fa45ce-d66a-4e16-938c-87470f944363"), null, new DateTime(2019, 9, 6, 11, 37, 11, 822, DateTimeKind.Local).AddTicks(3329), "00000003", new DateTime(2019, 9, 6, 11, 37, 11, 822, DateTimeKind.Local).AddTicks(3330), "DD01", "PoulinaGroupeHolding", "M", new DateTime(2019, 9, 6, 11, 37, 11, 822, DateTimeKind.Local).AddTicks(3331), "Test", "User2@poulina.com", "User2@poulina.com", "User2", "63524163", "63524141", "User2 Poste", false }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Applications_FkAppId",
                table: "Menus",
                column: "FkAppId",
                principalTable: "Applications",
                principalColumn: "AppId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Applications_FkAppId",
                table: "Menus");

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "AppId",
                keyValue: new Guid("65e582f2-e513-4164-ae8a-9f2aed435222"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "AppId",
                keyValue: new Guid("ea445968-9398-4058-bd2c-23293428765e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("0d0cda2c-826c-445f-b52b-4aacb438e1e8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("380117cd-58c7-4a53-a290-87e5b431cfde"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("4f47cd97-e586-471a-b428-d43c84141573"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("5bdadf51-9c3d-4964-9733-7378e469cf44"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("ca33b4da-a217-43e5-aefc-22c9b73a0d89"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("48da03cd-03fc-42df-85d2-cdfb8aa3ac8f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("e616fca0-d7f3-4288-85dc-7f30d55f36f2"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UsersId",
                keyValue: new Guid("0afb105d-5e9a-4306-934d-72f78f5d2768"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UsersId",
                keyValue: new Guid("2b6db602-4730-4c15-925a-8ca338a70e6b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UsersId",
                keyValue: new Guid("48fa45ce-d66a-4e16-938c-87470f944363"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UsersId",
                keyValue: new Guid("6e9544e5-1b31-44f1-995f-aebe22b9c6dd"));

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "AppId", "AppCode", "AppDescription", "AppDisplayName", "AppName", "AppState" },
                values: new object[,]
                {
                    { new Guid("cc94c8ff-fc72-46ab-90d6-e04a24d5ef72"), "0012", "Cette application gérer le processus d'analyse des échantillons par le labo Dick", "Gestion de laboratoire Dick", "LaboDick", false },
                    { new Guid("63419a1c-f347-4f7f-8667-0277d407e4eb"), "0013", "Mise a jour de l'ancienne application Laboratoir Dick", "Gestion de laboratoire Dick V2", "LaboDick V2", false }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermId", "PermDescription", "PermDisplayName", "PermName", "PermState" },
                values: new object[,]
                {
                    { new Guid("a3394ab4-faf9-4deb-b305-4de44408e25f"), "Users Will Have Read Permission.", "Affichage", "Read", true },
                    { new Guid("fb174caf-8ba8-45d8-a810-026dc977793a"), "Users Will Have Create Permission.", "Creation", "Create", true },
                    { new Guid("ccdef048-281e-4015-b5bf-a02cd9c26f25"), "Users Will Have Update Permission.", "Mise à jour", "Update", true },
                    { new Guid("fa94a36a-1b99-45b2-9ac4-8812aceadebe"), "Users Will Have Delete Permission.", "Suppression", "Delete", true },
                    { new Guid("a1722eb6-99d4-49d4-a0c5-f00bf6f8ac40"), "Users Will Have Permission To View Reporting Pages.", "View Reporting", "ViewReporting", true }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleDescription", "RoleDisplayName", "RoleName", "RoleState" },
                values: new object[,]
                {
                    { new Guid("b9a340fa-0274-4634-81df-c5cd6d9d377d"), "Ce rôle vous permet de lire les données spécifique de l'application.", "Readers LaboDick", "Readers", true },
                    { new Guid("179e3214-badd-4fac-8312-a3c8d45a027d"), "Ce rôle vous permet de Modifier les données spécifique de l'application.", "Editors LaboDick", "Editors", true }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UsersId", "FkUsersId", "UsersBirthDate", "UsersCode", "UsersDateLeave", "UsersFilialeCode", "UsersFilialeName", "UsersGenderCode", "UsersJoinDate", "UsersLastName", "UsersMail", "UsersMailIntern", "UsersName", "UsersPersonalNumber", "UsersPhoneNumber", "UsersPosteName", "UsersState" },
                values: new object[,]
                {
                    { new Guid("aca05877-f204-4ac8-9ec2-15466d263d0e"), null, new DateTime(2019, 9, 6, 11, 3, 14, 723, DateTimeKind.Local).AddTicks(9450), "00000000", new DateTime(2019, 9, 6, 11, 3, 14, 729, DateTimeKind.Local).AddTicks(1638), "DD01", "PoulinaGroupeHolding", "M", new DateTime(2019, 9, 6, 11, 3, 14, 729, DateTimeKind.Local).AddTicks(2636), "Admin", "Admin@poulina.com", "Admin@poulina.com", "Admin", "63524163", "63524141", "Admin Poste", false },
                    { new Guid("d1ae9d96-2d1e-4585-b4f5-7a8b99adaf01"), null, new DateTime(2019, 9, 6, 11, 3, 14, 733, DateTimeKind.Local).AddTicks(4933), "00000001", new DateTime(2019, 9, 6, 11, 3, 14, 733, DateTimeKind.Local).AddTicks(4956), "DD01", "PoulinaGroupeHolding", "M", new DateTime(2019, 9, 6, 11, 3, 14, 733, DateTimeKind.Local).AddTicks(4965), "SupAdmin", "SupAdmin@poulina.com", "SupAdmin@poulina.com", "SupAdmin", "63524163", "63524141", "SupAdmin Poste", false },
                    { new Guid("5816a32f-5b69-4bdf-8910-ceb00b649569"), null, new DateTime(2019, 9, 6, 11, 3, 14, 733, DateTimeKind.Local).AddTicks(5038), "00000002", new DateTime(2019, 9, 6, 11, 3, 14, 733, DateTimeKind.Local).AddTicks(5039), "DD01", "PoulinaGroupeHolding", "M", new DateTime(2019, 9, 6, 11, 3, 14, 733, DateTimeKind.Local).AddTicks(5041), "Test", "User1@poulina.com", "User1@poulina.com", "User1", "63524163", "63524141", "User1 Poste", false },
                    { new Guid("384f0912-cc5b-4504-ad61-a314dac749cf"), null, new DateTime(2019, 9, 6, 11, 3, 14, 733, DateTimeKind.Local).AddTicks(5046), "00000003", new DateTime(2019, 9, 6, 11, 3, 14, 733, DateTimeKind.Local).AddTicks(5047), "DD01", "PoulinaGroupeHolding", "M", new DateTime(2019, 9, 6, 11, 3, 14, 733, DateTimeKind.Local).AddTicks(5048), "Test", "User2@poulina.com", "User2@poulina.com", "User2", "63524163", "63524141", "User2 Poste", false }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Applications_FkAppId",
                table: "Menus",
                column: "FkAppId",
                principalTable: "Applications",
                principalColumn: "AppId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
