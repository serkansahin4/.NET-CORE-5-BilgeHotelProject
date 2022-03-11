using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BilgeHotel.DataAccess.Migrations
{
    public partial class sajdejge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Salary = table.Column<decimal>(type: "money", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Beds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BedType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cv2 = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    EndDate = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TcIdentityNo = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtraName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelExtras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtraName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelExtras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomSituations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomSituations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomViews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViewName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomViews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShiftTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    StopTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftTimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomBeds",
                columns: table => new
                {
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    BedId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomBeds", x => new { x.BedId, x.RoomTypeId });
                    table.ForeignKey(
                        name: "FK_RoomBeds_Beds_BedId",
                        column: x => x.BedId,
                        principalTable: "Beds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomBeds_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypeExtra",
                columns: table => new
                {
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    ExtraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypeExtra", x => new { x.RoomTypeId, x.ExtraId });
                    table.ForeignKey(
                        name: "FK_RoomTypeExtra_Extras_ExtraId",
                        column: x => x.ExtraId,
                        principalTable: "Extras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomTypeExtra_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomName = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomSize = table.Column<short>(type: "smallint", nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    RoomViewId = table.Column<int>(type: "int", nullable: false),
                    RoomSituationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomName);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomSituations_RoomSituationId",
                        column: x => x.RoomSituationId,
                        principalTable: "RoomSituations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomViews_RoomViewId",
                        column: x => x.RoomViewId,
                        principalTable: "RoomViews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeJobs",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    DayId = table.Column<int>(type: "int", nullable: false),
                    ShiftTimeId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeJobs", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_EmployeeJobs_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeJobs_Days_DayId",
                        column: x => x.DayId,
                        principalTable: "Days",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeJobs_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeJobs_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeJobs_ShiftTimes_ShiftTimeId",
                        column: x => x.ShiftTimeId,
                        principalTable: "ShiftTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationDetails",
                columns: table => new
                {
                    ReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    CardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    DiscountedPrice = table.Column<decimal>(type: "money", nullable: true),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationDetails", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_ReservationDetails_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReservationDetails_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationDetails_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartShift = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StopShift = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExtraTimeStop = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeJobId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shifts_EmployeeJobs_EmployeeJobId",
                        column: x => x.EmployeeJobId,
                        principalTable: "EmployeeJobs",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    ExtraTotalPrice = table.Column<decimal>(type: "money", nullable: true),
                    Out = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_ReservationDetails_Id",
                        column: x => x.Id,
                        principalTable: "ReservationDetails",
                        principalColumn: "ReservationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationOutHotelExtras",
                columns: table => new
                {
                    HotelExtraId = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationOutHotelExtras", x => new { x.HotelExtraId, x.ReservationId });
                    table.ForeignKey(
                        name: "FK_ReservationOutHotelExtras_HotelExtras_HotelExtraId",
                        column: x => x.HotelExtraId,
                        principalTable: "HotelExtras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationOutHotelExtras_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "Salary", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 4, 0, "Sırasöğütler", "5e945c0b-1e5b-484d-b35a-983fa74beb33", "1mehmet@gmail.com", false, "Gaye", "Şahin", false, null, null, null, null, "12345678955", null, false, 200m, null, false, "gayee" },
                    { 3, 0, "Sırasöğütler", "e9906289-cb78-4e7d-993e-78ac6a96d997", "1mustafa60@gmail.com", false, "Mehmet", "Şahin", false, null, null, null, null, "12345678955", null, false, 200m, null, false, "mehmete" },
                    { 2, 0, "Sırasöğütler", "e89eb0ba-bd5d-40f8-bf98-05e753068434", "1osmana60@gmail.com", false, "Murat", "Şahin", false, null, null, null, null, "12345678955", null, false, 100m, null, false, "murata" },
                    { 1, 0, "Sırasöğütler", "c1725db8-1b59-4eae-a844-332158fbb0d2", "1serkana60@gmail.com", true, "Osman", "Şahin", false, null, null, null, null, "12345678955", null, true, 500m, null, false, "osmana" }
                });

            migrationBuilder.InsertData(
                table: "Beds",
                columns: new[] { "Id", "BedType" },
                values: new object[,]
                {
                    { 1, "Tek Kişilik" },
                    { 2, "Double" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CardType", "Cv2", "EndDate" },
                values: new object[] { new Guid("ea5e6f70-1ce6-40d9-b9ff-c6d3216d66b2"), "selam", "Ziraat", "ABC", "02/05" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "Phone", "TcIdentityNo" },
                values: new object[] { 1, new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "serkana607@gmail.com", "Serkan", "Şahin", "25365485652", "64657172255" });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "DayName" },
                values: new object[,]
                {
                    { 1, "Pazartesi" },
                    { 2, "Salı" },
                    { 3, "Çarşamba" },
                    { 4, "Perşembe" },
                    { 5, "Cuma" },
                    { 6, "Cumartesi" },
                    { 7, "Pazar" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentName" },
                values: new object[,]
                {
                    { 7, "Elektrik" },
                    { 2, "SatisDepartmani" },
                    { 5, "InsanKaynaklari" },
                    { 3, "Resepsiyon" },
                    { 1, "Bilişim" },
                    { 6, "Mutfak" }
                });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "ExtraName" },
                values: new object[,]
                {
                    { 4, "Kablosuz İnternet" },
                    { 1, "Klima" },
                    { 2, "Televizyon" },
                    { 3, "Saç Kurutma Makinesi" },
                    { 5, "Minibar" }
                });

            migrationBuilder.InsertData(
                table: "HotelExtras",
                columns: new[] { "Id", "ExtraName", "Price" },
                values: new object[] { 1, "Şarap", 150m });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "JobName" },
                values: new object[,]
                {
                    { 1, "Resepsiyon Görevlisi" },
                    { 2, "Temizlik Görevlisi" },
                    { 3, "Aşçı" },
                    { 4, "Garson" },
                    { 5, "Elektrikci" },
                    { 6, "Bilgi İşlem Sorumlusu" }
                });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "PackageName", "Price" },
                values: new object[,]
                {
                    { 1, "Tam Pansiyon", 0m },
                    { 2, "Herşey Dahil", 0m }
                });

            migrationBuilder.InsertData(
                table: "RoomSituations",
                columns: new[] { "Id", "StatusName" },
                values: new object[,]
                {
                    { 1, "Hazır" },
                    { 2, "Meşgul" },
                    { 3, "Bakımda" },
                    { 4, "Hazırlanıyor" }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Name", "Price", "RoomTypeName" },
                values: new object[,]
                {
                    { 8, "Kral Dairesi DoubleYat", 1000m, "Kral Dairesi" },
                    { 7, "Sülale Odası Sülalecek Yat", 750m, "Dört Kişilik" },
                    { 6, "Aile Odası Çift Yanyana Cocuk AyrıYat", 350m, "Üç Kişilik" }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Name", "Price", "RoomTypeName" },
                values: new object[,]
                {
                    { 5, "Aile Odası AyrıYat", 200m, "Üç Kişilik" },
                    { 1, "Bekar Odası TekYat", 100m, "Tek Kişilik" },
                    { 3, "Çift Odası AyrıYat", 200m, "İki Kişilik" },
                    { 2, "Bekar Odası DoubleYat", 100m, "Tek Kişilik" },
                    { 4, "Çift Odası ÇiftYat", 150m, "İki Kişilik" }
                });

            migrationBuilder.InsertData(
                table: "RoomViews",
                columns: new[] { "Id", "ViewName" },
                values: new object[,]
                {
                    { 1, "Deniz" },
                    { 2, "Duvar" }
                });

            migrationBuilder.InsertData(
                table: "ShiftTimes",
                columns: new[] { "Id", "StartTime", "StopTime" },
                values: new object[,]
                {
                    { 3, new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 0, 0, 0, 0) },
                    { 1, new TimeSpan(0, 0, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 2, new TimeSpan(0, 8, 0, 0, 0), new TimeSpan(0, 16, 0, 0, 0) },
                    { 4, new TimeSpan(0, 8, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "EmployeeJobs",
                columns: new[] { "EmployeeId", "DayId", "DepartmentId", "JobId", "ShiftTimeId" },
                values: new object[,]
                {
                    { 3, 7, 1, 6, 4 },
                    { 4, 7, 3, 1, 1 },
                    { 1, 1, 1, 1, 1 },
                    { 2, 7, 7, 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Path", "RoomTypeId" },
                values: new object[,]
                {
                    { 9, "ABC.jpg", 5 },
                    { 6, "resepsiyon.jpg", 3 },
                    { 5, "ABC.jpg", 3 },
                    { 10, "resepsiyon.jpg", 5 },
                    { 11, "ABC.jpg", 6 },
                    { 12, "resepsiyon.jpg", 6 },
                    { 4, "resepsiyon.jpg", 2 },
                    { 8, "resepsiyon.jpg", 4 },
                    { 3, "ABC.jpg", 2 },
                    { 13, "ABC.jpg", 7 },
                    { 14, "resepsiyon.jpg", 7 },
                    { 15, "ABC.jpg", 8 },
                    { 2, "resepsiyon.jpg", 1 },
                    { 1, "ABC.jpg", 1 },
                    { 16, "resepsiyon.jpg", 8 },
                    { 7, "ABC.jpg", 4 }
                });

            migrationBuilder.InsertData(
                table: "RoomBeds",
                columns: new[] { "BedId", "RoomTypeId", "Quantity" },
                values: new object[,]
                {
                    { 2, 7, 1 },
                    { 2, 8, 1 },
                    { 1, 6, 1 },
                    { 2, 6, 1 },
                    { 1, 5, 3 },
                    { 1, 7, 2 },
                    { 1, 1, 1 },
                    { 1, 3, 2 },
                    { 2, 2, 1 },
                    { 2, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "RoomTypeExtra",
                columns: new[] { "ExtraId", "RoomTypeId" },
                values: new object[,]
                {
                    { 2, 7 },
                    { 3, 7 },
                    { 4, 7 },
                    { 5, 7 },
                    { 3, 2 },
                    { 2, 2 },
                    { 1, 2 },
                    { 1, 8 },
                    { 2, 8 },
                    { 3, 8 },
                    { 4, 8 },
                    { 5, 8 }
                });

            migrationBuilder.InsertData(
                table: "RoomTypeExtra",
                columns: new[] { "ExtraId", "RoomTypeId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 1, 1 },
                    { 3, 1 },
                    { 4, 4 },
                    { 1, 7 },
                    { 5, 4 },
                    { 2, 1 },
                    { 1, 3 },
                    { 4, 2 },
                    { 2, 4 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 5 },
                    { 3, 5 },
                    { 4, 5 },
                    { 5, 5 },
                    { 3, 4 },
                    { 4, 3 },
                    { 3, 3 },
                    { 1, 6 },
                    { 2, 6 },
                    { 3, 6 },
                    { 4, 6 },
                    { 2, 3 },
                    { 5, 3 },
                    { 5, 6 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomName", "RoomSituationId", "RoomSize", "RoomTypeId", "RoomViewId" },
                values: new object[,]
                {
                    { 117, 1, (short)50, 5, 1 },
                    { 116, 1, (short)50, 5, 1 },
                    { 115, 1, (short)50, 5, 1 },
                    { 114, 1, (short)50, 5, 1 },
                    { 113, 1, (short)50, 5, 1 },
                    { 112, 1, (short)50, 5, 1 },
                    { 409, 1, (short)50, 4, 1 },
                    { 110, 1, (short)50, 5, 1 },
                    { 408, 1, (short)50, 4, 1 },
                    { 407, 1, (short)50, 4, 1 },
                    { 406, 1, (short)50, 4, 1 },
                    { 405, 1, (short)50, 4, 1 },
                    { 118, 1, (short)50, 5, 1 },
                    { 403, 1, (short)50, 4, 1 },
                    { 111, 1, (short)50, 5, 1 },
                    { 404, 1, (short)50, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomName", "RoomSituationId", "RoomSize", "RoomTypeId", "RoomViewId" },
                values: new object[,]
                {
                    { 317, 1, (short)50, 6, 1 },
                    { 310, 1, (short)50, 6, 1 },
                    { 402, 1, (short)50, 4, 1 },
                    { 420, 1, (short)750, 8, 1 },
                    { 415, 1, (short)50, 7, 1 },
                    { 414, 1, (short)50, 7, 1 },
                    { 413, 1, (short)50, 7, 1 },
                    { 412, 1, (short)50, 7, 1 },
                    { 411, 1, (short)50, 7, 1 },
                    { 119, 1, (short)50, 5, 1 },
                    { 410, 1, (short)50, 7, 1 },
                    { 318, 1, (short)50, 6, 1 },
                    { 316, 1, (short)50, 6, 1 },
                    { 315, 1, (short)50, 6, 1 },
                    { 314, 1, (short)50, 6, 1 },
                    { 313, 1, (short)50, 6, 1 },
                    { 312, 1, (short)50, 6, 1 },
                    { 311, 1, (short)50, 6, 1 },
                    { 319, 1, (short)50, 6, 1 },
                    { 401, 1, (short)50, 4, 1 },
                    { 211, 1, (short)50, 3, 1 },
                    { 309, 1, (short)50, 4, 1 },
                    { 206, 1, (short)50, 2, 1 },
                    { 205, 1, (short)50, 2, 1 },
                    { 204, 1, (short)50, 2, 1 },
                    { 203, 1, (short)50, 2, 1 },
                    { 202, 1, (short)50, 2, 1 },
                    { 201, 1, (short)50, 2, 1 },
                    { 200, 1, (short)50, 2, 1 },
                    { 207, 1, (short)50, 2, 1 },
                    { 109, 1, (short)50, 1, 1 },
                    { 106, 1, (short)50, 1, 1 },
                    { 105, 1, (short)50, 1, 1 },
                    { 104, 1, (short)50, 1, 1 },
                    { 103, 1, (short)50, 1, 1 },
                    { 102, 1, (short)50, 1, 1 },
                    { 101, 1, (short)50, 1, 1 },
                    { 100, 1, (short)50, 1, 1 },
                    { 107, 1, (short)50, 1, 1 },
                    { 208, 1, (short)50, 2, 1 },
                    { 209, 1, (short)50, 2, 1 },
                    { 210, 1, (short)50, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomName", "RoomSituationId", "RoomSize", "RoomTypeId", "RoomViewId" },
                values: new object[,]
                {
                    { 308, 1, (short)50, 4, 1 },
                    { 307, 1, (short)50, 4, 1 },
                    { 306, 1, (short)50, 4, 1 },
                    { 305, 1, (short)50, 4, 1 },
                    { 304, 1, (short)50, 4, 1 },
                    { 303, 1, (short)50, 4, 1 },
                    { 302, 1, (short)50, 4, 1 },
                    { 301, 1, (short)50, 4, 1 },
                    { 300, 1, (short)50, 4, 1 },
                    { 219, 1, (short)50, 3, 1 },
                    { 218, 1, (short)50, 3, 1 },
                    { 217, 1, (short)50, 3, 1 },
                    { 216, 1, (short)50, 3, 1 },
                    { 215, 1, (short)50, 3, 1 },
                    { 214, 1, (short)50, 3, 1 },
                    { 213, 1, (short)50, 3, 1 },
                    { 212, 1, (short)50, 3, 1 },
                    { 400, 1, (short)50, 4, 1 },
                    { 108, 1, (short)50, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "ReservationDetails",
                columns: new[] { "ReservationId", "CardId", "CheckInDate", "CheckOutDate", "CreatedDate", "Discount", "DiscountedPrice", "PackageId", "RoomId" },
                values: new object[,]
                {
                    { new Guid("17427745-5488-4d17-8738-d275a59b2b32"), new Guid("ea5e6f70-1ce6-40d9-b9ff-c6d3216d66b2"), new DateTime(2022, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 10, 22, 33, 45, 72, DateTimeKind.Local).AddTicks(4496), 22.0, 150m, 1, 101 },
                    { new Guid("ae17ac89-0e13-4294-8615-f1dd76a3e7fd"), new Guid("ea5e6f70-1ce6-40d9-b9ff-c6d3216d66b2"), new DateTime(2022, 3, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 10, 22, 33, 45, 72, DateTimeKind.Local).AddTicks(6980), 22.0, 150m, 1, 101 },
                    { new Guid("be8268b3-4bf9-46bc-8038-aa37f4b107a2"), new Guid("ea5e6f70-1ce6-40d9-b9ff-c6d3216d66b2"), new DateTime(2022, 3, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 10, 22, 33, 45, 72, DateTimeKind.Local).AddTicks(6987), 22.0, 150m, 1, 101 },
                    { new Guid("cafaff4c-9747-4af6-93da-c345d1f0de57"), new Guid("ea5e6f70-1ce6-40d9-b9ff-c6d3216d66b2"), new DateTime(2022, 3, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 10, 22, 33, 45, 72, DateTimeKind.Local).AddTicks(6993), 22.0, 150m, 1, 102 }
                });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "Id", "CreatedDate", "EmployeeJobId", "ExtraTimeStop", "StartShift", "StopShift" },
                values: new object[] { 1, new DateTime(2022, 3, 10, 22, 33, 45, 69, DateTimeKind.Local).AddTicks(635), 4, new DateTime(2022, 3, 10, 22, 33, 45, 71, DateTimeKind.Local).AddTicks(600), new DateTime(2022, 3, 10, 22, 33, 45, 70, DateTimeKind.Local).AddTicks(9172), new DateTime(2022, 3, 10, 22, 33, 45, 70, DateTimeKind.Local).AddTicks(9713) });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "ExtraTotalPrice", "Out" },
                values: new object[,]
                {
                    { new Guid("17427745-5488-4d17-8738-d275a59b2b32"), 1, null, null, null },
                    { new Guid("ae17ac89-0e13-4294-8615-f1dd76a3e7fd"), 1, null, null, null },
                    { new Guid("be8268b3-4bf9-46bc-8038-aa37f4b107a2"), 1, null, null, null },
                    { new Guid("cafaff4c-9747-4af6-93da-c345d1f0de57"), 1, 4, null, null }
                });

            migrationBuilder.InsertData(
                table: "ReservationOutHotelExtras",
                columns: new[] { "HotelExtraId", "ReservationId", "Quantity" },
                values: new object[] { 1, new Guid("17427745-5488-4d17-8738-d275a59b2b32"), (short)5 });

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
                name: "IX_EmployeeJobs_DayId",
                table: "EmployeeJobs",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeJobs_DepartmentId",
                table: "EmployeeJobs",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeJobs_JobId",
                table: "EmployeeJobs",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeJobs_ShiftTimeId",
                table: "EmployeeJobs",
                column: "ShiftTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_RoomTypeId",
                table: "Images",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_CardId",
                table: "ReservationDetails",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_PackageId",
                table: "ReservationDetails",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_RoomId",
                table: "ReservationDetails",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationOutHotelExtras_ReservationId",
                table: "ReservationOutHotelExtras",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_EmployeeId",
                table: "Reservations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBeds_RoomTypeId",
                table: "RoomBeds",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomSituationId",
                table: "Rooms",
                column: "RoomSituationId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomViewId",
                table: "Rooms",
                column: "RoomViewId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomTypeExtra_ExtraId",
                table: "RoomTypeExtra",
                column: "ExtraId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_EmployeeJobId",
                table: "Shifts",
                column: "EmployeeJobId");
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
                name: "Images");

            migrationBuilder.DropTable(
                name: "ReservationOutHotelExtras");

            migrationBuilder.DropTable(
                name: "RoomBeds");

            migrationBuilder.DropTable(
                name: "RoomTypeExtra");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "HotelExtras");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Beds");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "EmployeeJobs");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ReservationDetails");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "ShiftTimes");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "RoomSituations");

            migrationBuilder.DropTable(
                name: "RoomTypes");

            migrationBuilder.DropTable(
                name: "RoomViews");
        }
    }
}
