﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sampleMVC.Entities;
using sampleMVC.Models;

namespace sampleMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly testContext _context;

    public HomeController(ILogger<HomeController> logger, testContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        Category c = new Category();
        c.Name = "Hello";
        _context.Categories.Add(c);
        _context.SaveChanges();

        return View();

    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
