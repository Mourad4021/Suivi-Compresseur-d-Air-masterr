using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pgh.Auth.Model.Migrations
{
    public partial class V10092019 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("fc5dcfbb-7f24-479c-922c-e8663bf5cab4"), "0000", "Cette application gérer l'authentification et des permissions des différents applications.", "Gestion de l'authentification  des applications", "AuthApp", true },
                    { new Guid("f39a767f-fb5d-490a-b3a3-6903eeb21638"), "0001", "Cette application gérer le processus d'analyse des échantillons par le labo Dick.", "Gestion de laboratoire Dick", "LaboDickAgro", true },
                    { new Guid("0a70dd20-305c-4e2b-b84e-704d827d2bfb"), "0013", "Mise a jour de l'ancienne application Laboratoir Dick.", "Gestion de laboratoire Dick Elevage", "LaboDickElevage", true }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermId", "PermDescription", "PermDisplayName", "PermName", "PermState" },
                values: new object[,]
                {
                    { new Guid("55246a69-70f1-484c-b454-057040cb408d"), "Users Will Have Permission to Manage personal views.", "Manage personal views", "ManagePersonalViews", true },
                    { new Guid("0c3fb9e5-9703-47ca-8290-e0ee0a6bf704"), "Users Will Have Permission to view pages.", "View Pages", "ViewPages", true },
                    { new Guid("b6cc17d7-8885-474d-8397-08dd594a43d9"), "Users Will Have Permission to create groups.", "Create Groups", "CreateGroups", true },
                    { new Guid("ddfea423-43ab-460f-aa82-75e9e56c6bd3"), "Users Will Have Permission to view application pages.", "View application pages", "ViewApplicationPages", true },
                    { new Guid("ea418322-d667-4742-8b47-79e0bcd9c43c"), "Users Will Have Permission to Delete versions.", "Delete Versions", "DeleteVersions", true },
                    { new Guid("d23cdb47-bc5f-4d55-b1a8-fbf033a11c16"), "Users Will Have Permission to edit users personal information.", "Edit user's personal information", "EditUserPersonalInformation", true },
                    { new Guid("81a7c86b-65de-4b7c-a608-b1d904f499b6"), "Users Will Have Permission to approve items.", "Approve Items", "ApproveItems", true },
                    { new Guid("e2855fd2-6713-420a-96c6-b31ba50a6f89"), "Users Will Have Permission to View Items.", "View Items", "ViewItems", true },
                    { new Guid("b781e222-af1d-4abf-af36-96c507815829"), "Users Will Have Permission to delete Elements.", "Delete Items", "DeleteItems", true },
                    { new Guid("c68d7a74-7e29-4b24-90a2-5f06f9e40048"), "Users Will Have Permission to edit Items.", "Edit Items", "EditItems", true },
                    { new Guid("13377610-d71b-4c3a-a7a1-feed4f21fb15"), "Users Will Have the permission to add items", "Add Items", "AddItems", true },
                    { new Guid("20ead205-14ac-4a14-adce-2d69df261801"), "Users Will Have Permission to show versions.", "Show Versions", "ShowVersions", true }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleDescription", "RoleDisplayName", "RoleName", "RoleState" },
                values: new object[,]
                {
                    { new Guid("aad23d91-72f7-46da-a5b6-ea8a6d6fc526"), "Restricted reading Default Groupe", "Restricted reading Groupe", "Restricted reading", true },
                    { new Guid("378ddc6d-f019-4103-a072-1a2f0da53094"), "Approval Default Groupe", "Approval Groupe", "Approval", true },
                    { new Guid("319d93fe-47f0-49cf-a4c6-f358fe88354c"), "Display Only Default Groupe", "Display Only Groupe", "DisplayOnly", true },
                    { new Guid("5cb17690-b876-46d9-97a5-9d3ef9c6295f"), "Limited Access Default Groupe", "Limited Access", "LimitedAccess", true },
                    { new Guid("ef49422b-0246-464b-8bae-a6f5408a82b1"), "Collaboration Default Groupe", "Collaboration Groupe", "Collaboration", true },
                    { new Guid("a59d6f95-74a2-4525-ad61-f6ab6e626ea3"), "Editors Groupe Default Groupe", "Editors Groupe", "Editors", true },
                    { new Guid("870057fd-94b0-4b02-9749-d058ac5fdc03"), "Design Groupe Default Groupe", "Design Groupe", "Design", true },
                    { new Guid("5acd82a4-dd50-46ed-9a82-7a735663e0df"), "Total Control Default Groupe", "Total Control", "TotalControl", true },
                    { new Guid("663f67d9-599c-42c3-b818-0c939c5e14c1"), "Readers Groupe Default Groupe", "Readers Groupe", "Readers", true }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UsersId", "FkUsersId", "UsersBirthDate", "UsersCode", "UsersDateLeave", "UsersFilialeCode", "UsersFilialeName", "UsersGenderCode", "UsersJoinDate", "UsersLastName", "UsersMail", "UsersMailIntern", "UsersName", "UsersPersonalNumber", "UsersPhoneNumber", "UsersPosteName", "UsersState" },
                values: new object[,]
                {
                    { new Guid("ac1f391b-da75-4d08-8222-26969a35ce58"), null, new DateTime(2019, 9, 10, 17, 56, 9, 137, DateTimeKind.Local).AddTicks(2170), "00000002", new DateTime(2019, 9, 10, 17, 56, 9, 137, DateTimeKind.Local).AddTicks(2171), "DD01", "PoulinaGroupeHolding", "M", new DateTime(2019, 9, 10, 17, 56, 9, 137, DateTimeKind.Local).AddTicks(2171), "Test", "User1@poulina.com", "User1@poulina.com", "User1", "63524163", "63524141", "User1 Poste", false },
                    { new Guid("d360d9d1-540d-4915-8637-a58990c0eff2"), null, new DateTime(2019, 9, 10, 17, 56, 9, 134, DateTimeKind.Local).AddTicks(7439), "00000000", new DateTime(2019, 9, 10, 17, 56, 9, 136, DateTimeKind.Local).AddTicks(3466), "DD01", "PoulinaGroupeHolding", "M", new DateTime(2019, 9, 10, 17, 56, 9, 136, DateTimeKind.Local).AddTicks(4362), "Admin", "Admin@poulina.com", "Admin@poulina.com", "Admin", "63524163", "63524141", "Admin Poste", false },
                    { new Guid("1eb21829-ebee-410a-a3b2-6237bf8c24c9"), null, new DateTime(2019, 9, 10, 17, 56, 9, 137, DateTimeKind.Local).AddTicks(2110), "00000001", new DateTime(2019, 9, 10, 17, 56, 9, 137, DateTimeKind.Local).AddTicks(2119), "DD01", "PoulinaGroupeHolding", "M", new DateTime(2019, 9, 10, 17, 56, 9, 137, DateTimeKind.Local).AddTicks(2123), "SupAdmin", "SupAdmin@poulina.com", "SupAdmin@poulina.com", "SupAdmin", "63524163", "63524141", "SupAdmin Poste", false },
                    { new Guid("da4a9814-7c71-4104-8447-cb778317db6c"), null, new DateTime(2019, 9, 10, 17, 56, 9, 137, DateTimeKind.Local).AddTicks(2204), "00000003", new DateTime(2019, 9, 10, 17, 56, 9, 137, DateTimeKind.Local).AddTicks(2204), "DD01", "PoulinaGroupeHolding", "M", new DateTime(2019, 9, 10, 17, 56, 9, 137, DateTimeKind.Local).AddTicks(2205), "Test", "User2@poulina.com", "User2@poulina.com", "User2", "63524163", "63524141", "User2 Poste", false }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "FkAppId", "FkMenuId", "MenuDescription", "MenuDisplayName", "MenuName", "MenuState", "MenuUrl" },
                values: new object[,]
                {
                    { new Guid("80795f57-7878-4ba4-9acb-ce0ee1a1e87e"), new Guid("fc5dcfbb-7f24-479c-922c-e8663bf5cab4"), null, "User setup menu.", "Users", "AuthUsers", true, "Http://srvapp/authusers" },
                    { new Guid("52010bc1-528f-4ea3-b978-dbb5956cd88c"), new Guid("fc5dcfbb-7f24-479c-922c-e8663bf5cab4"), null, "Permissions setup menu.", "Permissions", "AuthPermissions", true, "Http://srvapp/authpermissions" },
                    { new Guid("19b3c4d6-bd51-441f-8455-0b19d164a7dd"), new Guid("fc5dcfbb-7f24-479c-922c-e8663bf5cab4"), null, "Roles setup menu.", "Roles", "AuthRoles", true, "Http://srvapp/authroles" },
                    { new Guid("b01a7bf8-036a-4ff2-97f1-5a71f1eb35c8"), new Guid("fc5dcfbb-7f24-479c-922c-e8663bf5cab4"), null, "Applications setup menu.", "Applications", "AuthApplications", true, "Http://srvapp/authappications" },
                    { new Guid("300b625d-4be5-455e-bab8-b6c0dd29540c"), new Guid("fc5dcfbb-7f24-479c-922c-e8663bf5cab4"), null, "Menus setup menu.", "Menus", "AuthMenus", true, "Http://srvapp/authmenus" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "AppId",
                keyValue: new Guid("0a70dd20-305c-4e2b-b84e-704d827d2bfb"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "AppId",
                keyValue: new Guid("f39a767f-fb5d-490a-b3a3-6903eeb21638"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("19b3c4d6-bd51-441f-8455-0b19d164a7dd"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("300b625d-4be5-455e-bab8-b6c0dd29540c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("52010bc1-528f-4ea3-b978-dbb5956cd88c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("80795f57-7878-4ba4-9acb-ce0ee1a1e87e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b01a7bf8-036a-4ff2-97f1-5a71f1eb35c8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("0c3fb9e5-9703-47ca-8290-e0ee0a6bf704"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("13377610-d71b-4c3a-a7a1-feed4f21fb15"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("20ead205-14ac-4a14-adce-2d69df261801"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("55246a69-70f1-484c-b454-057040cb408d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("81a7c86b-65de-4b7c-a608-b1d904f499b6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("b6cc17d7-8885-474d-8397-08dd594a43d9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("b781e222-af1d-4abf-af36-96c507815829"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("c68d7a74-7e29-4b24-90a2-5f06f9e40048"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("d23cdb47-bc5f-4d55-b1a8-fbf033a11c16"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("ddfea423-43ab-460f-aa82-75e9e56c6bd3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("e2855fd2-6713-420a-96c6-b31ba50a6f89"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("ea418322-d667-4742-8b47-79e0bcd9c43c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("319d93fe-47f0-49cf-a4c6-f358fe88354c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("378ddc6d-f019-4103-a072-1a2f0da53094"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("5acd82a4-dd50-46ed-9a82-7a735663e0df"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("5cb17690-b876-46d9-97a5-9d3ef9c6295f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("663f67d9-599c-42c3-b818-0c939c5e14c1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("870057fd-94b0-4b02-9749-d058ac5fdc03"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("a59d6f95-74a2-4525-ad61-f6ab6e626ea3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("aad23d91-72f7-46da-a5b6-ea8a6d6fc526"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("ef49422b-0246-464b-8bae-a6f5408a82b1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UsersId",
                keyValue: new Guid("1eb21829-ebee-410a-a3b2-6237bf8c24c9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UsersId",
                keyValue: new Guid("ac1f391b-da75-4d08-8222-26969a35ce58"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UsersId",
                keyValue: new Guid("d360d9d1-540d-4915-8637-a58990c0eff2"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UsersId",
                keyValue: new Guid("da4a9814-7c71-4104-8447-cb778317db6c"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "AppId",
                keyValue: new Guid("fc5dcfbb-7f24-479c-922c-e8663bf5cab4"));

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
        }
    }
}
