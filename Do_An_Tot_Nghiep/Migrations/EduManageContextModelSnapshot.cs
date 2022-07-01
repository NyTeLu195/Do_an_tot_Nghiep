﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Do_An_Tot_Nghiep.Migrations
{
    [DbContext(typeof(EduManageContext))]
    partial class EduManageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.AssignmentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClassroomEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassroomID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Day")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TeacherEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeacherID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserCreataID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserUpdateID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ClassroomEntityId");

                    b.HasIndex("TeacherEntityId");

                    b.ToTable("AssignmentEntity");
                });

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.AttendanceEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("History")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StudentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("StudentsEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserCreataID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserUpdateID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentsEntityId");

                    b.ToTable("AttendanceEntity");
                });

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.ClassroomEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TeacherEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TeacherID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TotalNumberStudent")
                        .HasColumnType("int");

                    b.Property<Guid>("UserCreataID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserUpdateID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherEntityId");

                    b.ToTable("ClassroomEntity");
                });

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.RegisterDetailEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AssignmentEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssignmentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<Guid?>("RegisterEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RegisterID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Scores")
                        .HasColumnType("real");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserCreataID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserUpdateID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentEntityId");

                    b.HasIndex("RegisterEntityId");

                    b.ToTable("RegisterDetailEntity");
                });

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.RegisterEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassRoomID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClassroomEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserCreataID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserUpdateID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ClassroomEntityId");

                    b.ToTable("RegisterEntity");
                });

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.StudentsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FisrtName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Process")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserCreataID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserUpdateID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("StudentsEntity");
                });

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.TeacherEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FisrtName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserCreataID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserUpdateID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("TeacherEntity");
                });

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.ViolationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PenaltyPoint")
                        .HasColumnType("int");

                    b.Property<string>("Score")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserCreataID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserUpdateID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("ViolationEntity");
                });

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.ViolationHistoryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("History")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StudentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("StudentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserCreataID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserUpdateID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentsId");

                    b.ToTable("ViolationHistoryEntity");
                });

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.AssignmentEntity", b =>
                {
                    b.HasOne("Do_An_Tot_Nghiep.Entity.ClassroomEntity", "ClassroomEntity")
                        .WithMany("AssignmentEntitys")
                        .HasForeignKey("ClassroomEntityId");

                    b.HasOne("Do_An_Tot_Nghiep.Entity.TeacherEntity", "TeacherEntity")
                        .WithMany("Assignments")
                        .HasForeignKey("TeacherEntityId");

                    b.Navigation("ClassroomEntity");

                    b.Navigation("TeacherEntity");
                });

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.AttendanceEntity", b =>
                {
                    b.HasOne("Do_An_Tot_Nghiep.Entity.StudentsEntity", "StudentsEntity")
                        .WithMany("AttendanceEntitys")
                        .HasForeignKey("StudentsEntityId");

                    b.Navigation("StudentsEntity");
                });

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.ClassroomEntity", b =>
                {
                    b.HasOne("Do_An_Tot_Nghiep.Entity.TeacherEntity", "TeacherEntity")
                        .WithMany("Classrooms")
                        .HasForeignKey("TeacherEntityId");

                    b.Navigation("TeacherEntity");
                });

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.RegisterDetailEntity", b =>
                {
                    b.HasOne("Do_An_Tot_Nghiep.Entity.AssignmentEntity", "AssignmentEntity")
                        .WithMany()
                        .HasForeignKey("AssignmentEntityId");

                    b.HasOne("Do_An_Tot_Nghiep.Entity.RegisterEntity", "RegisterEntity")
                        .WithMany()
                        .HasForeignKey("RegisterEntityId");

                    b.Navigation("AssignmentEntity");

                    b.Navigation("RegisterEntity");
                });

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.RegisterEntity", b =>
                {
                    b.HasOne("Do_An_Tot_Nghiep.Entity.ClassroomEntity", "ClassroomEntity")
                        .WithMany("RegisterEntitys")
                        .HasForeignKey("ClassroomEntityId");

                    b.Navigation("ClassroomEntity");
                });

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.ViolationHistoryEntity", b =>
                {
                    b.HasOne("Do_An_Tot_Nghiep.Entity.StudentsEntity", "Students")
                        .WithMany("ViolationHistoryEntitys")
                        .HasForeignKey("StudentsId");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.ClassroomEntity", b =>
                {
                    b.Navigation("AssignmentEntitys");

                    b.Navigation("RegisterEntitys");
                });

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.StudentsEntity", b =>
                {
                    b.Navigation("AttendanceEntitys");

                    b.Navigation("ViolationHistoryEntitys");
                });

            modelBuilder.Entity("Do_An_Tot_Nghiep.Entity.TeacherEntity", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("Classrooms");
                });
#pragma warning restore 612, 618
        }
    }
}
