using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class Joke
    {

    #region properties

        public int Id { get; set; }
        public string JokeQuestion { get; set; }

        public string JokeAnswer { get; set; }

        #endregion

        #region constructors

        public Joke()
        {

        }

        #endregion
    }
}
