using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Film
{
    public class Film
    {

        public int id { get; set; }
        public String original_title { get; set; }
        public String overview { get; set; }
        public String poster_path { get; set; }
        public String release_date { get; set; }
        public String original_language { get; set; }
        public float popularity { get; set; }
        public String title { get; set; }
        public bool video { get; set; }
        public float vote_average { get; set; }
        public int vote_count { get; set; }
        private List<int> _genre_ids;

        private string adult { get; set; }
        public String backdrop_path { get; set; }


        public List<int> genre_ids()
        {
            return _genre_ids;
        }

        public void Setgenre_ids(List<int> value)
        {
            _genre_ids = value;
        }
    }
}
