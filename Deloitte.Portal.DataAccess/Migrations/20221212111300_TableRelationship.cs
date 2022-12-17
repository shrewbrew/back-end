using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Deloitte.Portal.DataAccess.Migrations
{
    public partial class TableRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Claims",
                columns: table => new
                {
                    claimID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userClaimID = table.Column<string>(nullable: true),
                    firstName = table.Column<string>(nullable: true),
                    middleName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    otherName = table.Column<string>(nullable: true),
                    dateOfBirth = table.Column<DateTime>(nullable: false),
                    socialInsuranceNumber = table.Column<int>(nullable: false),
                    indianStatusCardNumber = table.Column<int>(nullable: false),
                    bandRegistrationNumber = table.Column<int>(nullable: false),
                    bandNameMemberOf = table.Column<string>(nullable: true),
                    provinceBandLocated = table.Column<string>(nullable: true),
                    streetNameAndNumber = table.Column<string>(nullable: true),
                    UnitNumber = table.Column<string>(nullable: true),
                    poBox = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    province = table.Column<string>(nullable: true),
                    postalCode = table.Column<string>(nullable: true),
                    telephoneNumber = table.Column<long>(nullable: false),
                    mobileNumber = table.Column<long>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    nameOfNation = table.Column<bool>(nullable: false),
                    firstNationNameOfContactAddress = table.Column<string>(nullable: true),
                    COname = table.Column<string>(nullable: true),
                    IsGovernmentIssuedID = table.Column<bool>(nullable: false),
                    GovernmentIDFile = table.Column<string>(nullable: true),
                    modeOfPayment = table.Column<bool>(nullable: false),
                    chequeOrDepositFormFile = table.Column<string>(nullable: true),
                    authorizationFile = table.Column<string>(nullable: true),
                    authorizationDocumentType = table.Column<string>(nullable: true),
                    willYouBeClaimingSpecifiedInjuries = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => x.claimID);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    fileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fileName = table.Column<string>(nullable: true),
                    fileLocation = table.Column<string>(nullable: true),
                    fileSize = table.Column<string>(nullable: true),
                    documentType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.fileId);
                });

            migrationBuilder.CreateTable(
                name: "Reserve",
                columns: table => new
                {
                    reserveID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Proviences = table.Column<string>(nullable: true),
                    firstNationBandNumber = table.Column<string>(nullable: true),
                    startDateOfWaterAdvisory = table.Column<DateTime>(nullable: false),
                    endDateOfWaterAdvisory = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserve", x => x.reserveID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClaimFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    claimID = table.Column<int>(nullable: true),
                    fileId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClaimFiles_Claims_claimID",
                        column: x => x.claimID,
                        principalTable: "Claims",
                        principalColumn: "claimID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClaimFiles_Files_fileId",
                        column: x => x.fileId,
                        principalTable: "Files",
                        principalColumn: "fileId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClaimReserve",
                columns: table => new
                {
                    CRId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    claimID = table.Column<int>(nullable: true),
                    reserveID = table.Column<int>(nullable: true),
                    nameOfFirstNation = table.Column<string>(nullable: true),
                    provinceOrTerritory = table.Column<string>(nullable: true),
                    firstNationBandNumber = table.Column<string>(nullable: true),
                    waterAdvisoryStartDate = table.Column<DateTime>(nullable: false),
                    waterAdvisoryEndDate = table.Column<DateTime>(nullable: false),
                    fromLivedOnImpactedNation = table.Column<string>(nullable: true),
                    untilLivedOnImpactedNation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimReserve", x => x.CRId);
                    table.ForeignKey(
                        name: "FK_ClaimReserve_Claims_claimID",
                        column: x => x.claimID,
                        principalTable: "Claims",
                        principalColumn: "claimID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClaimReserve_Reserve_reserveID",
                        column: x => x.reserveID,
                        principalTable: "Reserve",
                        principalColumn: "reserveID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimFiles_claimID",
                table: "ClaimFiles",
                column: "claimID");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimFiles_fileId",
                table: "ClaimFiles",
                column: "fileId");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimReserve_claimID",
                table: "ClaimReserve",
                column: "claimID");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimReserve_reserveID",
                table: "ClaimReserve",
                column: "reserveID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ClaimFiles");

            migrationBuilder.DropTable(
                name: "ClaimReserve");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "Reserve");
        }
    }
}
