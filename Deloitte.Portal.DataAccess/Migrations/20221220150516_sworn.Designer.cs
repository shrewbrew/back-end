﻿// <auto-generated />
using System;
using Deloitte.Portal.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Deloitte.Portal.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221220150516_sworn")]
    partial class sworn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Deloitte.Portal.Model.Account.DeloitteUsers", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Deloitte.Portal.Model.ClaimForms.ClaimFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("claimID")
                        .HasColumnType("int");

                    b.Property<int?>("fileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("claimID");

                    b.HasIndex("fileId");

                    b.ToTable("ClaimFiles");
                });

            modelBuilder.Entity("Deloitte.Portal.Model.ClaimForms.ClaimFormsModel", b =>
                {
                    b.Property<int>("claimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("COname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GovernmentIDFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsGovernmentIssuedID")
                        .HasColumnType("bit");

                    b.Property<string>("UnitNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("authorizationDocumentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("authorizationFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bandNameMemberOf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("bandRegistrationNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("bloodStreamInjuries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bloodStreamLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bloodStreamNameOfPractitioner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bloodStreamPractitionerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("chequeOrDepositFormFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("dermatologicalInjuries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dermatologicalLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dermatologicalNameOfPractitioner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dermatologicalPractitionerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("digestiveHarmHealthPractitionerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("digestiveInjuries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("digestiveLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("digestiveNameOfPractitioner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstNationNameOfContactAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("indianStatusCardNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("kidneyInjuries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kidneyLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kidneyNameOfPractitioner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kidneyPractitionerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("liverInjuries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("liverLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("liverNameOfPractitioner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("liverPractitionerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthAdjustmentDisorder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthAdjustmentDisorderLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthAdjustmentDisorderNameOfPractitioner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthAdjustmentDisorderPractitionerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthAnxietyDisorder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthAnxietyDisorderLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthAnxietyDisorderNameOfPractitioner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthAnxietyDisorderPractitionerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthDepression")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthDepressionLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthDepressionNameOfPractitioner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthDepressionPractitionerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthPanicDisorder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthPanicDisorderLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthPanicDisorderNameOfPractitioner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthPanicDisorderPractitionerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthPostTraumatic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthPostTraumaticLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthPostTraumaticNameOfPractitioner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthPostTraumaticPractitionerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthSpecificPhobia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthSpecificPhobiaLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthSpecificPhobiaNameOfPractitioner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthSpecificPhobiaPractitionerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthSubstanceAddiction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthSubstanceAddictionLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthSubstanceAddictionNameOfPractitioner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentalHealthSubstanceAddictionPractitionerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("middleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("mobileNumber")
                        .HasColumnType("bigint");

                    b.Property<bool>("modeOfPayment")
                        .HasColumnType("bit");

                    b.Property<bool>("nameOfNation")
                        .HasColumnType("bit");

                    b.Property<string>("neurologicalInjuries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("neurologicalLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("neurologicalNameOfPractitioner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("neurologicalPractitionerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("otherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("poBox")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("provinceBandLocated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("respiratoryInjuries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("respiratoryLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("respiratoryNameOfPractitioner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("respiratoryPractitionerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("socialInsuranceNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("streetNameAndNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("swornAffirmationDeclarationFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("telephoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("tumorOrCancerInjuries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tumorOrCancerLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tumorOrCancerNameOfPractitioner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tumorOrCancerPractitionerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userClaimID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("willYouBeClaimingSpecifiedInjuries")
                        .HasColumnType("bit");

                    b.HasKey("claimID");

                    b.ToTable("Claims");
                });

            modelBuilder.Entity("Deloitte.Portal.Model.ClaimForms.ClaimReserveForm", b =>
                {
                    b.Property<int>("CRId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("claimID")
                        .HasColumnType("int");

                    b.Property<string>("firstNationBandNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fromMonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fromYear")
                        .HasColumnType("int");

                    b.Property<string>("nameOfFirstNation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("provinceOrTerritory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("reserveID")
                        .HasColumnType("int");

                    b.Property<string>("toMonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("toYear")
                        .HasColumnType("int");

                    b.Property<DateTime>("waterAdvisoryEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("waterAdvisoryStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CRId");

                    b.HasIndex("claimID");

                    b.HasIndex("reserveID");

                    b.ToTable("ClaimReserve");
                });

            modelBuilder.Entity("Deloitte.Portal.Model.ClaimForms.File", b =>
                {
                    b.Property<int>("fileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("documentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fileExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fileLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fileSize")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("fileId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Deloitte.Portal.Model.ClaimForms.ReserveFormModel", b =>
                {
                    b.Property<int>("reserveID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Proviences")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("endDateOfWaterAdvisory")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstNationBandNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("startDateOfWaterAdvisory")
                        .HasColumnType("datetime2");

                    b.HasKey("reserveID");

                    b.ToTable("Reserve");
                });

            modelBuilder.Entity("Deloitte.Portal.Model.ClaimForms.SpecifiedInjuries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SPID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SpecifiedInjuries");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Deloitte.Portal.Model.ClaimForms.ClaimFile", b =>
                {
                    b.HasOne("Deloitte.Portal.Model.ClaimForms.ClaimFormsModel", "claimId")
                        .WithMany("ClaimFiles")
                        .HasForeignKey("claimID");

                    b.HasOne("Deloitte.Portal.Model.ClaimForms.File", "fileID")
                        .WithMany("ClaimFiles")
                        .HasForeignKey("fileId");
                });

            modelBuilder.Entity("Deloitte.Portal.Model.ClaimForms.ClaimReserveForm", b =>
                {
                    b.HasOne("Deloitte.Portal.Model.ClaimForms.ClaimFormsModel", "ClaimId")
                        .WithMany("ClaimReserve")
                        .HasForeignKey("claimID");

                    b.HasOne("Deloitte.Portal.Model.ClaimForms.ReserveFormModel", "reserveId")
                        .WithMany("ClaimReserve")
                        .HasForeignKey("reserveID");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Deloitte.Portal.Model.Account.DeloitteUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Deloitte.Portal.Model.Account.DeloitteUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Deloitte.Portal.Model.Account.DeloitteUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Deloitte.Portal.Model.Account.DeloitteUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
