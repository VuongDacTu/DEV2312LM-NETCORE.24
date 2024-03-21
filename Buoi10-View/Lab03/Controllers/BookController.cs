﻿using Lab03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab03.Controllers
{
    public class BookController : Controller
    {
        protected Book book = new Book();
        public IActionResult Index()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            var books = book.GetBookList();
            return View(books);
        }
        public IActionResult Create()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            Book model = new Book();
            return View(model);
        }
        public IActionResult Edit(int Id)
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            Book model = book.GetBookById(Id);
            return View(model);
        }
        public PartialViewResult PopularBook()
        {
            var books = book.GetBookList();
            return PartialView(books);
        }

    }
}
