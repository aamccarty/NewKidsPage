using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AKidsPage.Models;

namespace AKidsPage.Controllers
{
    public class JokesController : Controller
    {
        IJoke repo;
        public JokesController(IJoke r)
        {
            repo = r;
        }

        public IActionResult JokesPage()
        {
            List<Joke> jokes = repo.Jokes;
            jokes.Sort((b1, b2) => string.Compare(b1.KeyWord, b2.KeyWord, StringComparison.Ordinal));
            return View(jokes);
        }

        public IActionResult JokeForm()
        {
            return View();
        }


        [HttpPost]
        public RedirectToActionResult JokeForm(string name,
                                              string keyword, string jokeline)
        {
            if (ModelState.IsValid)
            {
                Joke joke = new Joke { KeyWord = keyword };
                joke.Name = name;
                joke.JokeLine = jokeline;

                /*joke.Joke.Add(new Joke() { Name = name });
               joke.PubDate = DateTime.Parse(pubDate);*/
                repo.AddJoke(joke);  // this is temporary, in the future the data will go in a database
            }
            return RedirectToAction("Jokespage");
        }



    }

}