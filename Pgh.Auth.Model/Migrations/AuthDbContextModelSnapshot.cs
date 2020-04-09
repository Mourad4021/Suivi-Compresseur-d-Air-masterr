﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pgh.Auth.Model.Models;

namespace Pgh.Auth.Model.Migrations
{
    [DbContext(typeof(AuthDbContext))]
    partial class AuthDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pgh.Auth.Model.Models.AffApplicationUsers", b =>
                {
                    b.Property<Guid>("AppId");

                    b.Property<Guid>("UsersId");

                    b.Property<string>("Password");

                    b.HasKey("AppId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("AffApplicationUsers");
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.AffGroupUsers", b =>
                {
                    b.Property<Guid>("GrpId");

                    b.Property<Guid>("UsersId");

                    b.HasKey("GrpId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("AffGroupUsers");
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.AffRoleGroupMenus", b =>
                {
                    b.Property<Guid>("GrpId");

                    b.Property<Guid>("MenuId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("GrpId", "MenuId", "RoleId");

                    b.HasIndex("MenuId");

                    b.HasIndex("RoleId");

                    b.ToTable("AffRoleGroupMenus");
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.AffRolePermissions", b =>
                {
                    b.Property<Guid>("PermId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("PermId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AffRolePermissions");
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.AffRolesUsersMenus", b =>
                {
                    b.Property<Guid>("UsersId");

                    b.Property<Guid>("MenuId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UsersId", "MenuId", "RoleId");

                    b.HasIndex("MenuId");

                    b.HasIndex("RoleId");

                    b.ToTable("AffRolesUsersMenus");
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.Applications", b =>
                {
                    b.Property<Guid>("AppId");

                    b.Property<string>("AppCode");

                    b.Property<string>("AppDescription");

                    b.Property<string>("AppDisplayName");

                    b.Property<string>("AppName");

                    b.Property<bool>("AppState");

                    b.HasKey("AppId");

                    b.HasIndex("AppCode")
                        .IsUnique()
                        .HasFilter("([AppCode] IS NOT NULL)");

                    b.ToTable("Applications");

                    b.HasData(
                        new
                        {
                            AppId = new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"),
                            AppCode = "0000",
                            AppDescription = "Cette application gérer l'authentification et des permissions des différents applications.",
                            AppDisplayName = "Gestion de l'authentification  des applications",
                            AppName = "AuthApp",
                            AppState = true
                        },
                        new
                        {
                            AppId = new Guid("c5c9921e-2be4-4875-bc33-9fc4612870f6"),
                            AppCode = "0001",
                            AppDescription = "Cette application gérer le processus d'analyse des échantillons par le labo Dick.",
                            AppDisplayName = "Gestion de laboratoire Dick",
                            AppName = "LaboDickAgro",
                            AppState = true
                        },
                        new
                        {
                            AppId = new Guid("75275dd3-67b7-4097-a39a-151a8e357b85"),
                            AppCode = "0013",
                            AppDescription = "Mise a jour de l'ancienne application Laboratoir Dick.",
                            AppDisplayName = "Gestion de laboratoire Dick Elevage",
                            AppName = "LaboDickElevage",
                            AppState = true
                        });
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.Groupes", b =>
                {
                    b.Property<Guid>("GrpId");

                    b.Property<Guid?>("FkAppId");

                    b.Property<string>("GrpDescription");

                    b.Property<string>("GrpDisplayName");

                    b.Property<string>("GrpName");

                    b.Property<bool>("GrpState");

                    b.HasKey("GrpId");

                    b.HasIndex("FkAppId");

                    b.ToTable("Groupes");

                    b.HasData(
                        new
                        {
                            GrpId = new Guid("4ec91795-c9dd-404d-827b-19844ee55a49"),
                            FkAppId = new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"),
                            GrpDescription = "Administration Groupe for Authentication Application",
                            GrpDisplayName = "Administration Groupes",
                            GrpName = "AdministratorAuth",
                            GrpState = true
                        },
                        new
                        {
                            GrpId = new Guid("c8c8491f-0339-49a9-b5b8-59de49bc911f"),
                            FkAppId = new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"),
                            GrpDescription = "Readers Groupe for Authentication Application",
                            GrpDisplayName = "Readers Groupes",
                            GrpName = "ReadersAuth",
                            GrpState = true
                        },
                        new
                        {
                            GrpId = new Guid("eec69692-8bfc-4cd4-b111-a47dabc19c04"),
                            FkAppId = new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"),
                            GrpDescription = "Editors Groupe for Authentication Application",
                            GrpDisplayName = "Editors Groupes",
                            GrpName = "EditorsAuth",
                            GrpState = true
                        });
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.Menus", b =>
                {
                    b.Property<Guid>("MenuId");

                    b.Property<Guid?>("FkAppId");

                    b.Property<Guid?>("FkMenuId");

                    b.Property<string>("MenuDescription");

                    b.Property<string>("MenuDisplayName");

                    b.Property<string>("MenuName");

                    b.Property<bool>("MenuState");

                    b.Property<string>("MenuUrl");

                    b.HasKey("MenuId");

                    b.HasIndex("FkAppId");

                    b.HasIndex("FkMenuId");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            MenuId = new Guid("867daa3a-5d07-4339-b352-8ba59b724963"),
                            FkAppId = new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"),
                            MenuDescription = "User setup menu.",
                            MenuDisplayName = "Users",
                            MenuName = "AuthUsers",
                            MenuState = true,
                            MenuUrl = "Http://srvapp/authusers"
                        },
                        new
                        {
                            MenuId = new Guid("5a08c329-d42f-43d0-a632-ff1c22fc9301"),
                            FkAppId = new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"),
                            MenuDescription = "Permissions setup menu.",
                            MenuDisplayName = "Permissions",
                            MenuName = "AuthPermissions",
                            MenuState = true,
                            MenuUrl = "Http://srvapp/authpermissions"
                        },
                        new
                        {
                            MenuId = new Guid("822d45e6-ec8f-46bf-94ea-07f37b2a1904"),
                            FkAppId = new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"),
                            MenuDescription = "Roles setup menu.",
                            MenuDisplayName = "Roles",
                            MenuName = "AuthRoles",
                            MenuState = true,
                            MenuUrl = "Http://srvapp/authroles"
                        },
                        new
                        {
                            MenuId = new Guid("ffabfea9-a875-4313-adc0-3a9ea3059862"),
                            FkAppId = new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"),
                            MenuDescription = "Applications setup menu.",
                            MenuDisplayName = "Applications",
                            MenuName = "AuthApplications",
                            MenuState = true,
                            MenuUrl = "Http://srvapp/authappications"
                        },
                        new
                        {
                            MenuId = new Guid("5c78b402-0f82-4e40-b895-14a0403832df"),
                            FkAppId = new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"),
                            MenuDescription = "Menus setup menu.",
                            MenuDisplayName = "Menus",
                            MenuName = "AuthMenus",
                            MenuState = true,
                            MenuUrl = "Http://srvapp/authmenus"
                        },
                        new
                        {
                            MenuId = new Guid("32b3fa8f-f905-4809-904f-8d65ca066730"),
                            FkAppId = new Guid("5ebcc21f-0a2b-40e6-bae4-56d78743a36d"),
                            MenuDescription = "Groupes setup menu.",
                            MenuDisplayName = "Groupes",
                            MenuName = "AuthGroupes",
                            MenuState = true,
                            MenuUrl = "Http://srvapp/authgroupes"
                        });
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.Permissions", b =>
                {
                    b.Property<Guid>("PermId");

                    b.Property<string>("PermDescription");

                    b.Property<string>("PermDisplayName");

                    b.Property<string>("PermName");

                    b.Property<bool>("PermState");

                    b.HasKey("PermId");

                    b.HasIndex("PermName")
                        .IsUnique()
                        .HasFilter("([PermName] IS NOT NULL)");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            PermId = new Guid("3c6f65e3-3070-4300-93f9-3198115d8ec6"),
                            PermDescription = "Users Will Have the permission to add items",
                            PermDisplayName = "Add Items",
                            PermName = "AddItems",
                            PermState = true
                        },
                        new
                        {
                            PermId = new Guid("02864148-8ebb-486b-bfe5-e36de977d922"),
                            PermDescription = "Users Will Have Permission to edit Items.",
                            PermDisplayName = "Edit Items",
                            PermName = "EditItems",
                            PermState = true
                        },
                        new
                        {
                            PermId = new Guid("15d5a86a-bab0-46ef-acfa-7bc6cd9a3bf5"),
                            PermDescription = "Users Will Have Permission to delete Elements.",
                            PermDisplayName = "Delete Items",
                            PermName = "DeleteItems",
                            PermState = true
                        },
                        new
                        {
                            PermId = new Guid("d03431b8-e1bd-4489-864e-c5e4ef1709f8"),
                            PermDescription = "Users Will Have Permission to View Items.",
                            PermDisplayName = "View Items",
                            PermName = "ViewItems",
                            PermState = true
                        },
                        new
                        {
                            PermId = new Guid("021e1168-e9e4-4ca7-a47f-e7c2f57bf774"),
                            PermDescription = "Users Will Have Permission to approve items.",
                            PermDisplayName = "Approve Items",
                            PermName = "ApproveItems",
                            PermState = true
                        },
                        new
                        {
                            PermId = new Guid("2624395f-f3a4-4034-adea-be58b55f2900"),
                            PermDescription = "Users Will Have Permission to show versions.",
                            PermDisplayName = "Show Versions",
                            PermName = "ShowVersions",
                            PermState = true
                        },
                        new
                        {
                            PermId = new Guid("fd539a4b-cde3-46e9-aa7a-89c718f09595"),
                            PermDescription = "Users Will Have Permission to Delete versions.",
                            PermDisplayName = "Delete Versions",
                            PermName = "DeleteVersions",
                            PermState = true
                        },
                        new
                        {
                            PermId = new Guid("5f0bbf84-9a6f-407c-9df4-9ab8704fd6cb"),
                            PermDescription = "Users Will Have Permission to view application pages.",
                            PermDisplayName = "View application pages",
                            PermName = "ViewApplicationPages",
                            PermState = true
                        },
                        new
                        {
                            PermId = new Guid("122f6fba-46d8-4e3c-becf-3d5489f724fe"),
                            PermDescription = "Users Will Have Permission to create groups.",
                            PermDisplayName = "Create Groups",
                            PermName = "CreateGroups",
                            PermState = true
                        },
                        new
                        {
                            PermId = new Guid("45fb1687-62fd-4096-9841-823064f57c6e"),
                            PermDescription = "Users Will Have Permission to view pages.",
                            PermDisplayName = "View Pages",
                            PermName = "ViewPages",
                            PermState = true
                        },
                        new
                        {
                            PermId = new Guid("3c75c3da-24a2-4da1-b98d-fb958c2f4e41"),
                            PermDescription = "Users Will Have Permission to edit users personal information.",
                            PermDisplayName = "Edit user's personal information",
                            PermName = "EditUserPersonalInformation",
                            PermState = true
                        },
                        new
                        {
                            PermId = new Guid("28439660-afd0-4f48-8099-cdf4743c4b27"),
                            PermDescription = "Users Will Have Permission to Manage personal views.",
                            PermDisplayName = "Manage personal views",
                            PermName = "ManagePersonalViews",
                            PermState = true
                        });
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.Roles", b =>
                {
                    b.Property<Guid>("RoleId");

                    b.Property<string>("RoleDescription");

                    b.Property<string>("RoleDisplayName");

                    b.Property<string>("RoleName");

                    b.Property<bool>("RoleState");

                    b.HasKey("RoleId");

                    b.HasIndex("RoleName")
                        .IsUnique()
                        .HasFilter("([RoleName] IS NOT NULL)");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("af0345e3-cc04-4a5e-8e97-a5b81bbd73a6"),
                            RoleDescription = "Total Control Default Groupe",
                            RoleDisplayName = "Total Control",
                            RoleName = "TotalControl",
                            RoleState = true
                        },
                        new
                        {
                            RoleId = new Guid("d8d0d732-d09c-49c8-bace-d86692129d62"),
                            RoleDescription = "Design Groupe Default Groupe",
                            RoleDisplayName = "Design Groupe",
                            RoleName = "Design",
                            RoleState = true
                        },
                        new
                        {
                            RoleId = new Guid("9c37b3ad-1ebd-4a89-bbfb-979a2c6e01af"),
                            RoleDescription = "Editors Groupe Default Groupe",
                            RoleDisplayName = "Editors Groupe",
                            RoleName = "Editors",
                            RoleState = true
                        },
                        new
                        {
                            RoleId = new Guid("40c34095-e92a-43d2-8159-748c74c8ae84"),
                            RoleDescription = "Collaboration Default Groupe",
                            RoleDisplayName = "Collaboration Groupe",
                            RoleName = "Collaboration",
                            RoleState = true
                        },
                        new
                        {
                            RoleId = new Guid("bb3a471c-12b6-481b-964e-b81cebe386d6"),
                            RoleDescription = "Readers Groupe Default Groupe",
                            RoleDisplayName = "Readers Groupe",
                            RoleName = "Readers",
                            RoleState = true
                        },
                        new
                        {
                            RoleId = new Guid("92dc9862-164f-414b-8781-2a8dae13e1ec"),
                            RoleDescription = "Limited Access Default Groupe",
                            RoleDisplayName = "Limited Access",
                            RoleName = "LimitedAccess",
                            RoleState = true
                        },
                        new
                        {
                            RoleId = new Guid("bee6ce1b-15fe-44ad-9da0-05f9e415edaf"),
                            RoleDescription = "Display Only Default Groupe",
                            RoleDisplayName = "Display Only Groupe",
                            RoleName = "DisplayOnly",
                            RoleState = true
                        },
                        new
                        {
                            RoleId = new Guid("fbe5a4d3-4b79-4516-b4a3-7214a1d3ff03"),
                            RoleDescription = "Approval Default Groupe",
                            RoleDisplayName = "Approval Groupe",
                            RoleName = "Approval",
                            RoleState = true
                        },
                        new
                        {
                            RoleId = new Guid("80f1af2c-8d4d-48ab-bbd7-bedc0b31abf1"),
                            RoleDescription = "Restricted reading Default Groupe",
                            RoleDisplayName = "Restricted reading Groupe",
                            RoleName = "Restricted reading",
                            RoleState = true
                        });
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.Users", b =>
                {
                    b.Property<Guid>("UsersId");

                    b.Property<Guid?>("FkUsersId");

                    b.Property<DateTime>("UsersBirthDate");

                    b.Property<string>("UsersCode")
                        .HasMaxLength(8);

                    b.Property<DateTime>("UsersDateLeave");

                    b.Property<string>("UsersFilialeCode");

                    b.Property<string>("UsersFilialeName");

                    b.Property<string>("UsersGenderCode");

                    b.Property<DateTime>("UsersJoinDate");

                    b.Property<string>("UsersLastName")
                        .HasMaxLength(50);

                    b.Property<string>("UsersMail")
                        .HasMaxLength(80);

                    b.Property<string>("UsersMailIntern")
                        .HasMaxLength(80);

                    b.Property<string>("UsersName")
                        .HasMaxLength(50);

                    b.Property<string>("UsersPersonalNumber");

                    b.Property<string>("UsersPhoneNumber");

                    b.Property<string>("UsersPosteName");

                    b.Property<bool>("UsersState");

                    b.HasKey("UsersId");

                    b.HasIndex("FkUsersId");

                    b.HasIndex("UsersCode")
                        .IsUnique()
                        .HasFilter("([UsersCode] IS NOT NULL)");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UsersId = new Guid("81893b3e-b889-4f3f-88f3-c228994c38d2"),
                            UsersBirthDate = new DateTime(2019, 9, 10, 18, 12, 6, 666, DateTimeKind.Local).AddTicks(3726),
                            UsersCode = "00000000",
                            UsersDateLeave = new DateTime(2019, 9, 10, 18, 12, 6, 667, DateTimeKind.Local).AddTicks(9225),
                            UsersFilialeCode = "DD01",
                            UsersFilialeName = "PoulinaGroupeHolding",
                            UsersGenderCode = "M",
                            UsersJoinDate = new DateTime(2019, 9, 10, 18, 12, 6, 667, DateTimeKind.Local).AddTicks(9950),
                            UsersLastName = "Admin",
                            UsersMail = "Admin@poulina.com",
                            UsersMailIntern = "Admin@poulina.com",
                            UsersName = "Admin",
                            UsersPersonalNumber = "63524163",
                            UsersPhoneNumber = "63524141",
                            UsersPosteName = "Admin Poste",
                            UsersState = false
                        },
                        new
                        {
                            UsersId = new Guid("70f5b2ed-8199-43a0-8ad9-c5d8f7832f49"),
                            UsersBirthDate = new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6031),
                            UsersCode = "00000001",
                            UsersDateLeave = new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6037),
                            UsersFilialeCode = "DD01",
                            UsersFilialeName = "PoulinaGroupeHolding",
                            UsersGenderCode = "M",
                            UsersJoinDate = new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6042),
                            UsersLastName = "SupAdmin",
                            UsersMail = "SupAdmin@poulina.com",
                            UsersMailIntern = "SupAdmin@poulina.com",
                            UsersName = "SupAdmin",
                            UsersPersonalNumber = "63524163",
                            UsersPhoneNumber = "63524141",
                            UsersPosteName = "SupAdmin Poste",
                            UsersState = false
                        },
                        new
                        {
                            UsersId = new Guid("dc552333-637c-4e18-bd7f-be85f51fef6d"),
                            UsersBirthDate = new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6086),
                            UsersCode = "00000002",
                            UsersDateLeave = new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6087),
                            UsersFilialeCode = "DD01",
                            UsersFilialeName = "PoulinaGroupeHolding",
                            UsersGenderCode = "M",
                            UsersJoinDate = new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6088),
                            UsersLastName = "Test",
                            UsersMail = "User1@poulina.com",
                            UsersMailIntern = "User1@poulina.com",
                            UsersName = "User1",
                            UsersPersonalNumber = "63524163",
                            UsersPhoneNumber = "63524141",
                            UsersPosteName = "User1 Poste",
                            UsersState = false
                        },
                        new
                        {
                            UsersId = new Guid("088e1d30-51a1-497b-9ed3-bee9a9eecaf4"),
                            UsersBirthDate = new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6092),
                            UsersCode = "00000003",
                            UsersDateLeave = new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6092),
                            UsersFilialeCode = "DD01",
                            UsersFilialeName = "PoulinaGroupeHolding",
                            UsersGenderCode = "M",
                            UsersJoinDate = new DateTime(2019, 9, 10, 18, 12, 6, 668, DateTimeKind.Local).AddTicks(6093),
                            UsersLastName = "Test",
                            UsersMail = "User2@poulina.com",
                            UsersMailIntern = "User2@poulina.com",
                            UsersName = "User2",
                            UsersPersonalNumber = "63524163",
                            UsersPhoneNumber = "63524141",
                            UsersPosteName = "User2 Poste",
                            UsersState = false
                        });
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.AffApplicationUsers", b =>
                {
                    b.HasOne("Pgh.Auth.Model.Models.Applications", "App")
                        .WithMany("AffApplicationUsers")
                        .HasForeignKey("AppId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pgh.Auth.Model.Models.Users", "Users")
                        .WithMany("AffApplicationUsers")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.AffGroupUsers", b =>
                {
                    b.HasOne("Pgh.Auth.Model.Models.Groupes", "Grp")
                        .WithMany("AffGroupUsers")
                        .HasForeignKey("GrpId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pgh.Auth.Model.Models.Users", "Users")
                        .WithMany("AffGroupUsers")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.AffRoleGroupMenus", b =>
                {
                    b.HasOne("Pgh.Auth.Model.Models.Groupes", "Groupe")
                        .WithMany("AffRoleGroupMenus")
                        .HasForeignKey("GrpId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pgh.Auth.Model.Models.Menus", "Menu")
                        .WithMany("AffRoleGroupMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pgh.Auth.Model.Models.Roles", "Role")
                        .WithMany("AffRoleGroupMenus")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.AffRolePermissions", b =>
                {
                    b.HasOne("Pgh.Auth.Model.Models.Permissions", "Permission")
                        .WithMany("AffRolePermissions")
                        .HasForeignKey("PermId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pgh.Auth.Model.Models.Roles", "Role")
                        .WithMany("AffRolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.AffRolesUsersMenus", b =>
                {
                    b.HasOne("Pgh.Auth.Model.Models.Menus", "Menu")
                        .WithMany("AffRolesUsersMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pgh.Auth.Model.Models.Roles", "Role")
                        .WithMany("AffRolesUsersMenus")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pgh.Auth.Model.Models.Users", "Users")
                        .WithMany("AffRolesUsersMenus")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.Groupes", b =>
                {
                    b.HasOne("Pgh.Auth.Model.Models.Applications", "FkApp")
                        .WithMany("Groupes")
                        .HasForeignKey("FkAppId")
                        .HasConstraintName("FK_Groupes_Applications")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.Menus", b =>
                {
                    b.HasOne("Pgh.Auth.Model.Models.Applications", "FkApp")
                        .WithMany("Menus")
                        .HasForeignKey("FkAppId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Pgh.Auth.Model.Models.Menus", "FkMenu")
                        .WithMany("InverseFkMenu")
                        .HasForeignKey("FkMenuId");
                });

            modelBuilder.Entity("Pgh.Auth.Model.Models.Users", b =>
                {
                    b.HasOne("Pgh.Auth.Model.Models.Users", "FkUsers")
                        .WithMany("InverseFkUsers")
                        .HasForeignKey("FkUsersId");
                });
#pragma warning restore 612, 618
        }
    }
}