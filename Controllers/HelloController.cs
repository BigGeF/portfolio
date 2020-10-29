using Microsoft.AspNetCore.Mvc;
namespace TestProject.Controllers{
    public class HelloController:Controller{
        [HttpGet("any")]
        public IActionResult HiThere(){
            return View("index");
        }

        [HttpGet("{name}")]
        public string Hello(string name){
            return $"hello {name}";
        }

        [HttpGet("USA/{name}")]
        public string Country(string name){
            return $"hello USA from {name}";
        }

        [HttpGet("Hi")]
        public IActionResult function(){
            System.Console.WriteLine("Redirecting...");
            var param = new{name = "HaoFan"};
            return RedirectToAction("Country",param);
        }

        [HttpGet("new")]
        public IActionResult Hao(string username, string location, int height, int weight){
            var param = new{username="Hao", location="seattle", height="6'4",weight="250"};
            return Json(param);
        }
        
    }
}