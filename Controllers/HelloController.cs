using System;
using Microsoft.AspNetCore.Mvc;
namespace TestProject.Controllers{
    public class HelloController:Controller{
        [HttpGet("")]
        public IActionResult HiThere(){
            return View("index");
        }

        [HttpGet("home")]
        public IActionResult Home(){
            return RedirectToAction("HiThere");
        }

        [HttpGet("project")]
        public IActionResult iProject(){

            return View("Project");
        }

        [HttpGet("allProjects")]
        public IActionResult allProjects(){
            return RedirectToAction("iProject");
        }

//--------------------------------------------------------
        [HttpGet("contact")]
        public IActionResult icontact(){
            return View("Contact");
        }

        [HttpGet("toContact")]
        public IActionResult toContact(){
            
            return RedirectToAction("icontact");
        }
        [HttpPost("method")]
        public IActionResult postMethod(string name, string number)
        {
            ViewBag.Name=name;
            ViewBag.Num=number;
            return View("time");
        }
// -----------------------------------------------------------------------
        [HttpGet("time")]
        public IActionResult Time(){
            ViewBag.Example = "helloworld";
            var now = DateTime.Now.ToString("MM dd, yyy h：mm tt");
            ViewBag.clock = now;
            return View("time",now);
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