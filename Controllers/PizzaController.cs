using la_mia_pizzeria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_model.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = new List<Pizza>();

            Pizza margherita = new Pizza(0, "Margherita", "Pomodoro, Mozzarella", "https://www.melarossa.it/wp-content/uploads/2021/02/ricetta-pizza-margherita.jpg?x58780", 4.99);
            Pizza diavola = new Pizza(1, "Diavola", "Pomodoro, Mozzarella, Salame pizzante", "https://www.negroni.com/sites/negroni.com/files/styles/scale__1440_x_1440_/public/pizza_rustica.jpg?itok=Lbp_jtZW", 5.99);
            Pizza olive = new Pizza(2, "Olive", "Pomodoro, Mozzarella, Olive nere, Olive verdi", "https://blog.giallozafferano.it/dolcissimastefy/wp-content/uploads/2018/04/IMG_0480-2.jpg", 5.50);
            Pizza quattroStagioni = new Pizza(3, "4 Stagioni", "Pomodoro, Mozzarella, Funghi, Prosciutto, Olive nere, Carciofi", "https://primochef.it/wp-content/uploads/2020/04/SH_pizza_quattro_stagioni.jpg", 6.99);

            pizzas.Add(margherita);
            pizzas.Add(diavola);
            pizzas.Add(olive);
            pizzas.Add(quattroStagioni);

            return View(pizzas);
        }

        public IActionResult Show(int id)
        {
            List<Pizza> pizzas = new List<Pizza>();

            Pizza margherita = new Pizza(0, "Margherita", "Pomodoro, Mozzarella", "https://www.melarossa.it/wp-content/uploads/2021/02/ricetta-pizza-margherita.jpg?x58780", 4.99);
            Pizza diavola = new Pizza(1, "Diavola", "Pomodoro, Mozzarella, Salame pizzante", "https://www.negroni.com/sites/negroni.com/files/styles/scale__1440_x_1440_/public/pizza_rustica.jpg?itok=Lbp_jtZW", 5.99);
            Pizza olive = new Pizza(2, "Olive", "Pomodoro, Mozzarella, Olive nere, Olive verdi", "https://blog.giallozafferano.it/dolcissimastefy/wp-content/uploads/2018/04/IMG_0480-2.jpg", 5.50);
            Pizza quattroStagioni = new Pizza(3, "4 Stagioni", "Pomodoro, Mozzarella, Funghi, Prosciutto, Olive nere, Carciofi", "https://primochef.it/wp-content/uploads/2020/04/SH_pizza_quattro_stagioni.jpg", 6.99);

            pizzas.Add(margherita);
            pizzas.Add(diavola);
            pizzas.Add(olive);
            pizzas.Add(quattroStagioni);

            return View(pizzas[id]);
        }
    }
}
