﻿using BookStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\BookStore;Initial Catalog=BookStoreDb;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Book>()
            //    .HasOne(b => b.Publisher)
            //    .WithMany(p => p.Books);

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher() { Id = 1, Name = "Ciela" },
                new Publisher() { Id = 2, Name = "Knigomania" },
                new Publisher() { Id = 3, Name = "Bard" },
                new Publisher() { Id = 4, Name = "Labyrinth" },
                new Publisher() { Id = 5, Name = "Emgont" },
                new Publisher() { Id = 6, Name = "Bloomsbury" },
                new Publisher() { Id = 7, Name = "Unknown" }
                );

            modelBuilder.Entity<Courrier>().HasData(
                new Courrier() { Id = 1, Name = "Econt", CourrierPhoneNumber = "+359876760245"},
                new Courrier() { Id = 2, Name = "Speedy", CourrierPhoneNumber = "+359123456789" },
                new Courrier() { Id = 3, Name = "FedEx", CourrierPhoneNumber = "+359741258963" },
                new Courrier() { Id = 4, Name = "EuropaRoads", CourrierPhoneNumber = "+359002121215" }
                );

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "Опашката",
                    Author = "Захари Карабашлиев",
                    Created = new DateTime(2021, 1, 1),
                    Quantity = 100,
                    Price = 18.50,
                    PublisherId = 1
                },
                new Book
                {
                    BookId = 2,
                    Title = "Избрани стихотворения",
                    Author = "Дамян Дамянов",
                    Created = new DateTime(2011, 1, 1),
                    Quantity = 50,
                    Price = 22.60,
                    PublisherId = 6
                },
                new Book
                {
                    BookId = 3,
                    Title = "Времеубежище",
                    Author = "Георги Господинов",
                    Created = new DateTime(2020, 1, 1),
                    Quantity = 500,
                    Price = 20,
                    PublisherId = 2
                },
                new Book
                {
                    BookId = 4,
                    Title = "1984",
                    Author = "Джордж Оруел",
                    Created = new DateTime(2021, 1, 1),
                    Quantity = 30,
                    Price = 17.99,
                    PublisherId = 3
                },
                new Book
                {
                    BookId = 5,
                    Title = "Аутопсия на една любов",
                    Author = "Виктор Пасков",
                    Created = new DateTime(2018, 1, 1),
                    Quantity = 15,
                    Price = 19.90,
                    PublisherId = 5
                },
                new Book
                {
                    BookId = 6,
                    Title = "Имам нещо да ти кажа",
                    Author = "Константин Трендафилов",
                    Created = new DateTime(2023, 1, 1),
                    Quantity = 1500,
                    Price = 15,
                    PublisherId = 4
                },
                new Book
                {
                    BookId = 7,
                    Title = "Малкият Принц",
                    Author = "Антоан Дьо Екзюпери",
                    Created = new DateTime(2015, 1, 1),
                    Quantity = 3000,
                    Price = 7.90,
                    PublisherId = 1
                }
                );

            modelBuilder.Entity<BookCourrier>().HasData(
                new BookCourrier
                {
                    OrderID = 1,
                    BookId = 2,
                    CourrierId = 3,
                    DeliveryDate = new DateTime(2023, 1, 15),
                    Quantity = 6
                },
                new BookCourrier
                {
                    OrderID = 2,
                    BookId = 3,
                    CourrierId = 1,
                    DeliveryDate = new DateTime(2023, 1, 15),
                    Quantity = 2
                }, new BookCourrier
                {
                    OrderID = 3,
                    BookId = 4,
                    CourrierId = 3,
                    DeliveryDate = new DateTime(2023, 2, 8),
                    Quantity = 91
                },
                new BookCourrier
                {
                    OrderID = 4,
                    BookId = 3,
                    CourrierId = 3,
                    DeliveryDate = new DateTime(2023, 1, 13),
                    Quantity = 18
                },
                new BookCourrier
                {
                    OrderID = 5,
                    BookId = 5,
                    CourrierId = 4,
                    DeliveryDate = new DateTime(2022, 12, 29),
                    Quantity = 71
                },
                new BookCourrier
                {
                    OrderID = 6,
                    BookId = 6,
                    CourrierId = 2,
                    DeliveryDate = new DateTime(2022, 3, 31),
                    Quantity = 69
                },
                new BookCourrier
                {
                    OrderID = 7,
                    BookId = 1,
                    CourrierId = 3,
                    DeliveryDate = new DateTime(2023, 1, 1),
                    Quantity = 93
                },
                new BookCourrier
                {
                    OrderID = 8,
                    BookId = 7,
                    CourrierId = 3,
                    DeliveryDate = new DateTime(2022, 8, 5),
                    Quantity = 44
                },
                new BookCourrier
                {
                    OrderID = 9,
                    BookId = 7,
                    CourrierId = 3,
                    DeliveryDate = new DateTime(2022, 5, 3),
                    Quantity = 23
                }
                );
        }

        public void EnsureDatabaseCreated()
        {
            Database.EnsureCreated();
        }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Courrier> Courriers { get; set; }
        public virtual DbSet<BookCourrier> BookCourriers { get; set; }
    }
}