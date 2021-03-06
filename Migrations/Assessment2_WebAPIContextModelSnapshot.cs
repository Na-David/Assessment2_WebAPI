// <auto-generated />
using System;
using Assessment2_WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assessment2_WebAPI.Migrations
{
    [DbContext(typeof(Assessment2_WebAPIContext))]
    partial class Assessment2_WebAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assessment2_WebAPI.Models.Customer_User", b =>
                {
                    b.Property<string>("Cust_Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Cust_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cust_Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cust_Fname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cust_Lname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cust_Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cust_Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cust_Username");

                    b.ToTable("Customer_User");
                });

            modelBuilder.Entity("Assessment2_WebAPI.Models.Rent_Agent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Agent_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Agent_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Agent_Office")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Agent_Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rent_Agent");
                });

            modelBuilder.Entity("Assessment2_WebAPI.Models.Rent_Details", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Rent_AgentId")
                        .HasColumnType("int");

                    b.Property<int?>("Rent_HousesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Rent_AgentId");

                    b.HasIndex("Rent_HousesId");

                    b.ToTable("Rent_Details");
                });

            modelBuilder.Entity("Assessment2_WebAPI.Models.Rent_Houses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("House_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("House_Bathroom")
                        .HasColumnType("int");

                    b.Property<int>("House_Bedroom")
                        .HasColumnType("int");

                    b.Property<string>("House_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("House_WeeklyRent")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Rent_Houses");
                });

            modelBuilder.Entity("Assessment2_WebAPI.Models.Rent_Details", b =>
                {
                    b.HasOne("Assessment2_WebAPI.Models.Rent_Agent", "Rent_Agent")
                        .WithMany()
                        .HasForeignKey("Rent_AgentId");

                    b.HasOne("Assessment2_WebAPI.Models.Rent_Houses", "Rent_Houses")
                        .WithMany()
                        .HasForeignKey("Rent_HousesId");

                    b.Navigation("Rent_Agent");

                    b.Navigation("Rent_Houses");
                });
#pragma warning restore 612, 618
        }
    }
}
