using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using WebAppShop_test.Models.Statistic;

using WebShopApp.Core.Contracts;

namespace WebAppShop_test.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class StatisticController : Controller
    {
        // GET: StatisticControler
        private readonly IStatisticService _statisticsService;

        public StatisticController(IStatisticService statisticsService)
        {
            this._statisticsService = statisticsService;
        }

        public IActionResult Index()
        {
            StatisticVM statistics = new StatisticVM();

            statistics.CountClients = _statisticsService.CountClients();
            statistics.CountProducts = _statisticsService.CountProducts();
            statistics.CountOrders = _statisticsService.CountOrders();
            statistics.SumOrders = _statisticsService.SumOrders();

            return View(statistics);
        }

        // GET: StatisticControler/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StatisticControler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatisticControler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StatisticControler/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StatisticControler/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StatisticControler/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StatisticControler/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
