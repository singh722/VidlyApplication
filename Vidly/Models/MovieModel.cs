using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MovieModel
    {
        public IDictionary<int, Movie> Movies { get; set; }
        public MovieModel()
        {
            this.Movies = new Dictionary<int, Movie>();
            this.Movies.Add(new KeyValuePair<int, Movie>(1, new Movie(1, "Forrest Gump")));
            this.Movies.Add(new KeyValuePair<int, Movie>(2, new Movie(2, "Saving Private Ryan")));
        }
        public Movie GetMovieById(int id)
        {
            if (Movies.TryGetValue(id, out Movie m))
                return m;
            else
                return null;
        }
    }
}