using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class film
    {
        public int film_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int release_year { get; set; }
        
        public int reantla_duration { get; set; }
        public decimal rental_rate { get; set; }
        public int length { get; set; }
        public decimal replacement_cost { get; set; }
        public string rating { get; set; }
        public DateTime last_update { get; set; }
        public string special_features { get; set; }
        public string fulltext { get; set; }

        //relacion language

        public language language { get; set; }
        public int language_id { get; set; }
    }
}
