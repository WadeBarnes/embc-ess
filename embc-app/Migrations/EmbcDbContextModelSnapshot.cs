﻿// <auto-generated />
using System;
using Gov.Jag.Embc.Public.DataInterfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gov.Jag.Embc.Public.Migrations
{
    [DbContext(typeof(EmbcDbContext))]
    partial class EmbcDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:.ESSFileNumbers", "'ESSFileNumbers', '', '100000', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.seq_ReferralIds", "'seq_ReferralIds', '', '1000001', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.Community", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("RegionName")
                        .IsRequired();

                    b.Property<DateTime>("UpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("UpdatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("RegionName");

                    b.ToTable("Communities");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.Country", b =>
                {
                    b.Property<string>("CountryCode")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("UpdatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.HasKey("CountryCode");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.Evacuee", b =>
                {
                    b.Property<long>("RegistrationId");

                    b.Property<int>("EvacueeSequenceNumber");

                    b.Property<string>("BcServicesNumber");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<DateTime?>("Dob");

                    b.Property<string>("EvacueeTypeCode");

                    b.Property<string>("FirstName")
                        .HasMaxLength(255);

                    b.Property<string>("Gender")
                        .HasMaxLength(255);

                    b.Property<string>("Initials")
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .HasMaxLength(255);

                    b.Property<string>("Nickname")
                        .HasMaxLength(255);

                    b.Property<bool>("SameLastNameAsEvacuee");

                    b.Property<DateTime>("UpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("UpdatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.HasKey("RegistrationId", "EvacueeSequenceNumber");

                    b.ToTable("Evacuees");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.EvacueeRegistration", b =>
                {
                    b.Property<long>("EssFileNumber")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEXT VALUE FOR ESSFileNumbers");

                    b.Property<bool>("Active");

                    b.Property<string>("CompletedById")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<bool?>("DeclarationAndConsent");

                    b.Property<bool?>("DietaryNeeds");

                    b.Property<string>("DietaryNeedsDetails");

                    b.Property<string>("DisasterAffectDetails");

                    b.Property<string>("Email");

                    b.Property<string>("ExternalReferralsDetails");

                    b.Property<string>("Facility");

                    b.Property<string>("FamilyRecoveryPlan");

                    b.Property<string>("FollowUpDetails");

                    b.Property<bool?>("HasChildCareReferral");

                    b.Property<bool?>("HasFirstAidReferral");

                    b.Property<bool?>("HasHealthServicesReferral");

                    b.Property<bool?>("HasInquiryReferral");

                    b.Property<bool?>("HasPersonalServicesReferral");

                    b.Property<bool?>("HasPetCareReferral");

                    b.Property<bool?>("HasPets");

                    b.Property<bool?>("HasThreeDayMedicationSupply");

                    b.Property<Guid?>("HostCommunityId");

                    b.Property<Guid?>("IncidentTaskId");

                    b.Property<string>("InsuranceCode");

                    b.Property<bool?>("MedicationNeeds");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("PhoneNumberAlt");

                    b.Property<string>("RegisteringFamilyMembers");

                    b.Property<DateTime?>("RegistrationCompletionDate");

                    b.Property<bool?>("RequiresAccommodation");

                    b.Property<bool?>("RequiresClothing");

                    b.Property<bool?>("RequiresFood");

                    b.Property<bool?>("RequiresIncidentals");

                    b.Property<bool?>("RequiresSupport");

                    b.Property<bool?>("RequiresTransportation");

                    b.Property<bool?>("RestrictedAccess");

                    b.Property<DateTime?>("SelfRegisteredDate");

                    b.Property<DateTime>("UpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("UpdatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.HasKey("EssFileNumber");

                    b.HasIndex("HostCommunityId");

                    b.HasIndex("IncidentTaskId");

                    b.ToTable("EvacueeRegistrations");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.EvacueeRegistrationAddress", b =>
                {
                    b.Property<long>("RegistrationId");

                    b.Property<int>("AddressSequenceNumber");

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("AddressLine3");

                    b.Property<string>("AddressSubtypeCode");

                    b.Property<string>("AddressTypeCode");

                    b.Property<string>("City");

                    b.Property<Guid?>("CommunityId");

                    b.Property<string>("CountryCode");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Province");

                    b.Property<DateTime>("UpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("UpdatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.HasKey("RegistrationId", "AddressSequenceNumber");

                    b.HasIndex("CommunityId");

                    b.HasIndex("CountryCode");

                    b.ToTable("EvacueeRegistrationAddresses");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.FamilyRelationshipType", b =>
                {
                    b.Property<string>("Code");

                    b.Property<bool>("Active");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.HasKey("Code");

                    b.ToTable("FamilyRelationshipTypes");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.IncidentTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<Guid?>("CommunityId");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("Details");

                    b.Property<string>("RegionName");

                    b.Property<DateTimeOffset?>("StartDate");

                    b.Property<string>("TaskNumber");

                    b.Property<DateTime>("UpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("UpdatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CommunityId");

                    b.HasIndex("RegionName");

                    b.ToTable("IncidentTasks");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.Organization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("BCeIDBusinessGuid")
                        .HasColumnName("BceidAccountNumber")
                        .HasMaxLength(100);

                    b.Property<Guid?>("CommunityId");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("RegionName");

                    b.Property<DateTime>("UpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("UpdatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CommunityId");

                    b.HasIndex("RegionName");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.Referral", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEXT VALUE FOR seq_ReferralIds");

                    b.Property<bool>("Active");

                    b.Property<string>("Comments");

                    b.Property<bool>("ConfirmChecked");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("Purchaser")
                        .HasMaxLength(255);

                    b.Property<long>("RegistrationId");

                    b.Property<int>("SupplierId");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("UpdatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset>("ValidFrom");

                    b.Property<DateTimeOffset>("ValidTo");

                    b.HasKey("Id");

                    b.HasIndex("RegistrationId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Referrals");

                    b.HasDiscriminator<string>("Type").HasValue("Referral");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.ReferralEvacuee", b =>
                {
                    b.Property<long>("RegistrationId");

                    b.Property<int>("EvacueeId");

                    b.Property<long>("ReferralId");

                    b.HasKey("RegistrationId", "EvacueeId", "ReferralId");

                    b.HasIndex("ReferralId");

                    b.ToTable("ReferralEvacuees");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.Region", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255);

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<DateTime>("UpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("UpdatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.HasKey("Name");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Address")
                        .HasMaxLength(255);

                    b.Property<string>("City")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("Fax")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(50);

                    b.Property<string>("Province")
                        .HasMaxLength(50);

                    b.Property<string>("Telephone")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("UpdatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.Volunteer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("BceidAccountUserName");

                    b.Property<bool?>("CanAccessRestrictedFiles");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("Email")
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .HasMaxLength(255);

                    b.Property<bool?>("IsAdministrator");

                    b.Property<bool?>("IsNewUser");

                    b.Property<bool?>("IsPrimaryContact");

                    b.Property<string>("LastName")
                        .HasMaxLength(255);

                    b.Property<Guid?>("OrganizationId");

                    b.Property<DateTime>("UpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("UpdatedByUserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("'System'")
                        .HasMaxLength(255);

                    b.Property<string>("UserId")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Volunteers");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.BilletingLodgingReferral", b =>
                {
                    b.HasBaseType("Gov.Jag.Embc.Public.Models.Db.Referral");

                    b.Property<int>("NumberOfNights");

                    b.ToTable("BilletingLodgingReferral");

                    b.HasDiscriminator().HasValue("Lodging_Billeting");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.ClothingReferral", b =>
                {
                    b.HasBaseType("Gov.Jag.Embc.Public.Models.Db.Referral");

                    b.Property<bool>("ExtremeWinterConditions");

                    b.ToTable("ClothingReferral");

                    b.HasDiscriminator().HasValue("Clothing");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.GroceriesFoodReferral", b =>
                {
                    b.HasBaseType("Gov.Jag.Embc.Public.Models.Db.Referral");

                    b.Property<int>("NumberOfMeals");

                    b.ToTable("GroceriesFoodReferral");

                    b.HasDiscriminator().HasValue("Food_Groceries");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.GroupLodgingReferral", b =>
                {
                    b.HasBaseType("Gov.Jag.Embc.Public.Models.Db.Referral");

                    b.Property<int>("NumberOfNights")
                        .HasColumnName("GroupLodgingReferral_NumberOfNights");

                    b.ToTable("GroupLodgingReferral");

                    b.HasDiscriminator().HasValue("Lodging_Group");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.HotelLodgingReferral", b =>
                {
                    b.HasBaseType("Gov.Jag.Embc.Public.Models.Db.Referral");

                    b.Property<int>("NumberOfNights")
                        .HasColumnName("HotelLodgingReferral_NumberOfNights");

                    b.Property<int>("NumberOfRooms");

                    b.ToTable("HotelLodgingReferral");

                    b.HasDiscriminator().HasValue("Lodging_Hotel");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.IncidentalsReferral", b =>
                {
                    b.HasBaseType("Gov.Jag.Embc.Public.Models.Db.Referral");

                    b.Property<string>("ApprovedItems");

                    b.ToTable("IncidentalsReferral");

                    b.HasDiscriminator().HasValue("Incidentals");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.OtherTransportationReferral", b =>
                {
                    b.HasBaseType("Gov.Jag.Embc.Public.Models.Db.Referral");

                    b.Property<string>("TransportMode")
                        .HasMaxLength(255);

                    b.ToTable("OtherTransportationReferral");

                    b.HasDiscriminator().HasValue("Transportation_Other");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.RestaurantFoodReferral", b =>
                {
                    b.HasBaseType("Gov.Jag.Embc.Public.Models.Db.Referral");

                    b.Property<int>("NumberOfBreakfasts");

                    b.Property<int>("NumberOfDinners");

                    b.Property<int>("NumberOfLunches");

                    b.ToTable("RestaurantFoodReferral");

                    b.HasDiscriminator().HasValue("Food_Restaurant");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.TaxiTransportationReferral", b =>
                {
                    b.HasBaseType("Gov.Jag.Embc.Public.Models.Db.Referral");

                    b.Property<string>("FromAddress")
                        .HasMaxLength(255);

                    b.Property<string>("ToAddress")
                        .HasMaxLength(255);

                    b.ToTable("TaxiTransportationReferral");

                    b.HasDiscriminator().HasValue("Transportation_Taxi");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.Community", b =>
                {
                    b.HasOne("Gov.Jag.Embc.Public.Models.Db.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionName")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.Evacuee", b =>
                {
                    b.HasOne("Gov.Jag.Embc.Public.Models.Db.EvacueeRegistration", "EvacueeRegistration")
                        .WithMany("Evacuees")
                        .HasForeignKey("RegistrationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.EvacueeRegistration", b =>
                {
                    b.HasOne("Gov.Jag.Embc.Public.Models.Db.Community", "HostCommunity")
                        .WithMany()
                        .HasForeignKey("HostCommunityId");

                    b.HasOne("Gov.Jag.Embc.Public.Models.Db.IncidentTask", "IncidentTask")
                        .WithMany("EvacueeRegistrations")
                        .HasForeignKey("IncidentTaskId");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.EvacueeRegistrationAddress", b =>
                {
                    b.HasOne("Gov.Jag.Embc.Public.Models.Db.Community", "Community")
                        .WithMany()
                        .HasForeignKey("CommunityId");

                    b.HasOne("Gov.Jag.Embc.Public.Models.Db.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryCode");

                    b.HasOne("Gov.Jag.Embc.Public.Models.Db.EvacueeRegistration", "EvacueeRegistration")
                        .WithMany("EvacueeRegistrationAddresses")
                        .HasForeignKey("RegistrationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.IncidentTask", b =>
                {
                    b.HasOne("Gov.Jag.Embc.Public.Models.Db.Community", "Community")
                        .WithMany()
                        .HasForeignKey("CommunityId");

                    b.HasOne("Gov.Jag.Embc.Public.Models.Db.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionName");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.Organization", b =>
                {
                    b.HasOne("Gov.Jag.Embc.Public.Models.Db.Community", "Community")
                        .WithMany("Organizations")
                        .HasForeignKey("CommunityId");

                    b.HasOne("Gov.Jag.Embc.Public.Models.Db.Region", "Region")
                        .WithMany("Organizations")
                        .HasForeignKey("RegionName");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.Referral", b =>
                {
                    b.HasOne("Gov.Jag.Embc.Public.Models.Db.EvacueeRegistration", "Registration")
                        .WithMany()
                        .HasForeignKey("RegistrationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Gov.Jag.Embc.Public.Models.Db.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.ReferralEvacuee", b =>
                {
                    b.HasOne("Gov.Jag.Embc.Public.Models.Db.Referral", "Referral")
                        .WithMany("Evacuees")
                        .HasForeignKey("ReferralId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Gov.Jag.Embc.Public.Models.Db.Evacuee", "Evacuee")
                        .WithMany("Referrals")
                        .HasForeignKey("RegistrationId", "EvacueeId");
                });

            modelBuilder.Entity("Gov.Jag.Embc.Public.Models.Db.Volunteer", b =>
                {
                    b.HasOne("Gov.Jag.Embc.Public.Models.Db.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId");
                });
#pragma warning restore 612, 618
        }
    }
}
