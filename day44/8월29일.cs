ModelDataMVC
```
<HomeController.cs>

using Microsoft.AspNetCore.Mvc;
using ModelDataMVC2.Models;
using System.Diagnostics;

namespace ModelDataMVC2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["sports"] = new List<string>() { "축구", "야구", "농구", "배구" };
            ViewData["name"] = "홍길동";
            ViewBag.value = 500;
            string[] names = { "홍길동", "이순신", "강감찬" };
            ViewBag.data2 = names;
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
}
```
```
<index.html>

@{
    ViewData["Title"] = "Home Page";
    var sports = ViewData["sports"] as List<string>;
    var hongName = ViewData["name"] as string[];

    var names = ViewBag.data2;
}

<div class="text-center">
    <h1>Data 표현하기</h1>
    @{
        foreach (var item in sports)
        {
            @item

            <br />
        }
    }
    <hr />
    <h3>@hongName</h3>
    <h3>@ViewData["name"]</h3>
    <h3>@ViewBag.value</h3>
    @{
        foreach(var item in names)
        {
            @item<br />
        }
    }
</div>
```
