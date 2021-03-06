// <auto-generated />
using HCompensation.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HCompensation.Migrations
{
    [DbContext(typeof(HCompensationContext))]
    partial class HCompensationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("HCompensation.Models.CarOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<string>("OwnershipUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("PurchaseUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CarOwners");
                });

            modelBuilder.Entity("HCompensation.Models.FuelStation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BusinessName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastSupplyDetails")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("TicketUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FuelStations");
                });
#pragma warning restore 612, 618
        }
    }
}
