using Microsoft.AspNetCore.Mvc;
using TendaNET.Models;

public class ProductosController : Controller
{
    private readonly AppDbContext _context;

    public ProductosController(AppDbContext context)
    {
        _context = context;
    }

    // Muestra el formulario
    public IActionResult Crear()
    {
        return View();
    }

    // Recibe el formulario y guarda en la BD
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Crear(Producto producto)
    {
        if (ModelState.IsValid)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();   // 🔥 AQUÍ se guarda en la BD
            return RedirectToAction("Index");
        }

        return View(producto);
    }

    // Lista productos
    public IActionResult Index()
    {
        var productos = _context.Productos.ToList();
        return View(productos);
    }
}
