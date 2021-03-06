// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_rpg.Data;

namespace dotnet_rpg_31.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("dotnet_rpg.Model.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Damage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Damage = 30,
                            Name = "FireBall"
                        },
                        new
                        {
                            Id = 2,
                            Damage = 20,
                            Name = "Frenzy"
                        },
                        new
                        {
                            Id = 3,
                            Damage = 50,
                            Name = "Blizzard"
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue("Player");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PasswordHash = new byte[] { 218, 37, 140, 137, 141, 77, 201, 160, 141, 161, 36, 71, 70, 54, 181, 111, 90, 4, 166, 60, 180, 175, 96, 173, 229, 198, 128, 47, 236, 174, 54, 88 },
                            PasswordSalt = new byte[] { 211, 93, 226, 125, 253, 103, 45, 13, 202, 119, 35, 103, 2, 48, 62, 109, 100, 19, 56, 91, 123, 106, 253, 52, 105, 228, 139, 51, 245, 175, 89, 247, 42, 228, 148, 72, 189, 19, 71, 33, 238, 179, 250, 127, 51, 6, 210, 60, 111, 206, 137, 213, 206, 99, 215, 129, 165, 230, 55, 199, 208, 202, 124, 139 },
                            Username = "User1"
                        },
                        new
                        {
                            Id = 2,
                            PasswordHash = new byte[] { 218, 37, 140, 137, 141, 77, 201, 160, 141, 161, 36, 71, 70, 54, 181, 111, 90, 4, 166, 60, 180, 175, 96, 173, 229, 198, 128, 47, 236, 174, 54, 88 },
                            PasswordSalt = new byte[] { 211, 93, 226, 125, 253, 103, 45, 13, 202, 119, 35, 103, 2, 48, 62, 109, 100, 19, 56, 91, 123, 106, 253, 52, 105, 228, 139, 51, 245, 175, 89, 247, 42, 228, 148, 72, 189, 19, 71, 33, 238, 179, 250, 127, 51, 6, 210, 60, 111, 206, 137, 213, 206, 99, 215, 129, 165, 230, 55, 199, 208, 202, 124, 139 },
                            Username = "User2"
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Model.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Damage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Weapons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CharacterId = 1,
                            Damage = 20,
                            Name = "The Master Sword"
                        },
                        new
                        {
                            Id = 2,
                            CharacterId = 2,
                            Damage = 5,
                            Name = "Crystal Wand"
                        });
                });

            modelBuilder.Entity("dotnet_rpg_31.Model.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Class")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defeats")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defense")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fights")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HitPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Intelligence")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Strength")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Victories")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Class = 0,
                            Defeats = 0,
                            Defense = 10,
                            Fights = 0,
                            HitPoints = 100,
                            Intelligence = 10,
                            Name = "Aragorn",
                            Strength = 15,
                            UserId = 1,
                            Victories = 0
                        },
                        new
                        {
                            Id = 2,
                            Class = 1,
                            Defeats = 0,
                            Defense = 5,
                            Fights = 0,
                            HitPoints = 100,
                            Intelligence = 20,
                            Name = "Gandalf",
                            Strength = 5,
                            UserId = 2,
                            Victories = 0
                        });
                });

            modelBuilder.Entity("dotnet_rpg_31.Model.CharacterSkill", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SkillId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CharacterId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("CharacterSkills");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            SkillId = 2
                        },
                        new
                        {
                            CharacterId = 2,
                            SkillId = 1
                        },
                        new
                        {
                            CharacterId = 2,
                            SkillId = 3
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Model.Weapon", b =>
                {
                    b.HasOne("dotnet_rpg_31.Model.Character", "Character")
                        .WithOne("Weapon")
                        .HasForeignKey("dotnet_rpg.Model.Weapon", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dotnet_rpg_31.Model.Character", b =>
                {
                    b.HasOne("dotnet_rpg.Model.User", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dotnet_rpg_31.Model.CharacterSkill", b =>
                {
                    b.HasOne("dotnet_rpg_31.Model.Character", "Character")
                        .WithMany("CharacterSkills")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotnet_rpg.Model.Skill", "Skill")
                        .WithMany("CharacterSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
