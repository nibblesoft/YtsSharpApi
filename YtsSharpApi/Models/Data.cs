using System.Collections.Generic;

namespace YtsSharpApi.Models
{
    public class Data
    {
        public int movie_count { get; set; }
        public int limit { get; set; }
        public int page_number { get; set; }
        public List<Movie> movies { get; set; }
    }
}
