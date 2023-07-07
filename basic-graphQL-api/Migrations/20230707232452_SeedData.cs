using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace basic_graphQL_api.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EmployeeEntities",
                columns: new[] { "Id", "FirstName", "Position", "SecondName" },
                values: new object[,]
                {
                    { 1, "Amira", "Future Interactions Assistant", "Gerhold" },
                    { 2, "Celestino", "Global Data Consultant", "Crona" },
                    { 3, "Electa", "Forward Solutions Planner", "Bartell" },
                    { 4, "Antonio", "Product Marketing Administrator", "McCullough" },
                    { 5, "Arlo", "Corporate Web Director", "Howe" },
                    { 6, "Agustin", "Direct Brand Architect", "Beahan" },
                    { 7, "Alfonso", "Legacy Mobility Designer", "Bernier" },
                    { 8, "Kaci", "Dynamic Metrics Agent", "Cassin" },
                    { 9, "Bennett", "Direct Interactions Designer", "Johns" },
                    { 10, "Vivien", "Senior Tactics Officer", "Mraz" },
                    { 11, "Domenico", "Chief Quality Architect", "Von" },
                    { 12, "Josefina", "Forward Configuration Developer", "Herman" },
                    { 13, "Jaycee", "District Markets Officer", "Steuber" },
                    { 14, "Athena", "Dynamic Usability Architect", "Johns" },
                    { 15, "Clint", "Customer Accounts Technician", "Gottlieb" },
                    { 16, "Savanna", "Forward Operations Analyst", "Jakubowski" },
                    { 17, "Kathlyn", "Chief Mobility Administrator", "Johnson" },
                    { 18, "Justyn", "Dynamic Operations Agent", "McCullough" },
                    { 19, "Justine", "Legacy Quality Assistant", "Marks" },
                    { 20, "Eunice", "Senior Mobility Assistant", "Wiegand" },
                    { 21, "Loraine", "Corporate Data Director", "Kautzer" },
                    { 22, "Buddy", "Global Quality Facilitator", "Larkin" },
                    { 23, "Zoe", "Regional Branding Engineer", "Miller" },
                    { 24, "Nadia", "Investor Tactics Manager", "Stamm" },
                    { 25, "Dorris", "Dynamic Research Consultant", "Gottlieb" },
                    { 26, "Nakia", "Product Paradigm Assistant", "Rippin" },
                    { 27, "Tressie", "Chief Data Orchestrator", "Prohaska" },
                    { 28, "Kristoffer", "Future Mobility Specialist", "Powlowski" },
                    { 29, "Allie", "Forward Intranet Coordinator", "Kiehn" },
                    { 30, "Shany", "Corporate Brand Analyst", "Stanton" },
                    { 31, "Amparo", "Dynamic Identity Producer", "King" },
                    { 32, "Christophe", "Product Branding Executive", "Larkin" },
                    { 33, "Dixie", "International Functionality Architect", "Schuppe" },
                    { 34, "Floy", "Chief Identity Strategist", "Little" },
                    { 35, "Faye", "Lead Identity Liaison", "Schimmel" },
                    { 36, "Trudie", "District Usability Technician", "Jakubowski" },
                    { 37, "Trinity", "Corporate Group Analyst", "Spinka" },
                    { 38, "Adalberto", "Global Usability Engineer", "Ziemann" },
                    { 39, "Madelyn", "Legacy Metrics Facilitator", "Orn" },
                    { 40, "Montana", "Investor Accounts Designer", "Grant" },
                    { 41, "Bernie", "Chief Implementation Officer", "Adams" },
                    { 42, "Josefina", "Human Group Technician", "Hodkiewicz" },
                    { 43, "Maegan", "National Implementation Strategist", "Kris" },
                    { 44, "Colton", "National Division Consultant", "Buckridge" },
                    { 45, "Aletha", "Senior Communications Director", "D'Amore" },
                    { 46, "Margret", "Product Operations Supervisor", "King" },
                    { 47, "Alexis", "Principal Communications Planner", "Barrows" },
                    { 48, "Skyla", "Human Data Technician", "Barton" },
                    { 49, "Brady", "Central Operations Assistant", "Streich" },
                    { 50, "Constance", "Dynamic Metrics Analyst", "Littel" },
                    { 51, "Jonathon", "Legacy Program Producer", "Durgan" },
                    { 52, "Antone", "Direct Functionality Associate", "Thompson" },
                    { 53, "Maddison", "Chief Tactics Analyst", "Dare" },
                    { 54, "Berry", "Lead Accounts Consultant", "Ziemann" },
                    { 55, "Carolyne", "Internal Research Specialist", "Kohler" },
                    { 56, "Lorine", "Direct Branding Representative", "Heaney" },
                    { 57, "Arnoldo", "National Quality Specialist", "Becker" },
                    { 58, "Al", "Forward Operations Director", "Baumbach" },
                    { 59, "Dora", "National Security Facilitator", "Prohaska" },
                    { 60, "Keagan", "International Web Representative", "Ullrich" },
                    { 61, "Nathen", "Future Configuration Architect", "Dietrich" },
                    { 62, "Samson", "Dynamic Branding Liaison", "Kemmer" },
                    { 63, "Dexter", "Human Applications Manager", "McGlynn" },
                    { 64, "Eldred", "Lead Web Planner", "Lynch" },
                    { 65, "Andreanne", "International Identity Agent", "Koelpin" },
                    { 66, "Sabina", "Senior Security Strategist", "McKenzie" },
                    { 67, "Pedro", "Lead Brand Executive", "Reinger" },
                    { 68, "Joelle", "Regional Optimization Administrator", "Schmidt" },
                    { 69, "Ebony", "Internal Program Agent", "McKenzie" },
                    { 70, "Jerel", "Customer Paradigm Manager", "Altenwerth" },
                    { 71, "June", "Forward Research Engineer", "Gutmann" },
                    { 72, "Candice", "Product Branding Orchestrator", "Block" },
                    { 73, "Joelle", "Human Creative Representative", "Greenholt" },
                    { 74, "Herbert", "Regional Directives Facilitator", "Upton" },
                    { 75, "Leatha", "District Response Consultant", "Windler" },
                    { 76, "America", "Principal Response Developer", "Muller" },
                    { 77, "Ofelia", "Future Interactions Associate", "Schultz" },
                    { 78, "Adrian", "Customer Quality Producer", "Powlowski" },
                    { 79, "Evelyn", "Direct Identity Orchestrator", "Moore" },
                    { 80, "Malika", "International Usability Supervisor", "Langosh" },
                    { 81, "Murphy", "District Quality Associate", "Goodwin" },
                    { 82, "Melyna", "Principal Communications Designer", "Rice" },
                    { 83, "Kaela", "Chief Accounts Facilitator", "Koss" },
                    { 84, "Cole", "Legacy Functionality Representative", "Gorczany" },
                    { 85, "Emmett", "Investor Group Orchestrator", "Leannon" },
                    { 86, "Miller", "Principal Factors Agent", "Hayes" },
                    { 87, "Rollin", "International Accounts Associate", "Barrows" },
                    { 88, "Sydnie", "Product Factors Technician", "Terry" },
                    { 89, "Jo", "Direct Optimization Manager", "Bruen" },
                    { 90, "Breanne", "Dynamic Program Manager", "Bayer" },
                    { 91, "Elisha", "Human Response Developer", "Runolfsdottir" },
                    { 92, "Faye", "Forward Functionality Producer", "Block" },
                    { 93, "Marcelle", "Future Interactions Producer", "Nolan" },
                    { 94, "Dominic", "Product Group Supervisor", "Breitenberg" },
                    { 95, "Riley", "Internal Research Assistant", "Altenwerth" },
                    { 96, "Bradley", "Legacy Research Engineer", "Muller" },
                    { 97, "Beau", "Forward Program Coordinator", "Pacocha" },
                    { 98, "Aurelia", "Direct Communications Facilitator", "Herman" },
                    { 99, "Guadalupe", "Customer Directives Producer", "Conn" },
                    { 100, "Emmalee", "Direct Group Agent", "Erdman" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "EmployeeEntities",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
