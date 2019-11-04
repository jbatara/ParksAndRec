using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksAndRecAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Address", "City", "DepartmentHead_FirstName", "DepartmentHead_LasetName", "DepartmentName", "State" },
                values: new object[] { 1, null, null, "Kristine", "Stratton", "National Recreation and Park Association", null });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Address", "City", "DepartmentHead_FirstName", "DepartmentHead_LasetName", "DepartmentName", "State" },
                values: new object[] { 2, null, null, "Ron", "Swanson", "Pawnee Parks and Recreation Department", null });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Address", "City", "DepartmentHead_FirstName", "DepartmentHead_LasetName", "DepartmentName", "State" },
                values: new object[] { 3, null, null, "First", "Last", "Eagleton Parks and Recreation Department", null });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Acres", "Address", "City", "DepartmentId", "Name", "State", "YearFounded", "ZipCode" },
                values: new object[,]
                {
                    { 1, 0.0, null, null, 2, "Pwnee Commons", null, 1986, 0 },
                    { 2, 0.0, null, null, 2, "Harvey James Park", null, 0, 0 },
                    { 3, 0.0, null, null, 2, "Lafayette Park", null, 0, 0 },
                    { 5, 0.0, null, null, 2, "Maplewood Park", null, 0, 0 },
                    { 6, 0.0, null, null, 2, "North Pawnee Recreation Center", null, 0, 0 },
                    { 7, 0.0, null, null, 2, "Wamapokestone Park", null, 0, 0 },
                    { 8, 0.0, null, null, 2, "Tucker Park", null, 0, 0 },
                    { 9, 0.0, null, null, 2, "Pawnee Park: Smallest Park in Indiana", null, 0, 0 },
                    { 10, 0.0, null, null, 2, "Slippery Elm Park", null, 0, 0 },
                    { 11, 0.0, null, null, 2, "Ramsett Park", null, 0, 0 },
                    { 4, 0.0, null, null, 3, "Eagleton Park", null, 0, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3);
        }
    }
}
