using Microsoft.AspNetCore.Mvc;
using DemoApp.Models;
using System.Collections.Generic;

namespace DemoApp.Controllers
{
    public class BookController : Controller
    {
        // Giả lập một danh sách sách (thay cho database)
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "Lập Trình C#", Author = "Nguyễn Văn A", Price = 120000 },
            new Book { Id = 2, Title = "ASP.NET Core Cơ Bản", Author = "Trần Thị B", Price = 150000 },
            new Book { Id = 3, Title = "Entity Framework Core", Author = "Lê Văn C", Price = 180000 }
        };

        // Action hiển thị danh sách sách
        public IActionResult Index()
        {
            return View(books);
        }

        // Action hiển thị chi tiết sách
        public IActionResult Details(int id)
        {
            var book = books.Find(b => b.Id == id);
            if (book == null)
                return NotFound();
            return View(book);
        }

        // Action thêm sách mới (hiển thị form)
        public IActionResult Create()
        {
            return View();
        }

        // Action thêm sách mới (nhận dữ liệu từ form)
        [HttpPost]
        public IActionResult Create(Book book)
        {
            books.Add(book);
            return RedirectToAction("Index");
        }
    }
}
