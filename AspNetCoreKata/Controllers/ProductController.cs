﻿using AspCoreNetKata.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreKata.ProjectRepository;
using System;

namespace AspNetCoreKata.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repo;

        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            var prods = _repo.GetAllProducts();
            return View(prods);
        }

        public ActionResult Details(int id)
        {
            var prod = _repo.GetProductWithId(id);
            return View(prod);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var prod = _repo.GetProductWithId(id);
            return View(prod);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            var prod = new Product
                {Id = id,   Name = collection["Name"] };
            _repo.UpdateProduct(prod);

            return RedirectToAction(nameof(Index)); 
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            var prod = _repo.GetProductWithId(id);
            return View(prod);
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
          _repo.DeleteProductWithId(id);
            return RedirectToAction(nameof(Index));
        }
    }
}