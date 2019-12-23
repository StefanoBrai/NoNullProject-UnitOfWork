﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(NoNullProjectContext))]
    [Migration("20191211081559_addedEvaluEtiontoTrackProject")]
    partial class addedEvaluEtiontoTrackProject
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Availability", b =>
                {
                    b.Property<int>("Avaid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("avaid")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BeginningDate")
                        .HasColumnName("beginningdate")
                        .HasColumnType("datetime");

                    b.Property<int>("DestinationId")
                        .HasColumnName("destinationid")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndingDate")
                        .HasColumnName("endingdate")
                        .HasColumnType("datetime");

                    b.Property<int>("ProfId")
                        .HasColumnName("profid")
                        .HasColumnType("int");

                    b.HasKey("Avaid");

                    b.HasIndex("DestinationId");

                    b.HasIndex("ProfId");

                    b.ToTable("Availabilities","NoNull");
                });

            modelBuilder.Entity("WebApplication1.Models.Bid", b =>
                {
                    b.Property<int>("BidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("bidid")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Acceptation")
                        .HasColumnName("acceptation")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnName("message")
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<int>("ProfId")
                        .HasColumnName("profid")
                        .HasColumnType("int");

                    b.Property<int>("ReqId")
                        .HasColumnName("reqid")
                        .HasColumnType("int");

                    b.Property<DateTime>("SendData")
                        .HasColumnName("senddata")
                        .HasColumnType("datetime");

                    b.HasKey("BidId");

                    b.HasIndex("ProfId");

                    b.HasIndex("ReqId");

                    b.ToTable("Bid","NoNull");
                });

            modelBuilder.Entity("WebApplication1.Models.Candidature", b =>
                {
                    b.Property<int>("CandidatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("candidatureid")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Acceptation")
                        .HasColumnName("acceptation")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnName("message")
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<int>("ProfId")
                        .HasColumnName("profid")
                        .HasColumnType("int");

                    b.Property<int>("ReqId")
                        .HasColumnName("reqid")
                        .HasColumnType("int");

                    b.Property<DateTime>("SendData")
                        .HasColumnName("senddata")
                        .HasColumnType("datetime");

                    b.HasKey("CandidatureId");

                    b.HasIndex("ProfId");

                    b.HasIndex("ReqId");

                    b.ToTable("Candidature","NoNull");
                });

            modelBuilder.Entity("WebApplication1.Models.Company", b =>
                {
                    b.Property<int>("CompId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("compid")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("address")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnName("city")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<int>("DestinationId")
                        .HasColumnName("destinationid")
                        .HasColumnType("int");

                    b.Property<int>("GeneralareaId")
                        .HasColumnName("generalareaid")
                        .HasColumnType("int");

                    b.Property<string>("Mission")
                        .IsRequired()
                        .HasColumnName("mission")
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Postalcode")
                        .HasColumnName("postalcode")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasColumnName("region")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("CompId");

                    b.HasIndex("DestinationId");

                    b.HasIndex("GeneralareaId");

                    b.ToTable("Companies","NoNull");
                });

            modelBuilder.Entity("WebApplication1.Models.CompanyReference", b =>
                {
                    b.Property<int>("RefId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("refid")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnName("birthdate")
                        .HasColumnType("datetime");

                    b.Property<int>("CompId")
                        .HasColumnName("compid")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnName("firstname")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnName("lastname")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnName("mail")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnName("phone")
                        .HasColumnType("nvarchar(24)")
                        .HasMaxLength(24);

                    b.HasKey("RefId");

                    b.HasIndex("CompId");

                    b.ToTable("CompanyReference","NoNull");
                });

            modelBuilder.Entity("WebApplication1.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("destinationid")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MacroArea")
                        .HasColumnName("macroarea")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("DestinationId");

                    b.HasIndex("MacroArea");

                    b.ToTable("Destinations","NoNull");
                });

            modelBuilder.Entity("WebApplication1.Models.GeneralArea", b =>
                {
                    b.Property<int>("GeneralareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("generalareaid")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("GeneralareaId");

                    b.ToTable("GeneralArea","NoNull");
                });

            modelBuilder.Entity("WebApplication1.Models.Professionist", b =>
                {
                    b.Property<int>("ProfId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("profid")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("address")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnName("birthdate")
                        .HasColumnType("datetime");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnName("city")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<int>("DestinationId")
                        .HasColumnName("destinationid")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnName("firstname")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnName("lastname")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnName("mail")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("MaxAvailability")
                        .IsRequired()
                        .HasColumnName("maxavailability")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("MinAvailability")
                        .IsRequired()
                        .HasColumnName("minavailability")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnName("phone")
                        .HasColumnType("nvarchar(24)")
                        .HasMaxLength(24);

                    b.Property<string>("Postalcode")
                        .HasColumnName("postalcode")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasColumnName("profession")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Region")
                        .HasColumnName("region")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("ProfId");

                    b.HasIndex("DestinationId");

                    b.ToTable("Professionists","NoNull");
                });

            modelBuilder.Entity("WebApplication1.Models.Project", b =>
                {
                    b.Property<int>("ProjId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("projid")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompId")
                        .HasColumnName("compid")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<int>("GeneralareaId")
                        .HasColumnName("generalareaid")
                        .HasColumnType("int");

                    b.HasKey("ProjId");

                    b.HasIndex("CompId");

                    b.HasIndex("GeneralareaId");

                    b.ToTable("Projects","NoNull");
                });

            modelBuilder.Entity("WebApplication1.Models.Request", b =>
                {
                    b.Property<int>("ReqId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("reqid")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BeginningDate")
                        .HasColumnName("beginningdate")
                        .HasColumnType("datetime");

                    b.Property<int>("CompId")
                        .HasColumnName("compid")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<int>("DestinationId")
                        .HasColumnName("destinationid")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndingDate")
                        .HasColumnName("endingdate")
                        .HasColumnType("datetime");

                    b.Property<int>("ProjId")
                        .HasColumnName("projid")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnName("skillid")
                        .HasColumnType("int");

                    b.HasKey("ReqId")
                        .HasName("PK_REqeusts");

                    b.HasIndex("CompId");

                    b.HasIndex("DestinationId");

                    b.HasIndex("ProjId");

                    b.HasIndex("SkillId");

                    b.ToTable("Requests","NoNull");
                });

            modelBuilder.Entity("WebApplication1.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("skillid")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<int>("GeneralareaId")
                        .HasColumnName("generalareaid")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnName("level")
                        .HasColumnType("int");

                    b.Property<int>("ProfId")
                        .HasColumnName("profid")
                        .HasColumnType("int");

                    b.HasKey("SkillId");

                    b.HasIndex("GeneralareaId");

                    b.HasIndex("ProfId");

                    b.ToTable("Skills","NoNull");
                });

            modelBuilder.Entity("WebApplication1.Models.TrackRequest", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("trackid")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BeginningDate")
                        .HasColumnName("beginningdate")
                        .HasColumnType("datetime");

                    b.Property<int>("CompEvaluetion")
                        .HasColumnType("int");

                    b.Property<string>("Compcomment")
                        .HasColumnName("compcomment")
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<DateTime?>("EndingDate")
                        .HasColumnName("endingdate")
                        .HasColumnType("datetime");

                    b.Property<int>("ProfEValuation")
                        .HasColumnType("int");

                    b.Property<int>("ProfId")
                        .HasColumnName("profid")
                        .HasColumnType("int");

                    b.Property<string>("Profcomment")
                        .HasColumnName("profcomment")
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<int>("ReqId")
                        .HasColumnName("reqid")
                        .HasColumnType("int");

                    b.HasKey("TrackId");

                    b.HasIndex("ProfId");

                    b.HasIndex("ReqId");

                    b.ToTable("TrackRequests","NoNull");
                });

            modelBuilder.Entity("WebApplication1.Models.Availability", b =>
                {
                    b.HasOne("WebApplication1.Models.Destination", "Destination")
                        .WithMany("Availabilities")
                        .HasForeignKey("DestinationId")
                        .HasConstraintName("FK_Availabilities_Destinations")
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Professionist", "Prof")
                        .WithMany("Availabilities")
                        .HasForeignKey("ProfId")
                        .HasConstraintName("FK_Ava_Prof")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Bid", b =>
                {
                    b.HasOne("WebApplication1.Models.Professionist", "Prof")
                        .WithMany("Bid")
                        .HasForeignKey("ProfId")
                        .HasConstraintName("FK_Bid_Prof")
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Request", "Req")
                        .WithMany("Bid")
                        .HasForeignKey("ReqId")
                        .HasConstraintName("FK_Bid_Req")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Candidature", b =>
                {
                    b.HasOne("WebApplication1.Models.Professionist", "Prof")
                        .WithMany("Candidature")
                        .HasForeignKey("ProfId")
                        .HasConstraintName("FK_Candidature_Prof")
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Request", "Req")
                        .WithMany("Candidature")
                        .HasForeignKey("ReqId")
                        .HasConstraintName("FK_Candidature_Req")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Company", b =>
                {
                    b.HasOne("WebApplication1.Models.Destination", "Destination")
                        .WithMany("Companies")
                        .HasForeignKey("DestinationId")
                        .HasConstraintName("FK_Company_Destinations")
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.GeneralArea", "Generalarea")
                        .WithMany("Companies")
                        .HasForeignKey("GeneralareaId")
                        .HasConstraintName("FK_Company_GeneralArea")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.CompanyReference", b =>
                {
                    b.HasOne("WebApplication1.Models.Company", "Comp")
                        .WithMany("CompanyReference")
                        .HasForeignKey("CompId")
                        .HasConstraintName("FK_Ref_Comp")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Destination", b =>
                {
                    b.HasOne("WebApplication1.Models.Destination", "MacroareaNavigation")
                        .WithMany("InverseMacroareaNavigation")
                        .HasForeignKey("MacroArea")
                        .HasConstraintName("FK_Dest_Dest");
                });

            modelBuilder.Entity("WebApplication1.Models.Professionist", b =>
                {
                    b.HasOne("WebApplication1.Models.Destination", "Destination")
                        .WithMany("Professionists")
                        .HasForeignKey("DestinationId")
                        .HasConstraintName("FK_Prof_Destinations")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Project", b =>
                {
                    b.HasOne("WebApplication1.Models.Company", "Comp")
                        .WithMany("Projects")
                        .HasForeignKey("CompId")
                        .HasConstraintName("FK_Proj_Comp")
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.GeneralArea", "Generalarea")
                        .WithMany("Projects")
                        .HasForeignKey("GeneralareaId")
                        .HasConstraintName("FK_Proj_GeneralArea")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Request", b =>
                {
                    b.HasOne("WebApplication1.Models.Company", "Comp")
                        .WithMany("Requests")
                        .HasForeignKey("CompId")
                        .HasConstraintName("FK_Req_Comp")
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Destination", "Destination")
                        .WithMany("Requests")
                        .HasForeignKey("DestinationId")
                        .HasConstraintName("FK_Req_Destinations")
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Project", "Proj")
                        .WithMany("Requests")
                        .HasForeignKey("ProjId")
                        .HasConstraintName("FK_Req_Proj")
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Skill", "Skill")
                        .WithMany("Requests")
                        .HasForeignKey("SkillId")
                        .HasConstraintName("FK_Req_Skill")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Skill", b =>
                {
                    b.HasOne("WebApplication1.Models.GeneralArea", "Generalarea")
                        .WithMany("Skills")
                        .HasForeignKey("GeneralareaId")
                        .HasConstraintName("FK_Skills_GeneralArea")
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Professionist", "Prof")
                        .WithMany("Skills")
                        .HasForeignKey("ProfId")
                        .HasConstraintName("FK_Skills_Profs")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.TrackRequest", b =>
                {
                    b.HasOne("WebApplication1.Models.Professionist", "Prof")
                        .WithMany("TrackRequests")
                        .HasForeignKey("ProfId")
                        .HasConstraintName("FK_Track_Prof")
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Request", "Req")
                        .WithMany("TrackRequests")
                        .HasForeignKey("ReqId")
                        .HasConstraintName("FK_Track_Req")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
