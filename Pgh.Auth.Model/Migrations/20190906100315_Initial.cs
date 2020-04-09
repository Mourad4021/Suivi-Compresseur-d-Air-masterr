using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pgh.Auth.Model.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    AppId = table.Column<Guid>(nullable: false),
                    AppCode = table.Column<string>(nullable: true),
                    AppName = table.Column<string>(nullable: true),
                    AppDisplayName = table.Column<string>(nullable: true),
                    AppDescription = table.Column<string>(nullable: true),
                    AppState = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.AppId);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    PermId = table.Column<Guid>(nullable: false),
                    PermName = table.Column<string>(nullable: true),
                    PermDisplayName = table.Column<string>(nullable: true),
                    PermDescription = table.Column<string>(nullable: true),
                    PermState = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(nullable: false),
                    RoleName = table.Column<string>(nullable: true),
                    RoleDisplayName = table.Column<string>(nullable: true),
                    RoleDescription = table.Column<string>(nullable: true),
                    RoleState = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UsersId = table.Column<Guid>(nullable: false),
                    UsersCode = table.Column<string>(maxLength: 8, nullable: true),
                    UsersName = table.Column<string>(maxLength: 50, nullable: true),
                    UsersLastName = table.Column<string>(maxLength: 50, nullable: true),
                    UsersState = table.Column<bool>(nullable: false),
                    UsersMail = table.Column<string>(maxLength: 80, nullable: true),
                    UsersMailIntern = table.Column<string>(maxLength: 80, nullable: true),
                    UsersPosteName = table.Column<string>(nullable: true),
                    UsersPhoneNumber = table.Column<string>(nullable: true),
                    UsersPersonalNumber = table.Column<string>(nullable: true),
                    UsersGenderCode = table.Column<string>(nullable: true),
                    UsersFilialeName = table.Column<string>(nullable: true),
                    UsersFilialeCode = table.Column<string>(nullable: true),
                    UsersBirthDate = table.Column<DateTime>(nullable: false),
                    UsersJoinDate = table.Column<DateTime>(nullable: false),
                    UsersDateLeave = table.Column<DateTime>(nullable: false),
                    FkUsersId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UsersId);
                    table.ForeignKey(
                        name: "FK_User_User_FkUsersId",
                        column: x => x.FkUsersId,
                        principalTable: "User",
                        principalColumn: "UsersId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Groupes",
                columns: table => new
                {
                    GrpId = table.Column<Guid>(nullable: false),
                    GrpName = table.Column<string>(nullable: true),
                    GrpDisplayName = table.Column<string>(nullable: true),
                    GrpDescription = table.Column<string>(nullable: true),
                    GrpState = table.Column<bool>(nullable: false),
                    FkAppId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groupes", x => x.GrpId);
                    table.ForeignKey(
                        name: "FK_Groupes_Applications",
                        column: x => x.FkAppId,
                        principalTable: "Applications",
                        principalColumn: "AppId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<Guid>(nullable: false),
                    MenuName = table.Column<string>(nullable: true),
                    MenuDisplayName = table.Column<string>(nullable: true),
                    MenuDescription = table.Column<string>(nullable: true),
                    MenuUrl = table.Column<string>(nullable: true),
                    MenuState = table.Column<bool>(nullable: false),
                    FkMenuId = table.Column<Guid>(nullable: true),
                    FkAppId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_Menus_Applications_FkAppId",
                        column: x => x.FkAppId,
                        principalTable: "Applications",
                        principalColumn: "AppId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Menus_Menus_FkMenuId",
                        column: x => x.FkMenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AffRolePermissions",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(nullable: false),
                    PermId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AffRolePermissions", x => new { x.PermId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AffRolePermissions_Permissions_PermId",
                        column: x => x.PermId,
                        principalTable: "Permissions",
                        principalColumn: "PermId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AffRolePermissions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AffApplicationUsers",
                columns: table => new
                {
                    AppId = table.Column<Guid>(nullable: false),
                    UsersId = table.Column<Guid>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AffApplicationUsers", x => new { x.AppId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_AffApplicationUsers_Applications_AppId",
                        column: x => x.AppId,
                        principalTable: "Applications",
                        principalColumn: "AppId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AffApplicationUsers_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "User",
                        principalColumn: "UsersId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AffGroupUsers",
                columns: table => new
                {
                    UsersId = table.Column<Guid>(nullable: false),
                    GrpId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AffGroupUsers", x => new { x.GrpId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_AffGroupUsers_Groupes_GrpId",
                        column: x => x.GrpId,
                        principalTable: "Groupes",
                        principalColumn: "GrpId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AffGroupUsers_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "User",
                        principalColumn: "UsersId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AffRoleGroupMenus",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(nullable: false),
                    GrpId = table.Column<Guid>(nullable: false),
                    MenuId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AffRoleGroupMenus", x => new { x.GrpId, x.MenuId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AffRoleGroupMenus_Groupes_GrpId",
                        column: x => x.GrpId,
                        principalTable: "Groupes",
                        principalColumn: "GrpId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AffRoleGroupMenus_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AffRoleGroupMenus_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AffRolesUsersMenus",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(nullable: false),
                    UsersId = table.Column<Guid>(nullable: false),
                    MenuId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AffRolesUsersMenus", x => new { x.UsersId, x.MenuId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AffRolesUsersMenus_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AffRolesUsersMenus_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AffRolesUsersMenus_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "User",
                        principalColumn: "UsersId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AffApplicationUsers_UsersId",
                table: "AffApplicationUsers",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_AffGroupUsers_UsersId",
                table: "AffGroupUsers",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_AffRoleGroupMenus_MenuId",
                table: "AffRoleGroupMenus",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_AffRoleGroupMenus_RoleId",
                table: "AffRoleGroupMenus",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AffRolePermissions_RoleId",
                table: "AffRolePermissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AffRolesUsersMenus_MenuId",
                table: "AffRolesUsersMenus",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_AffRolesUsersMenus_RoleId",
                table: "AffRolesUsersMenus",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_AppCode",
                table: "Applications",
                column: "AppCode",
                unique: true,
                filter: "([AppCode] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_Groupes_FkAppId",
                table: "Groupes",
                column: "FkAppId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_FkAppId",
                table: "Menus",
                column: "FkAppId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_FkMenuId",
                table: "Menus",
                column: "FkMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_PermName",
                table: "Permissions",
                column: "PermName",
                unique: true,
                filter: "([PermName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_RoleName",
                table: "Roles",
                column: "RoleName",
                unique: true,
                filter: "([RoleName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_User_FkUsersId",
                table: "User",
                column: "FkUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UsersCode",
                table: "User",
                column: "UsersCode",
                unique: true,
                filter: "([UsersCode] IS NOT NULL)");

            // Custom stored procedures.
            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE [dbo].[GetUsersTree](@UserId uniqueidentifier)
                                        AS BEGIN
                                        WITH 
                                          [UserTree] 
                                          AS
                                          (
                                            SELECT *
                                            FROM [User]
                                            WHERE [UsersId] = @UserId --and [FkUsersId] is null
                                            UNION ALL
                                            SELECT usr.*
                                            FROM [User] usr
                                              INNER JOIN [UserTree] parent
                                                ON usr.FkUsersId = parent.UsersId
		                                        where usr.FkUsersId is not null
                                          )
                                          
                                        SELECT distinct *
                                        FROM [UserTree]
                                        OPTION (MAXRECURSION 32767);

                                        END");


            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE [dbo].[GetMenusTree](@UserId uniqueidentifier)
                            AS BEGIN
                            WITH 
                              [MenuTree] 
                              AS
                              (
                                SELECT *
                                FROM [Menus]
                                WHERE MenuId = @UserId --and [FkUsersId] is null
                                UNION ALL
                                SELECT menu.*
                                FROM [Menus] menu
                                  INNER JOIN [MenuTree] parent
                                    ON menu.FkMenuId = parent.MenuId
		                            where menu.FkMenuId is not null
                              )
                              
                            SELECT distinct *
                            FROM [MenuTree]
                            OPTION (MAXRECURSION 32767);

                            END");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AffApplicationUsers");

            migrationBuilder.DropTable(
                name: "AffGroupUsers");

            migrationBuilder.DropTable(
                name: "AffRoleGroupMenus");

            migrationBuilder.DropTable(
                name: "AffRolePermissions");

            migrationBuilder.DropTable(
                name: "AffRolesUsersMenus");

            migrationBuilder.DropTable(
                name: "Groupes");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.Sql(@"DROP PROCEDURE [dbo].[GetUsersTree]");
            migrationBuilder.Sql(@"DROP PROCEDURE [dbo].[GetMenusTree]");
        }
    }
}
