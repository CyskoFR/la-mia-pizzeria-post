using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria.Models;

namespace la_mia_pizzeria.Controllers
{
    public class PizzaController : Controller
    {
        // GET: PizzaController
        public ActionResult Index()
        {
            PizzeriaContext db = new PizzeriaContext();

            return View(db.Pizzas.ToList());
        }

        // GET: PizzaController/Show/5
        public ActionResult Show(int id)
        {
            PizzeriaContext db = new PizzeriaContext();

            return View(db.Pizzas.Find(id));
        }

        // GET: PizzaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pizza formData)
        {
            using (PizzeriaContext context = new PizzeriaContext())
            {
                Pizza pizzaCreate = new Pizza();
                pizzaCreate.Name = formData.Name;
                pizzaCreate.Description = formData.Description;
                pizzaCreate.Picture = formData.Picture;
                pizzaCreate.Price = formData.Price;

                context.Pizzas.Add(pizzaCreate);

                context.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        // GET: PizzaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaController/Edit/5
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

        // GET: PizzaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaController/Delete/5
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
