using Lab4MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab4MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryDbContext _dbContext;
        public HomeController(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Customer()
        {
            var customers = _dbContext.Customers.AsEnumerable();
            return View(customers);
        }
        public IActionResult Profile(int id)
        {
            var profileViewModel = new CustomerBooksViewModel();
            profileViewModel.Customer = _dbContext.Customers.Where(c => c.Id == id).FirstOrDefault();
            var borrowings = _dbContext.CustomerBorrowings
                .Where(c => c.CustomerId == profileViewModel.Customer.Id)
                .Select(c => c.BookId)
                .ToList();
            profileViewModel.Books = _dbContext.Books
                .Where(b => borrowings.Contains(b.Id)).ToList();
            return View(profileViewModel);
            //return View(_dbContext.Customers.Where(c => c.Id == id).FirstOrDefault());
        }
        public IActionResult AddOrEdit(int? id)
        {
            return View(_dbContext.Customers.Where(c => c.Id == id).FirstOrDefault());
        }
        public async Task<IActionResult> AddOrEdited(Customer customer)
        {
            if (customer.Id == 0)
            {
                _dbContext.Customers.Add(customer);
            }
            else
            {
                _dbContext.Update(customer);
            }
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Customer));
        }
        public async Task<IActionResult> DeletedCustomer(int? id)
        {
            _dbContext.Remove(_dbContext.Customers.Where(c=> c.Id == id).FirstOrDefault());
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Customer));
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}