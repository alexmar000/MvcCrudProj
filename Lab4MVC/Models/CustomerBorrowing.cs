using System.ComponentModel.DataAnnotations;

namespace Lab4MVC.Models
{
    public class CustomerBorrowing
    {
        [Key]
        public int Id { get; set; }
        public DateTime BorrowDate { get; set; }
        public bool IsReturned { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = default!;
        public int BookId { get; set; }
        public Book Book { get; set; } = default!;
    }
}
