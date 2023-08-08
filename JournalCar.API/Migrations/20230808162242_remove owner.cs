using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JournalCar.API.Migrations
{
    /// <inheritdoc />
    public partial class removeowner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Owner_OwnerId",
                table: "Activity");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DeleteData(
                table: "CategoryActivity",
                keyColumn: "Id",
                keyValue: new Guid("610ad829-6b4a-4927-91a9-c52f70ac6db0"));

            migrationBuilder.DeleteData(
                table: "CategoryActivity",
                keyColumn: "Id",
                keyValue: new Guid("da56996d-a238-4b2a-a015-a46b0fd70bdc"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("9fb41a8c-8304-42f4-953f-ce442f211064"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("a6c133b0-86de-4ca5-9878-4ed7ad0b00f1"));

            migrationBuilder.DeleteData(
                table: "TypeDoc",
                keyColumn: "Id",
                keyValue: new Guid("00483259-ae07-48fe-b3f1-9497f64189a6"));

            migrationBuilder.DeleteData(
                table: "TypeDoc",
                keyColumn: "Id",
                keyValue: new Guid("5b2e4078-261a-458e-84de-d23e08a67354"));

            migrationBuilder.DeleteData(
                table: "TypeVehicle",
                keyColumn: "Id",
                keyValue: new Guid("804d8b9e-3911-4cae-abeb-aff3418ab20d"));

            migrationBuilder.DeleteData(
                table: "TypeVehicle",
                keyColumn: "Id",
                keyValue: new Guid("9e6dfad4-a366-4a18-8bd3-af66cf09e4d0"));

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Activity",
                newName: "VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Activity_OwnerId",
                table: "Activity",
                newName: "IX_Activity_VehicleId");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Vehicle",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "CategoryActivity",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("087d7dd3-3d74-423a-87f1-4df8d6d498eb"), "Actions that involve keep your vehicles 'healthy'.", "Maintenance" },
                    { new Guid("4fe658b8-d299-4c6f-bba6-638848e3741a"), "Mandatory activities from your goverment laws.", "Legal" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("beac573f-0a81-4a69-b657-2807578d8180"), "Complete" },
                    { new Guid("f4785a3f-3339-495d-a49a-9bf4363aa449"), "Pending" }
                });

            migrationBuilder.InsertData(
                table: "TypeDoc",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("84d90b2b-89be-4828-979a-bbb198a2a305"), "CC", "Cédula de ciudadania" },
                    { new Guid("f6430df0-5f4d-43ad-8c67-629115941eaa"), "CE", "Cedula de extranjeria" }
                });

            migrationBuilder.InsertData(
                table: "TypeVehicle",
                columns: new[] { "Id", "IconUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("3157ca37-a8f4-4c67-8b0f-b848aa6528f2"), null, "Carro" },
                    { new Guid("321a26e1-8976-499d-b3b8-8f9a53f70eee"), null, "Moto" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_UserId",
                table: "Vehicle",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Vehicle_VehicleId",
                table: "Activity",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_User_UserId",
                table: "Vehicle",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Vehicle_VehicleId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_User_UserId",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_UserId",
                table: "Vehicle");

            migrationBuilder.DeleteData(
                table: "CategoryActivity",
                keyColumn: "Id",
                keyValue: new Guid("087d7dd3-3d74-423a-87f1-4df8d6d498eb"));

            migrationBuilder.DeleteData(
                table: "CategoryActivity",
                keyColumn: "Id",
                keyValue: new Guid("4fe658b8-d299-4c6f-bba6-638848e3741a"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("beac573f-0a81-4a69-b657-2807578d8180"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("f4785a3f-3339-495d-a49a-9bf4363aa449"));

            migrationBuilder.DeleteData(
                table: "TypeDoc",
                keyColumn: "Id",
                keyValue: new Guid("84d90b2b-89be-4828-979a-bbb198a2a305"));

            migrationBuilder.DeleteData(
                table: "TypeDoc",
                keyColumn: "Id",
                keyValue: new Guid("f6430df0-5f4d-43ad-8c67-629115941eaa"));

            migrationBuilder.DeleteData(
                table: "TypeVehicle",
                keyColumn: "Id",
                keyValue: new Guid("3157ca37-a8f4-4c67-8b0f-b848aa6528f2"));

            migrationBuilder.DeleteData(
                table: "TypeVehicle",
                keyColumn: "Id",
                keyValue: new Guid("321a26e1-8976-499d-b3b8-8f9a53f70eee"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Vehicle");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Activity",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Activity_VehicleId",
                table: "Activity",
                newName: "IX_Activity_OwnerId");

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    isMainOwner = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Owner_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Owner_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CategoryActivity",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("610ad829-6b4a-4927-91a9-c52f70ac6db0"), "Actions that involve keep your vehicles 'healthy'.", "Maintenance" },
                    { new Guid("da56996d-a238-4b2a-a015-a46b0fd70bdc"), "Mandatory activities from your goverment laws.", "Legal" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9fb41a8c-8304-42f4-953f-ce442f211064"), "Complete" },
                    { new Guid("a6c133b0-86de-4ca5-9878-4ed7ad0b00f1"), "Pending" }
                });

            migrationBuilder.InsertData(
                table: "TypeDoc",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("00483259-ae07-48fe-b3f1-9497f64189a6"), "CE", "Cedula de extranjeria" },
                    { new Guid("5b2e4078-261a-458e-84de-d23e08a67354"), "CC", "Cédula de ciudadania" }
                });

            migrationBuilder.InsertData(
                table: "TypeVehicle",
                columns: new[] { "Id", "IconUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("804d8b9e-3911-4cae-abeb-aff3418ab20d"), null, "Moto" },
                    { new Guid("9e6dfad4-a366-4a18-8bd3-af66cf09e4d0"), null, "Carro" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Owner_UserId",
                table: "Owner",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_VehicleId",
                table: "Owner",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Owner_OwnerId",
                table: "Activity",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
