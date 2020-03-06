using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AKidsPage.Models;
using Microsoft.EntityFrameworkCore;
using AKidsPage.Data;

namespace AKidsPage.Repository
{
    public class InsertData
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Jokes.Any())
            {
                /*AppUser user = new AppUser { Name = "Willy Wonka" };
                context.Users.Add(user);*/

                Joke joke = new Joke
                {
                    KeyWord = "Pirates",
                    JokeLine = "What's a Pirates favorite letter? RRRRRRRR",
                    PubDate = DateTime.Parse("7/24/05"),
                    UserEmail = "notfunny@gmail.com",
                    Phone = "541-555-5555"

                };
                //joke.Users.Add(user); //Add to Users List
                context.Jokes.Add(joke);

                context.SaveChanges(); // save all the data
            }
        }
    }
}