using Microsoft.EntityFrameworkCore;

namespace Lab4MVC.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<CustomerBorrowing> CustomerBorrowings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasData(
                new Book { Id = 1, Title = "Bröderna Karamazov", Author = "Fyodor Dostojevskij", ISBNNumber = 10032910265 },
                new Book { Id = 2, Title = "The Wind-Up Bird Chronicle", Author = "Haruki Murakami", ISBNNumber = 9328172321 },
                new Book { Id = 3, Title = "1984", Author = "George Orwell", ISBNNumber = 54213216738 }
                );
            modelBuilder.Entity<Customer>()
                .HasData(
                new Customer { Id = 1, FirstName = "Johan", LastName = "Hultkvist", Address = "Lysekilsvägen 12", PhoneNumber = "0703272138"},
                new Customer { Id = 2, FirstName = "Omar", LastName = "Asaad", Address = "Storgatan 23A", PhoneNumber = "0721472131" },
                new Customer { Id = 3, FirstName = "Philippa", LastName = "Myrdahl", Address = "Kungsholmsvägen 2", PhoneNumber = "0701435013" }
                );
            modelBuilder.Entity<CustomerBorrowing>()
                .HasData(
                new CustomerBorrowing { Id = 1, BorrowDate = new DateTime(2021,12,24), BookId = 1, CustomerId = 2, IsReturned = false },
                new CustomerBorrowing { Id = 2, BorrowDate = new DateTime(2021,1,12), BookId = 1, CustomerId = 1, IsReturned = true },
                new CustomerBorrowing { Id = 3, BorrowDate = new DateTime(2021,2,6), BookId = 2, CustomerId = 3, IsReturned = false },
                new CustomerBorrowing { Id = 4, BorrowDate = new DateTime(2020,09,13), BookId = 2, CustomerId = 2, IsReturned = false },
                new CustomerBorrowing { Id = 5, BorrowDate = new DateTime(2021,07,7), BookId = 3, CustomerId = 3, IsReturned = true }
                );
        }
    }
}
