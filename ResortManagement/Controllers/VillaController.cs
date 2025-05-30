using Microsoft.AspNetCore.Mvc;
using ResortManagement.Domain.Entities;
using ResortManagement.Infrastructure.Data;

namespace ResortManagement.Controllers;

public class VillaController : Controller
{
    private readonly ApplicationDbContext _context;
    public VillaController(ApplicationDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var data = _context.Villas.ToList();

        return View(data);
    }
    public IActionResult Create()
    {
       
        return View();
    }

    [HttpPost]
    public IActionResult Create(Villa obj)
    {
        _context.Villas.Add(obj);
        _context.SaveChanges();
        return RedirectToAction("Index");

    }

}
