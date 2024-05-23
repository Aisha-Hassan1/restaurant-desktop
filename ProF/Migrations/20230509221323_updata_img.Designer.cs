﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProF.Data;

#nullable disable

namespace ProF.Migrations
{
    [DbContext(typeof(ApplicationDBcontext))]
    [Migration("20230509221323_updata_img")]
    partial class updata_img
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OrderPayment", b =>
                {
                    b.Property<int>("Ordersorder_num")
                        .HasColumnType("int");

                    b.Property<int>("PaymentsPayment_Id")
                        .HasColumnType("int");

                    b.HasKey("Ordersorder_num", "PaymentsPayment_Id");

                    b.HasIndex("PaymentsPayment_Id");

                    b.ToTable("OrderPayment");
                });

            modelBuilder.Entity("ProF.Models.Category", b =>
                {
                    b.Property<int>("Cate_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cate_Id"));

                    b.Property<string>("Cate_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cate_Id");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("ProF.Models.Order", b =>
                {
                    b.Property<int>("order_num")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("order_num"));

                    b.Property<string>("Order_DateTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity_of_each_recipe")
                        .HasColumnType("int");

                    b.Property<string>("Recipes_Num")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Register_id")
                        .HasColumnType("int");

                    b.Property<int>("Registeration_USER_Register_id")
                        .HasColumnType("int");

                    b.HasKey("order_num");

                    b.HasIndex("Registeration_USER_Register_id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ProF.Models.Payment", b =>
                {
                    b.Property<int>("Payment_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Payment_Id"));

                    b.Property<int>("Total_payment")
                        .HasColumnType("int");

                    b.Property<int>("order_num")
                        .HasColumnType("int");

                    b.Property<string>("type_Payment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Payment_Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("ProF.Models.Recipe", b =>
                {
                    b.Property<int>("Recipe_num")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Recipe_num"));

                    b.Property<int>("CategoryCate_Id")
                        .HasColumnType("int");

                    b.Property<string>("Evaluation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Recip_Cost")
                        .HasColumnType("real");

                    b.Property<string>("Recipe_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Recipe_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Recipe_image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SearchId")
                        .HasColumnType("int");

                    b.Property<int>("order_num")
                        .HasColumnType("int");

                    b.HasKey("Recipe_num");

                    b.HasIndex("CategoryCate_Id");

                    b.HasIndex("SearchId");

                    b.HasIndex("order_num");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("ProF.Models.Registeration_USER_", b =>
                {
                    b.Property<int>("Register_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Register_id"));

                    b.Property<DateTime>("Register_DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("table_num")
                        .HasColumnType("int");

                    b.HasKey("Register_id");

                    b.ToTable("Registeration_USER_s");
                });

            modelBuilder.Entity("ProF.Models.Search", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Recipe_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Recipe_num")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Searches");
                });

            modelBuilder.Entity("ProF.Models.Table", b =>
                {
                    b.Property<int>("tatable_num")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("tatable_num"));

                    b.HasKey("tatable_num");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("ProF.Models.item", b =>
                {
                    b.Property<int>("item_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("item_id"));

                    b.Property<int>("adminID")
                        .HasColumnType("int");

                    b.Property<float>("item_Cost")
                        .HasColumnType("real");

                    b.Property<string>("item_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("item_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("item_image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("item_id");

                    b.HasIndex("adminID");

                    b.ToTable("items");
                });

            modelBuilder.Entity("ProF.Models.login_admin", b =>
                {
                    b.Property<int>("admin_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("admin_id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passward")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("admin_id");

                    b.ToTable("login_admins");
                });

            modelBuilder.Entity("Registeration_USER_Table", b =>
                {
                    b.Property<int>("Registeration_USER_sRegister_id")
                        .HasColumnType("int");

                    b.Property<int>("Tablestatable_num")
                        .HasColumnType("int");

                    b.HasKey("Registeration_USER_sRegister_id", "Tablestatable_num");

                    b.HasIndex("Tablestatable_num");

                    b.ToTable("Registeration_USER_Table");
                });

            modelBuilder.Entity("OrderPayment", b =>
                {
                    b.HasOne("ProF.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("Ordersorder_num")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProF.Models.Payment", null)
                        .WithMany()
                        .HasForeignKey("PaymentsPayment_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProF.Models.Order", b =>
                {
                    b.HasOne("ProF.Models.Registeration_USER_", "Registeration_USER_")
                        .WithMany("Orders")
                        .HasForeignKey("Registeration_USER_Register_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registeration_USER_");
                });

            modelBuilder.Entity("ProF.Models.Recipe", b =>
                {
                    b.HasOne("ProF.Models.Category", "Category")
                        .WithMany("Recipes")
                        .HasForeignKey("CategoryCate_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProF.Models.Search", "Search")
                        .WithMany("Recipes")
                        .HasForeignKey("SearchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProF.Models.Order", "Order")
                        .WithMany("Recipes")
                        .HasForeignKey("order_num")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Order");

                    b.Navigation("Search");
                });

            modelBuilder.Entity("ProF.Models.item", b =>
                {
                    b.HasOne("ProF.Models.login_admin", "login_admin")
                        .WithMany("Items")
                        .HasForeignKey("adminID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("login_admin");
                });

            modelBuilder.Entity("Registeration_USER_Table", b =>
                {
                    b.HasOne("ProF.Models.Registeration_USER_", null)
                        .WithMany()
                        .HasForeignKey("Registeration_USER_sRegister_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProF.Models.Table", null)
                        .WithMany()
                        .HasForeignKey("Tablestatable_num")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProF.Models.Category", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("ProF.Models.Order", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("ProF.Models.Registeration_USER_", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ProF.Models.Search", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("ProF.Models.login_admin", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
