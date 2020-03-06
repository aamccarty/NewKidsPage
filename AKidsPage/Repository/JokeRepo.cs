using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AKidsPage.Data;
using AKidsPage.Models;

namespace AKidsPage.Models
{
    public class JokeRepo : IJoke
    {
        private ApplicationDbContext context;
        /*public List<Joke> Jokes { get { return context.Jokes.Include("AppUser").ToList(); } }*/
        public List<Joke> Jokes
        {
            get
            {
                return context.Jokes.ToList();
            }
        }
        public JokeRepo(ApplicationDbContext appDbContext)
        {
            context = appDbContext;
        }

        public void AddJoke(Joke joke)
        {
            context.Jokes.Add(joke);
            context.SaveChanges();
        }

        public void AddUser(Joke joke, AppUser user)
        {
            joke.Users.Add(user);
            context.Jokes.Update(joke);
            context.SaveChanges();
        }

        public Joke GetJokeByKeyWord(string title)
        {
            Joke joke;
            joke = context.Jokes.First(b => b.KeyWord == title);
            return joke;
        }

    }
    /*
     public static IEnumerable<Jokes> Responses
     {
         get
         {
             return responses;
         }
     }
     public static void AddResponse(Jokes response)
     {
         responses.Add(response);
     }
     */

}
