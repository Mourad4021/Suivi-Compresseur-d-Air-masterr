using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pgh.Auth.Model.Migrations
{
    public partial class V0910201902 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"), "0000", "Cette application gérer l'authentification et des permissions des différents applications.", "Gestion de l'authentification  des applications", "AuthApp", true },
                    { new Guid("c5c9921e-2be4-4875-bc33-9fc4612870f6"), "0001", "Cette application gérer le processus d'analyse des échantillons par le labo Dick.", "Gestion de laboratoire Dick", "LaboDickAgro", true },
                    { new Guid("75275dd3-67b7-4097-a39a-151a8e357b85"), "0013", "Mise a jour de l'ancienne application Laboratoir Dick.", "Gestion de laboratoire Dick Elevage", "LaboDickElevage", true }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermId", "PermDescription", "PermDisplayName", "PermName", "PermState" },
                values: new object[,]
                {
                    { new Guid("28439660-afd0-4f48-8099-cdf4743c4b27"), "Users Will Have Permission to Manage personal views.", "Manage personal views", "ManagePersonalViews", true },
                    { new Guid("45fb1687-62fd-4096-9841-823064f57c6e"), "Users Will Have Permission to view pages.", "View Pages", "ViewPages", true },
                    { new Guid("122f6fba-46d8-4e3c-becf-3d5489f724fe"), "Users Will Have Permission to create groups.", "Create Groups", "CreateGroups", true },
                    { new Guid("5f0bbf84-9a6f-407c-9df4-9ab8704fd6cb"), "Users Will Have Permission to view application pages.", "View application pages", "ViewApplicationPages", true },
                    { new Guid("fd539a4b-cde3-46e9-aa7a-89c718f09595"), "Users Will Have Permission to Delete versions.", "Delete Versions", "DeleteVersions", true },
                    { new Guid("3c75c3da-24a2-4da1-b98d-fb958c2f4e41"), "Users Will Have Permission to edit users personal information.", "Edit user's personal information", "EditUserPersonalInformation", true },
                    { new Guid("021e1168-e9e4-4ca7-a47f-e7c2f57bf774"), "Users Will Have Permission to approve items.", "Approve Items", "ApproveItems", true },
                    { new Guid("d03431b8-e1bd-4489-864e-c5e4ef1709f8"), "Users Will Have Permission to View Items.", "View Items", "ViewItems", true },
                    { new Guid("15d5a86a-bab0-46ef-acfa-7bc6cd9a3bf5"), "Users Will Have Permission to delete Elements.", "Delete Items", "DeleteItems", true },
                    { new Guid("02864148-8ebb-486b-bfe5-e36de977d922"), "Users Will Have Permission to edit Items.", "Edit Items", "EditItems", true },
                    { new Guid("3c6f65e3-3070-4300-93f9-3198115d8ec6"), "Users Will Have the permission to add items", "Add Items", "AddItems", true },
                    { new Guid("2624395f-f3a4-4034-adea-be58b55f2900"), "Users Will Have Permission to show versions.", "Show Versions", "ShowVersions", true }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleDescription", "RoleDisplayName", "RoleName", "RoleState" },
                values: new object[,]
                {
                    { new Guid("80f1af2c-8d4d-48ab-bbd7-bedc0b31abf1"), "Restricted reading Default Groupe", "Restricted reading Groupe", "Restricted reading", true },
                    { new Guid("fbe5a4d3-4b79-4516-b4a3-7214a1d3ff03"), "Approval Default Groupe", "Approval Groupe", "Approval", true },
                    { new Guid("bee6ce1b-15fe-44ad-9da0-05f9e415edaf"), "Display Only Default Groupe", "Display Only Groupe", "DisplayOnly", true },
                    { new Guid("92dc9862-164f-414b-8781-2a8dae13e1ec"), "Limited Access Default Groupe", "Limited Access", "LimitedAccess", true },
                    { new Guid("40c34095-e92a-43d2-8159-748c74c8ae84"), "Collaboration Default Groupe", "Collaboration Groupe", "Collaboration", true },
                    { new Guid("9c37b3ad-1ebd-4a89-bbfb-979a2c6e01af"), "Editors Groupe Default Groupe", "Editors Groupe", "Editors", true },
                    { new Guid("d8d0d732-d09c-49c8-bace-d86692129d62"), "Design Groupe Default Groupe", "Design Groupe", "Design", true },
                    { new Guid("af0345e3-cc04-4a5e-8e97-a5b81bbd73a6"), "Total Control Default Groupe", "Total Control", "TotalControl", true },
                    { new Guid("bb3a471c-12b6-481b-964e-b81cebe386d6"), "Readers Groupe Default Groupe", "Readers Groupe", "Readers", true }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UsersId", "FkUsersId", "UsersBirthDate", "UsersCode", "UsersDateLeave", "UsersFilialeCode", "UsersFilialeName", "UsersGenderCode", "UsersJoinDate", "UsersLastName", "UsersMail", "UsersMailIntern", "UsersName", "UsersPersonalNumber", "UsersPhoneNumber", "UsersPosteName", "UsersState" },
                values: new object[,]
                {
                    { new Guid("dc552333-637c-4e18-bd7f-be85f51fef6d"), null, new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6086), "00000002", new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6087), "DD01", "PoulinaGroupeHolding", "M", new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6088), "Test", "User1@poulina.com", "User1@poulina.com", "User1", "63524163", "63524141", "User1 Poste", false },
                    { new Guid("81893b3e-b889-4f3f-88f3-c228994c38d2"), null, new DateTime(2019, 9, 10, 18, 12, 6, 666, DateTimeKind.Local).AddTicks(3726), "00000000", new DateTime(2019, 9, 10, 18, 12, 6, 667, DateTimeKind.Local).AddTicks(9225), "DD01", "PoulinaGroupeHolding", "M", new DateTime(2019, 9, 10, 18, 12, 6, 667, DateTimeKind.Local).AddTicks(9950), "Admin", "Admin@poulina.com", "Admin@poulina.com", "Admin", "63524163", "63524141", "Admin Poste", false },
                    { new Guid("70f5b2ed-8199-43a0-8ad9-c5d8f7832f49"), null, new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6031), "00000001", new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6037), "DD01", "PoulinaGroupeHolding", "M", new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6042), "SupAdmin", "SupAdmin@poulina.com", "SupAdmin@poulina.com", "SupAdmin", "63524163", "63524141", "SupAdmin Poste", false },
                    { new Guid("088e1d30-51a1-497b-9ed3-bee9a9eecaf4"), null, new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6092), "00000003", new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6092), "DD01", "PoulinaGroupeHolding", "M", new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6093), "Test", "User2@poulina.com", "User2@poulina.com", "User2", "63524163", "63524141", "User2 Poste", false }
                });

            migrationBuilder.InsertData(
                table: "Groupes",
                columns: new[] { "GrpId", "FkAppId", "GrpDescription", "GrpDisplayName", "GrpName", "GrpState" },
                values: new object[,]
                {
                    { new Guid("4ec91795-c9dd-404d-827b-19844ee55a49"), new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"), "Administration Groupe for Authentication Application", "Administration Groupes", "AdministratorAuth", true },
                    { new Guid("c8c8491f-0339-49a9-b5b8-59de49bc911f"), new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"), "Readers Groupe for Authentication Application", "Readers Groupes", "ReadersAuth", true },
                    { new Guid("eec69692-8bfc-4cd4-b111-a47dabc19c04"), new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"), "Editors Groupe for Authentication Application", "Editors Groupes", "EditorsAuth", true }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "FkAppId", "FkMenuId", "MenuDescription", "MenuDisplayName", "MenuName", "MenuState", "MenuUrl" },
                values: new object[,]
                {
                    { new Guid("867daa3a-5d07-4339-b352-8ba59b724963"), new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"), null, "User setup menu.", "Users", "AuthUsers", true, "Http://srvapp/authusers" },
                    { new Guid("5a08c329-d42f-43d0-a632-ff1c22fc9301"), new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"), null, "Permissions setup menu.", "Permissions", "AuthPermissions", true, "Http://srvapp/authpermissions" },
                    { new Guid("822d45e6-ec8f-46bf-94ea-07f37b2a1904"), new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"), null, "Roles setup menu.", "Roles", "AuthRoles", true, "Http://srvapp/authroles" },
                    { new Guid("ffabfea9-a875-4313-adc0-3a9ea3059862"), new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"), null, "Applications setup menu.", "Applications", "AuthApplications", true, "Http://srvapp/authappications" },
                    { new Guid("5c78b402-0f82-4e40-b895-14a0403832df"), new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"), null, "Menus setup menu.", "Menus", "AuthMenus", true, "Http://srvapp/authmenus" },
                    { new Guid("32b3fa8f-f905-4809-904f-8d65ca066730"), new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"), null, "Groupes setup menu.", "Groupes", "AuthGroupes", true, "Http://srvapp/authgroupes" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "AppId",
                keyValue: new Guid("75275dd3-67b7-4097-a39a-151a8e357b85"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "AppId",
                keyValue: new Guid("c5c9921e-2be4-4875-bc33-9fc4612870f6"));

            migrationBuilder.DeleteData(
                table: "Groupes",
                keyColumn: "GrpId",
                keyValue: new Guid("4ec91795-c9dd-404d-827b-19844ee55a49"));

            migrationBuilder.DeleteData(
                table: "Groupes",
                keyColumn: "GrpId",
                keyValue: new Guid("c8c8491f-0339-49a9-b5b8-59de49bc911f"));

            migrationBuilder.DeleteData(
                table: "Groupes",
                keyColumn: "GrpId",
                keyValue: new Guid("eec69692-8bfc-4cd4-b111-a47dabc19c04"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("32b3fa8f-f905-4809-904f-8d65ca066730"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5a08c329-d42f-43d0-a632-ff1c22fc9301"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5c78b402-0f82-4e40-b895-14a0403832df"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("822d45e6-ec8f-46bf-94ea-07f37b2a1904"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("867daa3a-5d07-4339-b352-8ba59b724963"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ffabfea9-a875-4313-adc0-3a9ea3059862"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("021e1168-e9e4-4ca7-a47f-e7c2f57bf774"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("02864148-8ebb-486b-bfe5-e36de977d922"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("122f6fba-46d8-4e3c-becf-3d5489f724fe"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("15d5a86a-bab0-46ef-acfa-7bc6cd9a3bf5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("2624395f-f3a4-4034-adea-be58b55f2900"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("28439660-afd0-4f48-8099-cdf4743c4b27"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("3c6f65e3-3070-4300-93f9-3198115d8ec6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("3c75c3da-24a2-4da1-b98d-fb958c2f4e41"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("45fb1687-62fd-4096-9841-823064f57c6e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("5f0bbf84-9a6f-407c-9df4-9ab8704fd6cb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("d03431b8-e1bd-4489-864e-c5e4ef1709f8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermId",
                keyValue: new Guid("fd539a4b-cde3-46e9-aa7a-89c718f09595"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("40c34095-e92a-43d2-8159-748c74c8ae84"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("80f1af2c-8d4d-48ab-bbd7-bedc0b31abf1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("92dc9862-164f-414b-8781-2a8dae13e1ec"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("9c37b3ad-1ebd-4a89-bbfb-979a2c6e01af"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("af0345e3-cc04-4a5e-8e97-a5b81bbd73a6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("bb3a471c-12b6-481b-964e-b81cebe386d6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("bee6ce1b-15fe-44ad-9da0-05f9e415edaf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("d8d0d732-d09c-49c8-bace-d86692129d62"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("fbe5a4d3-4b79-4516-b4a3-7214a1d3ff03"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UsersId",
                keyValue: new Guid("088e1d30-51a1-497b-9ed3-bee9a9eecaf4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UsersId",
                keyValue: new Guid("70f5b2ed-8199-43a0-8ad9-c5d8f7832f49"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UsersId",
                keyValue: new Guid("81893b3e-b889-4f3f-88f3-c228994c38d2"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UsersId",
                keyValue: new Guid("dc552333-637c-4e18-bd7f-be85f51fef6d"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "AppId",
                keyValue: new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"));

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
    }
}
