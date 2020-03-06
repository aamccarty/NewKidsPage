using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AKidsPage.Models
{
    public interface IJoke
    {
        List<Joke> Jokes { get; }
        void AddJoke(Joke joke);
        void AddUser(Joke joke, AppUser user);
        Joke GetJokeByKeyWord(string title);
    }
}


