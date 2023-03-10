// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using server.Data;

#nullable disable

namespace server.Migrations
{
    [DbContext(typeof(BudgetDbContext))]
    partial class BudgetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("server.Models.Budget", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Budgets");
                });

            modelBuilder.Entity("server.Models.Expense", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<Guid?>("BudgetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ExpenseCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BudgetId");

                    b.HasIndex("ExpenseCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("server.Models.ExpenseCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ExpenseCategories");
                });

            modelBuilder.Entity("server.Models.Income", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<Guid?>("BudgetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("IncomeCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BudgetId");

                    b.HasIndex("IncomeCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("server.Models.IncomeCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("IncomeCategories");
                });

            modelBuilder.Entity("server.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("server.Models.Budget", b =>
                {
                    b.HasOne("server.Models.User", "User")
                        .WithMany("BudgetsCollection")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("server.Models.Expense", b =>
                {
                    b.HasOne("server.Models.Budget", "Budget")
                        .WithMany("ExpensesCollection")
                        .HasForeignKey("BudgetId");

                    b.HasOne("server.Models.ExpenseCategory", "ExpenseCategory")
                        .WithMany("ExpensesCollection")
                        .HasForeignKey("ExpenseCategoryId");

                    b.HasOne("server.Models.User", "User")
                        .WithMany("ExpensesCollection")
                        .HasForeignKey("UserId");

                    b.Navigation("Budget");

                    b.Navigation("ExpenseCategory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("server.Models.ExpenseCategory", b =>
                {
                    b.HasOne("server.Models.User", "User")
                        .WithMany("ExpenseCategories")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("server.Models.Income", b =>
                {
                    b.HasOne("server.Models.Budget", "Budget")
                        .WithMany("IncomesCollection")
                        .HasForeignKey("BudgetId");

                    b.HasOne("server.Models.IncomeCategory", "IncomeCategory")
                        .WithMany("IncomesCollection")
                        .HasForeignKey("IncomeCategoryId");

                    b.HasOne("server.Models.User", "User")
                        .WithMany("IncomesCollection")
                        .HasForeignKey("UserId");

                    b.Navigation("Budget");

                    b.Navigation("IncomeCategory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("server.Models.IncomeCategory", b =>
                {
                    b.HasOne("server.Models.User", "User")
                        .WithMany("IncomeCategories")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("server.Models.Budget", b =>
                {
                    b.Navigation("ExpensesCollection");

                    b.Navigation("IncomesCollection");
                });

            modelBuilder.Entity("server.Models.ExpenseCategory", b =>
                {
                    b.Navigation("ExpensesCollection");
                });

            modelBuilder.Entity("server.Models.IncomeCategory", b =>
                {
                    b.Navigation("IncomesCollection");
                });

            modelBuilder.Entity("server.Models.User", b =>
                {
                    b.Navigation("BudgetsCollection");

                    b.Navigation("ExpenseCategories");

                    b.Navigation("ExpensesCollection");

                    b.Navigation("IncomeCategories");

                    b.Navigation("IncomesCollection");
                });
#pragma warning restore 612, 618
        }
    }
}
