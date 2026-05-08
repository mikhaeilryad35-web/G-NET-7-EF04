using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_EF04
{
    internal class BankContext : DbContext
    {
        #region project
        //public DbSet<Branch> Branches { get; set; }

        //public DbSet<Manager> Managers { get; set; }

        //public DbSet<Customer> Customers { get; set; }

        //public DbSet<Account> Accounts { get; set; }

        //public DbSet<CustomerAccount> CustomerAccounts { get; set; }

        //public DbSet<Transaction> Transactions { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(
        //        "Server=.;Database=BankDB;Trusted_Connection=True;TrustServerCertificate=True");
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            
        //    modelBuilder.Entity<Branch>()
        //        .HasOne(b => b.Manager)
        //        .WithOne(m => m.Branch)
        //        .HasForeignKey<Manager>(m => m.BranchCode);

            
        //    modelBuilder.Entity<Account>()
        //        .HasOne(a => a.Branch)
        //        .WithMany(b => b.Accounts)
        //        .HasForeignKey(a => a.BranchCode);

           
        //    modelBuilder.Entity<CustomerAccount>()
        //        .HasKey(ca => new { ca.CustomerId, ca.AccountNumber });

             
        //    modelBuilder.Entity<CustomerAccount>()
        //        .HasOne(ca => ca.Customer)
        //        .WithMany(c => c.CustomerAccounts)
        //        .HasForeignKey(ca => ca.CustomerId);

        //    modelBuilder.Entity<CustomerAccount>()
        //        .HasOne(ca => ca.Account)
        //        .WithMany(a => a.CustomerAccounts)
        //        .HasForeignKey(ca => ca.AccountNumber);

           
        //    modelBuilder.Entity<Transaction>()
        //        .HasOne(t => t.Account)
        //        .WithMany(a => a.Transactions)
        //        .HasForeignKey(t => t.AccountNumber);

            
        //    modelBuilder.Entity<Branch>().HasData(
        //        new Branch
        //        {
        //            Code = "B001",
        //            Name = "Cairo Branch",
        //            Address = "Cairo",
        //            PhoneNumber = "0100000000"
        //        },
        //        new Branch
        //        {
        //            Code = "B002",
        //            Name = "Alex Branch",
        //            Address = "Alexandria",
        //            PhoneNumber = "0111111111"
        //        }
        //    );

        //    modelBuilder.Entity<Manager>().HasData(
        //        new Manager
        //        {
        //            Id = 1,
        //            FullName = "Ahmed Ali",
        //            Email = "ahmed@bank.com",
        //            PhoneNumber = "0122222222",
        //            HireDate = new DateTime(2020, 1, 1),
        //            BranchCode = "B001"
        //        },
        //        new Manager
        //        {
        //            Id = 2,
        //            FullName = "Mona Hassan",
        //            Email = "mona@bank.com",
        //            PhoneNumber = "0155555555",
        //            HireDate = new DateTime(2021, 5, 10),
        //            BranchCode = "B002"
        //        }
        //    );
        //}
        #endregion
    }
}
