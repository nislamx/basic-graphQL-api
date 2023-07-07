﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using basic_graphQL_api.Infrastructure;

#nullable disable

namespace basic_graphQL_api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0-preview.5.23280.1");

            modelBuilder.Entity("basic_graphQL_api.Core.Entities.EmployeeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EmployeeEntities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Amira",
                            Position = "Future Interactions Assistant",
                            SecondName = "Gerhold"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Celestino",
                            Position = "Global Data Consultant",
                            SecondName = "Crona"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Electa",
                            Position = "Forward Solutions Planner",
                            SecondName = "Bartell"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Antonio",
                            Position = "Product Marketing Administrator",
                            SecondName = "McCullough"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Arlo",
                            Position = "Corporate Web Director",
                            SecondName = "Howe"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Agustin",
                            Position = "Direct Brand Architect",
                            SecondName = "Beahan"
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Alfonso",
                            Position = "Legacy Mobility Designer",
                            SecondName = "Bernier"
                        },
                        new
                        {
                            Id = 8,
                            FirstName = "Kaci",
                            Position = "Dynamic Metrics Agent",
                            SecondName = "Cassin"
                        },
                        new
                        {
                            Id = 9,
                            FirstName = "Bennett",
                            Position = "Direct Interactions Designer",
                            SecondName = "Johns"
                        },
                        new
                        {
                            Id = 10,
                            FirstName = "Vivien",
                            Position = "Senior Tactics Officer",
                            SecondName = "Mraz"
                        },
                        new
                        {
                            Id = 11,
                            FirstName = "Domenico",
                            Position = "Chief Quality Architect",
                            SecondName = "Von"
                        },
                        new
                        {
                            Id = 12,
                            FirstName = "Josefina",
                            Position = "Forward Configuration Developer",
                            SecondName = "Herman"
                        },
                        new
                        {
                            Id = 13,
                            FirstName = "Jaycee",
                            Position = "District Markets Officer",
                            SecondName = "Steuber"
                        },
                        new
                        {
                            Id = 14,
                            FirstName = "Athena",
                            Position = "Dynamic Usability Architect",
                            SecondName = "Johns"
                        },
                        new
                        {
                            Id = 15,
                            FirstName = "Clint",
                            Position = "Customer Accounts Technician",
                            SecondName = "Gottlieb"
                        },
                        new
                        {
                            Id = 16,
                            FirstName = "Savanna",
                            Position = "Forward Operations Analyst",
                            SecondName = "Jakubowski"
                        },
                        new
                        {
                            Id = 17,
                            FirstName = "Kathlyn",
                            Position = "Chief Mobility Administrator",
                            SecondName = "Johnson"
                        },
                        new
                        {
                            Id = 18,
                            FirstName = "Justyn",
                            Position = "Dynamic Operations Agent",
                            SecondName = "McCullough"
                        },
                        new
                        {
                            Id = 19,
                            FirstName = "Justine",
                            Position = "Legacy Quality Assistant",
                            SecondName = "Marks"
                        },
                        new
                        {
                            Id = 20,
                            FirstName = "Eunice",
                            Position = "Senior Mobility Assistant",
                            SecondName = "Wiegand"
                        },
                        new
                        {
                            Id = 21,
                            FirstName = "Loraine",
                            Position = "Corporate Data Director",
                            SecondName = "Kautzer"
                        },
                        new
                        {
                            Id = 22,
                            FirstName = "Buddy",
                            Position = "Global Quality Facilitator",
                            SecondName = "Larkin"
                        },
                        new
                        {
                            Id = 23,
                            FirstName = "Zoe",
                            Position = "Regional Branding Engineer",
                            SecondName = "Miller"
                        },
                        new
                        {
                            Id = 24,
                            FirstName = "Nadia",
                            Position = "Investor Tactics Manager",
                            SecondName = "Stamm"
                        },
                        new
                        {
                            Id = 25,
                            FirstName = "Dorris",
                            Position = "Dynamic Research Consultant",
                            SecondName = "Gottlieb"
                        },
                        new
                        {
                            Id = 26,
                            FirstName = "Nakia",
                            Position = "Product Paradigm Assistant",
                            SecondName = "Rippin"
                        },
                        new
                        {
                            Id = 27,
                            FirstName = "Tressie",
                            Position = "Chief Data Orchestrator",
                            SecondName = "Prohaska"
                        },
                        new
                        {
                            Id = 28,
                            FirstName = "Kristoffer",
                            Position = "Future Mobility Specialist",
                            SecondName = "Powlowski"
                        },
                        new
                        {
                            Id = 29,
                            FirstName = "Allie",
                            Position = "Forward Intranet Coordinator",
                            SecondName = "Kiehn"
                        },
                        new
                        {
                            Id = 30,
                            FirstName = "Shany",
                            Position = "Corporate Brand Analyst",
                            SecondName = "Stanton"
                        },
                        new
                        {
                            Id = 31,
                            FirstName = "Amparo",
                            Position = "Dynamic Identity Producer",
                            SecondName = "King"
                        },
                        new
                        {
                            Id = 32,
                            FirstName = "Christophe",
                            Position = "Product Branding Executive",
                            SecondName = "Larkin"
                        },
                        new
                        {
                            Id = 33,
                            FirstName = "Dixie",
                            Position = "International Functionality Architect",
                            SecondName = "Schuppe"
                        },
                        new
                        {
                            Id = 34,
                            FirstName = "Floy",
                            Position = "Chief Identity Strategist",
                            SecondName = "Little"
                        },
                        new
                        {
                            Id = 35,
                            FirstName = "Faye",
                            Position = "Lead Identity Liaison",
                            SecondName = "Schimmel"
                        },
                        new
                        {
                            Id = 36,
                            FirstName = "Trudie",
                            Position = "District Usability Technician",
                            SecondName = "Jakubowski"
                        },
                        new
                        {
                            Id = 37,
                            FirstName = "Trinity",
                            Position = "Corporate Group Analyst",
                            SecondName = "Spinka"
                        },
                        new
                        {
                            Id = 38,
                            FirstName = "Adalberto",
                            Position = "Global Usability Engineer",
                            SecondName = "Ziemann"
                        },
                        new
                        {
                            Id = 39,
                            FirstName = "Madelyn",
                            Position = "Legacy Metrics Facilitator",
                            SecondName = "Orn"
                        },
                        new
                        {
                            Id = 40,
                            FirstName = "Montana",
                            Position = "Investor Accounts Designer",
                            SecondName = "Grant"
                        },
                        new
                        {
                            Id = 41,
                            FirstName = "Bernie",
                            Position = "Chief Implementation Officer",
                            SecondName = "Adams"
                        },
                        new
                        {
                            Id = 42,
                            FirstName = "Josefina",
                            Position = "Human Group Technician",
                            SecondName = "Hodkiewicz"
                        },
                        new
                        {
                            Id = 43,
                            FirstName = "Maegan",
                            Position = "National Implementation Strategist",
                            SecondName = "Kris"
                        },
                        new
                        {
                            Id = 44,
                            FirstName = "Colton",
                            Position = "National Division Consultant",
                            SecondName = "Buckridge"
                        },
                        new
                        {
                            Id = 45,
                            FirstName = "Aletha",
                            Position = "Senior Communications Director",
                            SecondName = "D'Amore"
                        },
                        new
                        {
                            Id = 46,
                            FirstName = "Margret",
                            Position = "Product Operations Supervisor",
                            SecondName = "King"
                        },
                        new
                        {
                            Id = 47,
                            FirstName = "Alexis",
                            Position = "Principal Communications Planner",
                            SecondName = "Barrows"
                        },
                        new
                        {
                            Id = 48,
                            FirstName = "Skyla",
                            Position = "Human Data Technician",
                            SecondName = "Barton"
                        },
                        new
                        {
                            Id = 49,
                            FirstName = "Brady",
                            Position = "Central Operations Assistant",
                            SecondName = "Streich"
                        },
                        new
                        {
                            Id = 50,
                            FirstName = "Constance",
                            Position = "Dynamic Metrics Analyst",
                            SecondName = "Littel"
                        },
                        new
                        {
                            Id = 51,
                            FirstName = "Jonathon",
                            Position = "Legacy Program Producer",
                            SecondName = "Durgan"
                        },
                        new
                        {
                            Id = 52,
                            FirstName = "Antone",
                            Position = "Direct Functionality Associate",
                            SecondName = "Thompson"
                        },
                        new
                        {
                            Id = 53,
                            FirstName = "Maddison",
                            Position = "Chief Tactics Analyst",
                            SecondName = "Dare"
                        },
                        new
                        {
                            Id = 54,
                            FirstName = "Berry",
                            Position = "Lead Accounts Consultant",
                            SecondName = "Ziemann"
                        },
                        new
                        {
                            Id = 55,
                            FirstName = "Carolyne",
                            Position = "Internal Research Specialist",
                            SecondName = "Kohler"
                        },
                        new
                        {
                            Id = 56,
                            FirstName = "Lorine",
                            Position = "Direct Branding Representative",
                            SecondName = "Heaney"
                        },
                        new
                        {
                            Id = 57,
                            FirstName = "Arnoldo",
                            Position = "National Quality Specialist",
                            SecondName = "Becker"
                        },
                        new
                        {
                            Id = 58,
                            FirstName = "Al",
                            Position = "Forward Operations Director",
                            SecondName = "Baumbach"
                        },
                        new
                        {
                            Id = 59,
                            FirstName = "Dora",
                            Position = "National Security Facilitator",
                            SecondName = "Prohaska"
                        },
                        new
                        {
                            Id = 60,
                            FirstName = "Keagan",
                            Position = "International Web Representative",
                            SecondName = "Ullrich"
                        },
                        new
                        {
                            Id = 61,
                            FirstName = "Nathen",
                            Position = "Future Configuration Architect",
                            SecondName = "Dietrich"
                        },
                        new
                        {
                            Id = 62,
                            FirstName = "Samson",
                            Position = "Dynamic Branding Liaison",
                            SecondName = "Kemmer"
                        },
                        new
                        {
                            Id = 63,
                            FirstName = "Dexter",
                            Position = "Human Applications Manager",
                            SecondName = "McGlynn"
                        },
                        new
                        {
                            Id = 64,
                            FirstName = "Eldred",
                            Position = "Lead Web Planner",
                            SecondName = "Lynch"
                        },
                        new
                        {
                            Id = 65,
                            FirstName = "Andreanne",
                            Position = "International Identity Agent",
                            SecondName = "Koelpin"
                        },
                        new
                        {
                            Id = 66,
                            FirstName = "Sabina",
                            Position = "Senior Security Strategist",
                            SecondName = "McKenzie"
                        },
                        new
                        {
                            Id = 67,
                            FirstName = "Pedro",
                            Position = "Lead Brand Executive",
                            SecondName = "Reinger"
                        },
                        new
                        {
                            Id = 68,
                            FirstName = "Joelle",
                            Position = "Regional Optimization Administrator",
                            SecondName = "Schmidt"
                        },
                        new
                        {
                            Id = 69,
                            FirstName = "Ebony",
                            Position = "Internal Program Agent",
                            SecondName = "McKenzie"
                        },
                        new
                        {
                            Id = 70,
                            FirstName = "Jerel",
                            Position = "Customer Paradigm Manager",
                            SecondName = "Altenwerth"
                        },
                        new
                        {
                            Id = 71,
                            FirstName = "June",
                            Position = "Forward Research Engineer",
                            SecondName = "Gutmann"
                        },
                        new
                        {
                            Id = 72,
                            FirstName = "Candice",
                            Position = "Product Branding Orchestrator",
                            SecondName = "Block"
                        },
                        new
                        {
                            Id = 73,
                            FirstName = "Joelle",
                            Position = "Human Creative Representative",
                            SecondName = "Greenholt"
                        },
                        new
                        {
                            Id = 74,
                            FirstName = "Herbert",
                            Position = "Regional Directives Facilitator",
                            SecondName = "Upton"
                        },
                        new
                        {
                            Id = 75,
                            FirstName = "Leatha",
                            Position = "District Response Consultant",
                            SecondName = "Windler"
                        },
                        new
                        {
                            Id = 76,
                            FirstName = "America",
                            Position = "Principal Response Developer",
                            SecondName = "Muller"
                        },
                        new
                        {
                            Id = 77,
                            FirstName = "Ofelia",
                            Position = "Future Interactions Associate",
                            SecondName = "Schultz"
                        },
                        new
                        {
                            Id = 78,
                            FirstName = "Adrian",
                            Position = "Customer Quality Producer",
                            SecondName = "Powlowski"
                        },
                        new
                        {
                            Id = 79,
                            FirstName = "Evelyn",
                            Position = "Direct Identity Orchestrator",
                            SecondName = "Moore"
                        },
                        new
                        {
                            Id = 80,
                            FirstName = "Malika",
                            Position = "International Usability Supervisor",
                            SecondName = "Langosh"
                        },
                        new
                        {
                            Id = 81,
                            FirstName = "Murphy",
                            Position = "District Quality Associate",
                            SecondName = "Goodwin"
                        },
                        new
                        {
                            Id = 82,
                            FirstName = "Melyna",
                            Position = "Principal Communications Designer",
                            SecondName = "Rice"
                        },
                        new
                        {
                            Id = 83,
                            FirstName = "Kaela",
                            Position = "Chief Accounts Facilitator",
                            SecondName = "Koss"
                        },
                        new
                        {
                            Id = 84,
                            FirstName = "Cole",
                            Position = "Legacy Functionality Representative",
                            SecondName = "Gorczany"
                        },
                        new
                        {
                            Id = 85,
                            FirstName = "Emmett",
                            Position = "Investor Group Orchestrator",
                            SecondName = "Leannon"
                        },
                        new
                        {
                            Id = 86,
                            FirstName = "Miller",
                            Position = "Principal Factors Agent",
                            SecondName = "Hayes"
                        },
                        new
                        {
                            Id = 87,
                            FirstName = "Rollin",
                            Position = "International Accounts Associate",
                            SecondName = "Barrows"
                        },
                        new
                        {
                            Id = 88,
                            FirstName = "Sydnie",
                            Position = "Product Factors Technician",
                            SecondName = "Terry"
                        },
                        new
                        {
                            Id = 89,
                            FirstName = "Jo",
                            Position = "Direct Optimization Manager",
                            SecondName = "Bruen"
                        },
                        new
                        {
                            Id = 90,
                            FirstName = "Breanne",
                            Position = "Dynamic Program Manager",
                            SecondName = "Bayer"
                        },
                        new
                        {
                            Id = 91,
                            FirstName = "Elisha",
                            Position = "Human Response Developer",
                            SecondName = "Runolfsdottir"
                        },
                        new
                        {
                            Id = 92,
                            FirstName = "Faye",
                            Position = "Forward Functionality Producer",
                            SecondName = "Block"
                        },
                        new
                        {
                            Id = 93,
                            FirstName = "Marcelle",
                            Position = "Future Interactions Producer",
                            SecondName = "Nolan"
                        },
                        new
                        {
                            Id = 94,
                            FirstName = "Dominic",
                            Position = "Product Group Supervisor",
                            SecondName = "Breitenberg"
                        },
                        new
                        {
                            Id = 95,
                            FirstName = "Riley",
                            Position = "Internal Research Assistant",
                            SecondName = "Altenwerth"
                        },
                        new
                        {
                            Id = 96,
                            FirstName = "Bradley",
                            Position = "Legacy Research Engineer",
                            SecondName = "Muller"
                        },
                        new
                        {
                            Id = 97,
                            FirstName = "Beau",
                            Position = "Forward Program Coordinator",
                            SecondName = "Pacocha"
                        },
                        new
                        {
                            Id = 98,
                            FirstName = "Aurelia",
                            Position = "Direct Communications Facilitator",
                            SecondName = "Herman"
                        },
                        new
                        {
                            Id = 99,
                            FirstName = "Guadalupe",
                            Position = "Customer Directives Producer",
                            SecondName = "Conn"
                        },
                        new
                        {
                            Id = 100,
                            FirstName = "Emmalee",
                            Position = "Direct Group Agent",
                            SecondName = "Erdman"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
