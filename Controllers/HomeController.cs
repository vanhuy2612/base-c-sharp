using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using base_c_sharp.Models;
using Utils;
using Helpers.DBContext;
using Models;
using Newtonsoft.Json;

namespace base_c_sharp.Controllers;

public class HomeController: BaseController
{
    public HomeController(ILogger<HomeController> logger, DBContext context): base(logger, context)
    {

    }

    public IActionResult Index()
    {
        int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6 };
        ViewData["data"] = numbers;
        int[] data1 = Util.FilterEvenNumber(numbers);
        ViewData["data1"] = data1;

        int? data2 = Util.First(numbers);
        ViewData["data2"] = data2;

        int? data3 = Util.Last(numbers);
        ViewData["data3"] = data3;

        var users = from user in _context.Users select new UserModel
        {
            id = user.id,
            name = user.name
        };
        Console.WriteLine("How is going now ?");
        Console.WriteLine(JsonConvert.SerializeObject(users));
        IEnumerable<UserModel> userCollections = users.ToList();
        // ViewData value must be typecast to an appropriate type before using it
        ViewData["users"] = userCollections;
        // ViewBag doesn't require typecasting while retrieving value.
        ViewBag.bagUsers = users;

        // int? data4 = Util.Single(numbers);
        // ViewData["data4"] = data4;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

}
