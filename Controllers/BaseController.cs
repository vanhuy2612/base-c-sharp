using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using base_c_sharp.Models;
using Helpers.DBContext;

namespace base_c_sharp.Controllers;

public class BaseController: Controller
{
    public ILogger<BaseController> _logger;
    public DBContext _context;

    public BaseController(ILogger<BaseController> logger, DBContext context)
    {
        this._logger = logger;
        this._context = context;
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
