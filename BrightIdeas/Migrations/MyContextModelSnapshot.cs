﻿// <auto-generated />
using System;
using BrightIdeas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BrightIdeas.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BrightIdeas.Models.Idea", b =>
                {
                    b.Property<int>("IdeasId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.Property<string>("UserIdea")
                        .IsRequired();

                    b.HasKey("IdeasId");

                    b.HasIndex("UserId");

                    b.ToTable("Ideas");
                });

            modelBuilder.Entity("BrightIdeas.Models.Like", b =>
                {
                    b.Property<int>("LikeId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("IdeaId");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("LikeId");

                    b.HasIndex("IdeaId");

                    b.HasIndex("UserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("BrightIdeas.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("UserAlias")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BrightIdeas.Models.Idea", b =>
                {
                    b.HasOne("BrightIdeas.Models.User", "Blogger")
                        .WithMany("UserIdeas")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BrightIdeas.Models.Like", b =>
                {
                    b.HasOne("BrightIdeas.Models.Idea", "Idea")
                        .WithMany("LikedBy")
                        .HasForeignKey("IdeaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BrightIdeas.Models.User", "User")
                        .WithMany("UserLikes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
