﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebProjectManager.Models.EF;

#nullable disable

namespace WebProjectManager.Models.Migrations
{
    [DbContext(typeof(EFCoreDbContext))]
    [Migration("20240507025110_settingemail")]
    partial class settingemail
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens", (string)null);
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.AccountVerification", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime?>("CreateOn")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ExpiryOn")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("VerificationWith")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdUser");

                    b.ToTable("AccountVerification", (string)null);
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Card", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EstimatedFinish")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("NumberMember")
                        .HasColumnType("int");

                    b.Property<int?>("Order")
                        .HasColumnType("int");

                    b.Property<Guid?>("TabId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("TimeExpiry")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("TabId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.CardUserMember", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CardId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Member")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("Member");

                    b.ToTable("CardUserMember", (string)null);
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Invite", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("TimeExpiry")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("ProjectId");

                    b.ToTable("Invites");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.MemberProject", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("TimeExpiry")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("IdUser");

                    b.HasIndex("ProjectId");

                    b.ToTable("MemberProject", (string)null);
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Background")
                        .HasColumnType("int");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Image")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("NumberMember")
                        .HasColumnType("int");

                    b.Property<int?>("Order")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TimeExpiry")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.SettingEmail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("SendDaily")
                        .HasColumnType("bit");

                    b.Property<bool?>("SendEmail")
                        .HasColumnType("bit");

                    b.Property<bool?>("SendMonthly")
                        .HasColumnType("bit");

                    b.Property<bool?>("SendWeekly")
                        .HasColumnType("bit");

                    b.Property<bool?>("SendYearly")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("SettingEmail");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Tab", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Order")
                        .HasColumnType("int");

                    b.Property<Guid?>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("TimeExpiry")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tabs");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Task", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CardId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Icon")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("NumberMember")
                        .HasColumnType("int");

                    b.Property<int?>("Order")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TimeExpiry")
                        .HasColumnType("datetime");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.TaskUserMember", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Member")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Member");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskUserMember", (string)null);
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("TimeExpiry")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.TicketProject", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TicketId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TicketId");

                    b.ToTable("TicketProject", (string)null);
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Timesheet", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Icon")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("TimeBegin")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("TimeExpiry")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Timesheets");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.TimesheetProject", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TimesheetId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TimesheetId");

                    b.ToTable("TimesheetProject", (string)null);
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsVerification")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("UrlAvatar")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.AccountVerification", b =>
                {
                    b.HasOne("WebProjectManager.Models.Entities.User", "IdUserNavigation")
                        .WithMany("AccountVerifications")
                        .HasForeignKey("IdUser")
                        .HasConstraintName("FK__AccountVe__IdUse__15502E78");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Card", b =>
                {
                    b.HasOne("WebProjectManager.Models.Entities.User", "CreatedByNavigation")
                        .WithMany("Cards")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("FK__Cards__CreatedBy__1B0907CE");

                    b.HasOne("WebProjectManager.Models.Entities.Tab", "Tab")
                        .WithMany("Cards")
                        .HasForeignKey("TabId")
                        .HasConstraintName("FK__Cards__TabId__1BFD2C07");

                    b.Navigation("CreatedByNavigation");

                    b.Navigation("Tab");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.CardUserMember", b =>
                {
                    b.HasOne("WebProjectManager.Models.Entities.Card", "Card")
                        .WithMany("CardUserMembers")
                        .HasForeignKey("CardId")
                        .HasConstraintName("FK__CardUserM__CardI__33D4B598");

                    b.HasOne("WebProjectManager.Models.Entities.User", "MemberNavigation")
                        .WithMany("CardUserMembers")
                        .HasForeignKey("Member")
                        .HasConstraintName("FK__CardUserM__Membe__31EC6D26");

                    b.Navigation("Card");

                    b.Navigation("MemberNavigation");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Invite", b =>
                {
                    b.HasOne("WebProjectManager.Models.Entities.User", "CreatedByNavigation")
                        .WithMany("Invites")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("FK__Invites__Created__2A4B4B5E");

                    b.HasOne("WebProjectManager.Models.Entities.Project", "Project")
                        .WithMany("Invites")
                        .HasForeignKey("ProjectId")
                        .HasConstraintName("FK__Invites__Project__2B3F6F97");

                    b.Navigation("CreatedByNavigation");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.MemberProject", b =>
                {
                    b.HasOne("WebProjectManager.Models.Entities.User", "IdUserNavigation")
                        .WithMany("MemberProjects")
                        .HasForeignKey("IdUser")
                        .HasConstraintName("FK__MemberPro__IdUse__2E1BDC42");

                    b.HasOne("WebProjectManager.Models.Entities.Project", "Project")
                        .WithMany("MemberProjects")
                        .HasForeignKey("ProjectId")
                        .HasConstraintName("FK__MemberPro__Proje__2F10007B");

                    b.Navigation("IdUserNavigation");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Project", b =>
                {
                    b.HasOne("WebProjectManager.Models.Entities.User", "CreatedByNavigation")
                        .WithMany("Projects")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("FK__Projects__Create__182C9B23");

                    b.Navigation("CreatedByNavigation");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.SettingEmail", b =>
                {
                    b.HasOne("WebProjectManager.Models.Entities.User", "SettingEmailNavigation")
                        .WithOne("IdSettingEmail")
                        .HasForeignKey("WebProjectManager.Models.Entities.SettingEmail", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SettingEmailNavigation");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Tab", b =>
                {
                    b.HasOne("WebProjectManager.Models.Entities.User", "CreatedByNavigation")
                        .WithMany("Tabs")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("FK__Tabs__CreatedBy__1B0907CE");

                    b.HasOne("WebProjectManager.Models.Entities.Project", "Project")
                        .WithMany("Tabs")
                        .HasForeignKey("ProjectId")
                        .HasConstraintName("FK__Tabs__ProjectId__1BFD2C07");

                    b.Navigation("CreatedByNavigation");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Task", b =>
                {
                    b.HasOne("WebProjectManager.Models.Entities.Card", "Card")
                        .WithMany("Tasks")
                        .HasForeignKey("CardId")
                        .HasConstraintName("FK__Tasks__CardId__1FCDBCEB");

                    b.HasOne("WebProjectManager.Models.Entities.User", "CreatedByNavigation")
                        .WithMany("Tasks")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("FK__Tasks__CreatedBy__1ED998B2");

                    b.Navigation("Card");

                    b.Navigation("CreatedByNavigation");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.TaskUserMember", b =>
                {
                    b.HasOne("WebProjectManager.Models.Entities.User", "MemberNavigation")
                        .WithMany("TaskUserMember")
                        .HasForeignKey("Member")
                        .HasConstraintName("FK__TaskUserM__Membe__31EC6D26");

                    b.HasOne("WebProjectManager.Models.Entities.Task", "TaskNavigation")
                        .WithMany("TaskUserMember")
                        .HasForeignKey("TaskId")
                        .HasConstraintName("FK__TaskUserM__TaskI__33D4B598");

                    b.Navigation("MemberNavigation");

                    b.Navigation("TaskNavigation");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Ticket", b =>
                {
                    b.HasOne("WebProjectManager.Models.Entities.User", "CreatedByNavigation")
                        .WithMany("Tickets")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("FK__Tickets__Created__36B12243");

                    b.Navigation("CreatedByNavigation");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.TicketProject", b =>
                {
                    b.HasOne("WebProjectManager.Models.Entities.User", "CreatedByNavigation")
                        .WithMany("TicketProjects")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("FK__TicketPro__Creat__398D8EEE");

                    b.HasOne("WebProjectManager.Models.Entities.Project", "Project")
                        .WithMany("TicketProjects")
                        .HasForeignKey("ProjectId")
                        .HasConstraintName("FK__TicketPro__Proje__3A81B327");

                    b.HasOne("WebProjectManager.Models.Entities.Ticket", "Ticket")
                        .WithMany("TicketProjects")
                        .HasForeignKey("TicketId")
                        .HasConstraintName("FK__TicketPro__Ticke__3B75D760");

                    b.Navigation("CreatedByNavigation");

                    b.Navigation("Project");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Timesheet", b =>
                {
                    b.HasOne("WebProjectManager.Models.Entities.User", "CreatedByNavigation")
                        .WithMany("Timesheets")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("FK__Timesheet__Creat__22AA2996");

                    b.Navigation("CreatedByNavigation");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.TimesheetProject", b =>
                {
                    b.HasOne("WebProjectManager.Models.Entities.User", "CreatedByNavigation")
                        .WithMany("TimesheetProjects")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("FK__Timesheet__Creat__25869641");

                    b.HasOne("WebProjectManager.Models.Entities.Project", "Project")
                        .WithMany("TimesheetProjects")
                        .HasForeignKey("ProjectId")
                        .HasConstraintName("FK__Timesheet__Proje__267ABA7A");

                    b.HasOne("WebProjectManager.Models.Entities.Timesheet", "Timesheet")
                        .WithMany("TimesheetProjects")
                        .HasForeignKey("TimesheetId")
                        .HasConstraintName("FK__Timesheet__Times__276EDEB3");

                    b.Navigation("CreatedByNavigation");

                    b.Navigation("Project");

                    b.Navigation("Timesheet");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Card", b =>
                {
                    b.Navigation("CardUserMembers");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Project", b =>
                {
                    b.Navigation("Invites");

                    b.Navigation("MemberProjects");

                    b.Navigation("Tabs");

                    b.Navigation("TicketProjects");

                    b.Navigation("TimesheetProjects");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Tab", b =>
                {
                    b.Navigation("Cards");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Task", b =>
                {
                    b.Navigation("TaskUserMember");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Ticket", b =>
                {
                    b.Navigation("TicketProjects");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.Timesheet", b =>
                {
                    b.Navigation("TimesheetProjects");
                });

            modelBuilder.Entity("WebProjectManager.Models.Entities.User", b =>
                {
                    b.Navigation("AccountVerifications");

                    b.Navigation("CardUserMembers");

                    b.Navigation("Cards");

                    b.Navigation("IdSettingEmail");

                    b.Navigation("Invites");

                    b.Navigation("MemberProjects");

                    b.Navigation("Projects");

                    b.Navigation("Tabs");

                    b.Navigation("TaskUserMember");

                    b.Navigation("Tasks");

                    b.Navigation("TicketProjects");

                    b.Navigation("Tickets");

                    b.Navigation("TimesheetProjects");

                    b.Navigation("Timesheets");
                });
#pragma warning restore 612, 618
        }
    }
}
