using CoffeeTea.Pages.Home.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeTea.Pages.Home.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            // Тестовые данные
            var vm = new HomeItem
            {
                Cards = new List<CardItem>
            {
                new() {
                    Title = "Свежая обжарка недели",
                    Text = "Эфиопия Иргачеффе • ягоды, цитрус, жасмин. Попробуй!",
                    ImageUrl = "https://via.placeholder.com/600x400?text=Coffee",
                    Link = "/catalog?tag=weekly",
                    Badge = "NEW"
                },
                new() {
                    Title = "Топ-чай для вечера",
                    Text = "Молочный улун — мягкий сливочный вкус, без горечи.",
                    ImageUrl = "https://via.placeholder.com/600x400?text=Tea",
                    Link = "/catalog?type=tea"
                },
                new() {
                    Title = "Гид по завариванию V60",
                    Text = "Простая пошаговая инструкция для идеальной чашки.",
                    ImageUrl = "https://via.placeholder.com/600x400?text=Guide",
                    Link = "/articles/v60-guide",
                    Badge = "Гайд"
                }
            }
            };

            return View("~/Pages/Home/Views/_Home.cshtml", vm);
        }
    }
}